namespace Carcel
{
    partial class FrmMantPPL
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label9 = new Label();
            txtid = new TextBox();
            txtnombre = new TextBox();
            txtcedula = new TextBox();
            txtapellido = new TextBox();
            txtmotivo = new TextBox();
            dtpingreso = new DateTimePicker();
            dtpsalida = new DateTimePicker();
            btngrabar = new Button();
            btnsalir = new Button();
            picturefoto = new PictureBox();
            pictureqr = new PictureBox();
            btnfoto = new Button();
            btnqr = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label7 = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picturefoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureqr).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 50);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 137);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 166);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 196);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Motivo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 225);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 4;
            label5.Text = "Fecha Ingreso";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 254);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 5;
            label6.Text = "Fecha Salida";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(43, 108);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 8;
            label9.Text = "Cedula";
            // 
            // txtid
            // 
            txtid.Location = new Point(100, 42);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(140, 23);
            txtid.TabIndex = 9;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(100, 129);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(140, 23);
            txtnombre.TabIndex = 10;
            // 
            // txtcedula
            // 
            txtcedula.Location = new Point(99, 100);
            txtcedula.Name = "txtcedula";
            txtcedula.Size = new Size(140, 23);
            txtcedula.TabIndex = 11;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(99, 158);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(141, 23);
            txtapellido.TabIndex = 12;
            // 
            // txtmotivo
            // 
            txtmotivo.Location = new Point(100, 188);
            txtmotivo.Name = "txtmotivo";
            txtmotivo.Size = new Size(141, 23);
            txtmotivo.TabIndex = 13;
            // 
            // dtpingreso
            // 
            dtpingreso.Format = DateTimePickerFormat.Short;
            dtpingreso.Location = new Point(101, 217);
            dtpingreso.Name = "dtpingreso";
            dtpingreso.Size = new Size(140, 23);
            dtpingreso.TabIndex = 14;
            // 
            // dtpsalida
            // 
            dtpsalida.Format = DateTimePickerFormat.Short;
            dtpsalida.Location = new Point(101, 246);
            dtpsalida.Name = "dtpsalida";
            dtpsalida.Size = new Size(141, 23);
            dtpsalida.TabIndex = 15;
            // 
            // btngrabar
            // 
            btngrabar.Location = new Point(486, 552);
            btngrabar.Name = "btngrabar";
            btngrabar.Size = new Size(75, 23);
            btngrabar.TabIndex = 16;
            btngrabar.Text = "Grabar";
            btngrabar.UseVisualStyleBackColor = true;
            btngrabar.Click += btngrabar_Click;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(567, 552);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(75, 23);
            btnsalir.TabIndex = 18;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            // 
            // picturefoto
            // 
            picturefoto.Location = new Point(269, 28);
            picturefoto.Name = "picturefoto";
            picturefoto.Size = new Size(292, 196);
            picturefoto.TabIndex = 19;
            picturefoto.TabStop = false;
            // 
            // pictureqr
            // 
            pictureqr.Location = new Point(269, 284);
            pictureqr.Name = "pictureqr";
            pictureqr.Size = new Size(373, 252);
            pictureqr.TabIndex = 20;
            pictureqr.TabStop = false;
            // 
            // btnfoto
            // 
            btnfoto.Location = new Point(567, 28);
            btnfoto.Name = "btnfoto";
            btnfoto.Size = new Size(75, 23);
            btnfoto.TabIndex = 21;
            btnfoto.Text = "Foto Frente";
            btnfoto.UseVisualStyleBackColor = true;
            btnfoto.Click += btnfoto_Click;
            // 
            // btnqr
            // 
            btnqr.Location = new Point(567, 245);
            btnqr.Name = "btnqr";
            btnqr.Size = new Size(75, 23);
            btnqr.TabIndex = 22;
            btnqr.Text = "Generar QR";
            btnqr.UseVisualStyleBackColor = true;
            btnqr.Click += btnqr_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(269, 246);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 23);
            textBox1.TabIndex = 23;
            // 
            // button1
            // 
            button1.Location = new Point(567, 115);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 24;
            button1.Text = "Foto Completa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(567, 86);
            button2.Name = "button2";
            button2.Size = new Size(91, 23);
            button2.TabIndex = 25;
            button2.Text = "Foto Izquierda";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(567, 57);
            button3.Name = "button3";
            button3.Size = new Size(91, 23);
            button3.TabIndex = 26;
            button3.Text = "Foto Derecha";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 79);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 27;
            label7.Text = "Id Pabellón";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(139, 23);
            textBox2.TabIndex = 28;
            // 
            // FrmMantPPL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 587);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(btnqr);
            Controls.Add(btnfoto);
            Controls.Add(pictureqr);
            Controls.Add(picturefoto);
            Controls.Add(btnsalir);
            Controls.Add(btngrabar);
            Controls.Add(dtpsalida);
            Controls.Add(dtpingreso);
            Controls.Add(txtmotivo);
            Controls.Add(txtapellido);
            Controls.Add(txtcedula);
            Controls.Add(txtnombre);
            Controls.Add(txtid);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMantPPL";
            Text = "FrmMantPPL";
            Load += FrmMantPPL_Load;
            ((System.ComponentModel.ISupportInitialize)picturefoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureqr).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label9;
        private TextBox txtid;
        private TextBox txtnombre;
        private TextBox txtcedula;
        private TextBox txtapellido;
        private TextBox txtmotivo;
        private DateTimePicker dtpingreso;
        private DateTimePicker dtpsalida;
        private Button btngrabar;
        private Button btnsalir;
        private PictureBox picturefoto;
        private PictureBox pictureqr;
        private Button btnfoto;
        private Button btnqr;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label7;
        private TextBox textBox2;
    }
}