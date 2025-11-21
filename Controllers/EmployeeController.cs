using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using loginPage.Data;
using loginPage.Models;
using loginPage.ViewModels;
namespace loginPage.Controllers{
    public class EmployeeController:Controller{
        private readonly EmployeeContext _context;
        public EmployeeController(EmployeeContext context){
            _context = context;
        }
        public IActionResult Index(){
            var data = _context.employee.ToList();
            return View(data);
        }
        public IActionResult Edit(int eid){
            var data = _context.employee.Find(eid);
            return View(data);
        }
        
        [HttpPost]
        public IActionResult Edit(EditViewModel model){
        if (ModelState.IsValid)
        {
             employee emp=new employee{
                    eid=model.Eid,
                    name = model.Name,
                    address=model.Address,
                    email=model.Email,
                };
            _context.employee.Update(emp);
            _context.SaveChanges();
            return RedirectToAction("Index" , "Employee");
        }       
            return View(model);
        }
    }
}