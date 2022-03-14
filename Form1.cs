using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAvaliativaBubbleSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] salarios = new int[30];
        int[] index = new int[30];
        private void Button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < 30; i++)
            {
                index[i] = i;
                salarios[i] = r.Next(1500, 10000);
            }

            for (int j = 0; j < 29; j++)
            {
                for (int i = 0; i < 29; i++)
                {
                    int aux = 0;
                    if (salarios[index[i]] > salarios[index[i + 1]])
                    {
                        aux = index[i];
                        index[i] = index[i + 1];
                        index[i + 1] = aux;
                    }
                }
            }

            for (int i = 0; i < 30; i++)
            {
                listBox1.Items.Add(salarios[i]);
                listBox2.Items.Add(index[i]);
                listBox3.Items.Add(salarios[index[i]]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
