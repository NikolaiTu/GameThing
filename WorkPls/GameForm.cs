using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WorkPls
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WinnerForm SessionWin = new WinnerForm();
            SessionWin.Show();
            Hide();
        }

        private bool isMoving = false;
        private int DelayTime = 50;

        private async void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMoving)
            {
                isMoving = true;
                Random rnd = new Random();
                int x = rnd.Next(this.ClientSize.Width - button1.Size.Width);
                int y = rnd.Next(this.ClientSize.Height - button1.Size.Height);
                await Task.Delay(DelayTime);
                button1.Location = new Point(x, y);
                isMoving = false;

            }
        }

        private bool isHard = true;
        private void button2_Click(object sender, EventArgs e)
        {
            if (isHard == true)
            {
                isHard = false;
                DelayTime = 200;
                button2.BackColor = Color.Blue;
                button1.ForeColor = Color.Blue;
                button2.Text = "Ez Mode";
            }
            else if (isHard ==false)
            {
                isHard = true;
                DelayTime = 50;
                button2.BackColor = Color.Red;
                button1.ForeColor = Color.Red;
                button2.Text = "Hard Mode";
            }
        }
    }
}
