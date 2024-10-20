using VacancyManagementApp.Application.Repositories;
using VacancyManagementApp.Domain.Entities;
using VacancyManagementApp.Persistence.Contexts;

namespace VacancyManagementApp.Persistence.Repositories
{
    public class UserQuestionWriteRepository : WriteRepository<UserQuestion>,
        IUserQuestionWriteRepository
    {
        public UserQuestionWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
