using System;
using System.Windows.Forms;

namespace Uppgift3_TextAdventur
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();  
        }

        private void Start_Load(object sender, EventArgs e)
        {
            FormControl.MakeForm();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
           FormControl.Frm1.Show(); 
            Visible = false;
            //Form1 frm = new Form1();
            //frm.ShowDialog(this);    
        }
    }
}
