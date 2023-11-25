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
    public class Archivos
    {
        public static string carpetaSeleccionada;
        public static string archivoSeleccionado;
        public static bool archivosCargados = false;
        public static bool playing = false;
        public static int track = 0;

        //public static Reproductor holick = new Reproductor() ;

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

        public static void ObtenerTrack(int num){

            string ruta = Archivos.ObtenerRuta(num);

            Console.WriteLine(ruta);

            Console.WriteLine("Ruta Recibida: " + ruta);

            Archivos.playing = true;

            Form1.holick.URL = ruta;
        }

        public static void ControlarPlayer() 
        {
            Console.WriteLine("Cambio de Controlador Realizado");

            if ( Archivos.playing == false ) 
            {
                Archivos.playing = true;
                Form1.holick.Ctlcontrols.play();
            } else {
                Archivos.playing = false;
                Form1.holick.Ctlcontrols.pause();
            }
        
        }
        

        public static void AbrirExploradorDeArchivos(DataGridView visor)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Seleccionar archivo";
            openFileDialog.Filter = "Archivos Multimedia|*.mp3;*.mp4|Todos los archivos|*.*";
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

                string file = Archivos.carpetaSeleccionada + "\\Multimedia.txt";

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

        public static void Leer(string file, DataGridView visor) 
        {
                if (!System.IO.File.Exists(file))
                 {
                    using (System.IO.File.Create(file)) { }
                }
                
                using (StreamReader lector = new StreamReader(file))
                {
                    while (!lector.EndOfStream)
                    {
                        string line = lector.ReadLine();
                        string[] partes = line.Split('|');
                        visor.Rows.Add(partes);
                    }
                }          
        }

        public static string ObtenerRuta(int num) //No se si deba pasarle el argumento del archivo seleccionado o dejarlo estatico como esta
        {
            string datos = System.IO.File.ReadLines(Archivos.archivoSeleccionado).ElementAtOrDefault(num);

            string aux = datos.Split('*').LastOrDefault();

            string ruta = aux.Replace("\\","\\\\");

            //string sisa = "C:\\Users\\gvela\\Music\\proyectos\\cancion1.mp3";

            return ruta;
        }

        public static void OcultarInterfaz()
        {
            
        }
    }

    
}
