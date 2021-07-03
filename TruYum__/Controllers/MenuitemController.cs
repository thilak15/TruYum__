using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TruYum__.Models;

namespace TruYum__.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuitemController : ControllerBase
    {
        // GET: api/<MenuItemController>
        [HttpGet]
        public IEnumerable<Menuitem> Get()
        {
            return new Menuitem[] {
                new Menuitem() {Id=1,Name="Biryani",freeDelivery=true,Price=1000.00,dateOfLaunch=Convert.ToDateTime("2000-02-01"),Active=true },
                new Menuitem() {Id=2,Name="Fish",freeDelivery=false,Price=1250.00,dateOfLaunch=Convert.ToDateTime("2001-02-01"),Active=false },
                new Menuitem() {Id=3,Name="Dessert",freeDelivery=true,Price=1500.00,dateOfLaunch=Convert.ToDateTime("1999-09-15"),Active=true },

            };
        }

        // GET api/<MenuItemController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            foreach (var i in Get())
            {
                if (i.Id == id)
                {
                    return i.Name;
                }
            }
            return null;
        }
    }
}
