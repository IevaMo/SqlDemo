using EntityFrameworkDemo.Model;
using EntityFrameworkDemo.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EntityFrameworkDemo.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class FruitController : ControllerBase
    {
        private readonly FruitService _fruitService;

        public FruitController(FruitService fruitService)
        {
            _fruitService = fruitService;
        }
        [HttpGet]
        public List<Fruit> GetAll()
        {
            return _fruitService.GetAll();
        }

        [HttpPost]
        public void AddItem(Fruit fruit) // reikia nurodyti koki mes Item norime prideti
        {
            _fruitService.AddItem(fruit);
        }


        [HttpPut]
        public void UpdateItem(Fruit fruit) // reikia nurodyti koki mes Item norime prideti
        {
            _fruitService.AddItem(fruit);
        }

        [HttpDelete("{id}")]
        public void DeteleItem(int id)
        {
            _fruitService.DeleteItem(id);
        }
    }
}
