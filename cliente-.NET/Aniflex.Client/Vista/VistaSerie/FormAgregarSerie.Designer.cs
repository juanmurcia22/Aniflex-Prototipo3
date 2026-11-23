namespace Aniflex.Client
{
    partial class FormAgregarSerie
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
            label1 = new Label();
            label3 = new Label();
            txtTitulo = new TextBox();
            label4 = new Label();
            txtTemporadas = new TextBox();
            label5 = new Label();
            txtCalificacion = new TextBox();
            chkEnEmision = new CheckBox();
            btnGuardar = new Button();
            label6 = new Label();
            dateTimePickerEstreno = new DateTimePicker();
            txtCodigo = new TextBox();
            labelIdManual = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(219, 15);
            label1.Name = "label1";
            label1.Size = new Size(174, 28);
            label1.TabIndex = 0;
            label1.Text = "AGREGAR SERIE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(74, 157);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 3;
            label3.Text = "Título:";
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(283, 148);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(255, 30);
            txtTitulo.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(74, 218);
            label4.Name = "label4";
            label4.Size = new Size(140, 25);
            label4.TabIndex = 5;
            label4.Text = "Temporadas:";
            // 
            // txtTemporadas
            // 
            txtTemporadas.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTemporadas.Location = new Point(283, 212);
            txtTemporadas.Name = "txtTemporadas";
            txtTemporadas.Size = new Size(257, 30);
            txtTemporadas.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(74, 282);
            label5.Name = "label5";
            label5.Size = new Size(131, 25);
            label5.TabIndex = 7;
            label5.Text = "Calificación:";
            // 
            // txtCalificacion
            // 
            txtCalificacion.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCalificacion.Location = new Point(283, 275);
            txtCalificacion.Name = "txtCalificacion";
            txtCalificacion.Size = new Size(255, 30);
            txtCalificacion.TabIndex = 8;
            // 
            // chkEnEmision
            // 
            chkEnEmision.AutoSize = true;
            chkEnEmision.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkEnEmision.Location = new Point(74, 403);
            chkEnEmision.Name = "chkEnEmision";
            chkEnEmision.Size = new Size(144, 29);
            chkEnEmision.TabIndex = 9;
            chkEnEmision.Text = "En emisión";
            chkEnEmision.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(219, 470);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(169, 50);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar Serie";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(73, 347);
            label6.Name = "label6";
            label6.Size = new Size(159, 25);
            label6.TabIndex = 11;
            label6.Text = "Fecha Estreno:";
            label6.Click += label6_Click;
            // 
            // dateTimePickerEstreno
            // 
            dateTimePickerEstreno.CustomFormat = "yyyy-MM-dd HH:mm";
            dateTimePickerEstreno.Format = DateTimePickerFormat.Custom;
            dateTimePickerEstreno.Location = new Point(281, 338);
            dateTimePickerEstreno.Margin = new Padding(4, 5, 4, 5);
            dateTimePickerEstreno.Name = "dateTimePickerEstreno";
            dateTimePickerEstreno.Size = new Size(257, 31);
            dateTimePickerEstreno.TabIndex = 12;
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Times New Roman", 10F);
            txtCodigo.Location = new Point(283, 85);
            txtCodigo.Margin = new Padding(4, 5, 4, 5);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(255, 30);
            txtCodigo.TabIndex = 2;
            // 
            // labelIdManual
            // 
            labelIdManual.AutoSize = true;
            labelIdManual.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            labelIdManual.Location = new Point(74, 92);
            labelIdManual.Margin = new Padding(4, 0, 4, 0);
            labelIdManual.Name = "labelIdManual";
            labelIdManual.Size = new Size(40, 25);
            labelIdManual.TabIndex = 1;
            labelIdManual.Text = "ID:";
            // 
            // FormAgregarSerie
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 542);
            Controls.Add(labelIdManual);
            Controls.Add(txtCodigo);
            Controls.Add(dateTimePickerEstreno);
            Controls.Add(label6);
            Controls.Add(btnGuardar);
            Controls.Add(chkEnEmision);
            Controls.Add(txtCalificacion);
            Controls.Add(label5);
            Controls.Add(txtTemporadas);
            Controls.Add(label4);
            Controls.Add(txtTitulo);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "FormAgregarSerie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAgregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox txtTitulo;
        private Label label4;
        private TextBox txtTemporadas;
        private Label label5;
        private TextBox txtCalificacion;
        private CheckBox chkEnEmision;
        private Button btnGuardar;
        private Label label6;
        private DateTimePicker dateTimePickerEstreno;
        private TextBox txtCodigo;

        private Label labelIdManual;

    }
}