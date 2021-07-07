using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int num = 0;
        int count = 0;
        int usernum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            num = rnd.Next(1, 101);
            btnCheck.Enabled = true;
            count = 0;
            lblCount.Text = count.ToString();
            
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (num == 0)
            {
                MessageBox.Show("Начните игру");
                tbEnterNum.Text = "";
                return;
            }
            usernum = int.Parse(tbEnterNum.Text);
            tbEnterNum.Text = "";
            if (usernum == num)
            {
                lblShowHelp.Text = "Верно";
                count++;
                lblCount.Text = count.ToString();
                MessageBox.Show($"Вы выиграли.\n{count} попыток.");
            }
            else if (usernum > num)
            {
                lblShowHelp.Text = "Ваше число больше";
                count++;
                lblCount.Text = count.ToString();
                tbEnterNum.Text = "";
            }
            else
            {
                lblShowHelp.Text = "Ваше число меньше";
                count++;
                lblCount.Text = count.ToString();
                tbEnterNum.Text = "";
            }
        }
    }
}
