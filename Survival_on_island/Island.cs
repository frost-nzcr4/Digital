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

        //++++++++++++++++++
        //Переменные. ресурсы.
        //++++++++++++++++++
        int eat = 0;
        int wood = 0;
        int rock = 0;

        //действие
        int use = 1;

        //стандарт выпадения ресурсов. use - действие, var - вариант (локация).
        int use1_var1_min = 2;
        int use1_var1_max = 3;
        int use1_var2_min = 3;
        int use1_var2_max = 5;
        int use1_var3_min = 5;
        int use1_var3_max = 7;

        int use2_var1_min = 1;
        int use2_var1_max = 2;
        int use2_var2_min = 3;
        int use2_var2_max = 5;
        int use2_var3_min = 5;
        int use2_var3_max = 7;

        int use3_var1_min = 1;
        int use3_var1_max = 2;
        int use3_var2_min = 3;
        int use3_var2_max = 5;
        int use3_var3_min = 5;
        int use3_var3_max = 7;

        // начальные навыки персонажа для проверки.
        int NavSob = 30;
        int NavBuild = 33;
        int OD = 8;
        int ODhod = 8;
        int HP = 33;

        void Refresh()
        {
            label_eat.Text = Convert.ToString(eat);
            label_wood.Text = Convert.ToString(wood);
            label_rock.Text = Convert.ToString(rock);
            labelOD.Text = "ОД: " + ODhod;
            labelHP.Text = Convert.ToString( HP);
        }


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
                            eat += rand.Next(use1_var1_min, use1_var1_max + 1); // Генерирует кол-во в случае успеха.
                        }
                    }
                    if (use == 2) // поиск древесины
                    {
                        if (rand.Next(1, 101) < NavSob + NavBuild) // Проверка навыка. Повезет или нет найти древисину.
                        {
                            wood += rand.Next(use2_var1_min, use2_var1_max + 1); // Генерирует кол-во в случае успеха.
                        }
                    }
                    if (use == 3) // поиск камня
                    {
                        if (rand.Next(1, 101) < NavSob + NavBuild) // Проверка навыка. Повезет или нет найти камни.
                        {
                            rock += rand.Next(use3_var1_min, use3_var1_max + 1); // Генерирует кол-во в случае успеха.
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

        private void buttonUse1_Click(object sender, EventArgs e)
        {
            use = 1;
            buttonVer1.Text = "Равнина";
            buttonVer2.Text = "Лес";
            buttonVer3.Text = "Болото";
        }

        private void buttonUse2_Click(object sender, EventArgs e)
        {
            use = 2;
            buttonVer1.Text = "Пляж";
            buttonVer2.Text = "Равнина";
            buttonVer3.Text = "Чаща";
        }

        private void buttonUse3_Click(object sender, EventArgs e)
        {
            use = 3;
            buttonVer1.Text = "Пляж";
            buttonVer2.Text = "Склон";
            buttonVer3.Text = "Горы";
        }
    }
}
