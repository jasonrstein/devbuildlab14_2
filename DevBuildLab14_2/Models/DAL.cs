using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DevBuildLab14_2.Models
{
    public class DAL
    {
        static public IDbConnection db;
        
        public static Questions AddQuestion (int id, string username, string title, string detail, DateTime posted, string category, string tags, int status)
        {
            Questions ques = new Questions() { id = id, username = username, title = title, detail = detail, posted = posted, category = category, tags = tags, status = status };
            db.Insert(ques);
            return ques;
        }

        public static void AddQuestion(Questions ques)
        {
            //ques.username = DAL.CurrentUser;
            ques.posted = DateTime.Now;
            db.Insert(ques);
        }

        public static List<Questions> ReadAllQuestions()
        {
            return db.GetAll<Questions>().ToList();
        }

        public static Questions ReadOneQuestion(int id)
        {
            return db.Get<Questions>(id);
        }

        public static void EditQuestion(Questions ques)
        {
            db.Update(ques);
        }

        public static void DeleteQuestion(int id)
        {
            Questions ques = new Questions();
            ques.id = id;
            db.Delete(ques);
        }

        public static List<Answers> ReadAnswersToQuestions(int questionID)
        {
            return db.Query<Answers>($"select * from answers where questionID = '{questionID}'").ToList();
        }

        public static void DeleteAnswer(int id)
        {
            Answers ans = new Answers() { id = id };
            db.Delete(ans);
        }

        public static void AddAnswer(Answers ans)
        {
            db.Insert(ans);
        }
    }
}
