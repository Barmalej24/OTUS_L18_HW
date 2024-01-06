namespace OTUS_L18_1_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Init();
        }

        static void PrintInfo(dynamic objRef, dynamic obj)
        {
            Console.WriteLine($"Название > {obj.Name}, Порядковый номер от Солнца > {obj.Position}, Длина экватора > {obj.Equator} км., Предыдущая планета > {obj.Previous}");
            Console.WriteLine(objRef.Equals(obj));
        }

        static void Init()
        {
            var obj1 = new 
            { 
                Position = 2, 
                Name = "Венера", 
                Equator = 12103.6, 
                Previous = "null" 
            };

            var obj2 = new 
            { 
                Position = 3,
                Name = "Земля", 
                Equator = 12742, 
                Previous =  obj1 
            };

            var obj3 = new { 
                Position = 4, 
                Name = "Марс", 
                Equator = 6780, 
                Previous = obj2 
            };

            var obj4 = new { 
                Position = 2, 
                Name = "Венера", 
                Equator = 12103.6, 
                Previous = "null" 
            };

            PrintInfo(obj1, obj1);
            PrintInfo(obj1, obj2);
            PrintInfo(obj1, obj3);
            PrintInfo(obj1, obj4);
        }
    }
}
