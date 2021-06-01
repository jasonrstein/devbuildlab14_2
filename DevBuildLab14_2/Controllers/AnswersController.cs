using Dapper.Contrib.Extensions;
using DevBuildLab14_2.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBuildLab14_2.Controllers
{
    public class AnswersController : Controller
    {
        static MySqlConnection db = new MySqlConnection("Server=localhost;Database=stackoverflow;Uid=root;Password=abc123");

        public IActionResult Index()
        {
            List<Answers> ans = db.GetAll<Answers>().ToList();
            return View(ans);
        }

        public IActionResult ListofAnswers()
        {
            return View();
        }

        public IActionResult AskAnswer()
        {
            return View();
        }

        public IActionResult AddAnswer()
        {
            return View();
        }

        public IActionResult EditAnswerForm()
        {
            return View();
        }

        public IActionResult EditAnswer()
        {
            return View();
        }

        public IActionResult DeleteAnswer()
        {
            return View();
        }
    }
}
