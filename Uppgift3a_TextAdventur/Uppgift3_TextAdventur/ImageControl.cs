using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Uppgift3_TextAdventur
{
    public static class ImageControl
    {
        public static Image GetImage(string inputImageFile)
        {
            return
                Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                    inputImageFile));
        }

        public static PictureBox RotateImage(PictureBox inputPictureBox)
        {
            inputPictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            return inputPictureBox;
        }

        public static PictureBox FlipImage(PictureBox inputPictureBox)
        {
            inputPictureBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            return inputPictureBox;
        }

        public static PictureBox BackgroundImage(PictureBox inputPictureBox)
        {
            inputPictureBox.Image = GetImage("Resources/Background.png");
            return inputPictureBox;
        }

        public static PictureBox DoorImage(PictureBox inputPictureBox, PictureBox inputPictureBox2)
        {
            inputPictureBox.Image = GetImage("Resources/Door.png");
            inputPictureBox.Parent = BackgroundImage(inputPictureBox2);
            inputPictureBox.BackColor = Color.Transparent;
            inputPictureBox.Location = new Point(25, 115);
            return inputPictureBox;
        }

        public static PictureBox PictureImage(PictureBox inputPictureBox, PictureBox inputPictureBox2)
        {
            inputPictureBox.Image = GetImage("Resources/Picture.png");
            inputPictureBox.Parent = BackgroundImage(inputPictureBox2);
            inputPictureBox.BackColor = Color.Transparent;
            inputPictureBox.Location = new Point(270, 70);
            return inputPictureBox;
        }

        public static PictureBox CrackImage(PictureBox inputPictureBox, PictureBox inputPictureBox2)
        {
            inputPictureBox.Image = GetImage("Resources/Crack.png");
            inputPictureBox.Parent = BackgroundImage(inputPictureBox2);
            inputPictureBox.BackColor = Color.Transparent;
            inputPictureBox.Location = new Point(280, 100);
            return inputPictureBox;
        }

        public static PictureBox PlantImage(PictureBox inputPictureBox, PictureBox inputPictureBox2)
        {
            inputPictureBox.Image = GetImage("Resources/Plant.png");
            inputPictureBox.Parent = BackgroundImage(inputPictureBox2);
            inputPictureBox.BackColor = Color.Transparent;
            inputPictureBox.Location = new Point(200, 130);
            return inputPictureBox;
        }

        public static PictureBox WindowImage(PictureBox inputPictureBox, PictureBox inputPictureBox2)
        {
            inputPictureBox.Image = GetImage("Resources/Window.png");
            inputPictureBox.Parent = BackgroundImage(inputPictureBox2);
            inputPictureBox.BackColor = Color.Transparent;
            inputPictureBox.Location = new Point(155, 40);
            return inputPictureBox;
        }

        public static PictureBox LampImage(PictureBox inputPictureBox, PictureBox inputPictureBox2)
        {
            inputPictureBox.Image = GetImage("Resources/Lamp.png");
            inputPictureBox.Parent = BackgroundImage(inputPictureBox2);
            inputPictureBox.BackColor = Color.Transparent;
            inputPictureBox.Location = new Point(150, 0);
            return inputPictureBox;
        }

        public static PictureBox LampBrokenImage(PictureBox inputPictureBox, PictureBox inputPictureBox2)
        {
            inputPictureBox.Image = GetImage("Resources/LampBroken.png");
            inputPictureBox.Parent = BackgroundImage(inputPictureBox2);
            inputPictureBox.BackColor = Color.Transparent;
            inputPictureBox.Location = new Point(150, 0);
            return inputPictureBox;
        }

        public static PictureBox KeyImage(PictureBox inputPictureBox, PictureBox inputPictureBox2)
        {
            inputPictureBox.Image = GetImage("Resources/Key.png");
            inputPictureBox.Parent = BackgroundImage(inputPictureBox2);
            inputPictureBox.BackColor = Color.Transparent;
            inputPictureBox.Location = new Point(200, 180);
            return inputPictureBox;
        }

        public static PictureBox PaperBallImage(PictureBox inputPictureBox, PictureBox inputPictureBox2)
        {
            inputPictureBox.Image = GetImage("Resources/PaperBall.png");
            inputPictureBox.Parent = BackgroundImage(inputPictureBox2);
            inputPictureBox.BackColor = Color.Transparent;
            inputPictureBox.Location = new Point(100, 200);
            return inputPictureBox;
        }

        public static PictureBox DropWaterImage(PictureBox inputPictureBox, PictureBox inputPictureBox2)
        {
            inputPictureBox.Image = GetImage("Resources/Water.png");
            inputPictureBox.Parent = BackgroundImage(inputPictureBox2);
            inputPictureBox.BackColor = Color.Transparent;
            inputPictureBox.Location = new Point(38, -48);
            return inputPictureBox;
        }

        public static PictureBox LampshadeImage(PictureBox inputPictureBox, PictureBox inputPictureBox2)
        {
            inputPictureBox.Image = GetImage("Resources/Lampshade.png");
            inputPictureBox.Parent = BackgroundImage(inputPictureBox2);
            inputPictureBox.BackColor = Color.Transparent;
            inputPictureBox.Location = new Point(120, 200);
            return inputPictureBox;
        }

        public static PictureBox WaterImage(PictureBox inputPictureBox, PictureBox inputPictureBox2)
        {
            inputPictureBox.Image = GetImage("Resources/WithWater.png");
            inputPictureBox.Parent = BackgroundImage(inputPictureBox2);
            inputPictureBox.BackColor = Color.Transparent;
            inputPictureBox.Location = new Point(120, 200);
            return inputPictureBox;
        }

        public static PictureBox TapeImage(PictureBox inputPictureBox, PictureBox inputPictureBox2)
        {
            inputPictureBox.Image = GetImage("Resources/Tape.png");
            inputPictureBox.Parent = BackgroundImage(inputPictureBox2);
            inputPictureBox.BackColor = Color.Transparent;
            inputPictureBox.Location = new Point(250, 210);
            return inputPictureBox;
        }

        public static PictureBox LampBrokenImage2(PictureBox inputPictureBox, PictureBox inputPictureBox2)
        {
            inputPictureBox.Image = GetImage("Resources/LampBroken2.png");
            inputPictureBox.Parent = BackgroundImage(inputPictureBox2);
            inputPictureBox.BackColor = Color.Transparent;
            inputPictureBox.Location = new Point(100, 160);
            return inputPictureBox;
        }

        public static PictureBox Plant2Image(PictureBox inputPictureBox, PictureBox inputPictureBox2)
        {
            inputPictureBox.Image = GetImage("Resources/Plant3.png");
            inputPictureBox.Parent = BackgroundImage(inputPictureBox2);
            inputPictureBox.BackColor = Color.Transparent;
            inputPictureBox.Location = new Point(200, 10);
            return inputPictureBox;
        }
    }
}
