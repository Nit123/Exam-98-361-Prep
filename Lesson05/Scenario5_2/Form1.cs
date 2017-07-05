using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scenario5_2
{
    public partial class Form1 : Form
    {
        private bool insideTitleBar = false;
        private bool outsideTitleBar = false;
        Control mouse = new Control();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0xA0) // WM_NCMOUSEMOVE
            {
                if (!insideTitleBar)
                {
                    label1.Text = Control.MousePosition.ToString();
                    insideTitleBar = true;
                    outsideTitleBar = false;
                }
            }
            else if (m.Msg == 0x2A2) // WM_NCMOUSELEAVE
            {
                if (!outsideTitleBar)
                {
                    label1.Text = "";
                    outsideTitleBar = true;
                    insideTitleBar = false;
                }
            }
            base.WndProc(ref m);
        }

    }
}
