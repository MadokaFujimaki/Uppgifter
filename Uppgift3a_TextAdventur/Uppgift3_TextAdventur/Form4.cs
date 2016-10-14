using System;
using System.Drawing;
using System.Windows.Forms;

namespace Uppgift3_TextAdventur
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            ImageControl.BackgroundImage(PictureBoxRoom);
            //ImageControl.PictureImage(PictureBoxPicture, PictureBoxRoom);
            ImageControl.WindowImage(PictureBoxWindow, PictureBoxRoom);
            PictureBoxWindow.Location = new Point(130, 30);
            ImageControl.PaperBallImage(PictureBoxPaperBall, PictureBoxDropWater);
            PictureBoxPaperBall.Location = new Point(38, 250);
            ImageControl.LampshadeImage(PictureBoxLampshade3, PictureBoxRoom);
            ImageControl.LampshadeImage(PictureBoxLampshade, PictureBoxRoom);
            ImageControl.WaterImage(PictureBoxWater, PictureBoxRoom);
            ImageControl.TapeImage(PictureBoxTape, PictureBoxRoom);
            ImageControl.DropWaterImage(PictureBoxDropWater, PictureBoxRoom);
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
                PictureBoxLampshade.Location = new Point(200, 200);
                PictureBoxLampshade.Visible = true;
                LabelMessage.Text = @"You dropped the lampshade";
            }
            else if (PictureBoxWaterIcon.BackColor == Color.DarkCyan && PictureBoxWaterIcon.Visible)
            {
                PictureBoxWater.Location = new Point(200, 200);
                PictureBoxWater.Visible = true;
                LabelMessage.Text = @"You dropped the lampshade with water";
            }
            else if (PictureBoxLampshade2.BackColor == Color.DarkCyan && PictureBoxLampshade2.Visible)
            {
                PictureBoxLampshade3.Location = new Point(200, 200);
                PictureBoxLampshade3.Visible = true;
                LabelMessage.Text = @"You dropped the lampshade";
            }
            var itemControl = new ItemControl();
            itemControl.DropItem(PictureBoxKeyIcon, PictureBoxPictureIcon, PictureBoxPaperBallIcon, PictureBoxLampshadeIcon, PictureBoxWaterIcon, PictureBoxTapeIcon, PictureBoxLampshade2);
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

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            LabelMessage.Text = @"The forth room";
            FormControl.Frm2.PictureBoxPictureIcon.Image = PictureBoxPictureIcon.Image;
            FormControl.Frm2.PictureBoxPictureIcon.Visible = PictureBoxPictureIcon.Visible;
            FormControl.Frm2.PictureBoxPaperBallIcon.Image = PictureBoxPaperBallIcon.Image;
            FormControl.Frm2.PictureBoxPaperBallIcon.Visible = PictureBoxPaperBallIcon.Visible;
            FormControl.Frm2.PictureBoxTapeIcon.Image = PictureBoxTapeIcon.Image;
            FormControl.Frm2.PictureBoxTapeIcon.Visible = PictureBoxTapeIcon.Visible;
            FormControl.Frm2.PictureBoxLampshadeIcon.Image = PictureBoxLampshadeIcon.Image;
            FormControl.Frm2.PictureBoxLampshadeIcon.Visible = PictureBoxLampshadeIcon.Visible;
            FormControl.Frm2.PictureBoxWaterIcon.Image = PictureBoxWaterIcon.Image;
            FormControl.Frm2.PictureBoxWaterIcon.Visible = PictureBoxWaterIcon.Visible;
            FormControl.Frm2.PictureBoxLampshade2.Visible = PictureBoxLampshade2.Visible;

            FormControl.Frm2.PictureBoxLampshade3.Image = PictureBoxLampshade3.Image;
            FormControl.Frm2.PictureBoxPaperBall.Image = PictureBoxPaperBall.Image;
            FormControl.Frm2.PictureBoxTape.Image = PictureBoxTape.Image;
            FormControl.Frm2.PictureBoxLampshade.Image = PictureBoxLampshade.Image;
            FormControl.Frm2.PictureBoxWater.Image = PictureBoxWater.Image;
            Hide();
            FormControl.Frm2.Show();
        }

        private void PictureBoxPaperBall_Click(object sender, EventArgs e)
        {
            LabelMessage.Text = @"After all, maybe I can use it...?";
            PictureBoxPaperBallIcon.Visible = true;
            PictureBoxPaperBall.Visible = false;
        }

        private void PictureBoxTape_Click(object sender, EventArgs e)
        {
            PictureBoxTape.Visible = false;
            PictureBoxTapeIcon.Visible = true;
            PictureBoxTapeIcon.BackColor = Color.Transparent;
            LabelMessage.Text = @"You got a tape";
        }

        private void PictureBoxLampshade_Click(object sender, EventArgs e)
        {
            PictureBoxLampshade.Visible = false;
            PictureBoxLampshadeIcon.Visible = true;
            PictureBoxLampshadeIcon.BackColor = Color.Transparent;
            LabelMessage.Text = @"You got a lampshade";
        }

        private void PictureBoxWater_Click(object sender, EventArgs e)
        {
            PictureBoxWater.Visible = false;
            PictureBoxWaterIcon.Visible = true;
            PictureBoxWaterIcon.BackColor = Color.Transparent;
            LabelMessage.Text = @"You got a lampshade with water";
        }

        private void PictureBoxRoom_Click_1(object sender, EventArgs e)
        {
            var itemControl = new ItemControl();
            itemControl.InactiveItem(PictureBoxKeyIcon, PictureBoxPictureIcon, PictureBoxPaperBallIcon, PictureBoxLampshadeIcon, PictureBoxWaterIcon, PictureBoxTapeIcon, PictureBoxLampshade2);
            LabelMessage.Text = @"Did not find anything";
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

        private void PictureBoxDropWater_Click(object sender, EventArgs e)
        {
            if (PictureBoxLampshade2.BackColor == Color.DarkCyan)
            {
                PictureBoxLampshade2.Visible = false;
                PictureBoxWaterIcon.Visible = true;
                LabelMessage.Text = @"You let some water drip into the lampshade";
            }
            else
            {
                LabelMessage.Text = @"It drips from the ceiling";
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

        private void Form4_Load(object sender, EventArgs e)
        {
            LabelMessage.Text = @"The forth room";
        }
    }
}
