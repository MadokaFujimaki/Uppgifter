using System.Windows.Forms;

namespace Uppgift3_TextAdventur
{
    public interface IItemControl
    {
        void ActiveItem(PictureBox pb1, PictureBox pb2, PictureBox pb3, PictureBox pb4, PictureBox pb5, PictureBox pb6, PictureBox pb7);
        void InactiveItem(PictureBox pb1, PictureBox pb2, PictureBox pb3, PictureBox pb4, PictureBox pb5, PictureBox pb6, PictureBox pb7);
        string GetMessage(ref PictureBox inputPictureBox, Label inputLabel, string inputText, string inputText2);
        void DropItem(PictureBox pb1, PictureBox pb2, PictureBox pb3, PictureBox pb4, PictureBox pb5, PictureBox pb6, PictureBox pb7);
    }
}
