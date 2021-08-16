using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Entities
{
    public class Profile
    {
        public Guid Id { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Name { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [Required(ErrorMessage = "Este campo é obrigatório")]

        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(100, ErrorMessage = "O {0} deve ter pelo menos {2} caracteres.", MinimumLength = 6)]
        public string Biografy { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }

        public string ZipCode { get; set; }

        [StringLength(50, ErrorMessage = "O {0} deve ter pelo menos {2} caracteres.", MinimumLength = 6)]
        public string Address { get; set; }

        [StringLength(50, ErrorMessage = "O {0} deve ter pelo menos {2} caracteres.", MinimumLength = 6)]
        public string AddressDetails { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        public string UserId { get; set; }
    }
}