using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkDemo.Model
{
    public class Fruit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StoreId { get; set; }
    }
}
