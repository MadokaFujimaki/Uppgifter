using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uppgift2_Shotgun;

namespace Uppgift2_Shotgun
{
  
    public partial class Form1 : Form
    {
        private int bulletYou = 0;
        private int bulletAi = 0;
        private int scoreYou = 0;
        private int scoreAi = 0;


        public Form1()
        {
            InitializeComponent();
            LabelBulletYou.ForeColor = bulletYou.ControlBulletColor();
            LabelBulletAi.ForeColor = bulletAi.ControlBulletColor();
     
     

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PctureBoxBackground.BringToFront();
            PictureBoxTopImage.BringToFront();
            ButtonStart.BringToFront();
            PictureBoxTitle.BringToFront();
            PictureBoxYou.Image = ImageControl.ImageYou();
            PictureBoxAI.Image = ImageControl.ImageAi();
            Bullet.ControlButtonShoot(bulletYou, ButtonShoot);
            Bullet.ControlLebelMessage(bulletYou, LabelCharge);
        }


        private void ButtonShoot_Click(object sender, EventArgs e)
        {   
            Bullet.ControlLebelMessage(bulletYou, LabelCharge);
            var bulletEnemy = new BulletAi();
            PictureBoxAI.Image = ImageControl.GetImageAi(bulletAi, bulletYou);
            PictureBoxAI.Image = bulletEnemy.GetImageShotgun(bulletAi, PictureBoxAI.Image);

            if (bulletYou >= 3)
            {
                PictureBoxYou.Image = ImageControl.ImageList[3];
                bulletYou = bulletYou.UseShotgun();
                LabelMessage.Text = "Du sköt shotgun!";
            }
            else if (bulletYou > 0)
            {
                PictureBoxYou.Image = ImageControl.ImageList[0];
                bulletYou = bulletYou.ShootBullets();
                LabelMessage.Text = "Du sköt!";
            }
         
            LabelBulletYou.Text = bulletYou.ToString();
            LabelBulletYou.ForeColor = bulletYou.ControlBulletColor();

            Bullet.ConvertToGun(bulletYou, ButtonShoot);
            Bullet.ControlLebelMessage(bulletYou, LabelCharge);
            Bullet.ControlButtonShoot(bulletYou, ButtonShoot);

            bulletAi = bulletEnemy.ControlBullet(bulletAi, PictureBoxAI.Image);
            LabelBulletAi.Text = bulletAi.ToString();
            LabelBulletAi.ForeColor = bulletAi.ControlBulletColor();

            var fightControl = new FightControl();
            LabelResult.Text = fightControl.FightTextControl(PictureBoxYou.Image, PictureBoxAI.Image);
     
            fightControl.FightEndControl(LabelResult.Text, ButtonShoot);
            fightControl.FightEndControl(LabelResult.Text, ButtonCharge);
            fightControl.FightEndControl(LabelResult.Text, ButtonBlock);
            fightControl.ChangeTextColor(LabelResult);
      

            fightControl.ScoreControl(scoreYou, scoreAi, LabelResult);
            scoreYou = fightControl.TotalScoreYou;
            scoreAi = fightControl.TotalScoreAi;
            LabelScoreYou.Text = scoreYou.ToString();
            LabelScoreAI.Text= scoreAi.ToString();

        }



        private void ButtonCharge_Click(object sender, EventArgs e)
        {
            var bulletEnemy = new BulletAi();
            PictureBoxAI.Image = ImageControl.GetImageAi(bulletAi, bulletYou);
            PictureBoxAI.Image = bulletEnemy.GetImageShotgun(bulletAi, PictureBoxAI.Image);


            LabelMessage.ForeColor = Color.Aqua;
            LabelMessage.Text = "Du laddade geväret!";

            LabelBulletYou.Text = bulletYou.ToString();
            Image imageYou = ImageControl.ImageList[1];

            PictureBoxYou.Image = imageYou;

            bulletYou = bulletYou.ChargeBullets();
            LabelBulletYou.Text = bulletYou.ToString();
            LabelBulletYou.ForeColor = bulletYou.ControlBulletColor();

            Bullet.ConvertToShotgun(bulletYou, ButtonShoot);
            Bullet.ControlLebelMessage(bulletYou, LabelCharge);
            Bullet.ControlButtonShoot(bulletYou, ButtonShoot);


            bulletAi = bulletEnemy.ControlBullet(bulletAi, PictureBoxAI.Image);
            LabelBulletAi.Text = bulletAi.ToString();
            LabelBulletAi.ForeColor = bulletAi.ControlBulletColor();

            var fightControl = new FightControl();
            LabelResult.Text = fightControl.FightTextControl(PictureBoxYou.Image, PictureBoxAI.Image);

            fightControl.FightEndControl(LabelResult.Text, ButtonShoot);
            fightControl.FightEndControl(LabelResult.Text, ButtonCharge);
            fightControl.FightEndControl(LabelResult.Text, ButtonBlock);
            fightControl.ChangeTextColor(LabelResult);
        

            fightControl.ScoreControl(scoreYou, scoreAi, LabelResult);
            scoreYou = fightControl.TotalScoreYou;
            scoreAi = fightControl.TotalScoreAi;
            LabelScoreYou.Text = scoreYou.ToString();
            LabelScoreAI.Text = scoreAi.ToString();

  
        }


