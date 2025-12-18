using System.ComponentModel.DataAnnotations;

namespace HospitalPortal.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Patient Name")]
        public string Name { get; set; }

        [Required]
        [Range(0, 120)]
        public int Age { get; set; }

        [Required]
        public string Symptoms { get; set; }

        public DateTime RegistrationDate { get; set; } = DateTime.Now;
    }
}