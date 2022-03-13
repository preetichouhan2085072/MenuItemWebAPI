using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MenuItemListing.Models;

namespace MenuItemListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        [HttpGet]

        public List<MenuItem> MenuItems()
        {
            List<MenuItem> menuList = new List<MenuItem>()

            {

            new MenuItem() { Id = 101, Name = "Paneer Kofta", freeDelivery = false, Price = 250, DateOfLaunch = new DateTime(2020,03,01), Active = true },
            new MenuItem() { Id = 102, Name = "Pizza", freeDelivery = false, Price = 100, DateOfLaunch = new DateTime(2021,09,10), Active = true },
            new MenuItem() { Id = 103, Name = "Mashroom carry", freeDelivery = false, Price = 200, DateOfLaunch = new DateTime(2020,03,01), Active = false },
            new MenuItem() { Id = 104, Name = "Burger", freeDelivery = false, Price = 150, DateOfLaunch = new DateTime(2021,03,01), Active = true },
            new MenuItem() { Id = 105, Name = "Pasta", freeDelivery = false, Price = 100, DateOfLaunch = new DateTime(2022,03,01), Active = true }

            };

            return menuList;
        }


        [HttpGet("{Id}")]
        public MenuItem GetMenuItemById(int id)
        {
            List<MenuItem> menuList = new List<MenuItem>()

            {

            new MenuItem() { Id = 101, Name = "Paneer Kofta", freeDelivery = false, Price = 250, DateOfLaunch = new DateTime(2020,03,01), Active = true },
            new MenuItem() { Id = 102, Name = "Pizza", freeDelivery = false, Price = 100, DateOfLaunch = new DateTime(2021,09,10), Active = true },
            new MenuItem() { Id = 103, Name = "Mashroom carry", freeDelivery = false, Price = 200, DateOfLaunch = new DateTime(2020,03,01), Active = false },
            new MenuItem() { Id = 104, Name = "Burger", freeDelivery = false, Price = 150, DateOfLaunch = new DateTime(2021,03,01), Active = true },
            new MenuItem() { Id = 105, Name = "Pasta", freeDelivery = false, Price = 100, DateOfLaunch = new DateTime(2022,03,01), Active = true }

            };

            MenuItem obj = menuList.SingleOrDefault(item => item.Id == id);
            return obj;

        }
    }
}
