using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Survival_on_island
{
    public class Items
    {
        public string name; //Название предмета
        public string text; //Текст с описание
        public int value;   //кол-во предметов в инвентаре
        public int maxValue; //максимальное кол-во предметов в инвентаре
        public int type;    //тип предмета. 1 - оружие ближнего боя, 2 - дальнего боя, 3 - резерв, 4 - вспомогательное снаряжение, 5 - экпип голова, 6 - экип тело, 7- экип штаны, 8- экип обувь.
        public int equip;        //Обозначение экипированности снаряжения.
    //    public int quality1;
    //    public int quality2;


        public Items(string Name, string Text, int Value, int MaxValue, int Type)
        {
            this.name = Name;
            this.text = Text;
            this.value = Value;
            this.maxValue = MaxValue;
            this.type = Type;
            this.equip = 0;

        }

        //метод добавления предмета
        public void ItemAdd()
        {
            if (value < maxValue)
            {
                value += 1;
            }
        }
        //метод вычитания предмета
        public void ItemMinus()
        {
            if (value > 0 )
            {
                value -= 1;
            }
        }

    }
    
}
