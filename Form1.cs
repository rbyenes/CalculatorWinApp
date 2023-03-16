using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesiWinApp
{
    public partial class Form1 : Form
    {
        bool _ekranTemizlenmesi;
        int _birinciSayi;
        char _islem;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenmesi)
            {
                ekranLbl.Text = "";
                _ekranTemizlenmesi= false;
            }
            if (ekranLbl.Text == "0") ekranLbl.Text = ""; 
            ekranLbl.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenmesi)
            {
                ekranLbl.Text = "";
                _ekranTemizlenmesi = false;
            }
            if (ekranLbl.Text == "0") ekranLbl.Text = "";
            ekranLbl.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenmesi)
            {
                ekranLbl.Text = "";
                _ekranTemizlenmesi = false;
            }
            if (ekranLbl.Text == "0") ekranLbl.Text = "";
            ekranLbl.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenmesi)
            {
                ekranLbl.Text = "";
                _ekranTemizlenmesi = false;
            }
            if (ekranLbl.Text == "0") ekranLbl.Text = "";
            ekranLbl.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {   
            if (_ekranTemizlenmesi)
            {
                ekranLbl.Text = "";
                _ekranTemizlenmesi = false;
            }
            if (ekranLbl.Text == "0") ekranLbl.Text = "";
            ekranLbl.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {   
            if (_ekranTemizlenmesi)
            {
                ekranLbl.Text = "";
                _ekranTemizlenmesi = false;
            }
            if (ekranLbl.Text == "0") ekranLbl.Text = "";
            ekranLbl.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {   
            if (_ekranTemizlenmesi)
            {
                ekranLbl.Text = "";
                _ekranTemizlenmesi = false;
            }
            if (ekranLbl.Text == "0") ekranLbl.Text = "";
            ekranLbl.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {   
            if (_ekranTemizlenmesi)
            {
                ekranLbl.Text = "";
                _ekranTemizlenmesi = false;
            }
            if (ekranLbl.Text == "0") ekranLbl.Text = "";
            ekranLbl.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {   
            if (_ekranTemizlenmesi)
            {
                ekranLbl.Text = "";
                _ekranTemizlenmesi = false;
            }
            if (ekranLbl.Text == "0") ekranLbl.Text = "";
            ekranLbl.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {   
            if (_ekranTemizlenmesi)
            {
                ekranLbl.Text = "";
                _ekranTemizlenmesi = false;
            }
            if (ekranLbl.Text == "0") ekranLbl.Text = "";
            ekranLbl.Text += "0";
        }

        private void buttonArti_Click(object sender, EventArgs e)
        {
            _birinciSayi = Convert.ToInt32(ekranLbl.Text);
            _ekranTemizlenmesi = true;
            _islem = '+';
        }

        private void buttonEksi_Click(object sender, EventArgs e)
        {
            _birinciSayi = Convert.ToInt32(ekranLbl.Text);
            _ekranTemizlenmesi = true;
            _islem = '-';
        }

        private void buttonCarpi_Click(object sender, EventArgs e)
        {
            _birinciSayi = Convert.ToInt32(ekranLbl.Text);
            _ekranTemizlenmesi = true;
            _islem = '*';
        }

        private void buttonBolu_Click(object sender, EventArgs e)
        {
            _birinciSayi = Convert.ToInt32(ekranLbl.Text);
            _ekranTemizlenmesi = true;
            _islem = '/';
        }

        private void buttonSilme_Click(object sender, EventArgs e)
        {
            ekranLbl.Text = "0";
        }

        private void buttonEsittir_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(ekranLbl.Text);
            int sonuc;

            
            switch (_islem)
            {
                case '+':
                    sonuc = _birinciSayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _birinciSayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = _birinciSayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _birinciSayi / ikinciSayi;
                    break;

                default:
                    sonuc= 0;
                    break;
            }
            ekranLbl.Text = Convert.ToString(sonuc);

        }
    }
}
