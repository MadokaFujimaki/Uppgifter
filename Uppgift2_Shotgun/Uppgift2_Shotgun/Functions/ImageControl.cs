using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift2_Shotgun
{
    static class ImageControl
    {
        public static Image ImageToGame { get; set; }
        public  static List<Image> ImageList { get; set; }
        public static List<Image> ImageAiList { get; set; }
        //public  static List<Image> ImageShotgunList { get; set; }


        public static Image GetImage(this string inputImageFile)
        {       
            ImageToGame = Image.FromFile(Path.Combine(Path.GetDirectoryName( Assembly.GetExecutingAssembly().Location),inputImageFile));
            //ImageToGame = Image.FromFile(inputImageFile);
            return ImageToGame;
        }


        public static Image ImageYou()
        {
            ImageToGame = GetImage("Resources/WaitBlue.jpg");
            return ImageToGame;
        }

        public static Image ImageAi()
        {
            //ImageToGame = GetImage(@"C:\Users\madok\Desktop\Nackademin\c#\Uppgifter\Uppgift2_Shotgun\Uppgift2_Shotgun\Resources\WaitPurple.jpg");
            ImageToGame = GetImage("Resources/WaitPurple.jpg");
            return ImageToGame;
            return ImageToGame;
        }


        public static List<Image> ImageYouList()
        {
            ImageList.Add(GetImage("Resources/ShootBlue.gif"));
            ImageList.Add(GetImage("Resources/ChargeBlue.jpg"));
            ImageList.Add(GetImage("Resources/BlockBlue.jpg"));
            ImageList.Add(GetImage("Resources/ShotgunBlue.gif"));
            return ImageList;
        }

        public static Image ImageAiShoot()
        {
            ImageToGame = GetImage("Resources/ShootPurple.gif");
            return ImageToGame;
        }

        public static Image ImageAiCharge()
        {
            ImageToGame = GetImage("Resources/ChargePurple.jpg");
            return ImageToGame;
        }

        public static Image ImageAiBlock()
        {
            ImageToGame = GetImage("Resources/BlockPurple.jpg");
            return ImageToGame;
        }

        public static Image ImageAiShotgun()
        {
            ImageToGame = GetImage("Resources/ShotgunPurple.gif");
            return ImageToGame;
        }


        public static Image GetImageAi(int totalBulletAi, int totalbulletYou)
        {
            ImageList = new List<Image>();
            ImageList = ImageYouList();
            
            Random randomIndex = new Random();
            var imageShoot = ImageAiShoot();
            var imageCharge = ImageAiCharge();
            var imageBlock = ImageAiBlock();
            var imageShotgun = ImageAiShotgun();

            ImageAiList = new List<Image>();
            ImageAiList.Add(imageBlock);  //0
            ImageAiList.Add(imageCharge); //1
            ImageAiList.Add(imageShoot); //2
            ImageAiList.Add(imageShotgun); //3

            if (totalBulletAi == 0)
              {
                if ( totalbulletYou == 0)
                {
                    return ImageToGame = ImageAiList[1];
                }
                else
                {
                    return ImageToGame = ImageAiList[0];
                }   
            }
             else if (totalBulletAi >= 2 && totalbulletYou == 0)
             {
                 return ImageToGame = ImageAiList[2];
             }
      
            else
            {          
                int randomImage = randomIndex.Next(0, ImageAiList.Count-1);
                return ImageToGame = ImageAiList[randomImage];
            }
        }

    }
}
