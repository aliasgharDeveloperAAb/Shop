using System;
using System.Linq;
using System.Security.Claims;
using DgKala.Models.Entities.Quesion;
using DgKala.Repository;
using Ganss.Xss;
using Microsoft.AspNetCore.Mvc;

namespace DgKala.Controllers
{
    public class ForumController : Controller
    {
        private IForumServices _forumServices;

        public ForumController(IForumServices forumServices)
        {
            _forumServices = forumServices;
        }
        public IActionResult Index(int? categoryId,string filter="")
        {
            ViewBag.categoryId = categoryId;
            return View(_forumServices.GetQuestion(null,filter));
        }

        #region CreateQuestion

        public IActionResult CreateQuestion(int id)
        {
            Question question = new Question()
            {
                CategoryId = id
            };
            return View(question);
        }
        [HttpPost]
        public IActionResult CreateQuestion(Question question)
        {
            if (!ModelState.IsValid)
                return View(question);


            question.UserId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier).ToString());
            int questionId = _forumServices.AddQuestion(question);
            return Redirect($"Forum/ShowQuestion/{questionId}");



        }

        #endregion

        #region ShowQuestion

        public IActionResult ShowQuestion(int id)
        {
            return View(_forumServices.ShowQuestion(id));
        }

        #endregion

        #region Answer

        public IActionResult Answer(int id, string body)
        {
            if (!string.IsNullOrEmpty(body))
            {

                var sanitizer = new HtmlSanitizer();

                body = sanitizer.Sanitize(body);


                _forumServices.AddAnswer(new Answer()
                {
                    BodyAnswer = body,
                    CreateDate = DateTime.Now,
                    UserId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier).ToString()),
                    QuestionId = id

                });
            }
            return RedirectToAction("ShowQuestion", new { id = id });
        }
        public IActionResult SelectIsTrueAnswer(int questionId, int answerId)
        {
            int currentUserId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier).ToString());
            var question = _forumServices.ShowQuestion(questionId);
            if (question.Question.UserId == currentUserId)
            {
                _forumServices.ChangeIsTrueAnswer(questionId, answerId);
            }

            return RedirectToAction("ShowQuestion", new { id = questionId });
        }
        #endregion

    }
}
