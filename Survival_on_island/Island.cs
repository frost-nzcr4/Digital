using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Survival_on_island
{
    public partial class Island : Form
    {
        public Island()
        {
            InitializeComponent();
        }

        //++++++++++++++++++
        //Переменные. ресурсы.
        //++++++++++++++++++
        int eat = 0;
        int wood = 0;
        int rock = 0;

        int use1_var1_min = 1;
        int use1_var1_max = 3;
        int use1_var2_min = 3;
        int use1_var2_max = 5;
        int use1_var3_min = 5;
        int use1_var3_max = 7;

        private void buttonContin_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            eat += rand.Next(use1_var1_min, use1_var1_max+1);
            label_eat.Text = Convert.ToString(eat);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            eat += rand.Next(use1_var2_min, use1_var2_max+1);
            label_eat.Text = Convert.ToString(eat);
        }

        private void buttonVer3_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            eat += rand.Next(use1_var3_min, use1_var3_max+1);
            label_eat.Text = Convert.ToString(eat);
        }
    }
}
