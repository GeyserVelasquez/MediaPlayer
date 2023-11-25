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
    public class Reproductor : AxWMPLib.AxWindowsMediaPlayer
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

        public Reproductor() {
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.CausesValidation = false;
            this.Enabled = true;
            this.Location = new System.Drawing.Point(32, 38);
            this.Name = "mainPlayer";
            this.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mainPlayer.OcxState")));
            this.Size = new System.Drawing.Size(640, 400);
            this.TabIndex = 10;
        }
    }
}
