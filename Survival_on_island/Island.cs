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
            Refresh();

            

        }

        public Island(int[] param, string name)
        {
            InitializeComponent();

            HP = param[0];
            Def = param[1];
            OD = param[2];
            ODhod = param[2];
            Damage = param[3];
            Name = name;
            
            Refresh();
        }


        // ПРЕДМЕТЫ \ ИНСТРУМЕНТЫ

        //    knife.name = "Каменный нож";
        //   knife.text = "Самодельный каменный нож. Урон: +1";
        //    knife.value = 0;
        //    knife.maxValue = 1;
        //!Сделать добавление через конструктор класса.
        Items knife = new Items("Каменный нож", "Самодельный каменный нож.\nУрон: +1", 0, 1);
        Items fe_knife = new Items("Железный нож", "Найденный железный нож. Самому такой не сделать.\nУрон: +3\nЕда при охоте: +2", 0, 1);



        //++++++++++++++++++
        //Переменные. ресурсы.
        //++++++++++++++++++
        int eat = 0;
        int wood = 0;
        int rock = 0;

        //действие
        int use = 1;

        //стандарт выпадения ресурсов. Массив минимальных и максимальных значений для разных вариантов действия 1. {д1_мин, д1_макс, д2_мин ... и т.д.}
        int[] use1 = { 2, 3, 3, 5, 5, 7}; //Сбор ягод

        int[] use2 = { 1, 2, 3, 5, 5, 7}; //Добыча древесины

        int[] use3 = { 1, 2, 3, 5, 5, 7 }; //Добыча камня


        // начальные навыки персонажа для проверки.
        string Name = "";
        int NavSob = 30;
        int NavBuild = 33;
        int OD = 0;
        int ODhod = 0;
        int HP = 0;
        int Def = 0;
        int Damage = 0;

        void Refresh()
        {
            label_eat.Text = Convert.ToString(eat);
            label_wood.Text = Convert.ToString(wood);
            label_rock.Text = Convert.ToString(rock);
            labelOD.Text = "ОД: " + ODhod;
            labelHP.Text = Convert.ToString( HP);
        }

        // Кнопка локации\типа действия. Действие 1.
        private void button1_Click(object sender, EventArgs e)
        {
            // Вычет очков действия
            if (ODhod >= 2)
            {
                ODhod -= 2;
                    Random rand = new Random();
                    if (use == 1) // поиск ягод
                    {
                        if (rand.Next(1, 101) < NavSob * 2) // Проверка навыка. Повезет или нет найти ягоды.
                        {
                            eat += rand.Next(use1[0], use1[1] + 1); // Генерирует кол-во в случае успеха.
                        }
                    }
                    if (use == 2) // поиск древесины
                    {
                        if (rand.Next(1, 101) < NavSob + NavBuild) // Проверка навыка. Повезет или нет найти древисину.
                        {
                            wood += rand.Next(use2[0], use2[1] + 1); // Генерирует кол-во в случае успеха.
                        }
                    }
                    if (use == 3) // поиск камня
                    {
                        if (rand.Next(1, 101) < NavSob + NavBuild) // Проверка навыка. Повезет или нет найти камни.
                        {
                            rock += rand.Next(use3[0], use3[1] + 1); // Генерирует кол-во в случае успеха.
                        }
                    }
                    //включаем таймер между действиями
                    progressBar1.Value = 0;
                    timer1.Enabled = true;
                    buttonVer1.Enabled = false;
                    buttonVer2.Enabled = false;
                    buttonVer3.Enabled = false;
                
            }
            //обновляет все показатели экрана
            Refresh();
            
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            /*
            Random rand = new Random();
            eat += rand.Next(use1_var2_min, use1_var2_max+1);
            label_eat.Text = Convert.ToString(eat);
             * */
        }

        private void buttonVer3_Click(object sender, EventArgs e)
        {
            /*
            Random rand = new Random();
            eat += rand.Next(use1_var3_min, use1_var3_max+1);
            label_eat.Text = Convert.ToString(eat);
             */
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 100)
            {
                progressBar1.Value += 10;
            }
            else
            {
                timer1.Enabled = false;

                buttonVer1.Enabled = true;
                buttonVer2.Enabled = true;
                buttonVer3.Enabled = true;
            }
        }

        private void buttonEndDay_Click(object sender, EventArgs e)
        {
            //здесь будет счетчик дней
            //

            eat -= 2;
            ODhod = OD;

            //обновляет все показатели экрана
            Refresh();
            if (eat < 0)
            {
                MessageBox.Show("Сожалеем, но вы умерли от голода");
                this.Close();
            }
        }

        // Кнопка действия 1. "Собирать ягоды"
        private void buttonUse1_Click(object sender, EventArgs e)
        {
            use = 1;
            buttonVer1.Text = "Равнина";
            buttonVer2.Text = "Лес";
            buttonVer3.Text = "Болото";
        }

        // Кнопка действия 2. "Добывать древесину"
        private void buttonUse2_Click(object sender, EventArgs e)
        {
            use = 2;
            buttonVer1.Text = "Пляж";
            buttonVer2.Text = "Равнина";
            buttonVer3.Text = "Чаща";
        }

        // Кнопка действия 3. "Добывать камень"
        private void buttonUse3_Click(object sender, EventArgs e)
        {
            use = 3;
            buttonVer1.Text = "Пляж";
            buttonVer2.Text = "Склон";
            buttonVer3.Text = "Горы";
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Имя: " + Name + "\nHP: " + HP + "\nЗащита: " + Def + "\nОД: " + OD + "\nУрон: " + Damage);  
        }

        private void pictureRKnife_Click(object sender, EventArgs e)
        {
            MessageBox.Show(knife.name + "\n" + knife.text);
        }

        




    }
}
