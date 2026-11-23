namespace Aniflex.Client.Vista.VistaEpisodio
{
    partial class FormAgregarEpisodio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbSerie = new ComboBox();
            txtNumEpisodio = new TextBox();
            label8 = new Label();
            label7 = new Label();
            dateTimePickerEstreno = new DateTimePicker();
            label6 = new Label();
            btnGuardar = new Button();
            chkEsEspecial = new CheckBox();
            txtCalificacion = new TextBox();
            label5 = new Label();
            txtTitulo = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txtCodigo = new TextBox();
            labelIdManual = new Label();
            SuspendLayout();
            // 
            // cmbSerie
            // 
            cmbSerie.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSerie.FormattingEnabled = true;
            cmbSerie.Location = new Point(244, 180);
            cmbSerie.Margin = new Padding(4, 5, 4, 5);
            cmbSerie.Name = "cmbSerie";
            cmbSerie.Size = new Size(254, 33);
            cmbSerie.TabIndex = 44;
            // 
            // txtNumEpisodio
            // 
            txtNumEpisodio.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumEpisodio.Location = new Point(243, 230);
            txtNumEpisodio.Name = "txtNumEpisodio";
            txtNumEpisodio.Size = new Size(255, 30);
            txtNumEpisodio.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(34, 238);
            label8.Name = "label8";
            label8.Size = new Size(132, 25);
            label8.TabIndex = 42;
            label8.Text = "N° Episodio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(34, 183);
            label7.Name = "label7";
            label7.Size = new Size(70, 25);
            label7.TabIndex = 41;
            label7.Text = "Serie:";
            // 
            // dateTimePickerEstreno
            // 
            dateTimePickerEstreno.CustomFormat = "yyyy-MM-dd HH:mm";
            dateTimePickerEstreno.Format = DateTimePickerFormat.Custom;
            dateTimePickerEstreno.Location = new Point(243, 442);
            dateTimePickerEstreno.Margin = new Padding(4, 5, 4, 5);
            dateTimePickerEstreno.Name = "dateTimePickerEstreno";
            dateTimePickerEstreno.Size = new Size(257, 31);
            dateTimePickerEstreno.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(34, 450);
            label6.Name = "label6";
            label6.Size = new Size(161, 25);
            label6.TabIndex = 39;
            label6.Text = "Fecha Emisión:";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(179, 578);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(169, 50);
            btnGuardar.TabIndex = 38;
            btnGuardar.Text = "Guardar Episodio";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // chkEsEspecial
            // 
            chkEsEspecial.AutoSize = true;
            chkEsEspecial.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkEsEspecial.Location = new Point(36, 507);
            chkEsEspecial.Name = "chkEsEspecial";
            chkEsEspecial.Size = new Size(149, 29);
            chkEsEspecial.TabIndex = 37;
            chkEsEspecial.Text = "Es especial";
            chkEsEspecial.UseVisualStyleBackColor = true;
            // 
            // txtCalificacion
            // 
            txtCalificacion.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCalificacion.Location = new Point(244, 378);
            txtCalificacion.Name = "txtCalificacion";
            txtCalificacion.Size = new Size(255, 30);
            txtCalificacion.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(36, 385);
            label5.Name = "label5";
            label5.Size = new Size(131, 25);
            label5.TabIndex = 35;
            label5.Text = "Calificación:";
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(244, 298);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(255, 30);
            txtTitulo.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 307);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 33;
            label3.Text = "Título:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(164, 45);
            label1.Name = "label1";
            label1.Size = new Size(218, 28);
            label1.TabIndex = 30;
            label1.Text = "AGREGAR EPISODIO";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Times New Roman", 10F);
            txtCodigo.Location = new Point(243, 117);
            txtCodigo.Margin = new Padding(4, 5, 4, 5);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(255, 30);
            txtCodigo.TabIndex = 2;
            // 
            // labelIdManual
            // 
            labelIdManual.AutoSize = true;
            labelIdManual.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            labelIdManual.Location = new Point(34, 123);
            labelIdManual.Margin = new Padding(4, 0, 4, 0);
            labelIdManual.Name = "labelIdManual";
            labelIdManual.Size = new Size(40, 25);
            labelIdManual.TabIndex = 1;
            labelIdManual.Text = "ID:";
            // 
            // FormAgregarEpisodio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 665);
            Controls.Add(labelIdManual);
            Controls.Add(txtCodigo);
            Controls.Add(cmbSerie);
            Controls.Add(txtNumEpisodio);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dateTimePickerEstreno);
            Controls.Add(label6);
            Controls.Add(btnGuardar);
            Controls.Add(chkEsEspecial);
            Controls.Add(txtCalificacion);
            Controls.Add(label5);
            Controls.Add(txtTitulo);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormAgregarEpisodio";
            Text = "FormAgregarEpisodio";
            Load += FormAgregarEpisodio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSerie;
        private TextBox txtNumEpisodio;
        private Label label8;
        private Label label7;
        private DateTimePicker dateTimePickerEstreno;
        private Label label6;
        private Button btnGuardar;
        private CheckBox chkEsEspecial;
        private TextBox txtCalificacion;
        private Label label5;
        private TextBox txtTitulo;
        private Label label3;
        private Label label1;
        private TextBox txtCodigo;

        private Label labelIdManual;

    }
}