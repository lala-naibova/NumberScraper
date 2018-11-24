using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberScrapperUI
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }


        private void btnBroseFiles_Click(object sender, EventArgs e)
        {

            DialogResult dioResult= this.openFileDialog.ShowDialog();

            if (dioResult == DialogResult.OK)
            {
                int count = openFileDialog.FileNames.Length;
                if (count > 1)
                {
                    lblSelectedFilesCount.Text = $"{count} files selected";
                }
                else 
                {
                    lblSelectedFilesCount.Text = "1 file selected";
                }
                
            }
            else if (dioResult==DialogResult.Cancel)
            {
                lblSelectedFilesCount.Text = "No files selected";
            }
        }

        private void btnBroseFolder_Click(object sender, EventArgs e)
        {

            DialogResult diLog = folderBrowserDialog.ShowDialog();
            if (diLog==DialogResult.OK)
            {
                lblFolderPath.Text = folderBrowserDialog.SelectedPath;
            }
            else if (diLog==DialogResult.Cancel)
            {
                MessageBox.Show("You press the Cancel button");
            }
            
        }
    }
}
