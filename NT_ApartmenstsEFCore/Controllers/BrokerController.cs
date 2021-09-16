using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NT_ApartmenstsEFCore.Data;
using NT_ApartmenstsEFCore.DTOs;
using NT_ApartmenstsEFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NT_ApartmenstsEFCore.Controllers
{
    public class BrokerController : Controller
    {
        private readonly DataContext _context;

        public BrokerController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var brokers = _context.Brokers
                .Include(s => s.Company).ToList();

            var allCompanies = _context.Companies.ToList();

            var dto = new BrokerIndex()
            {
                Brokers = brokers,
                Companies = allCompanies
            };

            return View(dto);
        }

        [HttpPost]
        public IActionResult Index(BrokerIndex model)
        {
            var items = _context.Brokers
                .Include(s => s.Company).ToList();

            var allCompanies = _context.Companies.ToList();

            var dto = new BrokerIndex()
            {
                Brokers = items.Where(i => i.CompanyId == model.CompanyId || model.CompanyId == 0).ToList(),
                Companies = allCompanies
            };

            return View(dto);
        }

        public IActionResult Add()
        {
            var broker = new BrokerCreate();
            broker.Companies = _context.Companies.ToList();
            return View(broker);
        }

        [HttpPost]
        public IActionResult Add(BrokerCreate brokerCreate)
        {
            var mappedEntity = new BrokerModel()
            {
                Name = brokerCreate.Name,
                CompanyId = brokerCreate.CompanyId
            }; //mapping

            _context.Brokers.Add(mappedEntity);

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}

