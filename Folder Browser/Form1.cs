using System;
using System.Windows.Forms;
using System.IO;

namespace Folder_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            //folderBrowserDialog1.ShowDialog();
            //textBox1.Text = folderBrowserDialog1.SelectedPath;
            // if Ok button is pressed, then only show btnShowFiles
            // get the selected path display in textbox
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                btnShowFiles.Enabled = true;
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnShowFiles_Click(object sender, EventArgs e)
        {
            //get files from directory class & display in the richTextBox using system.IO and foreach the result
            string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
            foreach (var listFiles in files)
            {
                rtbShowFiles.Text += $"{listFiles}\n";
            }

        }
    }
}
