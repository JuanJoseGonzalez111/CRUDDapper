using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDDapper.Validator
{

    public class UserSuplidores
    {
        public string ID { get; set; }
        public string Nombrecompañia { get; set; }
        public string Nombrecontacto { get; set; }

        public string Region { get; set; }
        public string Pais { get; set; }
        public string telefono { get; set; }

        public string COd_postal { get; set; }
        public string direccion { get; set; }



    }
    public class serSuplidoresValidator : AbstractValidator<UserSuplidores>
    {
        public serSuplidoresValidator()
        {

            RuleFor(a => a.Nombrecompañia).NotEmpty().MinimumLength(2).MaximumLength(40);
            RuleFor(a => a.Nombrecontacto).NotEmpty().MinimumLength(2).MaximumLength(30);
            RuleFor(a => a.Region).NotEmpty().MinimumLength(2).MaximumLength(15);
            RuleFor(a => a.Pais).NotEmpty().MinimumLength(2).MaximumLength(15);
            RuleFor(a => a.telefono).NotEmpty().WithMessage("El número de teléfono es obligatorio")
            .Matches(@"^\+(?:[0-9]●?){6,14}[0-9]$")
            .WithMessage("El formato del número de teléfono no es válido").MaximumLength(24);
            RuleFor(a => a.COd_postal).NotEmpty().MinimumLength(2).MaximumLength(10);
            RuleFor(a => a.direccion).NotEmpty().MinimumLength(2).MaximumLength(60);



        }
    }
}