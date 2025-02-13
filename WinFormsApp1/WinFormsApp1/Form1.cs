using System.Windows.Forms;
using Microsoft.Win32;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey helloKey = currentUserKey.CreateSubKey("HelloKey");
            helloKey.SetValue("color", this.BackColor.Name);
            helloKey.SetValue("Width", this.Width);
            helloKey.SetValue("Height", this.Height);
            helloKey.SetValue("text", textBox1.Text);
            helloKey.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey helloKey = currentUserKey.OpenSubKey("HelloKey");
            this.BackColor = Color.FromName(helloKey.GetValue("color").ToString());
            this.Width = (int)helloKey.GetValue("Width");
            this.Height = (int)helloKey.GetValue("Height");
            textBox1.Text =(string)helloKey.GetValue("text");
            helloKey.Close();

        }

      
    }
}
