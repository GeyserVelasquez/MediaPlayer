using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using TagLib;
using System.Media;

namespace PlayerUI
{
    public class Media
    {
        public static string carpetaSeleccionada;
        public static PlayList PlayListActual;
        public static bool MediaCargados = false;
        public static bool playing = false;

        public static void CrearCarpeta() 
        {
            string rutaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string nombreCarpeta = "Holick";

            string rutaCarpeta = Path.Combine(rutaDocumentos, nombreCarpeta);

            carpetaSeleccionada = rutaCarpeta;

            try
            {
                if (!Directory.Exists(rutaCarpeta))
                {
                    Directory.CreateDirectory(rutaCarpeta);
                    Console.WriteLine("Carpeta creada exitosamente en Documents.");
                }
                else
                {
                    Console.WriteLine("La carpeta ya existe en Documents.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(("Error al crear la carpeta: " + ex.Message));
            }
        }

        public static void CambiarTrack(int num){

            string ruta = Media.ObtenerRuta(num);

            Console.WriteLine(ruta);

            Console.WriteLine("Ruta Recibida: " + ruta);

            Media.playing = true;

            Form1.holick.URL = ruta;
        }

        public static void ControlarPlayer() 
        {
            Console.WriteLine("Cambio de Controlador Realizado");

            if ( Media.playing == false ) 
            {
                Media.playing = true;
                Form1.holick.Ctlcontrols.play();
            } else {
                Media.playing = false;
                Form1.holick.Ctlcontrols.pause();
            }
        
        }

        public static void AbrirExploradorDeMedia(DataGridView visor)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Seleccionar archivo";
            openFileDialog.Filter = "Media Multimedia|*.mp3;*.mp4|Todos los Media|*.*";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;

                var multimedia = TagLib.File.Create(rutaArchivo);

                string name = multimedia.Name;
                string title = multimedia.Tag.Title;
                string artist = multimedia.Tag.FirstPerformer;
                string album = multimedia.Tag.Album;
                string year = multimedia.Tag.Year.ToString();

                string file = Media.carpetaSeleccionada + "\\Multimedia.txt";

                visor.Rows.Add(title, artist, album);

                Escribir(title, artist, album, name, file);
            }
        }

        public static void Escribir(string titulo, string artista, string album, string name, string file)
        {
            using (StreamWriter escritor = System.IO.File.AppendText(file))
            {
                escritor.WriteLine(titulo + "|" + artista + "|" + album + "|*" + name);
            }
        }

        public static void Leer(PlayList list, DataGridView visor) 
        {
            string file = list.ruta;
            int i=0;

            if (!System.IO.File.Exists(file))
             {
                using (System.IO.File.Create(file)) { }
            }
            
            using (StreamReader lector = new StreamReader(file))
            {
                while (!lector.EndOfStream)
                {
                    string line = lector.ReadLine();
                    i++;
                    string[] partes = line.Split('|');
                    visor.Rows.Add(partes);
                }
            }

            if (list.tamanio == 0) list.tamanio = i;
          
            Console.WriteLine(list.tamanio);
            Console.WriteLine(PlayListActual.tamanio);

        }

        public static string ObtenerRuta(int num) //No se si deba pasarle el argumento del archivo seleccionado o dejarlo estatico como esta
        {
            string direc = PlayListActual.ruta;

            string datos = System.IO.File.ReadLines(direc).ElementAtOrDefault(num);

            Console.WriteLine(datos);

            string aux = datos.Split('*').LastOrDefault();

            string ruta = aux.Replace("\\","\\\\");

            return ruta;
        }

        public static void NumLines()
        {
            var lineCount = 0;
            using (var reader = System.IO.File.OpenText(@"c:\file.txt"))
            { 
                while (reader.ReadLine() != null) { lineCount++; } 
            }

        }
    }

    
}
