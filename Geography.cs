using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geography
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string s in checkedListBox1.CheckedItems)
                listBox1.Items.Add(s);
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            Random Myno = new Random();
            int Maxpictures = 10;
            int numNo = Myno.Next(1, Maxpictures);
            lblCount.Text = numNo.ToString();
            if (numNo == 1)
            {
                btnnext.Enabled = false;
                pictureBox1.Image = Properties.Resources.Brasile;
                listBox1.Enabled = true;
                btnSubmit.Enabled = true;

            }
            else if (numNo == 2)
            {
                btnnext.Enabled = false;
                pictureBox1.Image = Properties.Resources.Israel;
                listBox1.Enabled = true;
                btnSubmit.Enabled = true;

            }
            else if (numNo == 3)
            {
                btnnext.Enabled = false;
                pictureBox1.Image = Properties.Resources.New_York;
                listBox1.Enabled = true;
                btnSubmit.Enabled = true;

            }
            else if (numNo == 4)
            {
                btnnext.Enabled = false;
                pictureBox1.Image = Properties.Resources.Paris;
                listBox1.Enabled = true;
                btnSubmit.Enabled = true;

            }
            else if (numNo == 5)
            {
                btnnext.Enabled = false;
                pictureBox1.Image = Properties.Resources.Rome;
                listBox1.Enabled = true;
                btnSubmit.Enabled = true;

            }
            else if (numNo == 6)
            {
                btnnext.Enabled = false;
                pictureBox1.Image = Properties.Resources.Russia;
                listBox1.Enabled = true;
                btnSubmit.Enabled = true;

            }
            else if (numNo == 7)
            {
                btnnext.Enabled = false;
                pictureBox1.Image = Properties.Resources.Africa;
                listBox1.Enabled = true;
                btnSubmit.Enabled = true;

            }
            else if (numNo == 8)
            {
                btnnext.Enabled = false;
                pictureBox1.Image = Properties.Resources.Miami;
                listBox1.Enabled = true;
                btnSubmit.Enabled = true;

            }
            else if (numNo == 9)
            {
                btnnext.Enabled = false;
                pictureBox1.Image = Properties.Resources.Antartica;
                listBox1.Enabled = true;
                btnSubmit.Enabled = true;

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if ((lblCount.Text == "1") && (listBox1.Text == "Brazil"))
            {
                MessageBox.Show("Brasil is located in the South America");
                btnnext.Enabled = true;
                MessageBox.Show("YOU GOT THE GOOD PLACE!!!!!!!!!");
            }
            else if ((lblCount.Text == "2") && (listBox1.Text == "Israel"))
            {
                MessageBox.Show("Israel is a country in Western Asia, located on the southeastern shore of the Mediterranean Sea");
                btnnext.Enabled = true;
                MessageBox.Show("YOU GOT THE GOOD PLACE!!!!!!!!!");
            }
            else if ((lblCount.Text == "3") && (listBox1.Text == "New York"))
            {
                MessageBox.Show("New York City is situated in the northeastern United States, in southeastern New York State");
                btnnext.Enabled = true;
                MessageBox.Show("YOU GOT THE GOOD PLACE!!!!!!!!!");
            }
            else if ((lblCount.Text == "4") && (listBox1.Text == "France"))
            {
                MessageBox.Show("Paris is located in northern central France, in a north-bending arc of the river Seine");
                btnnext.Enabled = true;
                MessageBox.Show("YOU GOT THE GOOD PLACE!!!!!!!!!");
            }
            else if ((lblCount.Text == "5") && (listBox1.Text == "Italy"))
            {
                MessageBox.Show("Rome is in the Lazio region of central Italy on the Tiber (Italian: Tevere) river.");
                btnnext.Enabled = true;
                MessageBox.Show("YOU GOT THE GOOD PLACE!!!!!!!!!");
            }

            else if ((lblCount.Text == "6") && (listBox1.Text == "Russie"))
            {
                MessageBox.Show("Russia: Россия, Rossiya, or the Russian Federation, is a transcontinental country spanning Eastern Europe.");
                btnnext.Enabled = true;
                MessageBox.Show("YOU GOT THE GOOD PLACE!!!!!!!!!");
            }
            else if ((lblCount.Text == "7") && (listBox1.Text == "Africa"))
            {
                MessageBox.Show("Africa is a continent of planet Earth, the third by surface, crossed by the equator and the tropics of Cancer and Capricorn and, therefore, characterized by a great variety of climates and environments, such as deserts, savannahs and rainforests.");
                btnnext.Enabled = true;
                MessageBox.Show("YOU GOT THE GOOD PLACE!!!!!!!!!");
            }
            else if ((lblCount.Text == "8") && (listBox1.Text == "Miami Beach"))
            {
                MessageBox.Show("Miami Beach is an island in southern Florida, connected by bridges to mainland Miami. Wide beaches stretch from the North Shore Open Space Park, past the palm-fringed Lummus Park, and into South Pointe Park");
                btnnext.Enabled = true;
                MessageBox.Show("YOU GOT THE GOOD PLACE!!!!!!!!!");
            }
            else if ((lblCount.Text == "9") && (listBox1.Text == "Antartica"))
            {
                MessageBox.Show("Antarctica is the continent located in the southern hemisphere of the Earth, surrounding the South Pole and opposite the Arctic, comprising the lands and seas included within the Antarctic Circle");
                btnnext.Enabled = true;
                MessageBox.Show("YOU GOT THE GOOD PLACE!!!!!!!!!");
            }
            else
            {
                MessageBox.Show("NO!!!!!TRY AGAINNN!!!!!!!!!!!");
            }
        }
    }
}
