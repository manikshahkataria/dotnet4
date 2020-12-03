using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class Emp : Controller
    {
        public IActionResult Index()
        {
            List<Empcs> empList = new List<Empcs>
        {
            new Empcs
            {
                Eid=1,
                EmpName="Manu",
                EmpDesignation="Manager",
                EmpDOJ=new DateTime(month:02,day:29,year:2000)
            },
            new Empcs
            {
                Eid=2,
                EmpName="Tina",
                EmpDesignation="Developer",
                EmpDOJ=new DateTime(month:11,day:03,year:2005)
            },
            new Empcs
            {
                Eid=5,
                EmpName="Ankit",
                EmpDesignation="HR",
                EmpDOJ=new DateTime(month:12,day:30,year:2016)
            },
            new Empcs
            {
                Eid=6,
                EmpName="Ankur",
                EmpDesignation="Manager",
                EmpDOJ=new DateTime(month:08,day:25,year:2010)
            }
        };
            return View(empList);
        }
    }
}
