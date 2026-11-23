using Aniflex.Client.Controlador;
using Aniflex.Client.Modelo;
using Aniflex.Client.Servicios;
using System.ComponentModel;

namespace Aniflex.Client.Vista.VistaEstudio;

public partial class FormListarEstudio : Form
{
    private readonly string? serieFiltro;
    private bool ocupado;
    private bool listadoCargado;

    public FormListarEstudio()
    {
        InitializeComponent();
        if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
        EstudioObserver.OnEstudiosCambiados += RefrescarListado;
        SerieObserver.OnSeriesCambiadas += RefrescarListado;
    }

    public FormListarEstudio(string? serieId) : this()
    {
        serieFiltro = serieId;
    }

    private async void cargar_Click(object? sender, EventArgs e)
    {
        codigoBusqueda.Clear();
        paisFiltro.Clear();
        await EjecutarAsync();
    }

    private async void filtrar_Click(object? sender, EventArgs e)
    {
        await EjecutarAsync();
    }

    private void limpiar_Click(object? sender, EventArgs e)
    {
        codigoBusqueda.Clear();
        paisFiltro.Clear();
        grilla.DataSource = null;
        listadoCargado = false;
    }

    private void grilla_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && grilla.Rows[e.RowIndex].DataBoundItem is Estudio estudio)
            new FormBuscarEstudio(estudio.Codigo).Show(this);
    }

    private void FormListarEstudio_FormClosed(object? sender, FormClosedEventArgs e)
    {
        EstudioObserver.OnEstudiosCambiados -= RefrescarListado;
        SerieObserver.OnSeriesCambiadas -= RefrescarListado;
    }

    private async void RefrescarListado()
    {
        if (!IsDisposed && !ocupado && listadoCargado) await EjecutarAsync();
    }

    private async Task EjecutarAsync()
    {
        if (ocupado) return;
        ocupado = true;
        Enabled = false;
        try
        {
            grilla.DataSource = await ServicioEstudio.GetInstance().ListarAsync(
                codigoBusqueda.Text.Trim(), paisFiltro.Text.Trim(), serieFiltro);
            listadoCargado = true;
        }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Estudios", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        finally
        {
            ocupado = false;
            if (!IsDisposed) Enabled = true;
        }
    }
}
