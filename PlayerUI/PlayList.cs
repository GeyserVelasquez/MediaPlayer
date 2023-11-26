using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerUI
{
    public class PlayList
    {
        public string name;
        public string ruta;
        public int tamanio =0;
        public int track = 0;

        public PlayList(string nombre)
        {
            this.name = nombre;
            this.ruta = Path.Combine(Media.carpetaSeleccionada, nombre+".txt");
        }

    }
}
