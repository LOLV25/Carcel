using Carcel.Context;
using Carcel.Metodo;
using Carcel.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Carcel
{
    public partial class FrmMantPPL : Form
    {
        private Bitmap fotoFrente = null;
        private Bitmap fotoDerecho = null;
        private Bitmap fotoIzquierdo = null;

        private FilterInfoCollection videoDevices; // Dispositivos que se encuentran disponibles
        private VideoCaptureDevice videoSource;    // la fuente de la cámara
        private Bitmap _currentFrame;              // y la variable para almacenar el frame actual


        public int IdPll;
        public FrmMantPPL()
        {
            InitializeComponent();
            IniciarCámara();

        }

        private void IniciarCámara()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            // Verificar si hay cámaras disponibles
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No se detectaron cámaras.");
                return;
            }

            // Usar el primer dispositivo de video (si hay más de una cámara, puedes elegir otra)
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);

            // Asignar el evento NewFrame para capturar cada frame
            videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);

            // Iniciar la captura de video
            videoSource.Start();
        }
        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Guardar el frame actual en la variable _currentFrame
            _currentFrame = (Bitmap)eventArgs.Frame.Clone();
        }

        // Detener la cámara cuando se cierre el formulario
        private void DetenerCámara()
        {
            if (videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            DetenerCámara();
        }



        private int contadorFotos = 0;
        private string[] tiposDeFoto = { "Frontal", "LateraIzquierda", "LateralDerecha" };
        //private NewFrameEventHandler videoSource_NewFrame;

        private void btngrabar_Click(object sender, EventArgs e)
        {
            if (IdPll == 0)
            {
                Ppl objppl = new Ppl();
                objppl.Cedula = txtcedula.Text;
                objppl.Nombre = txtnombre.Text;
                objppl.Apellido = txtapellido.Text;
                objppl.Motivo = txtmotivo.Text;
                objppl.FechaIngreso = DateOnly.FromDateTime(dtpingreso.Value);
                objppl.FechaSalida = DateOnly.FromDateTime(dtpsalida.Value);
                objppl.Estado = "A";
                Utiles.contexto.Ppls.Add(objppl);
                Utiles.contexto.SaveChanges();
                txtid.Text = objppl.IdPll.ToString();
                MessageBox.Show($"Preso {objppl.IdPll} creado con éxito");

            }
            else
            {
                var objppl = Utiles.contexto.Ppls.Find(IdPll);
                objppl.Cedula = txtcedula.Text;
                objppl.Nombre = txtnombre.Text;
                objppl.Apellido = txtapellido.Text;
                objppl.Motivo = txtmotivo.Text;
                objppl.FechaIngreso = DateOnly.FromDateTime(dtpingreso.Value);
                objppl.FechaSalida = DateOnly.FromDateTime(dtpsalida.Value);
                Utiles.contexto.Ppls.Update(objppl);
                Utiles.contexto.SaveChanges();
                MessageBox.Show($"Preso {objppl.IdPll} actualizado con éxito");
            }
            this.Close();

        }

        private void btnfoto_Click(object sender, EventArgs e)
        {
            if (_currentFrame != null)
            {
                // Guardar la foto del frente
                fotoFrente = new Bitmap(_currentFrame);

                // Opcionalmente, puedes guardar la foto en el disco
                string rutaFrente = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                                                 $"Descargas\\Foto_Fente_{txtcedula.Text}.jpg");
                fotoFrente.Save(rutaFrente, System.Drawing.Imaging.ImageFormat.Jpeg);

                // Mostrar la foto en el PictureBox
                picturefoto.Image = fotoFrente;

                MessageBox.Show("Foto Frente tomada y almacenada.");
            }
            else
            {
                MessageBox.Show("No hay ninguna foto para tomar.");
            }
        }





        private void btnqr_Click(object sender, EventArgs e)
        {
            string datos = $"CEDULA: {txtcedula.Text}\n" +
                   $"ID: {txtid.Text}\n" +
                   $"Nombre: {txtnombre.Text}\n" +
                   $"Apellido: {txtapellido.Text}\n" +
                   $"Motivo: {txtmotivo.Text}\n" +
                   $"Fecha Ingreso: {dtpingreso.Value.ToShortDateString()}\n" +
                   $"Fecha Salida: {dtpsalida.Value.ToShortDateString()}";

            Bitmap qrCodeImage = Generarqr.GenerarQR(datos);
            pictureqr.Image = qrCodeImage;

            string rutaQR = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Descargas\\QR_" + txtid.Text + ".jpg");
            qrCodeImage.Save(rutaQR, ImageFormat.Jpeg);
            MessageBox.Show($"QR guardado en: {rutaQR}");
        }

        private void FrmMantPPL_Load(object sender, EventArgs e)
        {
            string rutaBase = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Descargas");
            if (!Directory.Exists(rutaBase))
            {
                Directory.CreateDirectory(rutaBase);
                MessageBox.Show($"La carpeta para guardar fotos se ha creado en: {rutaBase}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fotoFrente != null && fotoDerecho != null && fotoIzquierdo != null)
            {
                // Crear un nuevo bitmap que combine las tres fotos
                int width = fotoFrente.Width + fotoDerecho.Width + fotoIzquierdo.Width;
                int height = Math.Max(fotoFrente.Height, Math.Max(fotoDerecho.Height, fotoIzquierdo.Height));

                Bitmap fotoCompleta = new Bitmap(width, height);

                // Dibujar las fotos en el bitmap combinado
                using (Graphics g = Graphics.FromImage(fotoCompleta))
                {
                    g.DrawImage(fotoFrente, 0, 0);
                    g.DrawImage(fotoDerecho, fotoFrente.Width, 0);
                    g.DrawImage(fotoIzquierdo, fotoFrente.Width + fotoDerecho.Width, 0);
                }

                // Mostrar la foto combinada en el PictureBox
                picturefoto.Image = fotoCompleta;

                MessageBox.Show("Las tres fotos han sido combinadas.");
            }
            else
            {
                MessageBox.Show("Debes tomar las tres fotos primero.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_currentFrame != null)
            {
                // Guardar la foto del izquierdo
                fotoIzquierdo = new Bitmap(_currentFrame);

                string rutaIzquierdo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                                                    $"Descargas\\Foto_Izquierdo_{txtcedula.Text}.jpg");
                fotoIzquierdo.Save(rutaIzquierdo, System.Drawing.Imaging.ImageFormat.Jpeg);

                MessageBox.Show("Foto Izquierda tomada y almacenada.");
            }
            else
            {
                MessageBox.Show("No hay ninguna foto para tomar.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_currentFrame != null)
            {
                // Guardar la foto del derecho
                fotoDerecho = new Bitmap(_currentFrame);

                string rutaDerecho = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                                                  $"Descargas\\Foto_Derecho_{txtcedula.Text}.jpg");
                fotoDerecho.Save(rutaDerecho, System.Drawing.Imaging.ImageFormat.Jpeg);

                MessageBox.Show("Foto Derecha tomada y almacenada.");
            }
            else
            {
                MessageBox.Show("No hay ninguna foto para tomar.");
            }
        }
    }
}




