using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDDapper.Validator
{
  
        public class UserProducto
        {
            public string Id { get; set; }
            public string Nameproducto { get; set; }
            public string ProductoId { get; set; }
            public string IDCategoria { get; set; }
            public string IDSuplidor { get; set; }

            public int Cantidad { get; set; }
            public string PrecioUnidad { get; set; }
            public string UnidadesStock { get; set; }
            public string UnidadesenOrden { get; set; }
            public string ReordenarNivel { get; set; }
            public string Interumpido { get; set; }


        }
        public class productoVAlidator : AbstractValidator<UserProducto>
        {
            private const int MaxSmallInt = short.MaxValue;
            public productoVAlidator()
            {

                RuleFor(a => a.Nameproducto).NotEmpty().MinimumLength(2).WithMessage("El nombre del producto es obligatorio y debe tener al menos 2 caracteres.").MaximumLength(40);

                RuleFor(a => a.IDCategoria).NotEmpty().WithMessage("La categoría es obligatoria.");

                RuleFor(a => a.IDSuplidor).NotEmpty().WithMessage("El suplidor es obligatorio.");

                RuleFor(a => a.Cantidad)
                       .NotEmpty().WithMessage("La cantidad es obligatoria.")
                       .Must(BeNumeroPositivo).WithMessage("La cantidad debe ser un número positivo.");

                RuleFor(a => a.PrecioUnidad).NotEmpty().Must(BeValidDecimal).WithMessage("El precio por unidad debe ser un número decimal válido.");


                RuleFor(a => a.UnidadesStock)
                   .NotEmpty().WithMessage("Las unidades en stock no pueden estar vacías.")
                   .Must(BeValidShort).WithMessage($"Las unidades en stock deben ser un número entero corto válido y no deben superar el valor máximo de {MaxSmallInt}.");

                RuleFor(a => a.UnidadesenOrden)
                           .NotEmpty().WithMessage("Las unidades en orden no pueden estar vacías.")
                           .Must(BeValidShort).WithMessage($"Las unidades en orden deben ser un número entero corto válido y no deben superar el valor máximo de {MaxSmallInt}.");

                RuleFor(a => a.ReordenarNivel)
                    .NotEmpty().WithMessage("El nivel de reordenamiento no puede estar vacío.")
                    .Must(BeValidShort).WithMessage($"El nivel de reordenamiento debe ser un número entero corto válido y no debe superar el valor máximo de {MaxSmallInt}.");

                RuleFor(a => a.Interumpido).NotEmpty().WithMessage("El suplidor es obligatorio.");
            }
            private bool BeNumeroPositivo(int cantidad)
            {
                return cantidad > 0;
            }

            private bool BeValidDecimal(string value)
            {
                return decimal.TryParse(value, out _);
            }

            private bool BeValidShort(string value)
            {
                return short.TryParse(value, out _);
            }
        }
}
