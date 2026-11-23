namespace Aniflex.Client
{
    partial class FormActualizarSerie
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
            txtCalificacion = new TextBox();
            txtTemporadas = new TextBox();
            txtTitulo = new TextBox();
            chkEnEmision = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnBuscar = new Button();
            label1 = new Label();
            btnActualizar = new Button();
            dateTimePickerEstreno = new DateTimePicker();
            label6 = new Label();
            textBoxID = new TextBox();
            label5 = new Label();
            txtCodigo = new TextBox();
            labelIdManual = new Label();
            SuspendLayout();
            // 
            // txtCalificacion
            // 
            txtCalificacion.Location = new Point(279, 528);
            txtCalificacion.Name = "txtCalificacion";
            txtCalificacion.Size = new Size(228, 31);
            txtCalificacion.TabIndex = 21;
            // 
            // txtTemporadas
            // 
            txtTemporadas.Location = new Point(279, 457);
            txtTemporadas.Name = "txtTemporadas";
            txtTemporadas.Size = new Size(227, 31);
            txtTemporadas.TabIndex = 20;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(279, 392);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(227, 31);
            txtTitulo.TabIndex = 19;
            // 
            // chkEnEmision
            // 
            chkEnEmision.AutoSize = true;
            chkEnEmision.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkEnEmision.Location = new Point(70, 668);
            chkEnEmision.Name = "chkEnEmision";
            chkEnEmision.Size = new Size(144, 29);
            chkEnEmision.TabIndex = 18;
            chkEnEmision.Text = "En emisión";
            chkEnEmision.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(70, 535);
            label4.Name = "label4";
            label4.Size = new Size(131, 25);
            label4.TabIndex = 17;
            label4.Text = "Calificación:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(70, 463);
            label3.Name = "label3";
            label3.Size = new Size(133, 25);
            label3.TabIndex = 16;
            label3.Text = "Temporadas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(70, 398);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 15;
            label2.Text = "Titulo:";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(396, 182);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(156, 58);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(147, 40);
            label1.Name = "label1";
            label1.Size = new Size(286, 28);
            label1.TabIndex = 12;
            label1.Text = "ACTUALIZACIÓN DE DATOS";
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(211, 733);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(156, 60);
            btnActualizar.TabIndex = 22;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dateTimePickerEstreno
            // 
            dateTimePickerEstreno.Format = DateTimePickerFormat.Short;
            dateTimePickerEstreno.Location = new Point(279, 592);
            dateTimePickerEstreno.Margin = new Padding(4, 5, 4, 5);
            dateTimePickerEstreno.Name = "dateTimePickerEstreno";
            dateTimePickerEstreno.Size = new Size(227, 31);
            dateTimePickerEstreno.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(70, 600);
            label6.Name = "label6";
            label6.Size = new Size(159, 25);
            label6.TabIndex = 23;
            label6.Text = "Fecha Estreno:";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(279, 330);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(227, 31);
            textBoxID.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(70, 337);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 25;
            label5.Text = "ObjectId:";
            label5.Click += label5_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Times New Roman", 10F);
            txtCodigo.Location = new Point(118, 182);
            txtCodigo.Margin = new Padding(4, 5, 4, 5);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(227, 30);
            txtCodigo.TabIndex = 14;
            // 
            // labelIdManual
            // 
            labelIdManual.AutoSize = true;
            labelIdManual.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            labelIdManual.Location = new Point(70, 187);
            labelIdManual.Margin = new Padding(4, 0, 4, 0);
            labelIdManual.Name = "labelIdManual";
            labelIdManual.Size = new Size(40, 25);
            labelIdManual.TabIndex = 0;
            labelIdManual.Text = "ID:";
            // 
            // FormActualizarSerie
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 815);
            Controls.Add(labelIdManual);
            Controls.Add(txtCodigo);
            Controls.Add(textBoxID);
            Controls.Add(label5);
            Controls.Add(dateTimePickerEstreno);
            Controls.Add(label6);
            Controls.Add(btnActualizar);
            Controls.Add(txtCalificacion);
            Controls.Add(txtTemporadas);
            Controls.Add(txtTitulo);
            Controls.Add(chkEnEmision);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Name = "FormActualizarSerie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormActualizar";
            Load += FormActualizar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCalificacion;
        private TextBox txtTemporadas;
        private TextBox txtTitulo;
        private CheckBox chkEnEmision;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnBuscar;
        private Label label1;
        private Button btnActualizar;
        private DateTimePicker dateTimePickerEstreno;
        private Label label6;
        private TextBox textBoxID;
        private Label label5;
        private TextBox txtCodigo;

        private Label labelIdManual;

    }
}
