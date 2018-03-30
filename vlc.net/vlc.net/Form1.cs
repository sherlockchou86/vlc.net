using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace vlc.net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // copy libvlc.dll,libvlccore.dll and plugins to current work directory
            player = new VlcPlayer(Environment.CurrentDirectory + "\\plugins\\");
            // show the video in panel1 control
            player.SetRenderWindow((int)panel1.Handle);

            // play rtmp stream
            player.PlayOnline(@"rtmp://192.168.1.2/live/123456");
            player.Play();
        }

        internal VlcPlayer player { get; set; }
    }
}