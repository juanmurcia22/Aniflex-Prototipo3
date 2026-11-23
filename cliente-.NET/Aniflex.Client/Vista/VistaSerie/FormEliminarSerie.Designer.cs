namespace Aniflex.Client
{
    partial class FormEliminarSerie
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
            btnEliminar = new Button();
            txtCalificacion = new TextBox();
            txtTemporadas = new TextBox();
            txtTitulo = new TextBox();
            chkEnEmision = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnBuscar = new Button();
            txtId = new TextBox();
            label1 = new Label();
            txtIdBuscar = new Label();
            dateTimePickerEstreno = new DateTimePicker();
            label6 = new Label();
            textBoxID = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(199, 778);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(156, 52);
            btnEliminar.TabIndex = 34;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtCalificacion
            // 
            txtCalificacion.Enabled = false;
            txtCalificacion.Location = new Point(260, 572);
            txtCalificacion.Name = "txtCalificacion";
            txtCalificacion.Size = new Size(231, 31);
            txtCalificacion.TabIndex = 33;
            // 
            // txtTemporadas
            // 
            txtTemporadas.Enabled = false;
            txtTemporadas.Location = new Point(260, 500);
            txtTemporadas.Name = "txtTemporadas";
            txtTemporadas.Size = new Size(231, 31);
            txtTemporadas.TabIndex = 32;
            // 
            // txtTitulo
            // 
            txtTitulo.Enabled = false;
            txtTitulo.Location = new Point(260, 437);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(231, 31);
            txtTitulo.TabIndex = 31;
            // 
            // chkEnEmision
            // 
            chkEnEmision.AutoSize = true;
            chkEnEmision.Enabled = false;
            chkEnEmision.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkEnEmision.Location = new Point(56, 720);
            chkEnEmision.Name = "chkEnEmision";
            chkEnEmision.Size = new Size(144, 29);
            chkEnEmision.TabIndex = 30;
            chkEnEmision.Text = "En emisión";
            chkEnEmision.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(56, 580);
            label4.Name = "label4";
            label4.Size = new Size(124, 25);
            label4.TabIndex = 29;
            label4.Text = "Calificacion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 507);
            label3.Name = "label3";
            label3.Size = new Size(140, 25);
            label3.TabIndex = 28;
            label3.Text = "Temporadas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 443);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 27;
            label2.Text = "Titulo:";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(199, 272);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(156, 52);
            btnBuscar.TabIndex = 26;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(260, 132);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.Size = new Size(231, 34);
            txtId.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(171, 47);
            label1.Name = "label1";
            label1.Size = new Size(176, 28);
            label1.TabIndex = 24;
            label1.Text = "ELIMINAR SERIE";
            label1.Click += label1_Click;
            // 
            // txtIdBuscar
            // 
            txtIdBuscar.AutoSize = true;
            txtIdBuscar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIdBuscar.Location = new Point(56, 142);
            txtIdBuscar.Name = "txtIdBuscar";
            txtIdBuscar.Size = new Size(40, 25);
            txtIdBuscar.TabIndex = 23;
            txtIdBuscar.Text = "ID:";
            txtIdBuscar.Click += txtIdBuscar_Click;
            // 
            // dateTimePickerEstreno
            // 
            dateTimePickerEstreno.Enabled = false;
            dateTimePickerEstreno.Format = DateTimePickerFormat.Short;
            dateTimePickerEstreno.Location = new Point(260, 647);
            dateTimePickerEstreno.Margin = new Padding(4, 5, 4, 5);
            dateTimePickerEstreno.Name = "dateTimePickerEstreno";
            dateTimePickerEstreno.Size = new Size(231, 31);
            dateTimePickerEstreno.TabIndex = 36;
            dateTimePickerEstreno.ValueChanged += dateTimePickerEstreno_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(56, 655);
            label6.Name = "label6";
            label6.Size = new Size(159, 25);
            label6.TabIndex = 35;
            label6.Text = "Fecha Estreno:";
            label6.Click += label6_Click;
            // 
            // textBoxID
            // 
            textBoxID.Enabled = false;
            textBoxID.Location = new Point(260, 367);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(231, 31);
            textBoxID.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(56, 373);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 37;
            label5.Text = "ObjectId:";
            // 
            // FormEliminarSerie
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 875);
            Controls.Add(textBoxID);
            Controls.Add(label5);
            Controls.Add(dateTimePickerEstreno);
            Controls.Add(label6);
            Controls.Add(btnEliminar);
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
            Name = "FormEliminarSerie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEliminar";
            Load += FormEliminar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private TextBox txtCalificacion;
        private TextBox txtTemporadas;
        private TextBox txtTitulo;
        private CheckBox chkEnEmision;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnBuscar;
        private TextBox txtId;
        private Label label1;
        private Label txtIdBuscar;
        private DateTimePicker dateTimePickerEstreno;
        private Label label6;
        private TextBox textBoxID;
        private Label label5;
    }
}
