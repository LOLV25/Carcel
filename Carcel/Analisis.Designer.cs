namespace Carcel
{
    partial class Analisis
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
            comboanalisis = new ComboBox();
            btngenerar = new Button();
            SuspendLayout();
            // 
            // comboanalisis
            // 
            comboanalisis.FormattingEnabled = true;
            comboanalisis.Items.AddRange(new object[] { "Análisis por pabellón", "Análisis por Estado" });
            comboanalisis.Location = new Point(119, 38);
            comboanalisis.Name = "comboanalisis";
            comboanalisis.Size = new Size(121, 23);
            comboanalisis.TabIndex = 0;
            // 
            // btngenerar
            // 
            btngenerar.Location = new Point(137, 110);
            btngenerar.Name = "btngenerar";
            btngenerar.Size = new Size(75, 23);
            btngenerar.TabIndex = 1;
            btngenerar.Text = "Generar";
            btngenerar.UseVisualStyleBackColor = true;
            btngenerar.Click += btngenerar_Click;
            // 
            // Analisis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 141);
            Controls.Add(btngenerar);
            Controls.Add(comboanalisis);
            Name = "Analisis";
            Text = "Analisis";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboanalisis;
        private Button btngenerar;
    }
}