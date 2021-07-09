using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeirdreAndGintaCA 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuickPick_Click(object sender, EventArgs e)
        {
            Random quickPick = new Random();//declare random

            for (int i = 0; i < 6; i++)
            {
              
                lstQuickPick.Items.Add(quickPick.Next(1, 50));//add random 1-49 had to put 50 as if put down 49 will only show 1-48
                lstQuickPick.Items.Add("");
                btnQuickPick.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstQuickPick.Items.Clear();
            lstSort.Items.Clear();
            btnQuickPick.Enabled = true;
            btnSort.Enabled = true;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] lotto = lstQuickPick.Items.OfType<int>().ToArray();//make listbox into array
            Array.Sort(lotto); //sort
            for (int i = 0; i <lotto.Length; i++)
            {
                lstSort.Items.Add(lotto[i].ToString()); 
                lstSort.Items.Add("");
            }

            btnSort.Enabled = false;
            
        }
    }
}
