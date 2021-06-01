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
    public class QuestionsController : Controller
    {
        //static MySqlConnection db = new MySqlConnection("Server=localhost;Database=stackoverflow;Uid=root;Password=abc123");

        public IActionResult Index()
        {
            List<Questions> ans = DAL.ReadAllQuestions();
            return View(ans);
        }

        public IActionResult ListofQuestions()
        {
            return View();
        }

        public IActionResult AddQuestion(Questions que)
        {
            DAL.AddQuestion(que);
            return RedirectToAction("Index");
        }

        public IActionResult AskQuestionForm(string id)
        {
            ViewBag.depid = id;
            return View();
        }

        public IActionResult EditQuestionForm(int id)
        {
            Questions que = DAL.ReadOneQuestion(id);
            return View(que);
        }

        [HttpPost]
        public IActionResult EditQuestion(Questions que)
        {
            DAL.EditQuestion(que);
            return RedirectToAction("index");
        }

        public IActionResult deleteform(int id)
        {
            return View(id);
        }

        public IActionResult DeleteQuestion(int id)
        {
            DAL.DeleteQuestion(id);
            return RedirectToAction("index");
        }
    }
}
