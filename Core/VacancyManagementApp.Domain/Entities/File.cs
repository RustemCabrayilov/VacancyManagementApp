using System.ComponentModel.DataAnnotations.Schema;
using VacancyManagementApp.Domain.Common;

namespace VacancyManagementApp.Domain.Entities
{
    public class File : BaseEntity
    {
        public string FileName { get; set; }
        public string Path { get; set; }

        [NotMapped]
        public override DateTime UpdatedDate { get => base.UpdatedDate; set => base.UpdatedDate = value; }


    }
}
