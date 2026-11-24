namespace Aniflex.Client.Vista.VistaEpisodio
{
    partial class FormActualizarEpisodio
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
            label3 = new Label();
            txtSerie = new TextBox();
            txtNumEpisodio = new TextBox();
            label9 = new Label();
            txtNumEliminar = new TextBox();
            label7 = new Label();
            textBoxID = new TextBox();
            dateTimePickerEstreno = new DateTimePicker();
            label6 = new Label();
            btnActualizar = new Button();
            txtCalificacion = new TextBox();
            txtTitulo = new TextBox();
            chkEsEspecial = new CheckBox();
            label4 = new Label();
            label2 = new Label();
            btnBuscar = new Button();
            label1 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 408);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 103;
            label3.Text = "Serie:";
            // 
            // txtSerie
            // 
            txtSerie.Enabled = false;
            txtSerie.Location = new Point(227, 398);
            txtSerie.Name = "txtSerie";
            txtSerie.Size = new Size(231, 31);
            txtSerie.TabIndex = 102;
            // 
            // txtNumEpisodio
            // 
            txtNumEpisodio.Enabled = false;
            txtNumEpisodio.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumEpisodio.Location = new Point(227, 530);
            txtNumEpisodio.Name = "txtNumEpisodio";
            txtNumEpisodio.Size = new Size(231, 30);
            txtNumEpisodio.TabIndex = 101;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(27, 533);
            label9.Name = "label9";
            label9.Size = new Size(132, 25);
            label9.TabIndex = 100;
            label9.Text = "N° Episodio:";
            // 
            // txtNumEliminar
            // 
            txtNumEliminar.Location = new Point(227, 143);
            txtNumEliminar.Name = "txtNumEliminar";
            txtNumEliminar.Size = new Size(231, 31);
            txtNumEliminar.TabIndex = 97;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(23, 150);
            label7.Name = "label7";
            label7.Size = new Size(40, 25);
            label7.TabIndex = 96;
            label7.Text = "ID:";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(227, 337);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(231, 31);
            textBoxID.TabIndex = 95;
            // 
            // dateTimePickerEstreno
            // 
            dateTimePickerEstreno.CustomFormat = "yyyy-MM-dd HH:mm";
            dateTimePickerEstreno.Enabled = false;
            dateTimePickerEstreno.Format = DateTimePickerFormat.Custom;
            dateTimePickerEstreno.Location = new Point(227, 672);
            dateTimePickerEstreno.Margin = new Padding(4, 5, 4, 5);
            dateTimePickerEstreno.Name = "dateTimePickerEstreno";
            dateTimePickerEstreno.Size = new Size(231, 31);
            dateTimePickerEstreno.TabIndex = 94;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(23, 680);
            label6.Name = "label6";
            label6.Size = new Size(161, 25);
            label6.TabIndex = 93;
            label6.Text = "Fecha Emisión:";
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(166, 803);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(156, 52);
            btnActualizar.TabIndex = 92;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtCalificacion
            // 
            txtCalificacion.Enabled = false;
            txtCalificacion.Location = new Point(227, 597);
            txtCalificacion.Name = "txtCalificacion";
            txtCalificacion.Size = new Size(231, 31);
            txtCalificacion.TabIndex = 91;
            // 
            // txtTitulo
            // 
            txtTitulo.Enabled = false;
            txtTitulo.Location = new Point(227, 462);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(231, 31);
            txtTitulo.TabIndex = 90;
            // 
            // chkEsEspecial
            // 
            chkEsEspecial.AutoSize = true;
            chkEsEspecial.Enabled = false;
            chkEsEspecial.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkEsEspecial.Location = new Point(23, 745);
            chkEsEspecial.Name = "chkEsEspecial";
            chkEsEspecial.Size = new Size(149, 29);
            chkEsEspecial.TabIndex = 89;
            chkEsEspecial.Text = "Es especial";
            chkEsEspecial.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 605);
            label4.Name = "label4";
            label4.Size = new Size(124, 25);
            label4.TabIndex = 88;
            label4.Text = "Calificacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 468);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 87;
            label2.Text = "Titulo:";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(166, 242);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(156, 52);
            btnBuscar.TabIndex = 86;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(116, 15);
            label1.Name = "label1";
            label1.Size = new Size(250, 28);
            label1.TabIndex = 85;
            label1.Text = "ACTUALIZAR EPISODIO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 340);
            label5.Name = "label5";
            label5.Size = new Size(40, 25);
            label5.TabIndex = 104;
            label5.Text = "ID:";
            // 
            // FormActualizarEpisodio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 862);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtSerie);
            Controls.Add(txtNumEpisodio);
            Controls.Add(label9);
            Controls.Add(txtNumEliminar);
            Controls.Add(label7);
            Controls.Add(textBoxID);
            Controls.Add(dateTimePickerEstreno);
            Controls.Add(label6);
            Controls.Add(btnActualizar);
            Controls.Add(txtCalificacion);
            Controls.Add(txtTitulo);
            Controls.Add(chkEsEspecial);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormActualizarEpisodio";
            Text = "FormActualizarEpisodio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtSerie;
        private TextBox txtNumEpisodio;
        private Label label9;
        private TextBox txtNumEliminar;
        private Label label7;
        private TextBox textBoxID;
        private DateTimePicker dateTimePickerEstreno;
        private Label label6;
        private Button btnActualizar;
        private TextBox txtCalificacion;
        private TextBox txtTitulo;
        private CheckBox chkEsEspecial;
        private Label label4;
        private Label label2;
        private Button btnBuscar;
        private Label label1;
        private Label label5;
    }
}