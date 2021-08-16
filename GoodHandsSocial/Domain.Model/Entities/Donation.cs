using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Entities
{
    public class Donation
    {
        public Guid Id { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [Required(ErrorMessage = "Este campo é obrigatorio")]
        public string DonationName { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required(ErrorMessage = "Este campo é obrigatorio")]
        public string Description { get; set; }

        public bool HaveCourier { get; set; }

        [Range(1, 100)]
        public int Quantity { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data de Registro")]
        public DateTime DateOfRegister { get; set; }
    }
}