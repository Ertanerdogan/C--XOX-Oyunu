using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOX_C_
{
    public partial class Form1 : Form
    {
        int sayac = 0;
        string[] tahta = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        bool gameover = false;
        public string kazanan_kontrol()
        {
            if (tahta[1] == tahta[2] && tahta[2] == tahta[3])
            {
                gameover = true;
                return tahta[1];
            }
            else if (tahta[4] == tahta[5] && tahta[5] == tahta[6])
            {
                gameover = true;
                return tahta[4];
            }
            else if (tahta[7] == tahta[8] && tahta[8] == tahta[9])
            {
                gameover = true;
                return tahta[7];
            }
            else if (tahta[1] == tahta[4] && tahta[4] == tahta[7])
            {
                gameover = true;
                return tahta[1];
            }
            else if (tahta[2] == tahta[5] && tahta[5] == tahta[8])
            {
                gameover = true;
                return tahta[2];
            }
            else if (tahta[3] == tahta[6] && tahta[6] == tahta[9])
            {
                gameover = true;
                return tahta[3];
            }
            else if (tahta[1] == tahta[5] && tahta[5] == tahta[9])
            {
                gameover = true;
                return tahta[1];
            }
            else if (tahta[3] == tahta[5] && tahta[5] == tahta[7])
            {
                gameover = true;
                return tahta[3];
            }
            gameover = false;
            return " ";

        }

        public int bos_kontrol()
        {
            int bos_alan = 9;
            if (tahta[1] == "1")
            {
                bos_alan--;
            }
            if (tahta[2] == "2")
            {
                bos_alan--;
            }
            if (tahta[3] == "3")
            {
                bos_alan--;
            }
            if (tahta[4] == "4")
            {
                bos_alan--;
            }
            if (tahta[4] == "4")
            {
                bos_alan--;
            }
            if (tahta[5] == "5")
            {
                bos_alan--;
            }
            if (tahta[6] == "6")
            {
                bos_alan--;
            }
            if (tahta[7] == "7")
            {
                bos_alan--;
            }
            if (tahta[8] == "8")
            {
                bos_alan--;
            }
            if (tahta[9] == "9")
            {
                bos_alan--;
            }

            return bos_alan;
        }

        public Form1()
        {
            InitializeComponent();
            string kazanan = kazanan_kontrol();
            int bos_alan = bos_kontrol();
            if(kazanan != " ")
            {
                MessageBox.Show("Kazanan : " + kazanan);
                sifirla();
            }
            else if(kazanan == " " && bos_alan == 0)
            {
                MessageBox.Show("Berabere");
                sifirla();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kazanan = kazanan_kontrol();
            int bos = bos_kontrol();

            if (gameover == false)
            {
                if (tahta[1] == "1")
                {
                    tahta[1] = sira_label.Text;
                    button1.Text = sira_label.Text;
                    sayac++;
                }
                else
                {
                    MessageBox.Show("Geçersiz hamle !");
                }
            }

            kazanan = kazanan_kontrol();
            bos = bos_kontrol();

            if (gameover == true)
            {
                if (kazanan != " ")
                {
                    MessageBox.Show("Kazanan : " + kazanan);
                    sifirla();
                }
                else if (kazanan == " " || bos == 0)
                {
                    MessageBox.Show("Berabere");
                    sifirla();
                }
            }

            if (sayac % 2 == 0)
            {
                sira_label.Text = "X";
            }
            else if (sayac % 2 == 1)
            {
                sira_label.Text = "O";
            }

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            string kazanan = kazanan_kontrol();
            int bos = bos_kontrol();

            if (gameover == false)
            {
                if (tahta[2] == "2")
                {
                    tahta[2] = sira_label.Text;
                    button2.Text = sira_label.Text;
                    sayac++;
                }
                else
                {
                    MessageBox.Show("Geçersiz hamle !");
                }
            }

            kazanan = kazanan_kontrol();
            bos = bos_kontrol();

            if (gameover == true)
            {
                if (kazanan != " ")
                {
                    MessageBox.Show("Kazanan : " + kazanan);
                    sifirla();
                }
                else if (kazanan == " " || bos == 0)
                {
                    MessageBox.Show("Berabere");
                    sifirla();
                }
            }

            if (sayac % 2 == 0)
            {
                sira_label.Text = "X";
            }
            else if (sayac % 2 == 1)
            {
                sira_label.Text = "O";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kazanan = kazanan_kontrol();
            int bos = bos_kontrol();

            if (gameover == false)
            {
                if (tahta[3] == "3")
                {
                    tahta[3] = sira_label.Text;
                    button3.Text = sira_label.Text;
                    sayac++;
                }
                else
                {
                    MessageBox.Show("Geçersiz hamle !");
                }
            }

            kazanan = kazanan_kontrol();
            bos = bos_kontrol();

            if (gameover == true)
            {
                if (kazanan != " ")
                {
                    MessageBox.Show("Kazanan : " + kazanan);
                    sifirla();
                }
                else if (kazanan == " " || bos == 0)
                {
                    MessageBox.Show("Berabere");
                    sifirla();
                }
            }

            if (sayac % 2 == 0)
            {
                sira_label.Text = "X";
            }
            else if (sayac % 2 == 1)
            {
                sira_label.Text = "O";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string kazanan = kazanan_kontrol();
            int bos = bos_kontrol();

            if (gameover == false)
            {
                if (tahta[4] == "4")
                {
                    tahta[4] = sira_label.Text;
                    button4.Text = sira_label.Text;
                    sayac++;
                }
                else
                {
                    MessageBox.Show("Geçersiz hamle !");
                }
            }

            kazanan = kazanan_kontrol();
            bos = bos_kontrol();

            if (gameover == true)
            {
                if (kazanan != " ")
                {
                    MessageBox.Show("Kazanan : " + kazanan);
                    sifirla();
                }
                else if (kazanan == " " || bos == 0)
                {
                    MessageBox.Show("Berabere");
                    sifirla();
                }
            }

            if (sayac % 2 == 0)
            {
                sira_label.Text = "X";
            }
            else if (sayac % 2 == 1)
            {
                sira_label.Text = "O";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string kazanan = kazanan_kontrol();
            int bos = bos_kontrol();

            if (gameover == false)
            {
                if (tahta[5] == "5")
                {
                    tahta[5] = sira_label.Text;
                    button5.Text = sira_label.Text;
                    sayac++;
                }
                else
                {
                    MessageBox.Show("Geçersiz hamle !");
                }
            }

            kazanan = kazanan_kontrol();
            bos = bos_kontrol();

            if (gameover == true)
            {
                if (kazanan != " ")
                {
                    MessageBox.Show("Kazanan : " + kazanan);
                    sifirla();
                }
                else if (kazanan == " " || bos == 0)
                {
                    MessageBox.Show("Berabere");
                    sifirla();
                }
            }

            if (sayac % 2 == 0)
            {
                sira_label.Text = "X";
            }
            else if (sayac % 2 == 1)
            {
                sira_label.Text = "O";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string kazanan = kazanan_kontrol();
            int bos = bos_kontrol();

            if (gameover == false)
            {
                if (tahta[6] == "6")
                {
                    tahta[6] = sira_label.Text;
                    button6.Text = sira_label.Text;
                    sayac++;
                }
                else
                {
                    MessageBox.Show("Geçersiz hamle !");
                }
            }

            kazanan = kazanan_kontrol();
            bos = bos_kontrol();

            if (gameover == true)
            {
                if (kazanan != " ")
                {
                    MessageBox.Show("Kazanan : " + kazanan);
                    sifirla();
                }
                else if (kazanan == " " || bos == 0)
                {
                    MessageBox.Show("Berabere");
                    sifirla();
                }
            }

            if (sayac % 2 == 0)
            {
                sira_label.Text = "X";
            }
            else if (sayac % 2 == 1)
            {
                sira_label.Text = "O";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string kazanan = kazanan_kontrol();
            int bos = bos_kontrol();

            if (gameover == false)
            {
                if (tahta[7] == "7")
                {
                    tahta[7] = sira_label.Text;
                    button7.Text = sira_label.Text;
                    sayac++;
                }
                else
                {
                    MessageBox.Show("Geçersiz hamle !");
                }
            }

            kazanan = kazanan_kontrol();
            bos = bos_kontrol();

            if (gameover == true)
            {
                if (kazanan != " ")
                {
                    MessageBox.Show("Kazanan : " + kazanan);
                    sifirla();
                }
                else if (kazanan == " " || bos == 0)
                {
                    MessageBox.Show("Berabere");
                    sifirla();
                }
            }

            if (sayac % 2 == 0)
            {
                sira_label.Text = "X";
            }
            else if (sayac % 2 == 1)
            {
                sira_label.Text = "O";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string kazanan = kazanan_kontrol();
            int bos = bos_kontrol();

            if (gameover == false)
            {
                if (tahta[8] == "8")
                {
                    tahta[8] = sira_label.Text;
                    button8.Text = sira_label.Text;
                    sayac++;
                }
                else
                {
                    MessageBox.Show("Geçersiz hamle !");
                }
            }

            kazanan = kazanan_kontrol();
            bos = bos_kontrol();

            if (gameover == true)
            {
                if (kazanan != " ")
                {
                    MessageBox.Show("Kazanan : " + kazanan);
                    sifirla();
                }
                else if (kazanan == " " || bos == 0)
                {
                    MessageBox.Show("Berabere");
                    sifirla();
                }
            }

            if (sayac % 2 == 0)
            {
                sira_label.Text = "X";
            }
            else if (sayac % 2 == 1)
            {
                sira_label.Text = "O";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string kazanan = kazanan_kontrol();
            int bos = bos_kontrol();

            if (gameover == false)
            {
                if (tahta[9] == "9")
                {
                    tahta[9] = sira_label.Text;
                    button9.Text = sira_label.Text;
                    sayac++;
                }
                else
                {
                    MessageBox.Show("Geçersiz hamle !");
                }
            }

            kazanan = kazanan_kontrol();
            bos = bos_kontrol();

            if (gameover == true)
            {
                if (kazanan != " ")
                {
                    MessageBox.Show("Kazanan : " + kazanan);
                    sifirla();
                }
                else if (kazanan == " " || bos == 0)
                {
                    
                    MessageBox.Show("Berabere");
                    sifirla();
                }
            }

            if (sayac % 2 == 0)
            {
                sira_label.Text = "X";
            }
            else if (sayac % 2 == 1)
            {
                sira_label.Text = "O";
            }
        }
        private void sifirla()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            sayac = 0;
            tahta[1] = "1";
            tahta[2] = "2";
            tahta[3] = "3";
            tahta[4] = "4";
            tahta[5] = "5";
            tahta[6] = "6";
            tahta[7] = "7";
            tahta[8] = "8";
            tahta[9] = "9";
            sira_label.Text = "X";
        }
        private void tekrar_buton_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            sayac = 0;
            tahta[1] = "1";
            tahta[2] = "2";
            tahta[3] = "3";
            tahta[4] = "4";
            tahta[5] = "5";
            tahta[6] = "6";
            tahta[7] = "7";
            tahta[8] = "8";
            tahta[9] = "9";
            sira_label.Text = "X";
            
        }
    }
}
