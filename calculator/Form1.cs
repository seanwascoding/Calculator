using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        // declared
        Model cal_mol;
        List<char> temp = new List<char>();
        bool state = false;

        // windows instance
        public Form1(Model c)
        {
            this.cal_mol = c;
            InitializeComponent();
        }
       
        // Method
        private void Plus_Click(object sender, EventArgs e)
        {
            if (temp.Count == 0)
            {
                MessageBox.Show("pls Enter the num");
                return;
            }
            else
            {
                if(state && temp.Count > 1)
                {
                    MessageBox.Show("Reset first");
                    return;
                }
            }
            cal_mol.setTemp(double.Parse(new string(temp.ToArray())));
            Results.Text = cal_mol.Sum().ToString();
            cal_mol.setMethod("+");
            temp.Clear();
        }
        private void Minus_Click(object sender, EventArgs e)
        {
            if (temp.Count == 0)
            {
                MessageBox.Show("pls Enter the num");
                return;
            }
            else
            {
                if (state && temp.Count > 1)
                {
                    MessageBox.Show("Reset first");
                    return;
                }
            }
            cal_mol.setTemp(double.Parse(new string(temp.ToArray())));
            Results.Text = cal_mol.Sum().ToString();
            cal_mol.setMethod("-");
            temp.Clear();
        }
        private void Times_Click(object sender, EventArgs e)
        {
            if (temp.Count == 0)
            {
                MessageBox.Show("pls Enter the num");
                return;
            }
            else
            {
                if (state && temp.Count > 1)
                {
                    MessageBox.Show("Reset first");
                    return;
                }
            }
            cal_mol.setTemp(double.Parse(new string(temp.ToArray())));
            Results.Text = cal_mol.Sum().ToString();
            cal_mol.setMethod("x");
            temp.Clear();
        }
        private void Slash_Click(object sender, EventArgs e)
        {
            if (temp.Count == 0)
            {
                MessageBox.Show("pls Enter the num");
                return;
            }
            else
            {
                if (state && temp.Count > 1)
                {
                    MessageBox.Show("Reset first");
                    return;
                }
            }
            cal_mol.setTemp(double.Parse(new string(temp.ToArray())));
            Results.Text = cal_mol.Sum().ToString();
            cal_mol.setMethod("/");
            temp.Clear();
        }
        private void Equal_Click(object sender, EventArgs e)
        {
            if (temp.Count == 0)
            {
                MessageBox.Show("pls Enter the num");
            }
            else
            {
                if (state && temp.Count > 1)
                {
                    MessageBox.Show("Reset first");
                    return;
                }
                cal_mol.setTemp(double.Parse(new string(temp.ToArray())));
                Results.Text = cal_mol.Sum().ToString();
                temp.Clear();
                cal_mol.setMethod("+");
                temp.Add('0');
                state = true;
            }
        }

        // Reset Button
        private void Clear_Click(object sender, EventArgs e)
        {
            cal_mol.Intialize();
            temp.Clear();
            Results.Text = "";
            state = false;
        }
        private void Clear_Entry_Click(object sender, EventArgs e)
        {
            if (temp.Count == 0 || new string(temp.ToArray()) == "0")
            {
                MessageBox.Show("pls Enter the num");
            }
            else
            {
                temp.Clear();
                Results.Text = "";
            }
        }

        // Numbers
        private void Zero_Click(object sender, EventArgs e)
        {
            temp.Add('0');
            Results.Text = new string(temp.ToArray());
        }
        private void One_Click(object sender, EventArgs e)
        {
            temp.Add('1');
            Results.Text = new string(temp.ToArray());
        }
        private void Two_Click(object sender, EventArgs e)
        {
            temp.Add('2');
            Results.Text = new string(temp.ToArray());
        }
        private void Three_Click(object sender, EventArgs e)
        {
            temp.Add('3');
            Results.Text = new string(temp.ToArray());
        }
        private void Four_Click(object sender, EventArgs e)
        {
            temp.Add('4');
            Results.Text = new string(temp.ToArray());
        }
        private void Five_Click(object sender, EventArgs e)
        {
            temp.Add('5');
            Results.Text = new string(temp.ToArray());
        }
        private void Six_Click(object sender, EventArgs e)
        {
            temp.Add('6');
            Results.Text = new string(temp.ToArray());
        }
        private void Seven_Click(object sender, EventArgs e)
        {
            temp.Add('7');
            Results.Text = new string(temp.ToArray());
        }
        private void Eight_Click(object sender, EventArgs e)
        {
            temp.Add('8');
            Results.Text = new string(temp.ToArray());
        }
        private void Nine_Click(object sender, EventArgs e)
        {
            temp.Add('9');
            Results.Text = new string(temp.ToArray());
        }
        private void Dot_Click(object sender, EventArgs e)
        {
            temp.Add('.');
            Results.Text = new string(temp.ToArray());
        } 
    }
}
