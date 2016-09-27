using System.Drawing;
using System.Windows.Forms;

namespace Uppgift2_Shotgun
{
    class FightControl
    {
        public int TotalScoreYou { get; set; }
        public int TotalScoreAi { get; set; }
        public string ResultText { get; set; }
  
 
        public string FightTextControl(Image imageYou, Image imageAi)
        {
            if (imageYou == ImageControl.ImageList[3] && imageAi != ImageControl.ImageAiList[3])
            {
                return ResultText = "Du vann!";
            }
           else if (imageAi == ImageControl.ImageAiList[3] && imageYou != ImageControl.ImageList[3])
            {
                return ResultText = "Du förlorade!";
            }
           else  if (imageYou == ImageControl.ImageList[0] && imageAi == ImageControl.ImageAiList[1])
            {
                return ResultText = "Du vann!";
            }
          else  if (imageYou == ImageControl.ImageList[1] && imageAi == ImageControl.ImageAiList[2])
            {
                return ResultText = "Du förlorade!";
            }
            else
            {
                return ResultText;
            }   
        }


        public void ScoreControl(int scoreYou, int scoreAi , Label inputLabel)
        {
            TotalScoreYou = scoreYou;
            TotalScoreAi = scoreAi;
            if (inputLabel.Text == "Du förlorade!")
            {
                TotalScoreAi += 1;
            }

            if (inputLabel.Text == "Du vann!")
            {
                TotalScoreYou += 1;
            }
        }



        public void ChangeTextColor( Label inputLabel)
        {
            if (inputLabel.Text == "Du förlorade!")
            {
                inputLabel.ForeColor = Color.DeepPink;
            }
        }


        public bool FightEndControl(string inputText, Button inputButton)
        {           
            if (inputText != "")
            {
                return inputButton.Enabled = false; 
            }
             if( inputButton.Enabled == false)
            {
                return inputButton.Enabled = false;
            }
            return inputButton.Enabled = true;
        }


    }
}
