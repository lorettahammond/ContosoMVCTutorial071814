using System;
using System.ComponentModel.DataAnnotations;
namespace ContosoSite.Models
{
    public class StudentMetadata
    {
        [StringLength(50)]
        public string LastName;
        [StringLength(50)]
        public string FirstName;
        [StringLength(50)]
        public string MiddleName;
    }
    public class EnrollmentMetadata { [Range(0, 4)] public Nullable<decimal> Grade; }
}