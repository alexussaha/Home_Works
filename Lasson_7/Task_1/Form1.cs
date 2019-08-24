using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {

        Udvoitel game;
        

        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            
            game = new Udvoitel(rnd.Next(50,201));
            lblDisplay.Text = game.Current.ToString();
            lblDisplayTheNum.Text = game.Number.ToString();
           
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (game == null)
            {
                MessageBox.Show("Начни игру!");
                return;
            }
            game.Plus();
            lblDisplay.Text = game.Current.ToString();
           
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (game == null)
            {
                MessageBox.Show("Начни игру!");
                return;
            }
            game.Multi();
            lblDisplay.Text = game.Current.ToString();
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (game == null)
            {
                MessageBox.Show("Начни игру!");
                return;
            }
            game.Reset();
            lblDisplay.Text = game.Current.ToString();
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (game == null)
            {
                MessageBox.Show("Начни игру!");
                return;
            }
            game.Back();
            lblDisplay.Text = game.Current.ToString();


        }
    }
}
