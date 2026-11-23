#nullable disable
namespace Aniflex.Client.Vista.VistaEstudio;

partial class FormBuscarEstudio
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
        labelBusqueda = new Label();
        codigoBusqueda = new TextBox();
        buscar = new Button();
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
        labelSeries = new Label();
        series = new ListBox();
        SuspendLayout();

        // labelTitulo
        labelTitulo.Name = "labelTitulo";
        labelTitulo.Text = "BUSCAR ESTUDIO";
        labelTitulo.AutoSize = true;
        labelTitulo.Location = new Point(250, 16);
        labelTitulo.Font = new Font("Showcard Gothic", 11F);
        labelTitulo.Anchor = AnchorStyles.Top;
        // labelBusqueda
        labelBusqueda.Name = "labelBusqueda";
        labelBusqueda.Text = "ID manual";
        labelBusqueda.AutoSize = true;
        labelBusqueda.Location = new Point(32, 65);
        labelBusqueda.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        // codigoBusqueda
        codigoBusqueda.Name = "codigoBusqueda";
        codigoBusqueda.Location = new Point(155, 61);
        codigoBusqueda.Size = new Size(260, 23);
        codigoBusqueda.Font = new Font("Times New Roman", 10F);
        codigoBusqueda.ReadOnly = false;
        codigoBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        // buscar
        buscar.Name = "buscar";
        buscar.Text = "Buscar";
        buscar.Location = new Point(435, 57);
        buscar.Size = new Size(110, 30);
        buscar.Font = new Font("Sitka Banner", 10F);
        buscar.UseVisualStyleBackColor = true;
        buscar.Click += buscar_Click;
        // detalle
        detalle.Name = "detalle";
        detalle.Location = new Point(0, 105);
        detalle.Size = new Size(700, 350);
        detalle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        detalle.Enabled = false;
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
        codigo.ReadOnly = true;
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
        nombre.ReadOnly = true;
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
        pais.ReadOnly = true;
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
        fecha.Enabled = false;
        fecha.Font = new Font("Times New Roman", 10F);
        // labelSeries
        labelSeries.Name = "labelSeries";
        labelSeries.Text = "Series referenciadas";
        labelSeries.AutoSize = true;
        labelSeries.Location = new Point(32, 184);
        labelSeries.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        // series
        series.Name = "series";
        series.Location = new Point(220, 180);
        series.Size = new Size(440, 160);
        series.IntegralHeight = false;
        series.FormattingEnabled = true;
        series.Font = new Font("Times New Roman", 10F);
        series.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        Controls.Add(labelTitulo);
        Controls.Add(labelBusqueda);
        Controls.Add(codigoBusqueda);
        Controls.Add(buscar);
        Controls.Add(detalle);
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
        detalle.Controls.Add(labelSeries);
        detalle.Controls.Add(series);
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(700, 485);
        MinimumSize = new Size(640, 524);
        Name = "FormBuscarEstudio";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Buscar estudio";
        Load += FormEstudio_Load;
        ResumeLayout(false);
        PerformLayout();
    }
    #endregion
    private Label labelTitulo;
    private Label labelBusqueda;
    private TextBox codigoBusqueda;
    private Button buscar;
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
    private Label labelSeries;
    private ListBox series;
}
