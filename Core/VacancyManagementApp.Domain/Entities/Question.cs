using VacancyManagementApp.Domain.Common;

namespace VacancyManagementApp.Domain.Entities
{
    public class Question:BaseEntity
    {
        public string Description { get; set; }
        public List<Answer> Answers { get; set; }
        public List<UserQuestion> UserQuestions { get; set; }
    }
}
