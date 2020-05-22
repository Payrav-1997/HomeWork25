using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HomeWork25.Models;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace HomeWork25.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            var conString = "Data Source=localhost;Initial Catalog=Person;Integrated Security=True";
            using(IDbConnection context = new SqlConnection(conString))
            {
                var list = context.Query<Person>($"SELECT * FROM PERSON").ToList();

                 return View(list);
            }
        }

       
    }
}
