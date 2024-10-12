using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDDapper.Validator
{
    public  class UserCliente
    { 
        public string Nombre_Compañia { get; set; }
        public string Nombre_Contacto { get; set; }
        public string Titulo_contacto { get; set; }
        public string Dirrecion  { get; set; }
        public string Ciudad { get; set; }
        public string Codigp_Postal { get; set; }
        public string Region  { get; set; }
        public string Pais { get; set; }
        public string Telefono  { get; set; }
        public string Fax { get; set; }

    }
    public class ClientesValidator : AbstractValidator<UserCliente>
    {
        public ClientesValidator() {


            RuleFor(cliente => cliente.Nombre_Compañia).NotEmpty().WithMessage("El nombre de la compañía es requerido.").MaximumLength(50).WithMessage("El nombre de la compañía no puede tener más de 100 caracteres.");
            RuleFor(cliente => cliente.Nombre_Contacto).NotEmpty().WithMessage("El nombre del contacto es requerido.").MaximumLength(50).WithMessage("El nombre del contacto no puede tener más de 50 caracteres.");
            RuleFor(cliente => cliente.Titulo_contacto).NotEmpty().WithMessage("El título del contacto es requerido.").MaximumLength(50).WithMessage("El título del contacto no puede tener más de 50 caracteres.");
            RuleFor(cliente => cliente.Dirrecion).NotEmpty().WithMessage("La dirección es requerida.").MaximumLength(150).WithMessage("La dirección no puede tener más de 150 caracteres.");
            RuleFor(cliente => cliente.Ciudad).NotEmpty().WithMessage("La ciudad es requerida.").MaximumLength(50).WithMessage("La ciudad no puede tener más de 50 caracteres.");
            RuleFor(cliente => cliente.Codigp_Postal).NotEmpty().WithMessage("El código postal es requerido.").MaximumLength(10).WithMessage("El código postal no puede tener más de 10 caracteres.");
            RuleFor(cliente => cliente.Region).NotEmpty().WithMessage("La región es requerida.").MaximumLength(50).WithMessage("La región no puede tener más de 50 caracteres.");
            RuleFor(cliente => cliente.Pais).NotEmpty().WithMessage("El país es requerido.").MaximumLength(50).WithMessage("El país no puede tener más de 50 caracteres.");
            RuleFor(cliente => cliente.Telefono).NotEmpty().WithMessage("El teléfono es requerido.").MaximumLength(20).WithMessage("El teléfono no puede tener más de 20 caracteres.");
            RuleFor(cliente => cliente.Fax).NotEmpty().WithMessage("El fax es requerido.").MaximumLength(20).WithMessage("El fax no puede tener más de 20 caracteres.");


        }
    }
}
