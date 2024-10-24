using VacancyManagementApp.Domain.Common;
using VacancyManagementApp.Domain.Entities.Identity;

namespace VacancyManagementApp.Domain.Entities
{
    public class UserQuestion : BaseEntity
    {
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public Guid QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
