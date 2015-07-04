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
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();
        }

        string name = "";

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            name = textBoxName.Text;
            CreatePers form = new CreatePers(name);
            form.Show();
        }

        private void buttonContin_Click(object sender, EventArgs e)
        {
            name = textBoxName.Text;
            CreatePers form = new CreatePers(name);
            form.Show();
        }
    }
}
