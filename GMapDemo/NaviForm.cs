using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace GMapDemo
{
    public partial class NaviForm : Form
    {
        

        MissionForm mpf;

        

        public NaviForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showMapForm();

            


        }

        


        private void showMapForm()
        {
            Screen[] sc;
            sc = Screen.AllScreens;
            //get all the screen width and heights 
            mpf = new MissionForm();
            mpf.FormBorderStyle = FormBorderStyle.None;
            mpf.Left = sc[1].Bounds.Width;
            mpf.Top = sc[1].Bounds.Height;
            mpf.StartPosition = FormStartPosition.Manual;
            mpf.Location = sc[1].Bounds.Location;
            Point p = new Point(sc[1].Bounds.Location.X, sc[1].Bounds.Location.Y);
            mpf.Location = p;
            mpf.WindowState = FormWindowState.Maximized;
            mpf.Show();
        }


        
       

        private void button1_Click(object sender, EventArgs e)
        {
            mpf.simpath();
        }

        private void NAVForm_Resize(object sender, EventArgs e)
        {

            
        }
    } 
}
