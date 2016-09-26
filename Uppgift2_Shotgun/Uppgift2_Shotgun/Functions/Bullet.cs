using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift2_Shotgun
{
    public  static  class Bullet
    {
        public static int Bullets { get; set; }

        public static int ChargeBullets(this int charge)
        {
            Bullets = charge;
            return  Bullets += 1;
        }

        public static int ShootBullets(this int shoot)
        {
            Bullets = shoot;
            if (Bullets > 0)
            {
                return Bullets -= 1;
            }
            return Bullets;
        }

        public static int UseShotgun(this int totalBullet)
        {
            Bullets = totalBullet;
               return Bullets -= 3;
        }

        public static Color ControlBulletColor(this int totalBullet)
        {
            //Bullets = totalBullet;
            if (totalBullet == 0)
            {
                return Color.DeepPink;
            }
            return Color.White;
        }




        public static void ConvertToShotgun( int totalBullet, Button inputText)
        {
            Bullets = totalBullet;
            if (Bullets >= 3)
            {
                inputText.Text = "Shotgun";
                inputText.BackColor = Color.Aqua;
            }
            else
            {
                inputText.Text = "Skjuta";
                inputText.BackColor = Color.White;
            }
        }

        public static void ConvertToGun( int totalBullet, Button inputText)
        {
            Bullets = totalBullet;
            if (Bullets < 3)
            {
                inputText.Text = "Skjuta";
                inputText.BackColor = Color.White;
            }
        }


        public static void ControlLebelMessage(int totalBullet, Label inputLabel)
        {
            Bullets = totalBullet;
            if (Bullets == 0)
            {
                inputLabel.ForeColor = Color.DeepPink;
                inputLabel.Text = "Du måste ladda!";
            }
            else
            {
                inputLabel.Text = "";
            }
        }



        public static bool ControlButtonShoot(int totalBullet, Button inputButton)
        {
            Bullets = totalBullet;
            if (Bullets == 0)
            {
                return inputButton.Enabled = false;
            }
            return inputButton.Enabled = true;
        }


    }
}
