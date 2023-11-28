using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkPls
{
    public partial class WinnerForm : Form
    {
        public WinnerForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1 Session = new Form1();
            Session.Show();
            Hide();
        }
    }
}
