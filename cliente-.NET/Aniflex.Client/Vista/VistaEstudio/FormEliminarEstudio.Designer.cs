#nullable disable
namespace Aniflex.Client.Vista.VistaEstudio;

partial class FormEliminarEstudio
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
        accion = new Button();
        detalle.SuspendLayout();
        SuspendLayout();
        // 
        // labelTitulo
        // 
        labelTitulo.Anchor = AnchorStyles.Top;
        labelTitulo.AutoSize = true;
        labelTitulo.Font = new Font("Showcard Gothic", 11F);
        labelTitulo.Location = new Point(357, 27);
        labelTitulo.Margin = new Padding(4, 0, 4, 0);
        labelTitulo.Name = "labelTitulo";
        labelTitulo.Size = new Size(209, 28);
        labelTitulo.TabIndex = 0;
        labelTitulo.Text = "ELIMINAR ESTUDIO";
        // 
        // labelBusqueda
        // 
        labelBusqueda.AutoSize = true;
        labelBusqueda.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        labelBusqueda.Location = new Point(46, 108);
        labelBusqueda.Margin = new Padding(4, 0, 4, 0);
        labelBusqueda.Name = "labelBusqueda";
        labelBusqueda.Size = new Size(39, 25);
        labelBusqueda.TabIndex = 1;
        labelBusqueda.Text = "ID ";
        // 
        // codigoBusqueda
        // 
        codigoBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        codigoBusqueda.Font = new Font("Times New Roman", 10F);
        codigoBusqueda.Location = new Point(221, 102);
        codigoBusqueda.Margin = new Padding(4, 5, 4, 5);
        codigoBusqueda.Name = "codigoBusqueda";
        codigoBusqueda.Size = new Size(370, 30);
        codigoBusqueda.TabIndex = 2;
        // 
        // buscar
        // 
        buscar.Font = new Font("Sitka Banner", 10F);
        buscar.Location = new Point(621, 95);
        buscar.Margin = new Padding(4, 5, 4, 5);
        buscar.Name = "buscar";
        buscar.Size = new Size(157, 50);
        buscar.TabIndex = 3;
        buscar.Text = "Buscar";
        buscar.UseVisualStyleBackColor = true;
        buscar.Click += buscar_Click;
        // 
        // detalle
        // 
        detalle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
        detalle.Enabled = false;
        detalle.Location = new Point(0, 175);
        detalle.Margin = new Padding(4, 5, 4, 5);
        detalle.Name = "detalle";
        detalle.Size = new Size(1000, 583);
        detalle.TabIndex = 4;
        // 
        // labelObjectid
        // 
        labelObjectid.AutoSize = true;
        labelObjectid.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        labelObjectid.Location = new Point(46, 7);
        labelObjectid.Margin = new Padding(4, 0, 4, 0);
        labelObjectid.Name = "labelObjectid";
        labelObjectid.Size = new Size(93, 25);
        labelObjectid.TabIndex = 0;
        labelObjectid.Text = "ObjectId";
        // 
        // objectId
        // 
        objectId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        objectId.Font = new Font("Times New Roman", 10F);
        objectId.Location = new Point(314, 0);
        objectId.Margin = new Padding(4, 5, 4, 5);
        objectId.Name = "objectId";
        objectId.ReadOnly = true;
        objectId.Size = new Size(627, 30);
        objectId.TabIndex = 1;
        // 
        // labelCodigo
        // 
        labelCodigo.AutoSize = true;
        labelCodigo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        labelCodigo.Location = new Point(46, 65);
        labelCodigo.Margin = new Padding(4, 0, 4, 0);
        labelCodigo.Name = "labelCodigo";
        labelCodigo.Size = new Size(39, 25);
        labelCodigo.TabIndex = 2;
        labelCodigo.Text = "ID ";
        // 
        // codigo
        // 
        codigo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        codigo.Font = new Font("Times New Roman", 10F);
        codigo.Location = new Point(314, 58);
        codigo.Margin = new Padding(4, 5, 4, 5);
        codigo.Name = "codigo";
        codigo.ReadOnly = true;
        codigo.Size = new Size(627, 30);
        codigo.TabIndex = 3;
        // 
        // labelNombre
        // 
        labelNombre.AutoSize = true;
        labelNombre.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        labelNombre.Location = new Point(46, 123);
        labelNombre.Margin = new Padding(4, 0, 4, 0);
        labelNombre.Name = "labelNombre";
        labelNombre.Size = new Size(87, 25);
        labelNombre.TabIndex = 4;
        labelNombre.Text = "Nombre";
        // 
        // nombre
        // 
        nombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        nombre.Font = new Font("Times New Roman", 10F);
        nombre.Location = new Point(314, 117);
        nombre.Margin = new Padding(4, 5, 4, 5);
        nombre.Name = "nombre";
        nombre.ReadOnly = true;
        nombre.Size = new Size(627, 30);
        nombre.TabIndex = 5;
        // 
        // labelPais
        // 
        labelPais.AutoSize = true;
        labelPais.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        labelPais.Location = new Point(46, 182);
        labelPais.Margin = new Padding(4, 0, 4, 0);
        labelPais.Name = "labelPais";
        labelPais.Size = new Size(150, 25);
        labelPais.TabIndex = 6;
        labelPais.Text = "País de origen";
        // 
        // pais
        // 
        pais.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        pais.Font = new Font("Times New Roman", 10F);
        pais.Location = new Point(314, 175);
        pais.Margin = new Padding(4, 5, 4, 5);
        pais.Name = "pais";
        pais.ReadOnly = true;
        pais.Size = new Size(627, 30);
        pais.TabIndex = 7;
        // 
        // labelFecha
        // 
        labelFecha.AutoSize = true;
        labelFecha.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        labelFecha.Location = new Point(46, 240);
        labelFecha.Margin = new Padding(4, 0, 4, 0);
        labelFecha.Name = "labelFecha";
        labelFecha.Size = new Size(202, 25);
        labelFecha.TabIndex = 8;
        labelFecha.Text = "Fecha de fundación";
        // 
        // fecha
        // 
        fecha.Enabled = false;
        fecha.Font = new Font("Times New Roman", 10F);
        fecha.Format = DateTimePickerFormat.Short;
        fecha.Location = new Point(314, 233);
        fecha.Margin = new Padding(4, 5, 4, 5);
        fecha.Name = "fecha";
        fecha.Size = new Size(313, 30);
        fecha.TabIndex = 9;
        // 
        // labelSeries
        // 
        labelSeries.AutoSize = true;
        labelSeries.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        labelSeries.Location = new Point(46, 307);
        labelSeries.Margin = new Padding(4, 0, 4, 0);
        labelSeries.Name = "labelSeries";
        labelSeries.Size = new Size(211, 25);
        labelSeries.TabIndex = 10;
        labelSeries.Text = "Series referenciadas";
        // 
        // series
        // 
        series.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        series.Font = new Font("Times New Roman", 10F);
        series.FormattingEnabled = true;
        series.IntegralHeight = false;
        series.Location = new Point(314, 300);
        series.Margin = new Padding(4, 5, 4, 5);
        series.Name = "series";
        series.Size = new Size(627, 264);
        series.TabIndex = 11;
        // 
        // accion
        // 
        accion.Enabled = false;
        accion.Font = new Font("Sitka Banner", 10F);
        accion.Location = new Point(386, 778);
        accion.Margin = new Padding(4, 5, 4, 5);
        accion.Name = "accion";
        accion.Size = new Size(229, 50);
        accion.TabIndex = 5;
        accion.Text = "Eliminar estudio";
        accion.UseVisualStyleBackColor = true;
        accion.Click += accion_Click;
        // 
        // FormEliminarEstudio
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1000, 875);
        Controls.Add(labelTitulo);
        Controls.Add(labelBusqueda);
        Controls.Add(codigoBusqueda);
        Controls.Add(buscar);
        Controls.Add(detalle);
        Controls.Add(accion);
        Margin = new Padding(4, 5, 4, 5);
        MinimumSize = new Size(905, 903);
        Name = "FormEliminarEstudio";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Eliminar estudio";
        Load += FormEstudio_Load;
        detalle.ResumeLayout(false);
        detalle.PerformLayout();
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
    private Button accion;
}
