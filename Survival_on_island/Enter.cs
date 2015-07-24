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
        /// <summary>
        /// Глобальный персонаж, который может вызываться из любой формы.
        /// </summary>
        /// <example>
        /// var pers = Program.pers;
        /// </example>
        public Pers pers;

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
            this.Hide();
            form.Show();
        }

        private void buttonContin_Click(object sender, EventArgs e)
        {
            name = textBoxName.Text;
            CreatePers CP = new CreatePers(name);
            Enter En = new Enter();
            this.Hide();
            CP.Show();
        }
    }
}
