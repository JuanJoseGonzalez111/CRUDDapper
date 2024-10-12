using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDDapper.Validator
{
     public class Empleado
    {
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        public byte[] Photo { get; set; }
        public string Notes { get; set; }
     //   public int? ReportsTo { get; set; }
        public string PhotoPath { get; set; }
    }
    public class EmpleadoValidator : AbstractValidator<Empleado>
    {

        public EmpleadoValidator()
        {
            RuleFor(empleado => empleado.LastName).NotEmpty().WithMessage("El apellido es obligatorio.");
            RuleFor(empleado => empleado.FirstName).NotEmpty().WithMessage("El nombre es obligatorio.");
            RuleFor(empleado => empleado.Title).NotEmpty().WithMessage("El título es obligatorio.");
            RuleFor(empleado => empleado.TitleOfCourtesy).NotEmpty().WithMessage("El título de cortesía es obligatorio.");
            RuleFor(empleado => empleado.BirthDate).NotEmpty().WithMessage("La fecha de nacimiento es obligatoria.");
            RuleFor(empleado => empleado.HireDate).NotEmpty().WithMessage("La fecha de contratación es obligatoria.");
            RuleFor(empleado => empleado.Address).NotEmpty().WithMessage("La dirección es obligatoria.");
            RuleFor(empleado => empleado.City).NotEmpty().WithMessage("La ciudad es obligatoria.");
            RuleFor(empleado => empleado.Region).NotEmpty().WithMessage("La región es obligatoria.");
            RuleFor(empleado => empleado.PostalCode).NotEmpty().WithMessage("El código postal es obligatorio.");
            RuleFor(empleado => empleado.Country).NotEmpty().WithMessage("El país es obligatorio.");
            RuleFor(empleado => empleado.HomePhone).NotEmpty().WithMessage("El número de teléfono es obligatorio.");
            RuleFor(empleado => empleado.Extension).NotEmpty().WithMessage("La extensión es obligatoria.");
            RuleFor(empleado => empleado.Photo).NotEmpty().WithMessage("La foto es obligatoria.");
            RuleFor(empleado => empleado.Notes).NotEmpty().WithMessage("Las notas son obligatorias.");
          //  RuleFor(empleado => empleado.ReportsTo).NotEmpty().WithMessage("El informe es obligatorio.");
            RuleFor(empleado => empleado.PhotoPath).NotEmpty().WithMessage("La ruta de la foto es obligatoria.");

        }
    };
    
   

}
