using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatinumCityManagement.Shared.Domain
{
    public class Booking : BaseDomainModel
    {
        [Required(ErrorMessage = "Booking type is required")]
        [RegularExpression("Student|Adult", ErrorMessage = "Invalid Booking Type")]
        public string BookingType { get; set; }

        [Required]
        [Range(0, 100000, ErrorMessage = "Total price must be between 0 and 100000")]
        public double TotalPrice { get; set; }

        [Required]
        [Range(1, 100, ErrorMessage = "Seat quantity must be between 1 and 100")]
        public int SeatQty { get; set; }

        [Required(ErrorMessage = "Seat number is required")]
        [StringLength(30, ErrorMessage = "Seat number cannot exceed 30 characters")]
        public string SeatNo { get; set; }

        [Required]
        [FutureDate(ErrorMessage = "Booking date and time must be in the future.")]
        public DateTime BookingDateTime { get; set; }
        public int StaffId { get; set; }
        public virtual Staff? Staff { get; set; }
		public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }
        public int ScreeningId { get; set; }
        public virtual Screening? Screening { get; set; }


        [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
        public class FutureDateAttribute : ValidationAttribute
        {
            public FutureDateAttribute() : base("Date must be in the future")
            {
            }

            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                if (value is DateTime dateTime)
                {
                    if (dateTime < DateTime.Now)
                    {
                        return new ValidationResult(GetErrorMessage());
                    }
                }
                else
                {
                    return new ValidationResult("Invalid date format");
                }

                return ValidationResult.Success;
            }

            private string GetErrorMessage()
            {
                return $"Booking date and time must be in the future.";
            }
        }




    }
}

