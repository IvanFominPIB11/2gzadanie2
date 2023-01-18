using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _2gzadanie2
{
    internal class Program
    {
        static void Main()
        {
            int number, delenie,delenie2;
            number = Int32.Parse(
                Interaction.InputBox(
                    "Введите число",
                    "Проверка")
                );
            delenie = number % 5;
            delenie2= number % 7;
            string txt = "Число " + number + " ", txt2 = "Число " + number + " ";
            txt += (delenie == 2 ? "Удовлетворяет" : "Не удовлетворяет") +" при делении на 5 в остатке 2 ";
            txt += (delenie2 == 1 ? "Удовлетворяет" : "Не удовлетворяет")+ " при делении на 7 в остатке 1";
            MessageBox.Show(txt, txt2);
        }
    }
}
