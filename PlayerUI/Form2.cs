using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI // Mandar Form2 a la mierda
{
    public partial class Form2 : Form
    {
        //public AxWMPLib.AxWindowsMediaPlayer auxPlayer { get; set; }


        public Form2()
        {
            InitializeComponent();

            Archivos.archivoSeleccionado = Archivos.carpetaSeleccionada+"\\Multimedia.txt";

            Archivos.Leer(Archivos.archivoSeleccionado, visorDeArchivos);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void explorarArchivos_Click(object sender, EventArgs e)
        {
            Archivos.AbrirExploradorDeArchivos(visorDeArchivos);
        }

        private void visorDeArchivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void visorDeArchivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int celda = e.RowIndex;

            Archivos.track = celda;

            Archivos.ObtenerTrack(celda);

            //Archivos.ControlarPlayer();

            this.Visible=false;
        }
    }
}
