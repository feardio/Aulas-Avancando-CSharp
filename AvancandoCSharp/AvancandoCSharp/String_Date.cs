using System;
using static System.Console;

namespace AvancandoCSharp
{
    class String_Date
    {
        public void STRING_PARA_DATA(string[] args)
        {
            string datadobanco = "2020-04-02 08:07:00";
            //DateTime data = new DateTime(2020, 04, 03, 08, 07, 00);
            DateTime data = DateTime.Parse(datadobanco);

            string horaformatada = String.Format("{0:HH}h{0:mm}", data);
            string dataformatada = String.Format("{0:dd/MM/yyyy}", data);

            WriteLine(dataformatada);

            ReadLine();
        }
    }
}
