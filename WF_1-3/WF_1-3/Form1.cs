using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_1_3
{
    public partial class Form1 : Form
    {
        static int left;
        static int top;

        public Form1()
        {
            InitializeComponent();
            Width = 300;
            Height = 300;
            StartPosition = FormStartPosition.Manual;
            left = 0; //(Screen.PrimaryScreen.Bounds.Width - 300) / 2;
            top = 0;  //(Screen.PrimaryScreen.Bounds.Height - 300) / 2;
            Location = new Point(left, top);
            KeyPreview = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)   timer1.Start();

            if (e.KeyCode == Keys.Escape)
            {
                timer1.Stop();
                if (e.KeyCode == Keys.Escape)
                    Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

                Text = DateTime.Now.ToString();

                if ((left >= 0) && (top == 0)) left += 5;
                if ((left == (Screen.PrimaryScreen.Bounds.Width - Width)) && (top >= 0)) top += 5;
                if ((left <= (Screen.PrimaryScreen.Bounds.Width - Width)) && (top == (Screen.PrimaryScreen.Bounds.Height - Height))) left -= 5;
                if ((left == 0) && (top <= (Screen.PrimaryScreen.Bounds.Height - Height))) top -= 5;

                this.Location = new Point(left, top);
            
        }
    }
}
