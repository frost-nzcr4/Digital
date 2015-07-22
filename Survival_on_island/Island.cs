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

            //
            //  Всплывающие подсказки
            //
            toolTipROM.ToolTipTitle = Rom.name;
            toolTipROM.SetToolTip(pictureRom, Rom.text);

                //ресурсы
            toolTipAll.SetToolTip(pictureBox1, "Еда");
            toolTipAll.SetToolTip(pictureBox8, "Вода");
            toolTipAll.SetToolTip(pictureBox2, "Древесина");
            toolTipAll.SetToolTip(pictureBox3, "Камень");
            toolTipAll.SetToolTip(pictureBox7, "Кожа");
            toolTipAll.SetToolTip(pictureBox9, "Веревки");
            toolTipAll.SetToolTip(pictureBox10, "Смола");
            toolTipAll.SetToolTip(pictureBox11, "Руда");
                //инструменты
            toolTipAll.SetToolTip(pictureSmallBasket, SmallBasket.name + "\n" + SmallBasket.text);
            toolTipAll.SetToolTip(pictureBasket, Basket.name + "\n" + Basket.text);
            toolTipAll.SetToolTip(pictureWoodAxe, WoodAxe.name + "\n" + WoodAxe.text);
            toolTipAll.SetToolTip(pictureRockAxe, RockAxe.name + "\n" + RockAxe.text);
            toolTipAll.SetToolTip(pictureWoodPick, WoodPick.name + "\n" + WoodPick.text);
            toolTipAll.SetToolTip(pictureRockPick, RockPick.name + "\n" + RockPick.text);
                //экипировка
            toolTipAll.SetToolTip(pictureShlem1, SkinHat.name + "\n" + SkinHat.text);
            toolTipAll.SetToolTip(pictureKurtka1, SkinShirt.name + "\n" + SkinShirt.text);
            toolTipAll.SetToolTip(pictureShtani1, SkinPants.name + "\n" + SkinPants.text);
            toolTipAll.SetToolTip(pictureSapogi1, SkinShoes.name + "\n" + SkinShoes.text);

            //присвоение параметрам формы значений входящих параметров
            HPmax = param[0];
            HPnow = param[0];
            Def = param[1];
            OD = param[2];
            ODhod = param[2];
            Damage = param[3];
            Name = name;
            
            Refresh();
        }
        

        // ПРЕДМЕТЫ \ ИНСТРУМЕНТЫ
            //основные
        Items Knife = new Items("Каменный нож", "Самодельный каменный нож.\nУрон: +1", 0, 1, 1);
        Items FeKnife = new Items("Железный нож", "Найденный железный нож. Самому такой не сделать.\nУрон: +3\nЕда при охоте: +2", 0, 1, 1);
        Items SmallBasket = new Items("Лукошко", "Небольшая емкость для сбора ягод.\nСбор ягод: +1", 0, 1, 4);
        Items Basket = new Items("Корзина", "Средняя емкость для сбора ягод.\nСбор ягод: +2", 0, 1, 4);
        Items WoodAxe = new Items("Деревянный топор", "Самый простой и не прочный топор.\nС таким много не нарубишь.\nСбор древесины: +0-1", 0, 1, 4);
        Items RockAxe = new Items("Каменный топор", "Самый лучше топор, что можно сделать в этим условиях.\nСбор древесины: +1-2", 0, 1, 4);
        Items FeAxe = new Items("Железный топор", "Лучший топор, о котором можно только мечтать на этом острове. С таким много не нарубишь.", 0, 1, 4);
        Items WoodPick = new Items("Деревянная кирка", "Самая простая кирка.\nДобывать камень такой очень сложно.\nСбор камня +0-1", 0, 1, 4);
        Items RockPick = new Items("Каменная кирка", "Долбить камнем о камень?\nГлупая затея, но других вариантов нет.\nСбор камня +1-2", 0, 1, 4);
        Items FePick = new Items("Железная кирка", "Обладателю такой кирки можно только позавидовать.", 0, 1, 4);
        Items Lance = new Items("Копье", "Хороший инструмент для охоты на дичь.", 0, 1, 1);
        Items FeLance = new Items("Железное копье", "Отличный инструмент для охоты на дичь.", 0, 1, 1);
        Items Baton = new Items("Дубинка", "Сгодится для охоты. Особенно хороша против крупных зверей.", 0, 1, 1);
            //оружие дальнего боя
        Items Bow = new Items("Лук", "Простой лук для убийства на расстоянии.\nУрон: +3", 0, 1, 2);
        Items StrongBow = new Items("Усиленный Лук", "Усиленный лук, отлично подойдет для охоты.\nУрон: +3", 0, 1, 2);
            //вспомогательные
        Items Medical = new Items("Медицинская аптечка", "Помогает залечивать раны.\nЗдоровье: +5", 0, 20, 4);
        Items Rom = new Items("Бутылка рома", "Крепкий напиток так любимый моряками.\nПосле глотка хочется больше работать.\nЗдоровье: +2\nОД: +4", 0, 20, 4);
        Items Bandaging = new Items("Перевязка", "Материя для перевязки ран, изготовленныя своими руками.\nЗдоровье: +4", 0, 20, 4);
        
            //одежда
        Items SkinHat = new Items("Кожанная шапка", "Простая шапка из шкур животных.\nКласс брони: +1", 0, 1, 5);
        Items SkinShirt = new Items("Кожанная рубаха", "Простая рубашка из шкур животных.\nКласс брони: +2", 0, 1, 6);
        Items SkinPants = new Items("Кожанные штаны", "Простые штаны из шкур животных.\nКласс брони: +2", 0, 1, 7);
        Items SkinShoes = new Items("Кожанные сапоги", "Простык сапоги из шкур животных.\nКласс брони: +1", 0, 1, 7);
            //защита
        Items Shield = new Items("Простой щит", "Обычный деревянный щит. Сгодится для обороны от диких животных.\nКласс защиты: +1", 0, 1, 3);
        Items Shield2 = new Items("Усиленный щит", "Усиленный деревянный щит. Сгодится для обороны от диких животных.\nКласс защиты: +2", 0, 1, 3);
        
        
        

        //++++++++++++++++++
        //Переменные. ресурсы.
        //++++++++++++++++++
        int eat = 0; //еда
        int wood = 0; //древесина
        int rock = 0; //камень
        int skin = 0; //шкура

        //номер действия.
        int use = 1;

        //переменые для герератора
        int min = 0;
        int max = 0;

        //переменные дня
        int day = 1;

        //переменная для добычи ресурсов. нужна для вывода добытых ресурсов на экран подсказок
        int addRes = 0;

        //стандарт выпадения ресурсов. Массив минимальных и максимальных значений для разных вариантов действия 1. {д1_мин, д1_макс, д2_мин ... и т.д.}
        int[] use1 = { 2, 3, 3, 5, 5, 7}; //Сбор ягод

        int[] use2 = { 0, 1, 1, 2, 2, 3}; //Добыча древесины

        int[] use3 = { 0, 1, 1, 2, 2, 3}; //Добыча камня


        // начальные навыки персонажа для проверки.
        string Name = "";
        int NavSob = 30;
        int NavBuild = 33;
        int OD = 0;
        int ODhod = 0;
        int HPmax = 0;
        int HPnow = 0;
        int Def = 0;
        int DefWithMod = 0;
        int Damage = 0;

        void Refresh()
        {
            //Проверка на HP
            if (HPnow > HPmax)
            {
                HPnow = HPmax;
            }

            //заполнение полей с данными
            label_eat.Text = Convert.ToString(eat);
            label_wood.Text = Convert.ToString(wood);
            label_rock.Text = Convert.ToString(rock);
            labelOD.Text = "ОД: " + ODhod;
            labelHP.Text = Convert.ToString( HPnow);

            

            //Отображение инструментов
            // маленькая корзина
            if (SmallBasket.value > 0)
            {
                pictureSmallBasket.Visible = true;
            }
            else
            {
                pictureSmallBasket.Visible = false;
            }
            //корзина
            if (Basket.value > 0)
            {
                pictureBasket.Visible = true;
            }
            else
            {
                pictureBasket.Visible = false;
            }
            //топоры
            if (WoodAxe.value > 0)
            {
                pictureWoodAxe.Visible = true;
            }
            else
            {
                pictureWoodAxe.Visible = false;
            }
            if (RockAxe.value > 0)
            {
                pictureRockAxe.Visible = true;
            }
            else
            {
                pictureRockAxe.Visible = false;
            }
            //кирки
            if (WoodPick.value > 0)
            {
                pictureWoodPick.Visible = true;
            }
            else
            {
                pictureWoodPick.Visible = false;
            }
            if (RockPick.value > 0)
            {
                pictureRockPick.Visible = true;
            }
            else
            {
                pictureRockPick.Visible = false;
            }
            //Ром
            if (Rom.value > 0)
            {
                pictureRom.Visible = true;
                labelRomValue.Visible = true;
            }
            else
            {
                pictureRom.Visible = false;
                labelRomValue.Visible = false;
            }
            labelRomValue.Text = Convert.ToString(Rom.value);

            //проверка и отображение экипировки
            DefWithMod = Def;
            if (SkinHat.value > 0)
            {
                pictureShlem1.Visible = true;
                DefWithMod += 1; // если есть броня, то + к защите
            }
            else
            {
                pictureShlem1.Visible = false;
            }
            if (SkinShirt.value > 0)
            {
                pictureKurtka1.Visible = true;
                DefWithMod += 2; // если есть броня, то + к защите
            }
            else
            {
                pictureKurtka1.Visible = false;
            }
            if (SkinPants.value > 0)
            {
                pictureShtani1.Visible = true;
                DefWithMod += 2; // если есть броня, то + к защите
            }
            else
            {
                pictureShtani1.Visible = false;
            }
            if (SkinShoes.value > 0)
            {
                pictureSapogi1.Visible = true;
                DefWithMod += 1; // если есть броня, то + к защите
            }
            else
            {
                pictureSapogi1.Visible = false;
            }


            //проверка на смерть
            if (HPnow <= 0)
            {
                MessageBox.Show("Сожалеем, но вы умерли");
                this.Close();
            }



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
                        EnableTimer(); // включает таймер действия для прогресс бара.
                        if (rand.Next(1, 101) < NavSob * 2) // Проверка навыка. Повезет или нет найти ягоды.
                        {
                            min = use1[0];
                            max = use1[1];
                            if (Basket.value > 0) //если есть корзина, то прибавить к максимальному сбору еды +2
                            {
                                max += 2;
                            }
                            else if (SmallBasket.value > 0) //иначе, если есть маленькия корзина, то прибавить +1
                            {
                                max += 1;
                            }
                            //временная строка для выводы минимума и максимума
                            labelLog.Text = ("Шанс: " + (NavSob + NavSob) + "% Min: " + min + " Max: " + max + "\n" + labelLog.Text);
                            addRes = rand.Next(min, max + 1); // Генерирует кол-во в случае успеха.
                            labelLog.Text = ("Вы нашли " + addRes + " еды" + "\n" + labelLog.Text);
                            eat += addRes;
                        }
                    }
                    if (use == 2) // поиск древесины
                    {
                        EnableTimer();
                        if (rand.Next(1, 101) < NavSob + NavBuild) // Проверка навыка. Повезет или нет найти древисину.
                        {
                            min = use2[0];
                            max = use2[1];
                            if (RockAxe.value > 0) //если есть каменный топор, то прибавить к максимальному сбору +1-2
                            {
                                min += 1;
                                max += 2;
                            }
                            else if (WoodAxe.value > 0) //иначе, если есть деревянный топор, то прибавить +1
                            {
                                max += 1;
                            }
                            //временная строка для выводы минимума и максимума
                            labelLog.Text = ( "Шанс: " + (NavSob + NavBuild) + "% Min: " + min + " Max: " + max + "\n" + labelLog.Text);
                            addRes = rand.Next(min, max + 1); // Генерирует кол-во в случае успеха.
                            if (addRes > 0) //проверка на кол-во добытого ресурса. показывает строку, только если ресурса больше 0.
                            {
                                labelLog.Text = ("Вы нашли " + addRes + " древесины" + "\n" + labelLog.Text);
                            }
                            wood += addRes;
                        }
                    }
                    if (use == 3) // поиск камня
                    {
                        EnableTimer();
                        if (rand.Next(1, 101) < NavSob + NavBuild) // Проверка навыка. Повезет или нет найти камни.
                        {
                            min = use3[0];
                            max = use3[1];
                            if (RockPick.value > 0) //если есть каменная кирка, то прибавить к максимальному сбору +1-2
                            {
                                min += 1;
                                max += 2;
                            }
                            else if (WoodPick.value > 0) //иначе, если есть деревянная кирка, то прибавить +1
                            {
                                max += 1;
                            }
                            //временная строка для выводы минимума и максимума
                            labelLog.Text = ("Шанс: " + (NavSob + NavBuild) + "% Min: " + min + " Max: " + max + "\n" + labelLog.Text);
                            addRes = rand.Next(min, max + 1); // Генерирует кол-во в случае успеха.
                            if (addRes > 0) //проверка на кол-во добытого ресурса. показывает строку, только если ресурса больше 0.
                            {
                                labelLog.Text = ("Вы нашли " + addRes + " камня" + "\n" + labelLog.Text);
                            }
                            rock += addRes;
                        }
                    }
                 
            }
            
            
        }

        // Кнопка локации\типа действия. Действие 2.
        private void button2_Click(object sender, EventArgs e)
        {
                // Проверка очков действия
                if (ODhod >= 2)
                {
                    Random rand = new Random();
                    if (use == 1) // поиск ягод
                    {
                        if (SmallBasket.value == 1) //Проверка на наличие нужного инструмента
                        {
                            ODhod -= 2;
                            EnableTimer(); // включает таймер действия для прогресс бара.
                            if (rand.Next(1, 101) < NavSob * 2) // Проверка навыка. Повезет или нет найти ягоды.
                            {
                                min = use1[2];
                                max = use1[3];
                                if (Basket.value > 0) //если есть корзина, то прибавить к максимальному сбору еды +2
                                {
                                    max += 2;
                                }
                                else if (SmallBasket.value > 0) //иначе, если есть маленькия корзина, то прибавить +1
                                {
                                    max += 1;
                                }
                                //временная строка для выводы минимума и максимума
                                labelLog.Text = ("Шанс: " + (NavSob + NavSob) + "% Min: " + min + " Max: " + max + "\n" + labelLog.Text);
                                addRes = rand.Next(min, max + 1); // Генерирует кол-во в случае успеха.
                                labelLog.Text = ("Вы нашли " + addRes + " еды" + "\n" + labelLog.Text);
                                eat += addRes;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Вам необходимо лукошко!");
                        }
                    }

                    if (use == 2) // поиск древесины
                    {
                        if (WoodAxe.value == 1) //Проверка на наличие нужного инструмента
                        {
                            ODhod -= 2;
                            EnableTimer();
                            if (rand.Next(1, 101) < NavSob + NavBuild) // Проверка навыка. Повезет или нет найти древисину.
                            {
                                min = use2[2];
                                max = use2[3];
                                if (RockAxe.value > 0) //если есть каменный топор, то прибавить к максимальному сбору +1-2
                                {
                                    min += 1;
                                    max += 2;
                                }
                                else if (WoodAxe.value > 0) //иначе, если есть деревянный топор, то прибавить +1
                                {
                                    max += 1;
                                }
                                //временная строка для выводы минимума и максимума
                                labelLog.Text = ("Шанс: " + (NavSob + NavBuild) + "% Min: " + min + " Max: " + max + "\n" + labelLog.Text);
                                addRes = rand.Next(min, max + 1); // Генерирует кол-во в случае успеха.
                                if (addRes > 0) //проверка на кол-во добытого ресурса. показывает строку, только если ресурса больше 0.
                                {
                                    labelLog.Text = ("Вы нашли " + addRes + " древесины" + "\n" + labelLog.Text);
                                }
                                wood += addRes;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Вам необходим деревянный топор!");
                        }
                    }
                    if (use == 3) // поиск камня
                    {
                        if (WoodPick.value == 1) //Проверка на наличие нужного инструмента
                        {
                            ODhod -= 2;
                            EnableTimer();
                            if (rand.Next(1, 101) < NavSob + NavBuild) // Проверка навыка. Повезет или нет найти камни.
                            {
                                min = use3[2];
                                max = use3[3];
                                if (RockPick.value > 0) //если есть каменная кирка, то прибавить к максимальному сбору +1-2
                                {
                                    min += 1;
                                    max += 2;
                                }
                                else if (WoodPick.value > 0) //иначе, если есть деревянная кирка, то прибавить +1
                                {
                                    max += 1;
                                }
                                //временная строка для выводы минимума и максимума
                                labelLog.Text = ("Шанс: " + (NavSob + NavBuild) + "% Min: " + min + " Max: " + max + "\n" + labelLog.Text);
                                addRes = rand.Next(min, max + 1); // Генерирует кол-во в случае успеха.
                                if (addRes > 0) //проверка на кол-во добытого ресурса. показывает строку, только если ресурса больше 0.
                                {
                                    labelLog.Text = ("Вы нашли " + addRes + " камня" + "\n" + labelLog.Text);
                                }
                                rock += addRes;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Вам необходима деревянная кирка!");
                        }
                    }
                }
                //обновляет все показатели экрана
                Refresh();
        }

        //метод включения таймера между действиями
        void EnableTimer() 
        {
            progressBar1.Value = 0;     // обнуляет полосу прогресса
            timer1.Enabled = true;      // включает таймер
            buttonVer1.Enabled = false; //отключает кнопки вариантов действий
            buttonVer2.Enabled = false;
            buttonVer3.Enabled = false;

            
        }

        private void buttonVer3_Click(object sender, EventArgs e)
        {
            /*
            Random rand = new Random();
            eat += rand.Next(use1_var3_min, use1_var3_max+1);
            label_eat.Text = Convert.ToString(eat);
             */
        }

        // таймер. сначала считает, увеличивая полосу прогресса, потом включает кнопки вариантов действия.
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

                Refresh();
            }

        }

        //Кнопка "закончить день"
        private void buttonEndDay_Click(object sender, EventArgs e)
        {
            //счетчик дней
            day++;
            NextDay();

            eat -= 2;
            ODhod = OD;

            //обновляет все показатели экрана
            Refresh();
            if (eat < 0)
            {
                HPnow -= 5;
                MessageBox.Show("Вы голодаете. Кол-во HP уменьшено", "ГОЛОД!");
            }
            Refresh();
        }

        //счетчик дней
        void NextDay()
        {
            if (day <= 30)
            {
                labelLog.Text = "Сегодня " + day + " июня";
            }
            if (day > 30 && day <= 61)
            {
                labelLog.Text = "Сегодня " + (day - 30) + " июля";
            }
            if (day > 61 && day <= 92)
            {
                labelLog.Text = "Сегодня " + (day - 61) + " августа";
            }
            if (day > 92 && day <= 122)
            {
                labelLog.Text = "Сегодня " + (day - 92) + " сентября";
            }
            if (day > 122 && day <= 153)
            {
                labelLog.Text = "Сегодня " + (day - 122) + " октября";
            }
            //пасхалка
            if (day == 122 + 22)
            {
                MessageBox.Show("У Вадимки день рождения! =)\nС неба падает ящик рома!");
                Rom.value += 8;
            }

            if (day > 153 && day <= 183)
            {
                labelLog.Text = "Сегодня " + (day - 153) + " ноября";
            }
        }

        // Кнопка действия 1. "Собирать ягоды"
        private void buttonUse1_Click(object sender, EventArgs e)
        {
            use = 1;
            buttonVer1.Text = "На равнине";
            buttonVer2.Text = "В лесу";
            buttonVer3.Text = "На болоте";
        }

        // Кнопка действия 2. "Добывать древесину"
        private void buttonUse2_Click(object sender, EventArgs e)
        {
            use = 2;
            buttonVer1.Text = "Собирать ветки";
            buttonVer2.Text = "Рубить в лесу";
            buttonVer3.Text = "Рубить в чаще";
        }

        // Кнопка действия 3. "Добывать камень"
        private void buttonUse3_Click(object sender, EventArgs e)
        {
            use = 3;
            buttonVer1.Text = "Искать на пляже";
            buttonVer2.Text = "У склона";
            buttonVer3.Text = "Из скалы";
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Имя: " + Name + "\nHP: " + HPnow + "\nКласс брони: " + DefWithMod + "\nОД: " + OD + "\nУрон: " + Damage , "Характеристики персонажа");

            
        }

        //Временный предмет в инструментами.
        private void pictureBoxBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы нашли ящик с инструментами.\nЯщик только на время теста и для проверки механики игры.", "Ящик с инструментами");
            //временно даем инструменты:
            SmallBasket.value = 1;
            Basket.value = 1;
            WoodAxe.value = 1;
            RockAxe.ItemAdd();
            WoodPick.value = 1;
            RockPick.value = 1;
            Rom.ItemAdd();
            Rom.ItemAdd();

            //даем экипировку
            SkinHat.ItemAdd();
            SkinShirt.ItemAdd();
            SkinPants.ItemAdd();
            SkinShoes.ItemAdd();

            Refresh();
        }

        

        private void pictureRom_Click(object sender, EventArgs e)
        {
            if (Rom.value > 0)
            {
                Rom.ItemMinus();
                ODhod += 4;
            }
            Refresh();
        }

        //Кнопка действия "Охотиться"
        private void buttonUse4_Click(object sender, EventArgs e)
        {
            use = 4;
            buttonVer1.Text = "На мелкую дичь";
            buttonVer2.Text = "На среднюю дичь";
            buttonVer3.Text = "На крупную дичь";
        }

        private void buttonUse5_Click(object sender, EventArgs e)
        {
            use = 5;
            buttonVer1.Text = "В озере";
            buttonVer2.Text = "В ручье";
            buttonVer3.Text = "В океане";
        }

        private void buttonUse6_Click(object sender, EventArgs e)
        {
            use = 6;
            buttonVer1.Text = "На берегу";
            buttonVer2.Text = "В трюме";
            buttonVer3.Text = "В воде у скал";
        }


        //клик на корзину. удалить потом
        private void pictureBasket_Click(object sender, EventArgs e)
        {
            Basket.ItemMinus();
            Refresh();
        }
        //клик на маленькую корзину. удалить потом
        private void pictureSmallBasket_Click(object sender, EventArgs e)
        {
            SmallBasket.ItemMinus();
            Refresh();
        }

        private void pictureWoodAxe_Click(object sender, EventArgs e)
        {
            WoodAxe.ItemMinus();
            Refresh();
        }

        private void pictureRockAxe_Click(object sender, EventArgs e)
        {
            RockAxe.ItemMinus();
            Refresh();
        }

        //КОСТЕР
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            eat += 10;
            HPnow += 10;
            Refresh();
        }








        
    }
}
