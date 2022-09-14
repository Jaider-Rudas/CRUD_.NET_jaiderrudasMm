﻿using System.ComponentModel.DataAnnotations;

namespace CustomerApi.Dtos
{
    public class CreateCustomerDto
    {
        [Required (ErrorMessage ="El Nombre es de carácter obligatorio")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "El Apellido es de carácter obligatorio")]
        public string LastName { get; set; }
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "el email no es correcto")]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}

