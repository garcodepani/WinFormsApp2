namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //[System.ComponentModel.Browsable(false)]
            //public System.Windows.Forms.Form? MdiParent = MDIParent1 { get; set; }

            //var form = new MDIParent1();
            //form.MdiParent;
            //form.Show();
            //form.MdiParent = MDIParent1

            
            
            
            var form = new MDIParent1();
            this.Hide();
            form.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            System.Environment.Exit(1);
        }
    }
}