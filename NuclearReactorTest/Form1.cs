using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace NuclearReactorTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void reactor1label_Click(object sender, EventArgs e)
        {

        }

        private void runbutton_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1500);
            reactorstatelabel1.BackColor = Color.Yellow;
           reactorstatelabel2.BackColor = Color.Yellow;
            sitlabel.Text = "Warning! Danger!";
            Refresh();
            Thread.Sleep(1000);
            reactorstatelabel1.BackColor = Color.Red;
            reactorstatelabel2.BackColor = Color.Red;
            sitlabel.BackColor = Color.White;
            sitlabel.Text = "Reactor Failing";
            Refresh();
            Thread.Sleep(900);
            reactorstatelabel1.BackColor = Color.White;
            reactorstatelabel2.BackColor = Color.White;
            sitlabel.BackColor = Color.Red;
            sitlabel.ForeColor = Color.White;
            Refresh();
            Thread.Sleep(900);
            reactorstatelabel1.BackColor = Color.Red;
            reactorstatelabel2.BackColor = Color.Red;
            sitlabel.BackColor = Color.White;
            sitlabel.ForeColor = Color.Black;
            sitlabel.Text = "Shutdown Imminent";
            Refresh();
            Thread.Sleep(900);
            reactorstatelabel1.BackColor = Color.White;
            reactorstatelabel2.BackColor = Color.White;
            sitlabel.BackColor = Color.Red;
            sitlabel.ForeColor = Color.White;
            sitlabel.Text = "Reactor Failing";
            Refresh();
            Thread.Sleep(900);
            reactorstatelabel1.BackColor = Color.Red;
            reactorstatelabel2.BackColor = Color.Red;
            sitlabel.BackColor = Color.White;
            sitlabel.ForeColor = Color.Black;
            sitlabel.Text = "Shutdown Imminent";
            Refresh();
            Thread.Sleep(900);
            reactorstatelabel1.BackColor = Color.White;
            reactorstatelabel2.BackColor = Color.White;
            sitlabel.BackColor = Color.Red;
            sitlabel.ForeColor = Color.White;
            sitlabel.Text = "Reactor Failing";
        }

        private void sitlabel_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void stopbutton_Click(object sender, EventArgs e)
        {
            reactorstatelabel1.BackColor= Color.Lime;
            reactorstatelabel2.BackColor= Color.Lime;
            Thread.Sleep(400);
            sitlabel.BackColor= Color.White;
            sitlabel.ForeColor= Color.Black;
            sitlabel.Text = "Reactor Satble";
        }
    }
}
