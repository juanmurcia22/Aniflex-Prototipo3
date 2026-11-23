using Aniflex.Client.Controlador;
using Aniflex.Client.Modelo;
using Aniflex.Client.Servicios;
using System.ComponentModel;

namespace Aniflex.Client.Vista.VistaEstudio;

public enum OperacionEstudio { Listar, Agregar, Buscar, Actualizar, Eliminar }

// Comparte el comportamiento. Los controles y la distribución pertenecen a cada formulario concreto.
public class FormDetalleEstudio : Form
{
    private OperacionEstudio operacion;
    private ServicioEstudio servicio = null!;
    private Control detalle = null!;
    private TextBox objectId = null!;
    private TextBox codigo = null!;
    private TextBox nombre = null!;
    private TextBox pais = null!;
    private DateTimePicker fecha = null!;
    private TextBox? codigoBusqueda;
    private TextBox? serieCodigo;
    private Button? accion;
    private ListBox listaSeries = null!;
    private readonly BindingList<Serie> seriesSeleccionadas = new();
    private string? idCargado;
    private bool ocupado;

    protected void Preparar(OperacionEstudio operacion, Control detalle, TextBox objectId,
        TextBox codigo, TextBox nombre, TextBox pais, DateTimePicker fecha, ListBox series,
        Button? accion = null, TextBox? codigoBusqueda = null, TextBox? serieCodigo = null)
    {
        this.operacion = operacion;
        this.detalle = detalle;
        this.objectId = objectId;
        this.codigo = codigo;
        this.nombre = nombre;
        this.pais = pais;
        this.fecha = fecha;
        this.accion = accion;
        this.codigoBusqueda = codigoBusqueda;
        this.serieCodigo = serieCodigo;
        servicio = ServicioEstudio.GetInstance();
        listaSeries = series;
        series.DataSource = seriesSeleccionadas;
        fecha.MaxDate = DateTime.Today;
    }

    protected void BuscarAlAbrir(string codigoManual)
    {
        if (codigoBusqueda != null) codigoBusqueda.Text = codigoManual;
    }

    protected async void FormEstudio_Load(object? sender, EventArgs e)
    {
        if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
        if (!string.IsNullOrWhiteSpace(codigoBusqueda?.Text)) await EjecutarAsync(BuscarAsync);
    }

    protected async void buscar_Click(object? sender, EventArgs e)
    {
        await EjecutarAsync(BuscarAsync);
    }

    protected async void agregarSerie_Click(object? sender, EventArgs e)
    {
        await EjecutarAsync(async () => {
            var serie = await ServicioSerie.GetInstance().BuscarPorCodigoAsync(serieCodigo!.Text.Trim());
            if (serie is null) throw new InvalidOperationException("No existe una serie con ese ID manual.");
            if (seriesSeleccionadas.Any(s => s.Id == serie.Id))
                throw new InvalidOperationException("La serie ya está en la lista.");
            if (!string.IsNullOrEmpty(serie.EstudioId) && serie.EstudioId != idCargado)
                throw new InvalidOperationException("Esta serie ya pertenece a otro estudio.");
            seriesSeleccionadas.Add(serie);
            serieCodigo.Clear();
        });
    }

    protected void retirarSerie_Click(object? sender, EventArgs e)
    {
        if (listaSeries.SelectedItem is Serie serie)
            seriesSeleccionadas.Remove(serie);
    }

    protected async void accion_Click(object? sender, EventArgs e)
    {
        await EjecutarAsync(GuardarAsync);
    }

    private async Task BuscarAsync()
    {
        idCargado = null;
        detalle.Enabled = false;
        if (accion != null) accion.Enabled = false;
        seriesSeleccionadas.Clear();
        if (string.IsNullOrWhiteSpace(codigoBusqueda?.Text))
            throw new ArgumentException("Ingresa el ID manual del estudio.");
        var estudio = await servicio.BuscarAsync(codigoBusqueda.Text.Trim());
        if (estudio is null) throw new InvalidOperationException("No existe un estudio con ese ID manual.");
        foreach (var serie in estudio.Series) seriesSeleccionadas.Add(serie);
        idCargado = estudio.Id;
        objectId.Text = estudio.Id;
        codigo.Text = estudio.Codigo;
        nombre.Text = estudio.Nombre;
        pais.Text = estudio.PaisOrigen;
        fecha.Value = estudio.FechaFundacion.Date;
        detalle.Enabled = true;
        if (accion != null) accion.Enabled = operacion is OperacionEstudio.Actualizar or OperacionEstudio.Eliminar;
    }

    private async Task GuardarAsync()
    {
        if (operacion == OperacionEstudio.Eliminar)
        {
            if (idCargado is null) throw new InvalidOperationException("Busca primero el estudio.");
            if (MessageBox.Show($"¿Eliminar el estudio {nombre.Text}? Sus series se conservarán.",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            if (!await servicio.EliminarAsync(idCargado)) throw new InvalidOperationException("El estudio ya no existe.");
            EstudioObserver.NotificarCambio();
            SerieObserver.NotificarCambio();
            Close();
            return;
        }
        if (string.IsNullOrWhiteSpace(codigo.Text) || string.IsNullOrWhiteSpace(nombre.Text) || string.IsNullOrWhiteSpace(pais.Text))
            throw new ArgumentException("Completa el ID manual, el nombre y el país de origen.");
        var nuevo = operacion == OperacionEstudio.Agregar;
        if (!nuevo && idCargado is null) throw new InvalidOperationException("Busca primero el estudio.");
        var estudio = await servicio.GuardarAsync(new Estudio {
            Id = idCargado ?? "", Codigo = codigo.Text.Trim(), Nombre = nombre.Text.Trim(),
            PaisOrigen = pais.Text.Trim(), FechaFundacion = fecha.Value.Date,
            SeriesIds = seriesSeleccionadas.Select(s => s.Id).ToList()
        }, nuevo);
        EstudioObserver.NotificarCambio();
        SerieObserver.NotificarCambio();
        MessageBox.Show($"Estudio {estudio.Codigo} guardado correctamente.");
        if (nuevo)
        {
            codigo.Clear(); nombre.Clear(); pais.Clear(); objectId.Clear(); seriesSeleccionadas.Clear();
        }
    }

    private async Task EjecutarAsync(Func<Task> trabajo)
    {
        if (ocupado) return;
        ocupado = true;
        Enabled = false;
        try { await trabajo(); }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Estudios", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        finally
        {
            ocupado = false;
            if (!IsDisposed) Enabled = true;
        }
    }
}
