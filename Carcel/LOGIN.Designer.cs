namespace Carcel
{
    partial class LOGIN
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnsesion = new Button();
            btncancelar = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 13);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Inicio de Sesión";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 90);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 60);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "Usuario";
            // 
            // btnsesion
            // 
            btnsesion.Location = new Point(84, 139);
            btnsesion.Name = "btnsesion";
            btnsesion.Size = new Size(90, 23);
            btnsesion.TabIndex = 3;
            btnsesion.Text = "Iniciar Sesión";
            btnsesion.UseVisualStyleBackColor = true;
            btnsesion.Click += btnsesion_Click;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(180, 139);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(75, 23);
            btncancelar.TabIndex = 4;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(116, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(135, 23);
            textBox2.TabIndex = 6;
            // 
            // LOGIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 172);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btncancelar);
            Controls.Add(btnsesion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LOGIN";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnsesion;
        private Button btncancelar;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
