using Microsoft.AspNetCore.Mvc;
using OrderApplicationPage.Data;
using OrderApplicationPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApplicationPage.Controllers
{
    public class OrderController : Controller
    {

        private readonly FormDbContext _db;
        public OrderController (FormDbContext db)
        {
            _db = db;
            
        }

        public IActionResult Index()
        {
            IEnumerable<Order> objList = _db.Orders;
           
            return View(objList);
        }

        //get
        public IActionResult Create()
        {
            return View();
        }


        //post
        //post 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Order obj)
        {
           

            _db.Orders.Add(obj);
            _db.SaveChanges();


            return RedirectToAction("Index");
            
          
        }

        //edit
        public IActionResult Edit(int? id)
        {
            if (id == null || id==0)
            {
                return NotFound();
            }

            var obj = _db.Orders.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        
        //post -edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Order obj)
        {
            

                _db.Orders.Update(obj);
                _db.SaveChanges();


                return RedirectToAction("Index");
            
           
        }



        //get - delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Orders.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }


        //post -delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Orders.Find(id); 
            
            _db.Orders.Remove(obj);
            _db.SaveChanges();


            return RedirectToAction("Index");


        }
    }
}
