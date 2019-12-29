using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourist_agency
{
    public interface IRelaxation
    {
        string Relaxation();
    }
    public interface IExursion
    {
        string Exursion();
    }
    public interface IReatment
    {
        string Reatment();
    }
    public interface IShopping
    {
        string Shopping();
    }
    public interface ICruise
    {
        string Cruise();
    }
    public interface ISkiing
    {
        string Skiing();
    }        
    public class Voucher
    {
        public ICollection<Voucher> Travel { get; set; }
        public  List<string> transport = new List<string>() { "car", "plane", "train", "bus", "on foot" };
        public  List<string> nutrition = new List<string>() { "breakfast", "dinner", "supper" };
        public  List<string> number_of_days = new List<string>() { "3", "7", "12", "14", "18", "20", "25", "30", "60" };
    }
    public class Dubai : Voucher, IRelaxation, IShopping, IExursion
    {
        public string Relaxation()
        {
            return $"{GetType().Name} ";
        }
        public string Shopping()
        {
            return $"{GetType().Name} ";
        }
        public string Exursion()
        {
            return $"{GetType().Name} ";
        }
        public void Get()
        {
            Console.Write("You can get there: ");
            for (int i = 0; i < transport.Count; i++)
            {
                if (i == 0 || i == 3 || i == 2)
                    continue;
                Console.Write(transport[i]+" ");
            }
            Console.WriteLine();
            Console.Write("There is: ");
            for (int i = 0; i < nutrition.Count; i++)
            {
                
                Console.Write(nutrition[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Duration in days: ");
            for (int i = 0; i < number_of_days.Count; i++)
            {
                
                Console.Write(number_of_days[i] + " ");
            }
            Console.WriteLine();
        }
    }
    public class Singapur : Voucher, IRelaxation, IShopping, ICruise
    {
        public string Relaxation()
        {
            return $"{GetType().Name} ";
        }
        public string Shopping()
        {
            return $"{GetType().Name} ";
        }
        public string Cruise()
        {
            return $"{GetType().Name} ";
        }
        public void Get()
        {
            Console.Write("You can get there: ");
            for (int i = 0; i < transport.Count; i++)
            {
                if (i == 1 || i == 2)
                    continue;
                Console.Write(transport[i] + " ");
            }
            Console.WriteLine();
            Console.Write("There is: ");
            for (int i = 0; i < nutrition.Count; i++)
            {
                
                Console.Write(nutrition[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Duration in days: ");
            for (int i = 0; i < number_of_days.Count; i++)
            {
                if (i == 1 || i == 2 || i == 6 || i == 7)
                    continue;
                Console.Write(number_of_days[i] + " ");
            }
            Console.WriteLine();
        }
    }
    public class New_York : Voucher, IReatment, IShopping, ISkiing
    {
        public string Reatment()
        {
            return $"{GetType().Name} ";
        }
        public string Shopping()
        {
            return $"{GetType().Name} ";
        }
        public string Skiing()
        {
            return $"{GetType().Name} ";
        }
        public void Get()
        {
            Console.Write("You can get there: ");
            for (int i = 0; i < transport.Count; i++)
            {
                if (i == 1 || i == 3 || i == 4)
                    continue;
                Console.Write(transport[i] + " ");
            }
            Console.WriteLine();
            Console.Write("There is: ");
            for (int i = 0; i < nutrition.Count; i++)
            {
                if (i == 1  || i == 3)
                    continue;
                Console.Write(nutrition[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Duration in days: ");
            for (int i = 0; i < number_of_days.Count; i++)
            {               
                Console.Write(number_of_days[i] + " ");
            }
            Console.WriteLine();
        }
    }
    public class Kuala_lumpur : Voucher, IRelaxation, IShopping, ICruise
    {
        public string Relaxation()
        {
            return $"{GetType().Name} ";
        }
        public string Shopping()
        {
            return $"{GetType().Name} ";
        }
        public string Cruise()
        {
            return $"{GetType().Name} ";
        }
        public void Get()
        {            
            Console.Write("You can get there: ");
            for (int i = 0; i < transport.Count; i++)
            {
                if (i == 1|| i==3||i==4)
                    continue;
                Console.Write(transport[i]+" ");                
            }
                Console.WriteLine();
                Console.Write("There is: ");
                for (int i = 0; i < nutrition.Count; i++)
                {
                    if (i == 1 || i ==2 )
                        continue;
                    Console.Write(nutrition[i] + " ");
                }
                Console.WriteLine();
                Console.Write("Duration in days: ");
                for (int i = 0; i < number_of_days.Count; i++)
                {
                    if (i == 0 || i == 3 || i == 6|| i == 7)
                        continue;
                    Console.Write(number_of_days[i] + " ");
                }
                Console.WriteLine();
        }        
    }
    public class Tokyo : Voucher, IRelaxation, IReatment, IExursion
    {
        public string Relaxation()
        {
            return $"{GetType().Name} ";
        }
        public string Reatment()
        {
            return $"{GetType().Name} ";
        }
        public string Exursion()
        {
            return $"{GetType().Name} ";
        }        
            public void Get()
            {
                Console.Write("You can get there:"); 
                for (int i = 0; i < transport.Count; i++)
                {
                    if (i == 0 || i == 2 || i == 4)
                        continue;
                    Console.Write(transport[i] + " ");
                }
                Console.WriteLine();
                Console.Write("There is: ");
                for (int i = 0; i < nutrition.Count; i++)
                {
                    if ( i == 2 )
                        continue;
                    Console.Write(nutrition[i] + " ");
                }
                Console.WriteLine();
                Console.Write("Duration in days: ");
                for (int i = 0; i < number_of_days.Count; i++)
                {
                    if (i == 0 || i == 2 || i == 5 || i == 7)
                        continue;
                    Console.Write(number_of_days[i]+" ");
                }
            Console.WriteLine();
            }
    }
    public class Search_Travel
    {
        public void Search()
        {
            List<Voucher> travel = new List<Voucher>() {
            new Tokyo(),
            new New_York(),
            new Kuala_lumpur(),
            new Singapur(),
            new Dubai()
            };
            List<string> name = new List<string>() { };
            Console.WriteLine("What do you do?");
            string act = Console.ReadLine();
            switch (act)
            {
                case "shopping":
                    var shoppinges = travel.Where(t => t is IShopping).Select(t => t as IShopping);
                    foreach (var shopping in shoppinges)
                    {
                        name.Add(shopping.Shopping());
                    }
                    break;
                case "relaxation":
                    var relaxations = travel.Where(t => t is IRelaxation).Select(t => t as IRelaxation);
                    foreach (var relaxation in relaxations)
                    {
                        name.Add(relaxation.Relaxation());
                    }
                    break;
                case "exursion":
                    var exursiones = travel.Where(t => t is IExursion).Select(t => t as IExursion);
                    foreach (var exursion in exursiones)
                    {
                        name.Add(exursion.Exursion());
                    }
                    break;
                case "reatment":
                    var reatmentes = travel.Where(t => t is IReatment).Select(t => t as IReatment);
                    foreach (var reatment in reatmentes)
                    {
                        name.Add(reatment.Reatment());
                    }
                    break;
                case "cruise":
                    var cruises = travel.Where(t => t is ICruise).Select(t => t as ICruise);
                    foreach (var cruise in cruises)
                    {
                        name.Add(cruise.Cruise());
                    }
                    break;
                case "skiing":
                    var skiinges = travel.Where(t => t is ISkiing).Select(t => t as ISkiing);
                    foreach (var skiing in skiinges)
                    {
                        name.Add(skiing.Skiing());
                    }
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
            for (int i = 0; i < name.Count; i++)
            {
                switch (name[i])
                {
                    case "Dubai ":
                        Dubai dubai = new Dubai { };
                        Console.WriteLine("Dubai");
                        dubai.Get();
                        Console.WriteLine();
                        break;
                    case "Singapur ":
                        Singapur singapur = new Singapur { };
                        Console.WriteLine("Singapur");
                        singapur.Get();
                        Console.WriteLine();
                        break;
                    case "New_York ":
                        New_York new_york = new New_York { };
                        Console.WriteLine("New_York");
                        new_york.Get();
                        Console.WriteLine();
                        break;
                    case "Kuala_lumpur ":
                        Kuala_lumpur kuala_lumpur = new Kuala_lumpur { };
                        Console.WriteLine("Kuala_lumpur");
                        kuala_lumpur.Get();
                        Console.WriteLine();
                        break;
                    case "Tokyo ":
                        Tokyo tokyo = new Tokyo { };
                        Console.WriteLine("Tokyo");
                        tokyo.Get();
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Search_Travel s = new Search_Travel { };
            s.Search();            
            Console.ReadKey();
        }
    }
}
