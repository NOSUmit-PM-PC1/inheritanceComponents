using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Train;
namespace inheritanceComponents
{
    public partial class Form1 : Form
    {
        Train t;
        public static Card dragCard = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Card c = new Card(5, this, 0);
            Card c1 = new Card(2, this, 50);
            t = new Train(5, this, 400);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Form1.dragCard != null)
                if (t.Bounds.IntersectsWith(Form1.dragCard.Bounds))
                {
                    Form1.dragCard.Location = new Point(1000, 1000);
                    Form1.dragCard = null;

                    MessageBox.Show("Попал");
                   
                }
        }
    }
}
