using EntityFrameworkDemo.Data;
using EntityFrameworkDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkDemo.Services
{
    public class FruitService
    {

        public FruitService(MainContext context) // iki cia
        {
            _context = context;
        }
        private readonly MainContext _context;

        public List<Fruit> GetAll()
        {
            var fruits = _context.Fruits.OrderBy(x => x.Id).ToList();
            return fruits;
        }

        public Fruit Get(int id)
        {
            var item = _context.Fruits.Where(i => i.Id == id).SingleOrDefault();
            return item;
        }

        public void AddItem(Fruit fruit)
        {
            _context.Fruits.Add(fruit);
            _context.SaveChanges();
        }

        public void UpdateItem(Fruit fruit)
        {
            foreach (var value in _context.Fruits)
            {
                if (value.Id == fruit.Id)
                {
                    value.Name = fruit.Name;
                }
            }
            _context.SaveChanges();
        }

        public void DeleteItem(int id)
        {
            var fruit = _context.Fruits.Where(i => i.Id == id).SingleOrDefault();
            _context.Fruits.Remove(fruit);
            _context.SaveChanges();
        }
    }

}
