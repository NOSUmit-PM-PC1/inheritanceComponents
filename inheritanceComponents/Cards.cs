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
        public Card(int id, Control control)
        {
            this.id = id;
            this.Load("cards/p" + id.ToString() + ".png");
            this.Top = 10;
            this.Left = 20;
            control.Controls.Add(this);

            this.SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }
}
