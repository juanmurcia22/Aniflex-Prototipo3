namespace Aniflex.Client
{
    partial class FormBuscarSerie
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
            txtIdBuscar = new Label();
            label1 = new Label();
            txtId = new TextBox();
            btnBuscar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            chkEnEmision = new CheckBox();
            txtTitulo = new TextBox();
            txtTemporadas = new TextBox();
            txtCalificacion = new TextBox();
            label5 = new Label();
            dateTimePickerEstreno = new DateTimePicker();
            label6 = new Label();
            textBoxID = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtIdBuscar
            // 
            txtIdBuscar.AutoSize = true;
            txtIdBuscar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIdBuscar.Location = new Point(33, 80);
            txtIdBuscar.Name = "txtIdBuscar";
            txtIdBuscar.Size = new Size(40, 25);
            txtIdBuscar.TabIndex = 0;
            txtIdBuscar.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(176, 15);
            label1.Name = "label1";
            label1.Size = new Size(126, 28);
            label1.TabIndex = 1;
            label1.Text = "BUSQUEDA";
            // 
            // txtId
            // 
            txtId.Location = new Point(237, 70);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.Size = new Size(231, 34);
            txtId.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(163, 203);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(156, 58);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 350);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 4;
            label2.Text = "Titulo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 415);
            label3.Name = "label3";
            label3.Size = new Size(140, 25);
            label3.TabIndex = 5;
            label3.Text = "Temporadas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 487);
            label4.Name = "label4";
            label4.Size = new Size(131, 25);
            label4.TabIndex = 6;
            label4.Text = "Calificación:";
            // 
            // chkEnEmision
            // 
            chkEnEmision.AutoSize = true;
            chkEnEmision.Enabled = false;
            chkEnEmision.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkEnEmision.Location = new Point(29, 615);
            chkEnEmision.Name = "chkEnEmision";
            chkEnEmision.Size = new Size(144, 29);
            chkEnEmision.TabIndex = 7;
            chkEnEmision.Text = "En emisión";
            chkEnEmision.UseVisualStyleBackColor = true;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(127, 343);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(335, 31);
            txtTitulo.TabIndex = 8;
            // 
            // txtTemporadas
            // 
            txtTemporadas.Location = new Point(224, 408);
            txtTemporadas.Name = "txtTemporadas";
            txtTemporadas.ReadOnly = true;
            txtTemporadas.Size = new Size(240, 31);
            txtTemporadas.TabIndex = 9;
            // 
            // txtCalificacion
            // 
            txtCalificacion.Location = new Point(236, 480);
            txtCalificacion.Name = "txtCalificacion";
            txtCalificacion.ReadOnly = true;
            txtCalificacion.Size = new Size(228, 31);
            txtCalificacion.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(34, 148);
            label5.Name = "label5";
            label5.Size = new Size(94, 25);
            label5.TabIndex = 11;
            label5.Text = "Nombre:";
            label5.Click += label5_Click;
            // 
            // dateTimePickerEstreno
            // 
            dateTimePickerEstreno.Enabled = false;
            dateTimePickerEstreno.Format = DateTimePickerFormat.Short;
            dateTimePickerEstreno.Location = new Point(237, 545);
            dateTimePickerEstreno.Margin = new Padding(4, 5, 4, 5);
            dateTimePickerEstreno.Name = "dateTimePickerEstreno";
            dateTimePickerEstreno.Size = new Size(227, 31);
            dateTimePickerEstreno.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(29, 553);
            label6.Name = "label6";
            label6.Size = new Size(159, 25);
            label6.TabIndex = 25;
            label6.Text = "Fecha Estreno:";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(127, 283);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(335, 31);
            textBoxID.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(27, 290);
            label7.Name = "label7";
            label7.Size = new Size(100, 25);
            label7.TabIndex = 27;
            label7.Text = "ObjectId:";
            // 
            // FormBuscarSerie
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 707);
            Controls.Add(textBoxID);
            Controls.Add(label7);
            Controls.Add(dateTimePickerEstreno);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtCalificacion);
            Controls.Add(txtTemporadas);
            Controls.Add(txtTitulo);
            Controls.Add(chkEnEmision);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(txtIdBuscar);
            Name = "FormBuscarSerie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBuscar";
            Load += FormBuscar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtIdBuscar;
        private Label label1;
        private TextBox txtId;
        private Button btnBuscar;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox chkEnEmision;
        private TextBox txtTitulo;
        private TextBox txtTemporadas;
        private TextBox txtCalificacion;
        private Label label5;
        private DateTimePicker dateTimePickerEstreno;
        private Label label6;
        private TextBox textBoxID;
        private Label label7;
    }
}
