namespace Uppgift3_TextAdventur
{
    public static class FormControl
    {
        public static Form1 Frm1 { get; set; }
        public static Form2 Frm2 { get; set; }
        public static Form3 Frm3 { get; set; }
        public static Form4 Frm4 { get; set; }

        public static void MakeForm()
        {
            Frm1 = new Form1();
            Frm2 = new Form2();
            Frm3 = new Form3();
            Frm4 = new Form4();          
        }
    }
}
