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
    public partial class CreatePers : Form
    {
        public CreatePers(string Name1)
        {
            InitializeComponent();
            this.name = Name1;

            pictureFon.SendToBack();
            
        }

        string name;

        //навыки
        int NavSob = 20;
        int NavHunt = 20;
        int NavFish = 20;
        int NavBuild = 20;
        int NavNauka = 20;
        int NavMed = 20;

        private void SpecAdd_ValueChanged(object sender, EventArgs e)
        {
            
        }



        // прибавляет силу на 1
        private void SpecSPlus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(SpecS.Text) < 10 && Convert.ToInt16(SpecAdd.Text)>0)
            {
                SpecS.Text = Convert.ToString (Convert.ToInt16(SpecS.Text) + 1) ;
            }
        }
        // убавляет силу на 1
        private void SpecSMin_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(SpecS.Text) > 1)
            {
                SpecS.Text = Convert.ToString(Convert.ToInt16(SpecS.Text) - 1);
            }
        }

        private void SpecPPlus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(SpecP.Text) < 10 && Convert.ToInt16(SpecAdd.Text) > 0)
            {
                SpecP.Text = Convert.ToString(Convert.ToInt16(SpecP.Text) + 1);
            }
        }

        private void SpecPMin_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(SpecP.Text) > 1)
            {
                SpecP.Text = Convert.ToString(Convert.ToInt16(SpecP.Text) - 1);
            }
        }

        //Метод обновления статов
        void Refresh_Stat()
        {
            labelHP.Text = Convert.ToString ( 15 + Convert.ToInt16(SpecS.Text) + 2 * (Convert.ToInt16(SpecE.Text)) ); //здоровье
            labelDef.Text = Convert.ToString(Convert.ToInt16(SpecA.Text));
            labelOD.Text = Convert.ToString( (Convert.ToInt16(SpecA.Text)/2 ) + 5 ); // подсчет ОД относительно ловкости. ОД = ЛВ/2 +5
            //Подсчет урона. Урон=Сила-5, но не меньше 1.
            if ((Convert.ToInt16(SpecS.Text) - 5) > 0)
            {
                labelDamage.Text = Convert.ToString(Convert.ToInt16(SpecS.Text) - 5);
            }
            else
            {
                labelDamage.Text = "1";
            }

            //дополнительные очки SPECIAL
            SpecAdd.Text = Convert.ToString(40 - Convert.ToInt16(SpecS.Text) - Convert.ToInt16(SpecP.Text) - Convert.ToInt16(SpecE.Text) - Convert.ToInt16(SpecC.Text) - Convert.ToInt16(SpecI.Text) - Convert.ToInt16(SpecA.Text) - Convert.ToInt16(SpecL.Text));
            
            //вывод имени
            labelName.Text = name;
            

            //навыки. вывод
            navSob.Text = Convert.ToString(NavSob + Convert.ToInt16(SpecP.Text) * 2) + "%";
            navHunt.Text = Convert.ToString(NavHunt + Convert.ToInt16(SpecP.Text) + Convert.ToInt16(SpecS.Text)) + "%";
            navFish.Text = Convert.ToString(NavFish + Convert.ToInt16(SpecE.Text) + Convert.ToInt16(SpecA.Text)) + "%";
            navBuild.Text = Convert.ToString(NavBuild + Convert.ToInt16(SpecI.Text) + Convert.ToInt16(SpecE.Text)) + "%";
            navNauka.Text = Convert.ToString(NavNauka + Convert.ToInt16(SpecI.Text) + Convert.ToInt16(SpecP.Text)) + "%";
            navMed.Text = Convert.ToString(NavMed + Convert.ToInt16(SpecI.Text) + Convert.ToInt16(SpecA.Text)) + "%";
        }
        // Таймер для обновления статов
        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh_Stat();
        }

        private void SpecEPlus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(SpecE.Text) < 10 && Convert.ToInt16(SpecAdd.Text) > 0)
            {
                SpecE.Text = Convert.ToString(Convert.ToInt16(SpecE.Text) + 1);
            }
        }

        private void SpecEMin_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(SpecE.Text) > 1)
            {
                SpecE.Text = Convert.ToString(Convert.ToInt16(SpecE.Text) - 1);
            }
        }

        private void SpecCPlus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(SpecC.Text) < 10 && Convert.ToInt16(SpecAdd.Text) > 0)
            {
                SpecC.Text = Convert.ToString(Convert.ToInt16(SpecC.Text) + 1);
            }
        }

        private void SpecCMin_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(SpecC.Text) > 1)
            {
                SpecC.Text = Convert.ToString(Convert.ToInt16(SpecC.Text) - 1);
            }
        }

        private void SpecIPlus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(SpecI.Text) < 10 && Convert.ToInt16(SpecAdd.Text) > 0)
            {
                SpecI.Text = Convert.ToString(Convert.ToInt16(SpecI.Text) + 1);
            }
        }

        private void SpecIMin_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(SpecI.Text) > 1)
            {
                SpecI.Text = Convert.ToString(Convert.ToInt16(SpecI.Text) - 1);
            }
        }

        private void SpecAPlus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(SpecA.Text) < 10 && Convert.ToInt16(SpecAdd.Text) > 0)
            {
                SpecA.Text = Convert.ToString(Convert.ToInt16(SpecA.Text) + 1);
            }
        }

        private void SpecAMin_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(SpecA.Text) > 1)
            {
                SpecA.Text = Convert.ToString(Convert.ToInt16(SpecA.Text) - 1);
            }
        }

        private void SpecLPlus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(SpecL.Text) < 10 && Convert.ToInt16(SpecAdd.Text) > 0)
            {
                SpecL.Text = Convert.ToString(Convert.ToInt16(SpecL.Text) + 1);
            }
        }

        private void SpecLMin_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(SpecL.Text) > 1)
            {
                SpecL.Text = Convert.ToString(Convert.ToInt16(SpecL.Text) - 1);
            }
        }

        private void buttomClose_Click(object sender, EventArgs e)
        {
            this.Close();

            var enter_form = Program.GetFormByName("Enter");
            enter_form.Show();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //забираем параметры для передачи в другую форму
            int hp = Convert.ToInt16(labelHP.Text);
            int def = Convert.ToInt16(labelDef.Text);
            int OD = Convert.ToInt16(labelOD.Text);
            int damage = Convert.ToInt16(labelDamage.Text);
            int[] param = {hp, def, OD, damage };

            Island form = new Island(param, name);
            this.Close();
            form.Show();
             
        }

        






    }
}
