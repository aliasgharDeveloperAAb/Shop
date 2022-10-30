using System.Collections.Generic;
using DgKala.Models.Entities.Quesion;

namespace DgKala.Models.ViewModels.Question
{
    public class ShowQuestionViewModel
    {
        public Entities.Quesion.Question Question { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