        private void ButtonBlock_Click(object sender, EventArgs e)
        {
            var bulletEnemy = new BulletAi();
            PictureBoxAI.Image = ImageControl.GetImageAi(bulletAi, bulletYou);
            PictureBoxAI.Image = bulletEnemy.GetImageShotgun(bulletAi, PictureBoxAI.Image);

            LabelMessage.ForeColor = Color.Aqua;
            LabelMessage.Text = "Du blockade!";

            Image imageYou = ImageControl.ImageList[2];
            PictureBoxYou.Image = imageYou;
            LabelBulletYou.ForeColor = bulletYou.ControlBulletColor();
            Bullet.ControlButtonShoot(bulletYou, ButtonShoot);

            bulletAi = bulletEnemy.ControlBullet(bulletAi, PictureBoxAI.Image);
            LabelBulletAi.Text = bulletAi.ToString();
            LabelBulletAi.ForeColor = bulletAi.ControlBulletColor();

            var fightControl = new FightControl();
            LabelResult.Text = fightControl.FightTextControl(PictureBoxYou.Image, PictureBoxAI.Image);

            fightControl.FightEndControl(LabelResult.Text, ButtonShoot);
            fightControl.FightEndControl(LabelResult.Text, ButtonCharge);
            fightControl.FightEndControl(LabelResult.Text, ButtonBlock);
            fightControl.ChangeTextColor(LabelResult);

            fightControl.ScoreControl(scoreYou, scoreAi, LabelResult);
            scoreYou = fightControl.TotalScoreYou;
            scoreAi = fightControl.TotalScoreAi;
            LabelScoreYou.Text = scoreYou.ToString();
            LabelScoreAI.Text = scoreAi.ToString();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            PctureBoxBackground.SendToBack();
            PictureBoxTitle.SendToBack();
            PictureBoxTopImage.SendToBack();
            ButtonStart.SendToBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LabelResult.ForeColor = Color.Aqua;
            PictureBoxYou.Image = ImageControl.ImageYou();
            PictureBoxAI.Image = ImageControl.ImageAi();

             Bullet.Bullets = 0;
            bulletYou = Bullet.Bullets;
            LabelBulletYou.Text = bulletYou.ToString();
            LabelBulletYou.ForeColor = Bullet.ControlBulletColor(bulletYou);
    
            var bulletCom = new BulletAi();
            bulletCom.Bullets = 0;
            bulletAi = bulletCom.Bullets;
            LabelBulletAi.Text = bulletAi.ToString();
            LabelBulletAi.ForeColor = Bullet.ControlBulletColor(bulletAi);

            LabelMessage.Text = "Välj en knapp ovan!";
            LabelResult.Text = "";

            Bullet.ControlButtonShoot(bulletYou, ButtonShoot);
            Bullet.ConvertToShotgun(bulletYou,ButtonShoot);
            ButtonCharge.Enabled = true;
            ButtonBlock.Enabled = true;
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            var fightControl = new FightControl();
            fightControl.TotalScoreYou = 0;
            fightControl.TotalScoreAi = 0;
            scoreYou = fightControl.TotalScoreYou;
            scoreAi = fightControl.TotalScoreAi;
            LabelScoreYou.Text = scoreYou.ToString();
            LabelScoreAI.Text = scoreAi.ToString();
        }

        private void PctureBoxBackground_Click(object sender, EventArgs e)
        {

        }
    }
}
