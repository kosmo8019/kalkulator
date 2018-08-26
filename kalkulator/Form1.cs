using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string liczbaPierwsza;
        string liczbaDruga;
        
        char dzialanie = ' ';


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void buttonDzielenie_Click(object sender, EventArgs e)
        {
            dzialanie = '/';
            textWynik.Text = "";

        }

        private void buttonMnozenie_Click(object sender, EventArgs e)
        {
            dzialanie = '*';
            textWynik.Text = "";
        }

        private void buttonOdejmowanie_Click(object sender, EventArgs e)
        {
            dzialanie = '-';
            textWynik.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            dzialanie = '+';
            textWynik.Text = "";
        }

        private void buttonWynik_Click(object sender, EventArgs e)
        {
            switch (dzialanie)
            {
                case ('+'):
                    textWynik.Text = (int.Parse(liczbaPierwsza) + int.Parse(liczbaDruga)).ToString();
                    break;

                case ('-'):
                    textWynik.Text = (int.Parse(liczbaPierwsza) - int.Parse(liczbaDruga)).ToString();
                    break;

                case ('*'):
                    textWynik.Text = (int.Parse(liczbaPierwsza) * int.Parse(liczbaDruga)).ToString();
                    break;

                case ('/'):
                    textWynik.Text = (int.Parse(liczbaPierwsza) / int.Parse(liczbaDruga)).ToString();
                    break;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            funkcjaDzialanie(0);
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            funkcjaDzialanie(9);
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            funkcjaDzialanie(8);
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            funkcjaDzialanie(7);
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            funkcjaDzialanie(6);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            funkcjaDzialanie(5);
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            funkcjaDzialanie(4);
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            funkcjaDzialanie(3);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            funkcjaDzialanie(2);
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            funkcjaDzialanie(1);
            
        }

        private void funkcjaDzialanie(int liczba)
        {
            if (dzialanie == ' ')
            {
                liczbaPierwsza += liczba;
                textWynik.Text = liczbaPierwsza;
            }
            else
            {
                liczbaDruga += liczba;
                textWynik.Text = liczbaDruga;

                  
            }




        }

    }
}
