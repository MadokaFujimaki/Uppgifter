using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Windows.Forms.VisualStyles;
using Timer = System.Windows.Forms.Timer;


namespace Uppgift1_Adressbok
{
    public partial class Form1 : Form
    {
        Timer myTimer = new Timer();
        Timer myTimer2 = new Timer();
        Timer myTimer3 = new Timer();
        Timer myTimer4 = new Timer();
        Timer myTimer5 = new Timer();
        int counter = 0;
        string missisng = "";

        public Form1()
        {
            InitializeComponent();
            myTimer.Tick += new System.EventHandler(MyTimer_Tick);
            myTimer2.Tick += new System.EventHandler(MyTimer_Tick2);
            myTimer3.Tick += new System.EventHandler(MyTimer_Tick3);
            myTimer4.Tick += new System.EventHandler(MyTimer_Tick4);
            myTimer5.Tick += new System.EventHandler(MyTimer_Tick5);
            myTimer.Interval = myTimer2.Interval = myTimer4.Interval = myTimer5.Interval = 50;
        }


        // var ticker = new Ticker
        //{
        //    Text = "Uppgiften togs bort!",
        //    Counter = 20,
        //    Color = Color.DarkGreen,
        //    MyTimer = myTimer
        //};

        //var ticker2 = new Ticker
        //{
        //    Text = "Uppgiften sparades!",
        //    Counter = 20,
        //    Color = Color.Blue,
        //    MyTimer = myTimer2
        //};

        //var ticker3 = new Ticker
        //{
        //    Text = "Följande fält saknas : " + missisng,
        //    Counter = 20,
        //    Color = Color.Crimson,
        //    MyTimer = myTimer3
        //};

        //var ticker4 = new Ticker
        //{
        //    Text = "Uppgiften hittades inte",
        //    Counter = 20,
        //    Color = Color.Crimson
        //        MyTimer = myTimer4
        //};


        //private void MyTimer_Tick(Ticker ticker)
        //{
        //    LabelMessage.ForeColor = ticker.Color;
        //    LabelMessage.Text = ticker.Text;
        //    counter = counter + 1;
        //    if (counter >= 20)
        //    {
        //        ticker.MyTimer.Stop();
        //        LabelMessage.Text = "";
        //        counter = 0;
        //    }
        //}

        private void MyTimer_Tick5(object sender, EventArgs e)
        {
            LabelMessage.ForeColor = Color.DarkGreen;
            LabelMessage.Font = new Font(LabelMessage.Font.FontFamily, 40);
            LabelMessage.Text = "→";
            counter = counter + 1;
            if (counter >= 20)
            {
                myTimer5.Stop();
                LabelMessage.Text = "";
                counter = 0;
                LabelMessage.Font = new Font(LabelMessage.Font.FontFamily, 11);
            }
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            LabelMessage.ForeColor = Color.DarkGreen;
            LabelMessage.Text = "Uppgiften togs bort!";
            counter = counter + 1;
            if (counter >= 20)
            {
                myTimer.Stop();
                LabelMessage.Text = "";
                counter = 0;
            }
        }

        private void MyTimer_Tick2(object sender, EventArgs e)
        {
            LabelMessage.ForeColor = Color.Blue;
            LabelMessage.Text = "Uppgiften sparades!";
            counter = counter + 1;
            if (counter >= 20)
            {
                myTimer2.Stop();
                LabelMessage.Text = "";
                counter = 0;
            }
        }

        private void MyTimer_Tick3(object sender, EventArgs e)
        {
            LabelMessage.ForeColor = Color.Crimson;
            LabelMessage.Text = "Följande fält saknas : " + missisng;
            counter = counter + 1;
            if (counter >= 30)
            {
                myTimer3.Stop();
                LabelMessage.Text = "";
                counter = 0;
            }
        }

        private void MyTimer_Tick4(object sender, EventArgs e)
        {
            LabelMessage.ForeColor = Color.Crimson;
            LabelMessage.Text = "Uppgiften hittades inte";
            counter = counter + 1;
            if (counter >= 20)
            {
                myTimer4.Stop();
                LabelMessage.Text = "";
                counter = 0;
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFromFile();
            //this.AcceptButton = this.ButtonSave;
        }




        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var contact = new Contact
            {
                Name = TextName.Text,
                Address = TextAddress.Text,
                Zip = TextZip.Text,
                City = TextCity.Text,
                Phone = TextPhone.Text,
                Email = TextEmail.Text
            };
            SaveContact(contact, out missisng);
            ReadFromFile();
        }

        private void SaveContact(Contact contact, out string missing)
        {
            missing = "";
            while (true)
            {
                if (contact.Name == "")
                {
                    missing = "Namn";
                }
                if (contact.Address == "")
                {
                    missing += ", Adress";
                }
                if (contact.Zip == "")
                {
                    missing += ", Postnummer";
                }
                if (contact.City == "")
                {
                    missing += ", Postort";
                }
                if (contact.Phone == "")
                {
                    missing += ", Telefon";
                }
                if (contact.Email == "")
                {
                    missing += ", Email";
                }
                if (missing == "")
                {
                    var stringBuilder = new StringBuilder();
                    stringBuilder.Append(contact.Name);
                    stringBuilder.Append(",");
                    stringBuilder.Append(contact.Address);
                    stringBuilder.Append(",");
                    stringBuilder.Append(contact.Zip);
                    stringBuilder.Append(",");
                    stringBuilder.Append(contact.City);
                    stringBuilder.Append(",");
                    stringBuilder.Append(contact.Phone);
                    stringBuilder.Append(",");
                    stringBuilder.Append(contact.Email);

                    using (var writer = new StreamWriter(Constants.PathToTxtFile, true))
                    {
                        writer.WriteLine(stringBuilder);
                        writer.Close();
                    }

                    myTimer2.Start();
                    break;
                }
                else
                {
                    if (missing.IndexOf(",") == 0)
                    {
                        missing = missisng.Substring(1, missing.Length - 1);
                    }
                    myTimer3.Start();
                    break;
                }
            }
        }





