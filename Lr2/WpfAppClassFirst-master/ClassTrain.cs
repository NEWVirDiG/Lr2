using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPClasses //пространство имен проекта
    {
        internal class ClassTrain
        {
            //поля
            private string punktNasnachenia;
            private DateTime Dstart;
            private string nTrain;
            // свойства для доступа к полям
            public string PunktNasnachenia
            {
                get { return punktNasnachenia; }//возвращает значение поля
                set { punktNasnachenia = value; } //устанавливает значение поля
            }
            public DateTime DStart
            {
                get { return Dstart; }
                set { Dstart = value; }
            }
            public string ntrain
            {
                get { return nTrain; } //возвращает значение поля
                set { nTrain = value; } //устанавливает значение поля
            }
            //методы 
            //конструктор без параметров задает значения полей по умолчанию
            public ClassTrain()
            {
                punktNasnachenia = "Куровское";
                nTrain = "22";
                Dstart = new DateTime(2023, 02, 01);
            }
            //конструктор с параметрами
            public ClassTrain(string f, DateTime d, string ad,
                string ph, byte k,
                string g, double s)
            {
                punktNasnachenia = f;
                Dstart = d;
                nTrain = ad;

            }
            //метод вывода на экран
            public string PrintToScreen()
            {
                string line = $"Пункт назначения {punktNasnachenia} дата отпрвления {Dstart}" + "\n";
                line = ($"Номер поезда {nTrain}");
                return line;
            }
            public void SaveToFile(string filename)
            {
                StreamWriter streamWriter = new StreamWriter(filename, true, Encoding.Default);
                streamWriter.WriteLine("Данные о работе поезда");
                streamWriter.WriteLine($"Пункт назначения: {punktNasnachenia}");
                streamWriter.WriteLine($"Номер поезда: {nTrain}");
                streamWriter.WriteLine($"Дата поступления: {Dstart.ToString()}");
                streamWriter.Close();

            }
            //метод ввода с клавиатуры
        }
    }
