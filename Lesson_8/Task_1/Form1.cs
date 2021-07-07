using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Используется связывание данных
namespace BelieveOrNotBelieve2
{
    public partial class Form1 : Form
    {
        BelieveOrNotBelive database;
        BindingSource bs;
        int countOfRightAnswers = 0;
        int numOfQuestion = 0;
        public static void IndexOfArray(ref int num, BelieveOrNotBelive data)
        {
            if(num < data.List.Count -1)
            {
                num += 1;
            }
            else
            {
                MessageBox.Show("Вопросы закончились", "Упс...");
            }
        }
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Database_changeName(string filename)
        {
            tsslCurrentFilename.Text = filename;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += Timer_Tick;
            rbTrue.Tag = false;
            BelieveOrNotBelive.changeName += Database_changeName;
            database = new BelieveOrNotBelive("data.txt");
            bs = new BindingSource();
            bs.DataSource = database;
            bs.DataMember = "List";
            tbText.DataBindings.Add("Text", bs, "text");
            rbTrue.DataBindings.Add("Checked", bs, "trueFalse");
            bindingNavigator1.BindingSource = bs;
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tsslCurrentTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            //radioButton1.Checked = !radioButton1.Checked;
            if ((bool)rbTrue.Tag) rbTrue.Checked = false;
            else rbTrue.Checked = true;
            rbTrue.Tag = rbTrue.Checked;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //radioButton1.Checked = !radioButton1.Checked;
        }



        private void сохранитькакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Все файлы|*.*|XML files|*.XML";
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                database.FileName = dialog.FileName;
                database.Save();
            }
            //OpenFileDialog
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Все файлы|*.*|XML files|*.XML";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                database.FileName = dialog.FileName;
                database.Load();
               
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            database.FileName = "data.XML";
            database.Save();
        }

        private void опрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игра \"Правда или ложь\"\n Разработчик: Усов Александр.\n Версия: 1.0.0");
        }

        private void открытьToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Все файлы|*.*|XML files|*.XML";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                database = new BelieveOrNotBelive(dialog.FileName);
              
                database.Load();

                
                
            }
        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            database.FileName = "data.XML";
            database.Save();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblQuestion.Text = database.List[numOfQuestion].text;
            lblScores.Text = countOfRightAnswers.ToString();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (database.List[numOfQuestion].trueFalse)
            {
                countOfRightAnswers += 1;
                lblScores.Text = countOfRightAnswers.ToString();   
            }
            IndexOfArray(ref numOfQuestion, database);
            lblQuestion.Text = database.List[numOfQuestion].text;
            lblScores.Text = countOfRightAnswers.ToString();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            if (!database.List[numOfQuestion].trueFalse)
            {
                countOfRightAnswers += 1;
                lblScores.Text = countOfRightAnswers.ToString();
            }
            IndexOfArray(ref numOfQuestion, database);
            lblQuestion.Text = database.List[numOfQuestion].text;
            lblScores.Text = countOfRightAnswers.ToString();
        }

        private void btnDontKnow_Click(object sender, EventArgs e)
        {
            IndexOfArray(ref numOfQuestion, database);
            lblQuestion.Text = database.List[numOfQuestion].text;
            lblScores.Text = countOfRightAnswers.ToString();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
