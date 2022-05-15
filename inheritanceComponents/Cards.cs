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
            this.MouseMove += Card_MouseMove;
        }

        int startX, startY;
 
        private void Card_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - startX;
                this.Top += e.Y - startY;
            }
        }

        private void Card_MouseDown(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(id.ToString());
            startX = e.X;
            startY = e.Y;
        }
    }
}
