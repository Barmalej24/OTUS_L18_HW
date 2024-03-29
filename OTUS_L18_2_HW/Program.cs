﻿using System.Text;

namespace OTUS_L18_2_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>() { "Земля", "Лимония", "Марс" };
            var cp = new CatalogPlanets();
            foreach (var item in list)
            {
                PrintInfo(cp.GetPlanet(item));
            }        
        }
        static void PrintInfo((ushort? position, double? equator, string? err) info)
        {
            if (!info.position.HasValue)
            {
                var st = new StringBuilder();
                st.AppendLine($"Сообщение: {info.err}");
                Console.WriteLine(st);
            }
            else
            {
                var st = new StringBuilder();
                st.AppendLine($"Информация о запрошеной планете:");
                st.AppendLine($"Порядковый номер планеты от Солнца: {info.position.Value}");
                st.AppendLine($"Длина экватора {info.equator} км.");
                st.AppendLine($"Дополнительно возможная информация {info.err}");
                Console.WriteLine(st);
            }
        }
    }
}
