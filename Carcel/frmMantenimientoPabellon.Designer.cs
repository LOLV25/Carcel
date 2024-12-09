namespace Carcel
{
    partial class frmMantenimientoPabellon
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
            comboseguridad = new ComboBox();
            txtid = new TextBox();
            btngrabar = new Button();
            btnsalir = new Button();
            label4 = new Label();
            combonombre = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 44);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 73);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 2;
            label3.Text = "Nivel Seguridad";
            // 
            // comboseguridad
            // 
            comboseguridad.FormattingEnabled = true;
            comboseguridad.Items.AddRange(new object[] { "Mínimo", "Medio", "Máximo" });
            comboseguridad.Location = new Point(112, 94);
            comboseguridad.Name = "comboseguridad";
            comboseguridad.Size = new Size(156, 23);
            comboseguridad.TabIndex = 3;
            // 
            // txtid
            // 
            txtid.Location = new Point(112, 36);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(156, 23);
            txtid.TabIndex = 4;
            // 
            // btngrabar
            // 
            btngrabar.Location = new Point(141, 171);
            btngrabar.Name = "btngrabar";
            btngrabar.Size = new Size(75, 23);
            btngrabar.TabIndex = 6;
            btngrabar.Text = "Grabar";
            btngrabar.UseVisualStyleBackColor = true;
            btngrabar.Click += btngrabar_Click;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(222, 171);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(75, 23);
            btnsalir.TabIndex = 7;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 9);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 8;
            label4.Text = "Agregar Pabellon";
            // 
            // combonombre
            // 
            combonombre.FormattingEnabled = true;
            combonombre.Items.AddRange(new object[] { "Pabellón C - Nivel Minimo ", "Pabellón B - Nivel Medio", "Pabellón A - Nivel Máximo" });
            combonombre.Location = new Point(112, 65);
            combonombre.Name = "combonombre";
            combonombre.Size = new Size(156, 23);
            combonombre.TabIndex = 9;
            // 
            // frmMantenimientoPabellon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 196);
            Controls.Add(combonombre);
            Controls.Add(label4);
            Controls.Add(btnsalir);
            Controls.Add(btngrabar);
            Controls.Add(txtid);
            Controls.Add(comboseguridad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmMantenimientoPabellon";
            Text = "Pabellon";
            Load += frmMantenimientoPabellon_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboseguridad;
        private TextBox txtid;
        private Button btngrabar;
        private Button btnsalir;
        private Label label4;
        private ComboBox combonombre;
    }
}