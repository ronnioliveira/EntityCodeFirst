using CodeFirst.Data;
using CodeFirst.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using(CarStoreContext context = new CarStoreContext())
            {
                context.Stores.Add(new Store()
                {
                    Name = "Porschers"
                });

                var idStore = context.SaveChanges();

                context.Cars.Add(new Car()
                {
                    Name = "Cayman",
                    AutoMaker = "Porsche",
                    YearModel = "2019/2019",
                    IdStore = idStore
                });

                context.SaveChanges();
            }

            Console.WriteLine("Registros salvos com sucesso.");
            Console.ReadKey();
        }
    }
}
