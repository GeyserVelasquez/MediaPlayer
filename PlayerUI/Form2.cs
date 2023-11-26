using System;
using System.IO;
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


        public Form2()
        {
            InitializeComponent();

            Media.Leer(Media.PlayListActual, visorDeArchivos);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void explorarMedia_Click(object sender, EventArgs e)
        {
            Media.AbrirExploradorDeMedia(visorDeArchivos);
        }

        private void visorDeMedia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void visorDeMedia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int celda = e.RowIndex;

            Media.PlayListActual.track = celda;

            Media.CambiarTrack(celda);

            Console.WriteLine("Numero de Track: " + Media.PlayListActual.track);

            Console.WriteLine(Media.PlayListActual.tamanio);

            this.Close();
        }

        private void EliminarArchivo_Click(object sender, EventArgs e)
        {
            Media.PlayListActual.track = 66;
            Console.WriteLine(Form1.Multimedia.track);
        }
    }
}
