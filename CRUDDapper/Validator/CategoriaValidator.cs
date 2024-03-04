using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDDapper.Validator
{
    public class UserCategoria
    {
        public string Categoriname { get; set; }

        public string Descripcion { get; set; }
    }

    public class CategoriaValidator : AbstractValidator<UserCategoria>
    {
        public CategoriaValidator()
        {
            // RuleFor(a=>a.Categoriname).NotEmpty().MinimumLength(2).MaximumLength(15);
            RuleFor(a => a.Categoriname)
           .NotEmpty()
           .WithMessage("El nombre de la categoría no puede estar vacío.")
           .MinimumLength(2)
              .MaximumLength(15);
            RuleFor(a => a.Descripcion).NotEmpty().WithMessage("La descripcion de la categoria no puede estar vacia ").MinimumLength(5)
                .WithMessage("La descripcion de la categoria  es obligatorio y debe tener al menos 5 caracteres.").MaximumLength(1024);


        }
    }
}
