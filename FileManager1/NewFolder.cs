using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager1
{
    public partial class NewFolder : Form
    {
        public string folderName;
        public NewFolder()
        {       
            InitializeComponent();
            label1.Text = lvp.EnterNameForm2Text;
            this.Text = lvp.Form2NameText;
            folderName = "";
        }

        private void ConfirmCreation()
        {
            FileManager main = this.Owner as FileManager;
            if (main != null) { folderName = textBox1.Text; }
            Close();
        }

        private void NewFolderFormLoad()
        {
            label1.Text = lvp.EnterNameForm2Text;
            this.Text = lvp.Form2NameText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfirmCreation();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, null);
            }
        }

        private void NewFolder_Load(object sender, EventArgs e)
        {
            NewFolderFormLoad();
        }
    }
}
