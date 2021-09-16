using Microsoft.AspNetCore.Mvc;
using NT_ApartmenstsEFCore.Data;
using NT_ApartmenstsEFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NT_ApartmenstsEFCore.Controllers
{
    public class CompanyController : Controller
    {
        private readonly DataContext _context;

        public CompanyController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var companies = _context.Companies.ToList();
            return View(companies);
        }



        public IActionResult Edit(int id)
        {
            var company = _context.Companies.FirstOrDefault(s => s.Id == id);
            return View(company);
        }

        [HttpPost]
        public IActionResult Edit(CompanyModel company)
        {
            _context.Companies.Update(company);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Add()
        {
            var company = new CompanyModel();
            return View(company);
        }

        [HttpPost]
        public IActionResult Add(CompanyModel company)
        {
            _context.Companies.Add(company);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {
            var company = _context.Companies.FirstOrDefault(s => s.Id == id);
            _context.Remove(company);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
