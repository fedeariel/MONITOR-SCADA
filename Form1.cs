using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VncSharp;

namespace MONITOR_SCADA
{
//    vnc = new VncClient();

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
     
        }
        public static string MyPwdFunction()
        { return "ags2019"; }  



        private void Form1_Load(object sender, EventArgs e)
        {
          
            rd.GetPassword = new AuthenticateDelegate(MyPwdFunction);
            rd.Connect("192.168.4.72",true,true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rd.Refresh();
            //rd.FullScreenUpdate();


        }

    }
}
