using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace inheritanceComponents
{
    class Trains
    {
    }

    class Train: PictureBox
    {
        int id;

        public Train(int id, Control control, int x)
        {
            this.id = id;

            this.Load("Images/p" + id.ToString() + "Ossetian.png");

            this.Top = 10;
            this.Left = x;
            this.SizeMode = PictureBoxSizeMode.AutoSize;
            control.Controls.Add(this);

            this.MouseMove += Train_MouseMove;
        }

        private void Train_MouseMove(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("!!!");
        }

       
    }
}
