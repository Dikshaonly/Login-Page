using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using loginPage.Data;
using loginPage.Models;
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
    }
}