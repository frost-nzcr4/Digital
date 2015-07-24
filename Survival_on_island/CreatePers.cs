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

        //Имя
        string name;

        //начальные навыки
        int NavSob = 0;
        int NavHunt = 0;
        int NavFish = 0;
        int NavCraft = 0;
        int NavMining = 0;
        int NavWood = 0;
        int NavDefault = 20; //Кол-во % навыков по-умолчанию. Необходимо для ввода уровней сложности.

        //Характеристики
        int Strength = 5;
        int Perception = 5;
        int Endurance  = 5;
        int Will = 5;           //Воля. Вместо 'C'
        int Intelligence  = 5;
        int Agility  = 5;
        int Luck = 5;
        int SpecialAll = 40;       //Всего навыков

        //Параметры
        int hp = 0;
        int def = 0;
        int OD = 0;
        int damage = 0;
        int morality = 0;


        //Метод обновления статов
        void Refresh_Stat()
        {
            //Вывод имени
            labelName.Text = name;

            //Выводим характеристики на экран
            SpecS.Text = Convert.ToString(Strength);
            SpecP.Text = Convert.ToString(Perception);
            SpecE.Text = Convert.ToString(Endurance);
            SpecC.Text = Convert.ToString(Will);
            SpecI.Text = Convert.ToString(Intelligence);
            SpecA.Text = Convert.ToString(Agility);
            SpecL.Text = Convert.ToString(Luck);
            SpecialAll = 40 - (Strength + Perception + Endurance + Will + Intelligence + Agility + Luck);
            SpecAdd.Text = Convert.ToString(SpecialAll);

            //Считаем и выводим основые параметры. HP, Защита, ОД, Урон, Мораль.
            hp = Strength + (2*Endurance) + 15;
            labelHP.Text = Convert.ToString(hp);
            def = Agility;
            labelDef.Text = Convert.ToString(def);
            OD = (Agility/2) + 5;
            labelOD.Text = Convert.ToString(OD);
            damage = Strength;
            labelDamage.Text = Convert.ToString(damage);
            morality = 20 + (Will * 4);
            labelMorality.Text = Convert.ToString(morality);

            //Подсчет и вывод навыков
            NavSob = NavDefault + (Perception * 2);
            labelNavSob.Text = Convert.ToString(NavSob);
            NavHunt = NavDefault + Perception + Agility;
            labelNavHunt.Text = Convert.ToString(NavHunt);
            NavFish = NavDefault + Will + Will;
            labelNavFish.Text = Convert.ToString(NavFish);
            NavCraft = NavDefault + (Intelligence * 2);
            labelNavCraft.Text = Convert.ToString(NavCraft);
            NavMining = NavDefault + Strength + Endurance;
            labelNavMining.Text = Convert.ToString(NavMining);
            NavWood = NavDefault + Strength + Agility;
            labelNavWood.Text = Convert.ToString(NavWood);
        }

        // Таймер для обновления статов
        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh_Stat();
        }



        // прибавляет силу на 1
        private void SpecSPlus_Click(object sender, EventArgs e)
        {
            if (Strength < 10 && SpecialAll > 0)
            {
                Strength++;
            }
        }
        // убавляет силу на 1
        private void SpecSMin_Click(object sender, EventArgs e)
        {
            if (Strength > 2)
            {
                Strength--;
            }
        }

        private void SpecPPlus_Click(object sender, EventArgs e)
        {
            if (Perception < 10 && SpecialAll > 0)
            {
                Perception++;
            }
        }

        private void SpecPMin_Click(object sender, EventArgs e)
        {
            if (Perception > 2)
            {
                Perception--;
            }
        }

        

        private void SpecEPlus_Click(object sender, EventArgs e)
        {
            if (Endurance < 10 && SpecialAll > 0)
            {
                Endurance++;
            }
        }

        private void SpecEMin_Click(object sender, EventArgs e)
        {
            if (Endurance > 2)
            {
                Endurance--;
            }
        }

        private void SpecCPlus_Click(object sender, EventArgs e)
        {
            if (Will < 10 && SpecialAll > 0)
            {
                Will++;
            }
        }

        private void SpecCMin_Click(object sender, EventArgs e)
        {
            if (Will > 2)
            {
                Will--;
            }
        }

        private void SpecIPlus_Click(object sender, EventArgs e)
        {
            if (Intelligence < 10 && SpecialAll > 0)
            {
                Intelligence++;
            }
        }

        private void SpecIMin_Click(object sender, EventArgs e)
        {
            if (Intelligence > 2)
            {
                Intelligence--;
            }
        }

        private void SpecAPlus_Click(object sender, EventArgs e)
        {
            if (Agility < 10 && SpecialAll > 0)
            {
                Agility++;
            }
        }

        private void SpecAMin_Click(object sender, EventArgs e)
        {
            if (Agility > 2)
            {
                Agility--;
            }
        }

        private void SpecLPlus_Click(object sender, EventArgs e)
        {
            if (Luck < 10 && SpecialAll > 0)
            {
                Luck++;
            }
        }

        private void SpecLMin_Click(object sender, EventArgs e)
        {
            if (Luck > 2)
            {
                Luck--;
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
            
            int[] param = {hp, def, OD, damage };

            Island form = new Island(param, name);
            this.Close();
            form.Show();
        }
    }
}
