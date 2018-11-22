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
                string allFileNames = string.Join(Environment.NewLine, openFileDialog.FileNames);
                MessageBox.Show(allFileNames);
            }
        }
    }
}
