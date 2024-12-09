namespace Carcel
{
    partial class FrmPabellones
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
            panel1 = new Panel();
            btnnuevo = new Button();
            btnsalir = new Button();
            panel2 = new Panel();
            grdpabellon = new DataGridView();
            btnmodifi = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdpabellon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnmodifi);
            panel1.Controls.Add(btnnuevo);
            panel1.Controls.Add(btnsalir);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 235);
            panel1.Name = "panel1";
            panel1.Size = new Size(852, 42);
            panel1.TabIndex = 0;
            // 
            // btnnuevo
            // 
            btnnuevo.Location = new Point(627, 0);
            btnnuevo.Name = "btnnuevo";
            btnnuevo.Size = new Size(75, 42);
            btnnuevo.TabIndex = 2;
            btnnuevo.Text = "Nuevo";
            btnnuevo.UseVisualStyleBackColor = true;
            btnnuevo.Click += btnnuevo_Click;
            // 
            // btnsalir
            // 
            btnsalir.Dock = DockStyle.Right;
            btnsalir.Location = new Point(777, 0);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(75, 42);
            btnsalir.TabIndex = 0;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(grdpabellon);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(852, 235);
            panel2.TabIndex = 1;
            // 
            // grdpabellon
            // 
            grdpabellon.AllowUserToAddRows = false;
            grdpabellon.AllowUserToDeleteRows = false;
            grdpabellon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdpabellon.Dock = DockStyle.Fill;
            grdpabellon.Location = new Point(0, 0);
            grdpabellon.Name = "grdpabellon";
            grdpabellon.ReadOnly = true;
            grdpabellon.Size = new Size(852, 235);
            grdpabellon.TabIndex = 0;
            // 
            // btnmodifi
            // 
            btnmodifi.Dock = DockStyle.Right;
            btnmodifi.Location = new Point(702, 0);
            btnmodifi.Name = "btnmodifi";
            btnmodifi.Size = new Size(75, 42);
            btnmodifi.TabIndex = 3;
            btnmodifi.Text = "Modificar";
            btnmodifi.UseVisualStyleBackColor = true;
            btnmodifi.Click += btnmodifi_Click;
            // 
            // FrmPabellones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 277);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmPabellones";
            Text = "FrmPabellones";
            Load += FrmPabellones_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdpabellon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView grdpabellon;
        private Button btnsalir;
        private Button btnnuevo;
        private Button btnmodificar;
        private Button btnmodifi;
    }
}