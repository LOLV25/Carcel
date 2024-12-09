using Carcel.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carcel
{
    public partial class FrmPabellones : Form
    {
        public FrmPabellones()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void FrmPabellones_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }

        private void cargarGrid()
        {
            var Listapabellon = Utiles.contexto.Pabellons.ToList();
            grdpabellon.DataSource = Listapabellon;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            frmMantenimientoPabellon form = new frmMantenimientoPabellon();
            form.ShowDialog();
            cargarGrid();
        }

        private void btnmodifi_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void modificar()
        {
            if(grdpabellon.RowCount <= 0)
            {
                MessageBox.Show("No existe datos");
                return;
            }
            else
            {
                int id = Convert.ToInt32(grdpabellon.CurrentRow.Cells[0].Value);
                frmMantenimientoPabellon form = new frmMantenimientoPabellon();
                form.IdPabellon = id;
                form.ShowDialog();
                cargarGrid();
            }
        }
    }
}
