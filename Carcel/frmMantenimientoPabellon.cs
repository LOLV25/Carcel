using Carcel.Context;
using Carcel.Modelo;
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
    public partial class frmMantenimientoPabellon : Form
    {
        public int IdPabellon = 0;
        public frmMantenimientoPabellon()
        {
            InitializeComponent();
        }

        private void frmMantenimientoPabellon_Load(object sender, EventArgs e)
        {
            if (IdPabellon != 0)
            {
                var objpabellon = Utiles.contexto.Pabellons.Find(IdPabellon);

                if (objpabellon != null)
                {
                    txtid.Text = objpabellon.IdPabellon.ToString();
                    combonombre.Text = objpabellon.Nombre;
                    comboseguridad.Text = objpabellon.NivelSeguridad;
                }
                else
                {
                    MessageBox.Show($"No existe el registro {IdPabellon}");
                    this.Close();
                }
            }
        }

        private void btngrabar_Click(object sender, EventArgs e)
        {
            if (IdPabellon == 0)
            {
                Pabellon objpabellon = new Pabellon();
                objpabellon.Nombre = combonombre.Text;
                objpabellon.NivelSeguridad = comboseguridad.Text;
                Utiles.contexto.Pabellons.Add(objpabellon);
                Utiles.contexto.SaveChanges();
                txtid.Text = objpabellon.IdPabellon.ToString();
                MessageBox.Show($"Pabellon {objpabellon.IdPabellon} creado con éxito");
            }
            else
            {
                var objpabellon = Utiles.contexto.Pabellons.Find(IdPabellon);
                objpabellon.Nombre = combonombre.Text;
                objpabellon.NivelSeguridad = comboseguridad.Text;
                Utiles.contexto.Pabellons.Update(objpabellon);
                Utiles.contexto.SaveChanges();
                MessageBox.Show($"Pabellon {objpabellon.IdPabellon} Actuaizado con Ëxito");
            }
            this.Close();

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
    


        
     



