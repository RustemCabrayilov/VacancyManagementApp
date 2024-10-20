using VacancyManagementApp.Application.Repositories;
using VacancyManagementApp.Domain.Entities;
using VacancyManagementApp.Persistence.Contexts;

namespace VacancyManagementApp.Persistence.Repositories
{
    public class UserQuestionReadRepository : ReadRepository<UserQuestion>, IUserQuestionReadRepository
    {
        public UserQuestionReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
