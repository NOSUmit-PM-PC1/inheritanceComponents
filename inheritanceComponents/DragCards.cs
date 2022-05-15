using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace Train
{
    class DragCards
    {
            static bool isPress = false;
            static Point startPst;
            /// <summary>
            /// Функция выполняется при нажатии на перемещаемый контрол
            /// </summary>
            /// <param name="sender">контролл</param>
            /// <param name="e">событие мышки</param>
            public void MouseDown(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Right) return;//проверка что нажата левая кнопка
                isPress = true;
                startPst = e.Location;
            }
            /// <summary>
            /// Функция выполняется при отжатии перемещаемого контрола
            /// </summary>
            /// <param name="sender">контролл</param>
            /// <param name="e">событие мышки</param>
            public void MouseUp(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Right) return;//проверка что нажата левая кнопка
                isPress = false;
            }
            /// <summary>
            /// Функция выполняется при перемещении контрола
            /// </summary>
            /// <param name="sender">контролл</param>
            /// <param name="e">событие мышки</param>
            public void MouseMove(object sender, MouseEventArgs e)
            {
                if (isPress)
                {
                    Control control = (Control)sender;
                    control.Top += e.Y - startPst.Y;
                    control.Left += e.X - startPst.X;
                }
            }

            /// <summary>
            /// обучает контролы передвигаться
            /// </summary>
            /// <param name="sender">контролл(это может быть кнопка, лейбл, календарик и.т.д)</param>
            public void Drag(object sender)
            {
                Control control = (Control)sender;
                control.MouseDown += new MouseEventHandler(MouseDown);
                control.MouseUp += new MouseEventHandler(MouseUp);
                control.MouseMove += new MouseEventHandler(MouseMove);


            }
        }
    }


