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
        private Pers pers;

        public CreatePers(string Name1)
        {
            InitializeComponent();
            
            pictureFon.SendToBack();

            var form = (Enter) Program.GetFormByName ("Enter");
            form.pers = new Pers(Name1);
            this.pers = form.pers;
        }

        //начальные навыки
        int NavDefault = 20; //Кол-во % навыков по-умолчанию. Необходимо для ввода уровней сложности.

        //Характеристики
        int SpecialAll = 40;       //Всего навыков

        //Метод обновления статов
        void Refresh_Stat()
        {
            //Вывод имени
            labelName.Text = pers.name;

            //Выводим характеристики на экран
            SpecS.Text = Convert.ToString(pers.Strength);
            SpecP.Text = Convert.ToString(pers.Perception);
            SpecE.Text = Convert.ToString(pers.Endurance);
            SpecC.Text = Convert.ToString(pers.Will);
            SpecI.Text = Convert.ToString(pers.Intelligence);
            SpecA.Text = Convert.ToString(pers.Agility);
            SpecL.Text = Convert.ToString(pers.Luck);
            SpecialAll = 40 - (pers.Strength + pers.Perception + pers.Endurance + pers.Will + pers.Intelligence + pers.Agility + pers.Luck);
            SpecAdd.Text = Convert.ToString(SpecialAll);

            //Считаем и выводим основые параметры. HP, Защита, ОД, Урон, Мораль.
            pers.hp = pers.Strength + (2*pers.Endurance) + 15;
            labelHP.Text = Convert.ToString(pers.hp);
            pers.def = pers.Agility;
            labelDef.Text = Convert.ToString(pers.def);
            pers.od = (pers.Agility/2) + 5;
            labelOD.Text = Convert.ToString(pers.od);
            pers.damage = pers.Strength;
            labelDamage.Text = Convert.ToString(pers.damage);
            pers.morality = 20 + (pers.Will * 4);
            labelMorality.Text = Convert.ToString(pers.morality);

            //Подсчет и вывод навыков
            pers.NavSob = NavDefault + (pers.Perception * 2);
            labelNavSob.Text = Convert.ToString(pers.NavSob);
            pers.NavHunt = NavDefault + pers.Perception + pers.Agility;
            labelNavHunt.Text = Convert.ToString(pers.NavHunt);
            pers.NavFish = NavDefault + pers.Will + pers.Will;
            labelNavFish.Text = Convert.ToString(pers.NavFish);
            pers.NavCraft = NavDefault + (pers.Intelligence * 2);
            labelNavCraft.Text = Convert.ToString(pers.NavCraft);
            pers.NavMining = NavDefault + pers.Strength + pers.Endurance;
            labelNavMining.Text = Convert.ToString(pers.NavMining);
            pers.NavWood = NavDefault + pers.Strength + pers.Agility;
            labelNavWood.Text = Convert.ToString(pers.NavWood);
        }

        // Таймер для обновления статов
        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh_Stat();
        }



        // прибавляет силу на 1
        private void SpecSPlus_Click(object sender, EventArgs e)
        {
            if (pers.Strength < 10 && SpecialAll > 0)
            {
                pers.Strength++;
            }
        }
        // убавляет силу на 1
        private void SpecSMin_Click(object sender, EventArgs e)
        {
            if (pers.Strength > 2)
            {
                pers.Strength--;
            }
        }

        private void SpecPPlus_Click(object sender, EventArgs e)
        {
            if (pers.Perception < 10 && SpecialAll > 0)
            {
                pers.Perception++;
            }
        }

        private void SpecPMin_Click(object sender, EventArgs e)
        {
            if (pers.Perception > 2)
            {
                pers.Perception--;
            }
        }

        

        private void SpecEPlus_Click(object sender, EventArgs e)
        {
            if (pers.Endurance < 10 && SpecialAll > 0)
            {
                pers.Endurance++;
            }
        }

        private void SpecEMin_Click(object sender, EventArgs e)
        {
            if (pers.Endurance > 2)
            {
                pers.Endurance--;
            }
        }

        private void SpecCPlus_Click(object sender, EventArgs e)
        {
            if (pers.Will < 10 && SpecialAll > 0)
            {
                pers.Will++;
            }
        }

        private void SpecCMin_Click(object sender, EventArgs e)
        {
            if (pers.Will > 2)
            {
                pers.Will--;
            }
        }

        private void SpecIPlus_Click(object sender, EventArgs e)
        {
            if (pers.Intelligence < 10 && SpecialAll > 0)
            {
                pers.Intelligence++;
            }
        }

        private void SpecIMin_Click(object sender, EventArgs e)
        {
            if (pers.Intelligence > 2)
            {
                pers.Intelligence--;
            }
        }

        private void SpecAPlus_Click(object sender, EventArgs e)
        {
            if (pers.Agility < 10 && SpecialAll > 0)
            {
                pers.Agility++;
            }
        }

        private void SpecAMin_Click(object sender, EventArgs e)
        {
            if (pers.Agility > 2)
            {
                pers.Agility--;
            }
        }

        private void SpecLPlus_Click(object sender, EventArgs e)
        {
            if (pers.Luck < 10 && SpecialAll > 0)
            {
                pers.Luck++;
            }
        }

        private void SpecLMin_Click(object sender, EventArgs e)
        {
            if (pers.Luck > 2)
            {
                pers.Luck--;
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
            int[] param = {};
            Island form = new Island(param, pers.name);
            this.Close();
            form.Show();
        }
    }
}
