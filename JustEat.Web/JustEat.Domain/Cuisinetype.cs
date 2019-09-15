using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustEat.Domain
{
    public class Cuisinetype
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SeoName { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
