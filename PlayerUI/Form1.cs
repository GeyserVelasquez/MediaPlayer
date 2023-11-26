using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class Form1 : Form
    {
        public Form formy2;
        public Form formy3;
        public static PlayList Multimedia;
        public static int a = 10;
        public static int c;

        public Form1()
        {
            InitializeComponent();
            hideSubMenu();
            Media.CrearCarpeta();
            Multimedia = new PlayList("Multimedia");
            Media.PlayListActual = Multimedia;
            formy2 = new Form2();
            formy3 = new Form3();
            Console.WriteLine("---------------------");
            c = a;
            a--;
            Console.WriteLine(c);
        }

        private void hideSubMenu()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }

        #region MediaSubMenu
        private void button2_Click(object sender, EventArgs e)
        {
            if (formy2 == null || formy2.IsDisposed) formy2 = new Form2();

            openChildForm(formy2);

            hideSubMenu();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }

        #region PlayListManagemetSubMenu
        private void button8_Click(object sender, EventArgs e)
        {
            if (formy3 == null || formy3.IsDisposed) formy3 = new Form3();

            openChildForm(formy3);
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }
        #region ToolsSubMenu
        private void button13_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Media.ControlarPlayer();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Media.PlayListActual.track+1 < Media.PlayListActual.tamanio)
            {
                Media.CambiarTrack(++Media.PlayListActual.track);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (Media.PlayListActual.track-1 > -1)
            {
                Media.CambiarTrack(--Media.PlayListActual.track);
            }
        }

        private void holick_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            switch (e.newState)
            {
                case 0:    // Undefined
                    Console.WriteLine("Undefined");
                    break;

                case 1:    // Stopped
                    Console.WriteLine("Stopped");
                    break;

                case 2:    // Paused
                    Console.WriteLine("Paused");
                    break;

                case 3:    // Playing
                    Console.WriteLine ( "Playing");
                    break;

                case 4:    // ScanForward
                    Console.WriteLine ( "ScanForward");
                    break;

                case 5:    // ScanReverse
                    Console.WriteLine ( "ScanReverse");
                    break;

                case 6:    // Buffering
                    Console.WriteLine ( "Buffering");
                    break;

                case 7:    // Waiting
                    Console.WriteLine ( "Waiting");
                    break;

                case 8:    // MediaEnded
                    Console.WriteLine ( "MediaEnded");
                    if (Media.PlayListActual.track + 1 < Media.PlayListActual.tamanio) 
                    {
                        Media.CambiarTrack(++Media.PlayListActual.track); 
                    }
                    break;

                case 9:    // Transitioning
                    Console.WriteLine ( "Transitioning");
                    break;

                case 10:   // Ready
                    Console.WriteLine ( "Ready");
                    Media.ControlarPlayer();
                    break;

                case 11:   // Reconnecting
                    Console.WriteLine ( "Reconnecting");
                    break;

                case 12:   // Last
                    Console.WriteLine ( "Last");
                    break;

                default:
                    Console.WriteLine ( ("Unknown State: " + e.newState.ToString()));
                    break;
                }
            }
       }
}
