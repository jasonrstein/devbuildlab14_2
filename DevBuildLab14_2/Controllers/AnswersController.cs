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

        public IActionResult AddAnswerForm()
        {
            return View();
        }

        public IActionResult AddAnswer(Answers ans)
        {
            DAL.AddAnswer(ans);
            return RedirectToAction("Index");
        }

        public IActionResult EditAnswerForm(int id)
        {
            Answers ans = DAL.ReadOneAnswers(id);
            return View(ans);
        }

        public IActionResult EditAnswer(Answers ans)
        {
            DAL.EditAnswer(ans);
            return RedirectToAction("index"); 
        }

        public IActionResult DeleteAnswer(int id)
        {
            DAL.DeleteAnswer(id);
            return RedirectToAction("index");
        }
    }
}
