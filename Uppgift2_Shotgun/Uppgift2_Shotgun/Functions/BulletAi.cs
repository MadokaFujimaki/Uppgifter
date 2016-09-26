using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift2_Shotgun
{
    class BulletAi
    {
        public int Bullets { get; set; }

        public int ControlBullet(int totalBulletEnemy, Image inputImage)
        {
            Bullets = totalBulletEnemy;
 
            if (inputImage == ImageControl.ImageAiList[1])
            {
                return Bullets += 1;
            }     
            else if (Bullets > 0 && inputImage == ImageControl.ImageAiList[2])
            {
                if (Bullets > 0)
                {
                    return Bullets -= 1;
                }
            }
            else if (Bullets >= 3 && inputImage == ImageControl.ImageAiList[3] )
            {
                return Bullets -= 3;
            }
            else
            {
                return Bullets;
            }
            return Bullets;
        }

        public Image GetImageShotgun(int totalBulletEnemy, Image inputImage)
        {
            Bullets = totalBulletEnemy;
             if (Bullets >= 3 && inputImage == ImageControl.ImageAiList[2] )
            {
                return ImageControl.ImageAiList[3];
            }
            else
            {
                return inputImage;
            }     
        }

    }
}
