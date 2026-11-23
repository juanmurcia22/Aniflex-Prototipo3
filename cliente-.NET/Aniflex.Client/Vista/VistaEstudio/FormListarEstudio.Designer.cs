#nullable disable
namespace Aniflex.Client.Vista.VistaEstudio;

partial class FormListarEstudio
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
        labelPais = new Label();
        paisFiltro = new TextBox();
        cargar = new Button();
        filtrar = new Button();
        limpiar = new Button();
        grilla = new DataGridView();
        colCodigo = new DataGridViewTextBoxColumn();
        colNombre = new DataGridViewTextBoxColumn();
        colPais = new DataGridViewTextBoxColumn();
        colFecha = new DataGridViewTextBoxColumn();
        DataGridViewCellStyle estiloFecha = new DataGridViewCellStyle();
        estiloFecha.Format = "d";
        colFecha.DefaultCellStyle = estiloFecha;
        grilla.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colNombre, colPais, colFecha });
        ((System.ComponentModel.ISupportInitialize)grilla).BeginInit();
        SuspendLayout();

        // labelTitulo
        labelTitulo.Name = "labelTitulo";
        labelTitulo.Text = "LISTAR ESTUDIOS";
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
        codigoBusqueda.Size = new Size(155, 23);
        codigoBusqueda.Font = new Font("Times New Roman", 10F);
        codigoBusqueda.ReadOnly = false;
        codigoBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        // labelPais
        labelPais.Name = "labelPais";
        labelPais.Text = "País";
        labelPais.AutoSize = true;
        labelPais.Location = new Point(330, 65);
        labelPais.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        // paisFiltro
        paisFiltro.Name = "paisFiltro";
        paisFiltro.Location = new Point(385, 61);
        paisFiltro.Size = new Size(120, 23);
        paisFiltro.Font = new Font("Times New Roman", 10F);
        paisFiltro.ReadOnly = false;
        paisFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        // cargar
        cargar.Name = "cargar";
        cargar.Text = "Cargar";
        cargar.Location = new Point(32, 102);
        cargar.Size = new Size(110, 30);
        cargar.Font = new Font("Sitka Banner", 10F);
        cargar.UseVisualStyleBackColor = true;
        cargar.Click += cargar_Click;
        // filtrar
        filtrar.Name = "filtrar";
        filtrar.Text = "Filtrar";
        filtrar.Location = new Point(160, 102);
        filtrar.Size = new Size(110, 30);
        filtrar.Font = new Font("Sitka Banner", 10F);
        filtrar.UseVisualStyleBackColor = true;
        filtrar.Click += filtrar_Click;
        // limpiar
        limpiar.Name = "limpiar";
        limpiar.Text = "Limpiar";
        limpiar.Location = new Point(288, 102);
        limpiar.Size = new Size(110, 30);
        limpiar.Font = new Font("Sitka Banner", 10F);
        limpiar.UseVisualStyleBackColor = true;
        limpiar.Click += limpiar_Click;
        // grilla
        grilla.Name = "grilla";
        grilla.Location = new Point(32, 150);
        grilla.Size = new Size(636, 280);
        grilla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        grilla.ReadOnly = true;
        grilla.AllowUserToAddRows = false;
        grilla.AllowUserToDeleteRows = false;
        grilla.AutoGenerateColumns = false;
        grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grilla.MultiSelect = false;
        grilla.RowHeadersVisible = false;
        grilla.CellDoubleClick += grilla_CellDoubleClick;
        // colCodigo
        colCodigo.Name = "colCodigo";
        colCodigo.DataPropertyName = "Codigo";
        colCodigo.HeaderText = "ID manual";
        // colNombre
        colNombre.Name = "colNombre";
        colNombre.DataPropertyName = "Nombre";
        colNombre.HeaderText = "Nombre";
        // colPais
        colPais.Name = "colPais";
        colPais.DataPropertyName = "PaisOrigen";
        colPais.HeaderText = "País de origen";
        // colFecha
        colFecha.Name = "colFecha";
        colFecha.DataPropertyName = "FechaFundacion";
        colFecha.HeaderText = "Fundación";
        Controls.Add(labelTitulo);
        Controls.Add(labelBusqueda);
        Controls.Add(codigoBusqueda);
        Controls.Add(labelPais);
        Controls.Add(paisFiltro);
        Controls.Add(cargar);
        Controls.Add(filtrar);
        Controls.Add(limpiar);
        Controls.Add(grilla);
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(700, 460);
        MinimumSize = new Size(640, 499);
        Name = "FormListarEstudio";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Listar estudio";
        FormClosed += FormListarEstudio_FormClosed;
        ((System.ComponentModel.ISupportInitialize)grilla).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
    #endregion
    private Label labelTitulo;
    private Label labelBusqueda;
    private TextBox codigoBusqueda;
    private Label labelPais;
    private TextBox paisFiltro;
    private Button cargar;
    private Button filtrar;
    private Button limpiar;
    private DataGridView grilla;
    private DataGridViewTextBoxColumn colCodigo;
    private DataGridViewTextBoxColumn colNombre;
    private DataGridViewTextBoxColumn colPais;
    private DataGridViewTextBoxColumn colFecha;
}
