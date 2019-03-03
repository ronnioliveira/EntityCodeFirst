using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entity
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AutoMaker { get; set; }
        public string YearModel { get; set; }
        public Store Store { get; set; }
        public int IdStore { get; set; }
    }
}
