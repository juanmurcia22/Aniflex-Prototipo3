#nullable disable
namespace Aniflex.Client.Vista.VistaEstudio;

partial class FormAgregarEstudio
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code
    private void InitializeComponent()
    {
        labelTitulo = new Label();
        detalle = new Panel();
        labelObjectid = new Label();
        objectId = new TextBox();
        labelCodigo = new Label();
        codigo = new TextBox();
        labelNombre = new Label();
        nombre = new TextBox();
        labelPais = new Label();
        pais = new TextBox();
        labelFecha = new Label();
        fecha = new DateTimePicker();
        labelSerieCodigo = new Label();
        serieCodigo = new TextBox();
        agregarSerie = new Button();
        retirarSerie = new Button();
        labelSeries = new Label();
        series = new ListBox();
        accion = new Button();
        SuspendLayout();

        // labelTitulo
        labelTitulo.Name = "labelTitulo";
        labelTitulo.Text = "AGREGAR ESTUDIO";
        labelTitulo.AutoSize = true;
        labelTitulo.Location = new Point(250, 16);
        labelTitulo.Font = new Font("Showcard Gothic", 11F);
        labelTitulo.Anchor = AnchorStyles.Top;
        // detalle
        detalle.Name = "detalle";
        detalle.Location = new Point(0, 55);
        detalle.Size = new Size(700, 390);
        detalle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        detalle.Enabled = true;
        // labelObjectid
        labelObjectid.Name = "labelObjectid";
        labelObjectid.Text = "ObjectId";
        labelObjectid.AutoSize = true;
        labelObjectid.Location = new Point(32, 4);
        labelObjectid.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        // objectId
        objectId.Name = "objectId";
        objectId.Location = new Point(220, 0);
        objectId.Size = new Size(440, 23);
        objectId.Font = new Font("Times New Roman", 10F);
        objectId.ReadOnly = true;
        objectId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        // labelCodigo
        labelCodigo.Name = "labelCodigo";
        labelCodigo.Text = "ID manual";
        labelCodigo.AutoSize = true;
        labelCodigo.Location = new Point(32, 39);
        labelCodigo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        // codigo
        codigo.Name = "codigo";
        codigo.Location = new Point(220, 35);
        codigo.Size = new Size(440, 23);
        codigo.Font = new Font("Times New Roman", 10F);
        codigo.ReadOnly = false;
        codigo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        // labelNombre
        labelNombre.Name = "labelNombre";
        labelNombre.Text = "Nombre";
        labelNombre.AutoSize = true;
        labelNombre.Location = new Point(32, 74);
        labelNombre.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        // nombre
        nombre.Name = "nombre";
        nombre.Location = new Point(220, 70);
        nombre.Size = new Size(440, 23);
        nombre.Font = new Font("Times New Roman", 10F);
        nombre.ReadOnly = false;
        nombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        // labelPais
        labelPais.Name = "labelPais";
        labelPais.Text = "País de origen";
        labelPais.AutoSize = true;
        labelPais.Location = new Point(32, 109);
        labelPais.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        // pais
        pais.Name = "pais";
        pais.Location = new Point(220, 105);
        pais.Size = new Size(440, 23);
        pais.Font = new Font("Times New Roman", 10F);
        pais.ReadOnly = false;
        pais.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        // labelFecha
        labelFecha.Name = "labelFecha";
        labelFecha.Text = "Fecha de fundación";
        labelFecha.AutoSize = true;
        labelFecha.Location = new Point(32, 144);
        labelFecha.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        // fecha
        fecha.Name = "fecha";
        fecha.Location = new Point(220, 140);
        fecha.Size = new Size(220, 23);
        fecha.Format = DateTimePickerFormat.Short;
        fecha.Enabled = true;
        fecha.Font = new Font("Times New Roman", 10F);
        // labelSerieCodigo
        labelSerieCodigo.Name = "labelSerieCodigo";
        labelSerieCodigo.Text = "ID manual de serie";
        labelSerieCodigo.AutoSize = true;
        labelSerieCodigo.Location = new Point(32, 181);
        labelSerieCodigo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        // serieCodigo
        serieCodigo.Name = "serieCodigo";
        serieCodigo.Location = new Point(220, 177);
        serieCodigo.Size = new Size(150, 23);
        serieCodigo.Font = new Font("Times New Roman", 10F);
        serieCodigo.ReadOnly = false;
        serieCodigo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        // agregarSerie
        agregarSerie.Name = "agregarSerie";
        agregarSerie.Text = "Añadir serie";
        agregarSerie.Location = new Point(385, 174);
        agregarSerie.Size = new Size(110, 30);
        agregarSerie.Font = new Font("Sitka Banner", 10F);
        agregarSerie.UseVisualStyleBackColor = true;
        agregarSerie.Click += agregarSerie_Click;
        // retirarSerie
        retirarSerie.Name = "retirarSerie";
        retirarSerie.Text = "Retirar selección";
        retirarSerie.Location = new Point(510, 174);
        retirarSerie.Size = new Size(150, 30);
        retirarSerie.Font = new Font("Sitka Banner", 10F);
        retirarSerie.UseVisualStyleBackColor = true;
        retirarSerie.Click += retirarSerie_Click;
        // labelSeries
        labelSeries.Name = "labelSeries";
        labelSeries.Text = "Series referenciadas";
        labelSeries.AutoSize = true;
        labelSeries.Location = new Point(32, 224);
        labelSeries.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        // series
        series.Name = "series";
        series.Location = new Point(220, 220);
        series.Size = new Size(440, 160);
        series.IntegralHeight = false;
        series.FormattingEnabled = true;
        series.Font = new Font("Times New Roman", 10F);
        series.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        // accion
        accion.Name = "accion";
        accion.Text = "Guardar estudio";
        accion.Location = new Point(270, 457);
        accion.Size = new Size(160, 30);
        accion.Font = new Font("Sitka Banner", 10F);
        accion.UseVisualStyleBackColor = true;
        accion.Enabled = true;
        accion.Click += accion_Click;
        Controls.Add(labelTitulo);
        Controls.Add(detalle);
        Controls.Add(accion);
        detalle.Controls.Add(labelObjectid);
        detalle.Controls.Add(objectId);
        detalle.Controls.Add(labelCodigo);
        detalle.Controls.Add(codigo);
        detalle.Controls.Add(labelNombre);
        detalle.Controls.Add(nombre);
        detalle.Controls.Add(labelPais);
        detalle.Controls.Add(pais);
        detalle.Controls.Add(labelFecha);
        detalle.Controls.Add(fecha);
        detalle.Controls.Add(labelSerieCodigo);
        detalle.Controls.Add(serieCodigo);
        detalle.Controls.Add(agregarSerie);
        detalle.Controls.Add(retirarSerie);
        detalle.Controls.Add(labelSeries);
        detalle.Controls.Add(series);
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(700, 515);
        MinimumSize = new Size(640, 554);
        Name = "FormAgregarEstudio";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Agregar estudio";
        Load += FormEstudio_Load;
        ResumeLayout(false);
        PerformLayout();
    }
    #endregion
    private Label labelTitulo;
    private Panel detalle;
    private Label labelObjectid;
    private TextBox objectId;
    private Label labelCodigo;
    private TextBox codigo;
    private Label labelNombre;
    private TextBox nombre;
    private Label labelPais;
    private TextBox pais;
    private Label labelFecha;
    private DateTimePicker fecha;
    private Label labelSerieCodigo;
    private TextBox serieCodigo;
    private Button agregarSerie;
    private Button retirarSerie;
    private Label labelSeries;
    private ListBox series;
    private Button accion;
}
