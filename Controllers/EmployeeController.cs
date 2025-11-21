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

        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeViewModel model){
            if (ModelState.IsValid)
        {
             employee emp=new employee{
                    name = model.Name,
                    address=model.Address,
                    email=model.Email,
                };
            _context.employee.Add(emp);
            _context.SaveChanges();
            return RedirectToAction("Index" , "Employee");
        }  
        return View(model);    
        }

        public IActionResult Edit(int id){
            var data = _context.employee.Find(id);
            if(data==null){
                return NotFound();
            }
            var model=new EmployeeViewModel{
                Eid=data.eid,
                Name=data.name,
                Address=data.address,
                Email=data.email,
            };
            return View(model);
        }
        
        [HttpPost]
        public IActionResult Edit(int eid,EmployeeViewModel model){
            if(eid!=model.Eid){
                return NotFound();
            }
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