        public void ReadFromFile()
        {
            if (File.Exists(Constants.PathToTxtFile))
            {
                ListBoxAddressbook.Items.Clear();
                var lines = File.ReadAllLines(Constants.PathToTxtFile);
                foreach (var line in lines)
                {
                    ListBoxAddressbook.Items.Add(line);
                }

                for (int i = 0; i < ListBoxAddressbook.Items.Count - 1; i++)
                {
                    for (int j = i + 1; j < ListBoxAddressbook.Items.Count; j++)
                    {
                        if (ListBoxAddressbook.Items[i].Equals(ListBoxAddressbook.Items[j]) == true)
                        {
                            ListBoxAddressbook.Items.RemoveAt(j);
                        }
                    }
                }

                using (var writer = new StreamWriter(Constants.PathToTxtFile))
                {
                    for (int i = 0; i < ListBoxAddressbook.Items.Count; i++)
                    {
                        writer.WriteLine(ListBoxAddressbook.Items[i].ToString());
                    }
                    writer.Close();
                }
            }
            else
            {
                LabelMessage.ForeColor = Color.Crimson;
                LabelMessage.Text = "Filen finns inte!";
            }
        }





        private void ButtonDelete_Click_1(object sender, EventArgs e)
        {
            if (ListBoxAddressbook.SelectedItem != null)
            {
                while (ListBoxAddressbook.SelectedIndex > -1)
                {
                    ListBoxAddressbook.Items.RemoveAt(ListBoxAddressbook.SelectedIndex);
                }
                using (var writer = new StreamWriter(Constants.PathToTxtFile))
                {
                    for (int i = 0; i < ListBoxAddressbook.Items.Count; i++)
                    {
                        writer.WriteLine(ListBoxAddressbook.Items[i].ToString());
                    }
                    writer.Close();
                }
                myTimer.Start();
            }
            else
            {
            }
        }





        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (ListBoxAddressbook.SelectedItem != null)
            {
                var line = ListBoxAddressbook.SelectedItem.ToString();
                string[] splitContact = line.Split(',').ToArray();
                TextName.Text = splitContact[0];
                TextAddress.Text = splitContact[1];
                TextZip.Text = splitContact[2];
                TextCity.Text = splitContact[3];
                TextPhone.Text = splitContact[4];
                TextEmail.Text = splitContact[5];
                ListBoxAddressbook.Items.Remove(ListBoxAddressbook.SelectedItem);
                myTimer5.Start();
                using (var writer = new StreamWriter(Constants.PathToTxtFile))
                {
                    for (int i = 0; i < ListBoxAddressbook.Items.Count; i++)
                    {
                        writer.WriteLine(ListBoxAddressbook.Items[i].ToString());
                    }
                    writer.Close();
                }
            }
            else
            {
            }
        }





        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            var searchWord = TextBoxSearch.Text;

            int listBoxSize = ListBoxAddressbook.Items.Count;
            if (searchWord != string.Empty)
            {
                ListBoxAddressbook.ClearSelected();
                for (int i = 0; i < listBoxSize; i++)
                {
                    string item = ListBoxAddressbook.Items[i].ToString();
                    if (item.ToLower().Contains(searchWord.ToLower()))
                    {
                        ListBoxAddressbook.SetSelected(i, true);
                    }
                }
                if (ListBoxAddressbook.SelectedItem == null)
                {
                    myTimer4.Start();
                }
            }
            else
            {
                myTimer4.Start();
            }
        }




        private void ButtonClearSelected_Click(object sender, EventArgs e)
        {
            ListBoxAddressbook.ClearSelected();
        }





        private void ListBoxAddressbook_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var line = ListBoxAddressbook.SelectedItem.ToString();
            string[] splitContact = line.Split(',').ToArray();
            TextName.Text = splitContact[0];
            TextAddress.Text = splitContact[1];
            TextZip.Text = splitContact[2];
            TextCity.Text = splitContact[3];
            TextPhone.Text = splitContact[4];
            TextEmail.Text = splitContact[5];

            ListBoxAddressbook.Items.Remove(ListBoxAddressbook.SelectedItem);
            myTimer5.Start();
            using (var writer = new StreamWriter(Constants.PathToTxtFile))
            {
                for (int i = 0; i < ListBoxAddressbook.Items.Count; i++)
                {
                    writer.WriteLine(ListBoxAddressbook.Items[i].ToString());
                }
                writer.Close();
            }
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }




        private void TextZip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '\u002D')
            {
                e.Handled = true;
            }
        }

        private void TextPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '\u002D')
            {
                e.Handled = true;
            }
        }

        private void TextName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void TextAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void TextCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void TextEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void TextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

    }

}
