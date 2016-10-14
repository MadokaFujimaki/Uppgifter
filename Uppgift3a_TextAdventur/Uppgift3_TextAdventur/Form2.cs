using System;
using System.Drawing;
using System.Windows.Forms;

namespace Uppgift3_TextAdventur
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ImageControl.BackgroundImage(PictureBoxRoom);
            ImageControl.DoorImage(PictureBoxDoor, PictureBoxRoom);
            ImageControl.DoorImage(PictureBoxDoor2, PictureBoxRoom);
            ImageControl.FlipImage(PictureBoxDoor2);
            PictureBoxDoor2.Location = new Point(280, 115);
            ImageControl.LampImage(PictureBoxLamp, PictureBoxRoom);
            ImageControl.PaperBallImage(PictureBoxPaperBall, PictureBoxRoom);
            ImageControl.LampshadeImage(PictureBoxLampshade3, PictureBoxRoom);
            ImageControl.LampshadeImage(PictureBoxLampshade, PictureBoxRoom);
            ImageControl.WaterImage(PictureBoxWater, PictureBoxRoom);
            ImageControl.TapeImage(PictureBoxTape, PictureBoxRoom);
        }

        private void PictureBoxWaterIcon_Click(object sender, EventArgs e)
        {
            LabelMessage.Text = @"It has plenty of water";
            ItemControl itemControl = new ItemControl();
            itemControl.ActiveItem(PictureBoxWaterIcon, PictureBoxPaperBallIcon, PictureBoxPictureIcon, PictureBoxKeyIcon, PictureBoxLampshadeIcon, PictureBoxTapeIcon, PictureBoxLampshade2);
        }

        private void PictureBoxLampshadeIcon_Click(object sender, EventArgs e)
        {
            if (PictureBoxTapeIcon.BackColor == Color.DarkCyan)
            {
                PictureBoxTapeIcon.Visible = false;
                PictureBoxLampshadeIcon.Visible = false;
                PictureBoxLampshade2.Visible = true;
                LabelMessage.Text = @"Taped up to the lampshade's hole";
                ItemControl itemControl = new ItemControl();
                itemControl.ActiveItem(PictureBoxLampshade2, PictureBoxLampshadeIcon, PictureBoxPaperBallIcon, PictureBoxPictureIcon, PictureBoxKeyIcon, PictureBoxWaterIcon, PictureBoxTapeIcon);
            }
            else
            {
                LabelMessage.Text = @"A plastic lampshade. Umm how can i use this...?";
                ItemControl itemControl = new ItemControl();
                itemControl.ActiveItem(PictureBoxLampshadeIcon, PictureBoxPaperBallIcon, PictureBoxPictureIcon, PictureBoxKeyIcon, PictureBoxWaterIcon, PictureBoxTapeIcon, PictureBoxLampshade2);
            }
        }

        private void PictureBoxTapeIcon_Click(object sender, EventArgs e)
        {
            LabelMessage.Text = @"A sturdy tape";
            ItemControl itemControl = new ItemControl();
            itemControl.ActiveItem(PictureBoxTapeIcon, PictureBoxPaperBallIcon, PictureBoxPictureIcon, PictureBoxKeyIcon, PictureBoxLampshadeIcon, PictureBoxWaterIcon, PictureBoxLampshade2);
        }

        private void PictureBoxPictureIcon_Click(object sender, EventArgs e)
        {
            LabelMessage.Text = @"Maybe I don't need this one...";
            ItemControl itemControl = new ItemControl();
            itemControl.ActiveItem(PictureBoxPictureIcon, PictureBoxKeyIcon, PictureBoxPaperBallIcon, PictureBoxLampshadeIcon, PictureBoxWaterIcon, PictureBoxTapeIcon, PictureBoxLampshade2);
        }

        private void PictureBoxPaperBallIcon_Click(object sender, EventArgs e)
        {
            LabelMessage.Text = @"Maybe I can use it somewhere...?";
            ItemControl itemControl = new ItemControl();
            itemControl.ActiveItem(PictureBoxPaperBallIcon, PictureBoxPictureIcon, PictureBoxKeyIcon, PictureBoxLampshadeIcon, PictureBoxWaterIcon, PictureBoxTapeIcon, PictureBoxLampshade2);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LabelMessage.Text = @"The second room";
        }

        private void PictureBoxDoor_Click(object sender, EventArgs e)
        {
            LabelMessage.Text = @"The second room";
            FormControl.Frm3.PictureBoxPictureIcon.Image = PictureBoxPictureIcon.Image;
            FormControl.Frm3.PictureBoxPictureIcon.Visible = PictureBoxPictureIcon.Visible;
            FormControl.Frm3.PictureBoxPaperBallIcon.Image = PictureBoxPaperBallIcon.Image;
            FormControl.Frm3.PictureBoxPaperBallIcon.Visible = PictureBoxPaperBallIcon.Visible;
            FormControl.Frm3.PictureBoxTapeIcon.Image = PictureBoxTapeIcon.Image;
            FormControl.Frm3.PictureBoxTapeIcon.Visible = PictureBoxTapeIcon.Visible;
            FormControl.Frm3.PictureBoxLampshadeIcon.Image = PictureBoxLampshadeIcon.Image;
            FormControl.Frm3.PictureBoxLampshadeIcon.Visible = PictureBoxLampshadeIcon.Visible;
            FormControl.Frm3.PictureBoxWaterIcon.Image = PictureBoxWaterIcon.Image;
            FormControl.Frm3.PictureBoxWaterIcon.Visible = PictureBoxWaterIcon.Visible;
            FormControl.Frm3.PictureBoxLampshade2.Visible = PictureBoxLampshade2.Visible;

            FormControl.Frm2.PictureBoxLampshade3.Image = PictureBoxLampshade3.Image;
            FormControl.Frm3.PictureBoxPaperBall.Image = PictureBoxPaperBall.Image;
            FormControl.Frm3.PictureBoxTape.Image = PictureBoxTape.Image;
            FormControl.Frm3.PictureBoxLampshade.Image = PictureBoxLampshade.Image;
            FormControl.Frm3.PictureBoxWater.Image = PictureBoxWater.Image;
            Hide();
            FormControl.Frm3.Show();
        }

        private void PictureBoxRoom_Click(object sender, EventArgs e)
        {
            var itemControl = new ItemControl();
            itemControl.InactiveItem(PictureBoxKeyIcon, PictureBoxPictureIcon, PictureBoxPaperBallIcon, PictureBoxLampshadeIcon, PictureBoxWaterIcon, PictureBoxTapeIcon, PictureBoxLampshade2);
            LabelMessage.Text = @"Did not find anything";
        }

        private void PictureBoxTape_Click(object sender, EventArgs e)
        {
            PictureBoxTape.Visible = false;
            PictureBoxTapeIcon.Visible = true;
            PictureBoxTapeIcon.BackColor = Color.Transparent;
            LabelMessage.Text = @"You got a tape";
        }

        private void PictureBoxPaperBall_Click(object sender, EventArgs e)
        {
            LabelMessage.Text = @"After all, maybe I can use it...?";
            PictureBoxPaperBallIcon.Visible = true;
            PictureBoxPaperBall.Visible = false;
        }

        private void PictureBoxWater_Click(object sender, EventArgs e)
        {
            PictureBoxWater.Visible = false;
            PictureBoxWaterIcon.Visible = true;
            PictureBoxWaterIcon.BackColor = Color.Transparent;
            LabelMessage.Text = @"You got a lampshade with water";
        }

        private void PictureBoxLampshade_Click(object sender, EventArgs e)
        {
            PictureBoxLampshade.Visible = false;
            PictureBoxLampshadeIcon.Visible = true;
            PictureBoxLampshadeIcon.BackColor = Color.Transparent;
            LabelMessage.Text = @"You got a lampshade";
        }

        private void PictureBoxDoor2_Click(object sender, EventArgs e)
        {
            LabelMessage.Text = @"The second room";
            FormControl.Frm4.PictureBoxPictureIcon.Image = PictureBoxPictureIcon.Image;
            FormControl.Frm4.PictureBoxPictureIcon.Visible = PictureBoxPictureIcon.Visible;
            FormControl.Frm4.PictureBoxPaperBallIcon.Image = PictureBoxPaperBallIcon.Image;
            FormControl.Frm4.PictureBoxPaperBallIcon.Visible = PictureBoxPaperBallIcon.Visible;
            FormControl.Frm4.PictureBoxTapeIcon.Image = PictureBoxTapeIcon.Image;
            FormControl.Frm4.PictureBoxTapeIcon.Visible = PictureBoxTapeIcon.Visible;
            FormControl.Frm4.PictureBoxLampshadeIcon.Image = PictureBoxLampshadeIcon.Image;
            FormControl.Frm4.PictureBoxLampshadeIcon.Visible = PictureBoxLampshadeIcon.Visible;
            FormControl.Frm4.PictureBoxWaterIcon.Image = PictureBoxWaterIcon.Image;
            FormControl.Frm4.PictureBoxWaterIcon.Visible = PictureBoxWaterIcon.Visible;
            FormControl.Frm4.PictureBoxLampshade2.Visible = PictureBoxLampshade2.Visible;

            FormControl.Frm2.PictureBoxLampshade3.Image = PictureBoxLampshade3.Image;
            FormControl.Frm4.PictureBoxPaperBall.Image = PictureBoxPaperBall.Image;
            FormControl.Frm4.PictureBoxTape.Image = PictureBoxTape.Image;
            FormControl.Frm4.PictureBoxLampshade.Image = PictureBoxLampshade.Image;
            FormControl.Frm4.PictureBoxWater.Image = PictureBoxWater.Image;
            Hide();
            FormControl.Frm4.Show();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            LabelMessage.Text = @"The second room";
            FormControl.Frm1.PictureBoxPictureIcon.Image = PictureBoxPictureIcon.Image;
            FormControl.Frm1.PictureBoxPictureIcon.Visible = PictureBoxPictureIcon.Visible;
            FormControl.Frm1.PictureBoxPaperBallIcon.Image = PictureBoxPaperBallIcon.Image;
            FormControl.Frm1.PictureBoxPaperBallIcon.Visible = PictureBoxPaperBallIcon.Visible;
            FormControl.Frm1.PictureBoxTapeIcon.Image = PictureBoxTapeIcon.Image;
            FormControl.Frm1.PictureBoxTapeIcon.Visible = PictureBoxTapeIcon.Visible;
            FormControl.Frm1.PictureBoxLampshadeIcon.Image = PictureBoxLampshadeIcon.Image;
            FormControl.Frm1.PictureBoxLampshadeIcon.Visible = PictureBoxLampshadeIcon.Visible;
            FormControl.Frm1.PictureBoxWaterIcon.Image = PictureBoxWaterIcon.Image;
            FormControl.Frm1.PictureBoxWaterIcon.Visible = PictureBoxWaterIcon.Visible;
            FormControl.Frm1.PictureBoxLampshade2.Visible = PictureBoxLampshade2.Visible;

            FormControl.Frm2.PictureBoxLampshade3.Image = PictureBoxLampshade3.Image;
            FormControl.Frm1.PictureBoxPaperBall.Image = PictureBoxPaperBall.Image;
            FormControl.Frm1.PictureBoxTape.Image = PictureBoxTape.Image;
            FormControl.Frm1.PictureBoxLampshade.Image = PictureBoxLampshade.Image;
            FormControl.Frm1.PictureBoxWater.Image = PictureBoxWater.Image;
            Hide();
            FormControl.Frm1.Show();
        }

        private void ButtonDrop_Click(object sender, EventArgs e)
        {
            if (PictureBoxPictureIcon.BackColor == Color.DarkCyan)
            {
                PictureBoxPaperBall.Visible = true;
                LabelMessage.Text = @"You discarded the poster";
            }
            else if (PictureBoxPaperBallIcon.BackColor == Color.DarkCyan && PictureBoxPaperBallIcon.Visible)
            {
                PictureBoxPaperBall.Visible = true;
                LabelMessage.Text = @"You dropped the paper";
            }
            else if (PictureBoxTapeIcon.BackColor == Color.DarkCyan)
            {
                PictureBoxTape.Visible = true;
                LabelMessage.Text = @"You dropped the tape";
            }
            else if (PictureBoxLampshadeIcon.BackColor == Color.DarkCyan)
            {
                PictureBoxLampshade.Visible = true;
                LabelMessage.Text = @"You dropped the lampshade";
            }
            else if (PictureBoxWaterIcon.BackColor == Color.DarkCyan && PictureBoxWaterIcon.Visible)
            {
                PictureBoxWater.Visible = true;
                LabelMessage.Text = @"You dropped the lampshade with water";
            }
            else if (PictureBoxLampshade2.BackColor == Color.DarkCyan && PictureBoxLampshade2.Visible)
            {
                PictureBoxLampshade3.Visible = true;
                LabelMessage.Text = @"You dropped the lampshade";
            }
            var itemControl = new ItemControl();
            itemControl.DropItem(PictureBoxKeyIcon, PictureBoxPictureIcon, PictureBoxPaperBallIcon, PictureBoxLampshadeIcon, PictureBoxWaterIcon, PictureBoxTapeIcon, PictureBoxLampshade2);
        }

        private void ButtonLookItem_Click(object sender, EventArgs e)
        {
            if (PictureBoxPictureIcon.BackColor == Color.DarkCyan)
            {
                LabelMessage.Text = @"Don't want this poster";
            }
            else if (PictureBoxPaperBallIcon.BackColor == Color.DarkCyan)
            {
                LabelMessage.Text = @"A wrinkled poster";
            }
            else if (PictureBoxTapeIcon.BackColor == Color.DarkCyan)
            {
                LabelMessage.Text = @"A sturdy tape";
            }
            else if (PictureBoxLampshadeIcon.BackColor == Color.DarkCyan)
            {
                LabelMessage.Text = @"A lampshade. There is a hole at the top";
            }
            else if (PictureBoxWaterIcon.BackColor == Color.DarkCyan)
            {
                LabelMessage.Text = @"It has plenty of water";
            }
            else if (PictureBoxLampshade2.BackColor == Color.DarkCyan)
            {
                LabelMessage.Text = @"It seems you can put in something in lampshade";
            }
        }

        private void PictureBoxLampshade2_Click(object sender, EventArgs e)
        {
            LabelMessage.Text = @"Taped up to the lampshade's hole";
            ItemControl itemControl = new ItemControl();
            itemControl.ActiveItem(PictureBoxLampshade2, PictureBoxWaterIcon, PictureBoxPaperBallIcon, PictureBoxPictureIcon, PictureBoxKeyIcon, PictureBoxLampshadeIcon, PictureBoxTapeIcon);
        }

        private void PictureBoxLampshade3_Click(object sender, EventArgs e)
        {
            PictureBoxLampshade3.Visible = false;
            PictureBoxLampshade2.Visible = true;
            PictureBoxLampshade2.BackColor = Color.Transparent;
            LabelMessage.Text = @"You got a lampshade";
        }
    }
}
