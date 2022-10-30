using System;
using System.Collections.Generic;
using System.Linq;
using DgKala.Models.Context;
using DgKala.Models.Entities.Quesion;
using DgKala.Models.ViewModels.Question;
using Microsoft.EntityFrameworkCore;

namespace DgKala.Repository
{
    public interface IForumServices
    {
        #region Question

        int AddQuestion(Question question);
        ShowQuestionViewModel ShowQuestion(int questionId);

        #endregion

        #region Answer

        void AddAnswer(Answer answer);
        void ChangeIsTrueAnswer(int questionId,int answerId);
        IEnumerable<Question> GetQuestion(int? categoryId,string filter = "");

        #endregion
    }


    public class ForumServices : IForumServices
    {
        private DgkalaContext _context;

        public ForumServices(DgkalaContext context)
        {
            _context = context;
        }
        public int AddQuestion(Question question)
        {
           question.CreateDate=DateTime.Now;
           ;
           question.ModifiedDate = DateTime.Now;
           _context.Add(question);
           _context.SaveChanges();
           return question.QuestionId;
        }
        public ShowQuestionViewModel ShowQuestion(int questionId)
        {
            var question = new ShowQuestionViewModel();

            question. Question = _context.Questions.Include(q => q.User)
                .FirstOrDefault(q => q.QuestionId == questionId);
            question.Answers = _context.Answers.Where(a => a.QuestionId == questionId).Include(a=>a.User).ToList();
           
            return question;

        }
        public void AddAnswer(Answer answer)
        {
            _context.Answers.Add(answer);
            _context.SaveChanges();
        }
        public void ChangeIsTrueAnswer(int questionId,int answerId)
        {
            var answer = _context.Answers.Where(a => a.QuestionId == questionId);
            foreach (var ans in answer)
            {
                ans.IsTrue = false;
                if (ans.AnswerId == answerId)
                {
                    ans.IsTrue = true;
                }
            }
            _context.UpdateRange(answer);
            _context.SaveChanges();
        }
        public IEnumerable<Question> GetQuestion(int? categoryId,string filter = "")
        {
            IQueryable<Question>result= _context.Questions
                .Where(q=>EF.Functions.Like(q.Title,$"%{filter}%"));
            if (categoryId != null)
            {
                result = result.Where(q => q.CategoryId == categoryId);
            }

            return result.Include(q=>q.Category)
                .Include(q=>q.User).ToList();
        }
    }
}
