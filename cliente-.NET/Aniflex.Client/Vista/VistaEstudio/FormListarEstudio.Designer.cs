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
        ((System.ComponentModel.ISupportInitialize)grilla).BeginInit();
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
        labelTitulo.Size = new Size(191, 28);
        labelTitulo.TabIndex = 0;
        labelTitulo.Text = "LISTAR ESTUDIOS";
        // 
        // labelBusqueda
        // 
        labelBusqueda.AutoSize = true;
        labelBusqueda.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        labelBusqueda.Location = new Point(46, 108);
        labelBusqueda.Margin = new Padding(4, 0, 4, 0);
        labelBusqueda.Name = "labelBusqueda";
        labelBusqueda.Size = new Size(33, 25);
        labelBusqueda.TabIndex = 1;
        labelBusqueda.Text = "ID";
        // 
        // codigoBusqueda
        // 
        codigoBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        codigoBusqueda.Font = new Font("Times New Roman", 10F);
        codigoBusqueda.Location = new Point(221, 102);
        codigoBusqueda.Margin = new Padding(4, 5, 4, 5);
        codigoBusqueda.Name = "codigoBusqueda";
        codigoBusqueda.Size = new Size(220, 30);
        codigoBusqueda.TabIndex = 2;
        // 
        // labelPais
        // 
        labelPais.AutoSize = true;
        labelPais.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
        labelPais.Location = new Point(471, 108);
        labelPais.Margin = new Padding(4, 0, 4, 0);
        labelPais.Name = "labelPais";
        labelPais.Size = new Size(54, 25);
        labelPais.TabIndex = 3;
        labelPais.Text = "País";
        // 
        // paisFiltro
        // 
        paisFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        paisFiltro.Font = new Font("Times New Roman", 10F);
        paisFiltro.Location = new Point(550, 102);
        paisFiltro.Margin = new Padding(4, 5, 4, 5);
        paisFiltro.Name = "paisFiltro";
        paisFiltro.Size = new Size(170, 30);
        paisFiltro.TabIndex = 4;
        // 
        // cargar
        // 
        cargar.Font = new Font("Sitka Banner", 10F);
        cargar.Location = new Point(46, 170);
        cargar.Margin = new Padding(4, 5, 4, 5);
        cargar.Name = "cargar";
        cargar.Size = new Size(157, 50);
        cargar.TabIndex = 5;
        cargar.Text = "Cargar";
        cargar.UseVisualStyleBackColor = true;
        cargar.Click += cargar_Click;
        // 
        // filtrar
        // 
        filtrar.Font = new Font("Sitka Banner", 10F);
        filtrar.Location = new Point(229, 170);
        filtrar.Margin = new Padding(4, 5, 4, 5);
        filtrar.Name = "filtrar";
        filtrar.Size = new Size(157, 50);
        filtrar.TabIndex = 6;
        filtrar.Text = "Filtrar";
        filtrar.UseVisualStyleBackColor = true;
        filtrar.Click += filtrar_Click;
        // 
        // limpiar
        // 
        limpiar.Font = new Font("Sitka Banner", 10F);
        limpiar.Location = new Point(411, 170);
        limpiar.Margin = new Padding(4, 5, 4, 5);
        limpiar.Name = "limpiar";
        limpiar.Size = new Size(157, 50);
        limpiar.TabIndex = 7;
        limpiar.Text = "Limpiar";
        limpiar.UseVisualStyleBackColor = true;
        limpiar.Click += limpiar_Click;
        // 
        // grilla
        // 
        grilla.AllowUserToAddRows = false;
        grilla.AllowUserToDeleteRows = false;
        grilla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        grilla.ColumnHeadersHeight = 34;
        grilla.Location = new Point(46, 250);
        grilla.Margin = new Padding(4, 5, 4, 5);
        grilla.MultiSelect = false;
        grilla.Name = "grilla";
        grilla.ReadOnly = true;
        grilla.RowHeadersVisible = false;
        grilla.RowHeadersWidth = 62;
        grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grilla.Size = new Size(909, 467);
        grilla.TabIndex = 8;
        grilla.CellDoubleClick += grilla_CellDoubleClick;
        // 
        // FormListarEstudio
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1000, 767);
        Controls.Add(labelTitulo);
        Controls.Add(labelBusqueda);
        Controls.Add(codigoBusqueda);
        Controls.Add(labelPais);
        Controls.Add(paisFiltro);
        Controls.Add(cargar);
        Controls.Add(filtrar);
        Controls.Add(limpiar);
        Controls.Add(grilla);
        Margin = new Padding(4, 5, 4, 5);
        MinimumSize = new Size(905, 794);
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
