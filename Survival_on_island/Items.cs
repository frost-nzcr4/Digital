using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Survival_on_island
{
    public class Items
    {
        public string name;
        public string text;
        public int value;
        public int maxValue;

        public Items(string Name, string Text, int Value, int MaxValue)
        {
            this.name = Name;
            this.text = Text;
            this.value = Value;
            this.maxValue = MaxValue;
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
