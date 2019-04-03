using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleMvcApp.Models
{
    public class ProfileModel
    {
        [Display(Name = "Correo Electronico")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Porfavor ingrese su nombre")]
        [DataType(DataType.Text)]
        [Display(Name = "Nombre")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Porfavor ingrese solo letras")]
        public string Name { get; set; }

        [Display(Name = "Primer Apellido")]
        [Required(ErrorMessage = "Porfavor ingrese su primer apellido")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Porfavor ingrese solo letras")]
        public string FirstLastName { get; set; }

        [Display(Name = "Segundo Apellido")]
        [Required(ErrorMessage = "Porfavor ingrese su segundo apellido")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Porfavor ingrese solo letras")]
        public string SecondLastName { get; set; }

        [Display(Name = "Numero de Telefono")]
        [Required(ErrorMessage = "Porfavor ingrese su numero de telefono")]
        [MaxLength(8), MinLength(8)]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("([0-9]+)", ErrorMessage = "Porfavor ingrese solo numeros")]
        public string PhoneNumber { get; set; }


        [Display(Name = "Identificacion")]
        [Required(ErrorMessage = "Porfavor ingrese su ID")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Porfavor ingrese solo numeros")]
        public string PersonID { get; set; }

        [Display(Name = "Tipo de Identificacion")]
        [Required(ErrorMessage = "Porfavor ingrese el tipo de ID")]
        public string IDType { get; set; }
    }
}
