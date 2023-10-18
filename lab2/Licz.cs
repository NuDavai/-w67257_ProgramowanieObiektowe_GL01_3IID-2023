using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Models
{
    public class Licz
    {
        public int Value = 0;

        public void Dodaj(int addValue)
        {
            Value += addValue;
        }

        public void Odejmij(int addValue)
        {
            Value -= addValue;
        }
    }
}