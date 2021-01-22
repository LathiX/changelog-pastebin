using System;
using System.Windows.Forms;
using System.Net;

namespace changelog_pastebin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Get changelog on startup.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Making a webclient.
            using (WebClient cl = new WebClient())
            {
                // Getting data from pastebin link!
                string changelog = cl.DownloadString("https://pastebin.com/raw/6Md6J3wj");
                // Paste code here, what do you want it to do when it gets the pastebin text
                // EXAMPLE:
                richTextBox1.Text = changelog;
            }
        }
    }
}
