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
    public partial class frmPPLS : Form
    {
        
        public frmPPLS()
        {
            InitializeComponent();

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void modificar()
        {
            if (grdppl.RowCount <= 0)
            {
                MessageBox.Show("No existe datos");
                return;
            }
            else
            {
                int id = Convert.ToInt32(grdppl.CurrentRow.Cells[0].Value);
                frmMantenimientoPabellon form = new frmMantenimientoPabellon();
                form.IdPabellon = id;
                form.ShowDialog();
                cargarGrid();
            }
        }

        private void frmPPLS_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }

        private void cargarGrid()
        {
            var ListaPPl = Utiles.contexto.Ppls.ToList();
            grdppl.DataSource = ListaPPl;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            FrmMantPPL form = new FrmMantPPL();
            form.ShowDialog();
            cargarGrid();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if(grdppl.RowCount <= 0)
            {
                MessageBox.Show("No existe datos");
                return;
            }
            else
            {
                if(MessageBox.Show("!Está seguro que desea eliminar el registro? ","Mensaje del Sistema",MessageBoxButtons.YesNo)== DialogResult.Yes)
                {
                    int id = Convert.ToInt32(grdppl.CurrentRow.Cells[0].Value);
                    var objppl = Utiles.contexto.Ppls.Find(id);
                    objppl.Estado = "I";
                    MessageBox.Show($"PPL {objppl.IdPll} Inactivado con éxito");
                    cargarGrid();
                }
            }
        }
    }
}
