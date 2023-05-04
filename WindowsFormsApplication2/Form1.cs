using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        int[,] mas = new int[1,1];
        Random rand = new Random();
        int r = 1;
        int rr = 1;
        int lik = 0;
        int k = 1;
        int l = 1;




        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("", "");
            dataGridView1.Rows.Add("", " ");
           // label4.Text = "STR =" + dataGridView1.Rows.Count + "\nK ="+k + "\nRr="+rr;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < k; i++)
            {
                string al = "";
                for (int a = 0; a < l; a++)
                {
                    mas[i, a] = rand.Next(0, 256);
                    dataGridView1.Rows[i].Cells[a].Value = mas[i, a];

                }
               // dataGridView1.i
            }
       
            //label1.Text ="сума между первым и последними индексами:\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // int ser = mas[,];
            int[] som = new int[l] ;
            if (k % 2 == 0)
            {
                for (int i = 0; i < k; i=i+2)
                {

                    for (int a = 0; a < l; a++)
                    {
                        som[a]=mas[i+1,a];
                        mas[i + 1, a] = mas[i, a];
                        mas[i, a] = som[a];
                    }

                }
                for (int i = 0; i < k; i++)
                {

                    for (int a = 0; a < l; a++)
                    {
                        dataGridView1.Rows[i].Cells[a].Value = mas[i, a];
                    }

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                //comboBox1.Visible = true;
                dataGridView1.ReadOnly = false;
            }
            else
            {
                comboBox1.Visible = false;
                dataGridView1.ReadOnly = true;
            }

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
           // numericUpDown2.Value 



            numericUpDown2.Minimum = 1;
            numericUpDown2.Maximum = 256;
            k = Convert.ToInt32(numericUpDown2.Value.ToString());
            mas = new int[k,l];
           
            if (rr - k < 0)
            {
                rr++;
                dataGridView1.Rows.Add(" ", "" );
            }

            if (rr - k > 0)
            {
                dataGridView1.Rows.RemoveAt(k-1);
                rr--;
            }
           // label4.Text = "STR =" + dataGridView1.Rows.Count + "\nK =" + k + "\nR=" + rr;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 256;
            l = Convert.ToInt32(numericUpDown1.Value.ToString());
            mas = new int[k,l];
            
            if (r - l<0)
            {
                r++;
                dataGridView1.Columns.Add("", " ");
            }

            if (r - l>0)
            {
                dataGridView1.Columns.RemoveAt(r-1);
                r--;
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                button1.Visible = true;

            }
            else
            {
                button1.Visible = false;
            }
        }
    }
}
