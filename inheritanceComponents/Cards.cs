using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace inheritanceComponents
{
    class Card: PictureBox
    {
        int id;
        public Card(int id, Control control, int x)
        {
            this.id = id;
            this.Load("cards/p" + id.ToString() + ".png");
            this.Top = 10;
            this.Left = x;
            control.Controls.Add(this);

            this.SizeMode = PictureBoxSizeMode.AutoSize;
            this.MouseDown += Card_MouseDown;
        }

        private void Card_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show(id.ToString());
        }
    }
}
