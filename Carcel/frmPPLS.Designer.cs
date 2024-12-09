namespace Carcel
{
    partial class frmPPLS
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
            btnmodificar = new Button();
            btneliminar = new Button();
            btnsalir = new Button();
            panel2 = new Panel();
            grdppl = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdppl).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnnuevo);
            panel1.Controls.Add(btnmodificar);
            panel1.Controls.Add(btneliminar);
            panel1.Controls.Add(btnsalir);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 209);
            panel1.Name = "panel1";
            panel1.Size = new Size(861, 41);
            panel1.TabIndex = 0;
            // 
            // btnnuevo
            // 
            btnnuevo.Dock = DockStyle.Right;
            btnnuevo.Location = new Point(561, 0);
            btnnuevo.Name = "btnnuevo";
            btnnuevo.Size = new Size(75, 41);
            btnnuevo.TabIndex = 3;
            btnnuevo.Text = "Nuevo";
            btnnuevo.UseVisualStyleBackColor = true;
            btnnuevo.Click += btnnuevo_Click;
            // 
            // btnmodificar
            // 
            btnmodificar.Dock = DockStyle.Right;
            btnmodificar.Location = new Point(636, 0);
            btnmodificar.Name = "btnmodificar";
            btnmodificar.Size = new Size(75, 41);
            btnmodificar.TabIndex = 2;
            btnmodificar.Text = "Modificar";
            btnmodificar.UseVisualStyleBackColor = true;
            btnmodificar.Click += btnmodificar_Click;
            // 
            // btneliminar
            // 
            btneliminar.Dock = DockStyle.Right;
            btneliminar.Location = new Point(711, 0);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(75, 41);
            btneliminar.TabIndex = 1;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnsalir
            // 
            btnsalir.Dock = DockStyle.Right;
            btnsalir.Location = new Point(786, 0);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(75, 41);
            btnsalir.TabIndex = 0;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(grdppl);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(861, 209);
            panel2.TabIndex = 1;
            // 
            // grdppl
            // 
            grdppl.AllowUserToAddRows = false;
            grdppl.AllowUserToDeleteRows = false;
            grdppl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdppl.Dock = DockStyle.Fill;
            grdppl.Location = new Point(0, 0);
            grdppl.Name = "grdppl";
            grdppl.ReadOnly = true;
            grdppl.Size = new Size(861, 209);
            grdppl.TabIndex = 0;
            // 
            // frmPPLS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 250);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmPPLS";
            Text = "frmPPLS";
            Load += frmPPLS_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdppl).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnnuevo;
        private Button btnmodificar;
        private Button btneliminar;
        private Button btnsalir;
        private Panel panel2;
        private DataGridView grdppl;
    }
}