using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MENÜ.Items.Clear();
            if (comboBox1.Text == "MENÜ 1")
            {
                MENÜ.Items.Add("Çorba");
                MENÜ.Items.Add("Tas Kebabı");
                MENÜ.Items.Add("pilav");
                MENÜ.Items.Add("Cacık");
                textBox1.Text = "50";
            }
                

                if (comboBox1 .Text == "MENÜ 2")

                {
                    MENÜ.Items.Add("Çorba");
                    MENÜ.Items.Add("Kuru Fasulye");
                    MENÜ.Items.Add("pilav");
                    MENÜ.Items.Add("Salata");
                textBox1.Text = "60";
                }
                 if (comboBox1 .Text == "MENÜ 3")
                {
                    MENÜ.Items.Add("Çorba");
                    MENÜ.Items.Add("Döner");
                    MENÜ.Items.Add("pilav");
                    MENÜ.Items.Add("Tatlı");
                textBox1.Text = "55";
                }
                 
            }

        private void button1_Click(object sender, EventArgs e)
        {
            int menuFiyat, adet, toplamFiyat;
            menuFiyat =int.Parse(textBox1.Text);
            adet = Convert.ToUInt16(numericUpDown1.Value);
            toplamFiyat = menuFiyat * adet;

            textBox2.Text = toplamFiyat.ToString();
            
             
            
        }
    }
    }

    