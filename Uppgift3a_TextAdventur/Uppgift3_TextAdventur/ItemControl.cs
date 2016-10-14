using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Uppgift3_TextAdventur
{
   public class ItemControl : IItemControl
    {
        public void ActiveItem(PictureBox pb1, PictureBox pb2, PictureBox pb3, PictureBox pb4, PictureBox pb5, PictureBox pb6, PictureBox pb7)
        {
            pb1.BackColor = Color.DarkCyan;
            pb2.BackColor = Color.Transparent;
            pb3.BackColor = Color.Transparent;
            pb4.BackColor = Color.Transparent;
            pb5.BackColor = Color.Transparent;
            pb6.BackColor = Color.Transparent;
            pb7.BackColor = Color.Transparent;
        }

        public void InactiveItem(PictureBox pb1, PictureBox pb2, PictureBox pb3, PictureBox pb4, PictureBox pb5, PictureBox pb6, PictureBox pb7)
        {
            pb1.BackColor = Color.Transparent;
            pb2.BackColor = Color.Transparent;
            pb3.BackColor = Color.Transparent;
            pb4.BackColor = Color.Transparent;
            pb5.BackColor = Color.Transparent;
            pb6.BackColor = Color.Transparent;
            pb7.BackColor = Color.Transparent;
        }

        public string GetMessage(ref PictureBox inputPictureBox, Label inputLabel, string inputText, string inputText2)
        {
            if (inputPictureBox.BackColor == Color.DarkCyan)
            {         
                inputPictureBox.Visible = false;
                return inputLabel.Text = inputText;
            }
            else
            {
               return inputLabel.Text = inputText2;
            }
        }

        public void DropItem(PictureBox pb1, PictureBox pb2, PictureBox pb3, PictureBox pb4, PictureBox pb5, PictureBox pb6, PictureBox pb7)
        {
            List<PictureBox> myList = new List<PictureBox> {pb1, pb2, pb3, pb4, pb5, pb6, pb7};
            var result = myList.Where(p => p.BackColor == Color.DarkCyan);
            foreach (var item in result)
            {
                item.Visible = false;
            }
           
            if (pb1.BackColor == Color.DarkCyan || pb2.BackColor == Color.DarkCyan || pb3.BackColor == Color.DarkCyan || pb4.BackColor == Color.DarkCyan || pb5.BackColor == Color.DarkCyan || pb6.BackColor == Color.DarkCyan || pb7.BackColor == Color.DarkCyan)
            {
                pb1.BackColor = Color.Transparent;
                pb2.BackColor = Color.Transparent;
                pb3.BackColor = Color.Transparent;
                pb4.BackColor = Color.Transparent;
                pb5.BackColor = Color.Transparent;
                pb6.BackColor = Color.Transparent;
                pb7.BackColor = Color.Transparent;
            }
        }
    }
}
