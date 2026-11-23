namespace Aniflex.Client.Vista.VistaEpisodio
{
    partial class FormEliminarEpisodio
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
            txtNumEliminar = new TextBox();
            label7 = new Label();
            textBoxID = new TextBox();
            label5 = new Label();
            dateTimePickerEstreno = new DateTimePicker();
            label6 = new Label();
            btnEliminar = new Button();
            txtCalificacion = new TextBox();
            txtTitulo = new TextBox();
            chkEsEspecial = new CheckBox();
            label4 = new Label();
            label2 = new Label();
            btnBuscar = new Button();
            label1 = new Label();
            txtNumEpisodio = new TextBox();
            label9 = new Label();
            label3 = new Label();
            txtSerie = new TextBox();
            SuspendLayout();
            // 
            // txtNumEliminar
            // 
            txtNumEliminar.Location = new Point(73, 177);
            txtNumEliminar.Name = "txtNumEliminar";
            txtNumEliminar.Size = new Size(231, 31);
            txtNumEliminar.TabIndex = 58;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(27, 183);
            label7.Name = "label7";
            label7.Size = new Size(40, 25);
            label7.TabIndex = 57;
            label7.Text = "ID:";
            // 
            // textBoxID
            // 
            textBoxID.Enabled = false;
            textBoxID.Location = new Point(231, 350);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(231, 31);
            textBoxID.TabIndex = 56;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 357);
            label5.Name = "label5";
            label5.Size = new Size(40, 25);
            label5.TabIndex = 55;
            label5.Text = "ID:";
            // 
            // dateTimePickerEstreno
            // 
            dateTimePickerEstreno.CustomFormat = "yyyy-MM-dd HH:mm";
            dateTimePickerEstreno.Enabled = false;
            dateTimePickerEstreno.Format = DateTimePickerFormat.Custom;
            dateTimePickerEstreno.Location = new Point(231, 685);
            dateTimePickerEstreno.Margin = new Padding(4, 5, 4, 5);
            dateTimePickerEstreno.Name = "dateTimePickerEstreno";
            dateTimePickerEstreno.Size = new Size(231, 31);
            dateTimePickerEstreno.TabIndex = 54;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(27, 693);
            label6.Name = "label6";
            label6.Size = new Size(161, 25);
            label6.TabIndex = 53;
            label6.Text = "Fecha Emisión:";
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(170, 817);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(156, 52);
            btnEliminar.TabIndex = 52;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtCalificacion
            // 
            txtCalificacion.Enabled = false;
            txtCalificacion.Location = new Point(231, 610);
            txtCalificacion.Name = "txtCalificacion";
            txtCalificacion.Size = new Size(231, 31);
            txtCalificacion.TabIndex = 51;
            // 
            // txtTitulo
            // 
            txtTitulo.Enabled = false;
            txtTitulo.Location = new Point(231, 475);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(231, 31);
            txtTitulo.TabIndex = 49;
            // 
            // chkEsEspecial
            // 
            chkEsEspecial.AutoSize = true;
            chkEsEspecial.Enabled = false;
            chkEsEspecial.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkEsEspecial.Location = new Point(27, 758);
            chkEsEspecial.Name = "chkEsEspecial";
            chkEsEspecial.Size = new Size(149, 29);
            chkEsEspecial.TabIndex = 48;
            chkEsEspecial.Text = "Es especial";
            chkEsEspecial.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 618);
            label4.Name = "label4";
            label4.Size = new Size(124, 25);
            label4.TabIndex = 47;
            label4.Text = "Calificacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 482);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 45;
            label2.Text = "Titulo:";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(335, 168);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(156, 52);
            btnBuscar.TabIndex = 44;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(133, 30);
            label1.Name = "label1";
            label1.Size = new Size(220, 28);
            label1.TabIndex = 42;
            label1.Text = "ELIMINAR EPISODIO";
            // 
            // txtNumEpisodio
            // 
            txtNumEpisodio.Enabled = false;
            txtNumEpisodio.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumEpisodio.Location = new Point(231, 543);
            txtNumEpisodio.Name = "txtNumEpisodio";
            txtNumEpisodio.Size = new Size(231, 30);
            txtNumEpisodio.TabIndex = 62;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(31, 547);
            label9.Name = "label9";
            label9.Size = new Size(132, 25);
            label9.TabIndex = 61;
            label9.Text = "N° Episodio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 422);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 84;
            label3.Text = "Serie:";
            // 
            // txtSerie
            // 
            txtSerie.Enabled = false;
            txtSerie.Location = new Point(231, 412);
            txtSerie.Name = "txtSerie";
            txtSerie.Size = new Size(231, 31);
            txtSerie.TabIndex = 83;
            // 
            // FormEliminarEpisodio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 897);
            Controls.Add(label3);
            Controls.Add(txtSerie);
            Controls.Add(txtNumEpisodio);
            Controls.Add(label9);
            Controls.Add(txtNumEliminar);
            Controls.Add(label7);
            Controls.Add(textBoxID);
            Controls.Add(label5);
            Controls.Add(dateTimePickerEstreno);
            Controls.Add(label6);
            Controls.Add(btnEliminar);
            Controls.Add(txtCalificacion);
            Controls.Add(txtTitulo);
            Controls.Add(chkEsEspecial);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormEliminarEpisodio";
            Text = "FormEliminarEpisodio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumEliminar;
        private Label label7;
        private TextBox textBoxID;
        private Label label5;
        private DateTimePicker dateTimePickerEstreno;
        private Label label6;
        private Button btnEliminar;
        private TextBox txtCalificacion;
        private TextBox txtTitulo;
        private CheckBox chkEsEspecial;
        private Label label4;
        private Label label2;
        private Button btnBuscar;
        private Label label1;
        private TextBox txtNumEpisodio;
        private Label label9;
        private Label label3;
        private TextBox txtSerie;
    }
}