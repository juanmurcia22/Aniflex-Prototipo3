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
        labelTitulo.Size = new Size(207, 28);
        labelTitulo.TabIndex = 0;
        labelTitulo.Text = "AGREGAR ESTUDIO";
        // 
        // detalle
        // 
        detalle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
        detalle.Location = new Point(0, 92);
        detalle.Margin = new Padding(4, 5, 4, 5);
        detalle.Name = "detalle";
        detalle.Size = new Size(1000, 650);
        detalle.TabIndex = 1;
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
        fecha.Font = new Font("Times New Roman", 10F);
        fecha.Format = DateTimePickerFormat.Short;
        fecha.Location = new Point(314, 233);
        fecha.Margin = new Padding(4, 5, 4, 5);
        fecha.Name = "fecha";
        fecha.Size = new Size(313, 30);
        fecha.TabIndex = 9;
        // 
        // labelSerieCodigo
        // 
        labelSerieCodigo.AutoSize = true;
        labelSerieCodigo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        labelSerieCodigo.Location = new Point(46, 302);
        labelSerieCodigo.Margin = new Padding(4, 0, 4, 0);
        labelSerieCodigo.Name = "labelSerieCodigo";
        labelSerieCodigo.Size = new Size(116, 25);
        labelSerieCodigo.TabIndex = 10;
        labelSerieCodigo.Text = "ID de serie";
        // 
        // serieCodigo
        // 
        serieCodigo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        serieCodigo.Font = new Font("Times New Roman", 10F);
        serieCodigo.Location = new Point(314, 295);
        serieCodigo.Margin = new Padding(4, 5, 4, 5);
        serieCodigo.Name = "serieCodigo";
        serieCodigo.Size = new Size(213, 30);
        serieCodigo.TabIndex = 11;
        // 
        // agregarSerie
        // 
        agregarSerie.Font = new Font("Sitka Banner", 10F);
        agregarSerie.Location = new Point(550, 290);
        agregarSerie.Margin = new Padding(4, 5, 4, 5);
        agregarSerie.Name = "agregarSerie";
        agregarSerie.Size = new Size(157, 50);
        agregarSerie.TabIndex = 12;
        agregarSerie.Text = "Añadir serie";
        agregarSerie.UseVisualStyleBackColor = true;
        agregarSerie.Click += agregarSerie_Click;
        // 
        // retirarSerie
        // 
        retirarSerie.Font = new Font("Sitka Banner", 10F);
        retirarSerie.Location = new Point(729, 290);
        retirarSerie.Margin = new Padding(4, 5, 4, 5);
        retirarSerie.Name = "retirarSerie";
        retirarSerie.Size = new Size(214, 50);
        retirarSerie.TabIndex = 13;
        retirarSerie.Text = "Retirar selección";
        retirarSerie.UseVisualStyleBackColor = true;
        retirarSerie.Click += retirarSerie_Click;
        // 
        // labelSeries
        // 
        labelSeries.AutoSize = true;
        labelSeries.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        labelSeries.Location = new Point(46, 373);
        labelSeries.Margin = new Padding(4, 0, 4, 0);
        labelSeries.Name = "labelSeries";
        labelSeries.Size = new Size(211, 25);
        labelSeries.TabIndex = 14;
        labelSeries.Text = "Series referenciadas";
        // 
        // series
        // 
        series.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        series.Font = new Font("Times New Roman", 10F);
        series.FormattingEnabled = true;
        series.IntegralHeight = false;
        series.Location = new Point(314, 367);
        series.Margin = new Padding(4, 5, 4, 5);
        series.Name = "series";
        series.Size = new Size(627, 264);
        series.TabIndex = 15;
        // 
        // accion
        // 
        accion.Font = new Font("Sitka Banner", 10F);
        accion.Location = new Point(386, 762);
        accion.Margin = new Padding(4, 5, 4, 5);
        accion.Name = "accion";
        accion.Size = new Size(229, 50);
        accion.TabIndex = 2;
        accion.Text = "Guardar estudio";
        accion.UseVisualStyleBackColor = true;
        accion.Click += accion_Click;
        // 
        // FormAgregarEstudio
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1000, 858);
        Controls.Add(labelTitulo);
        Controls.Add(detalle);
        Controls.Add(accion);
        Margin = new Padding(4, 5, 4, 5);
        MinimumSize = new Size(905, 886);
        Name = "FormAgregarEstudio";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Agregar estudio";
        Load += FormEstudio_Load;
        detalle.ResumeLayout(false);
        detalle.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
    #endregion
    private Label labelTitulo;
    private Panel detalle;
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
