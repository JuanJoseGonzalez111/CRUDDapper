using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDDapper.Validator
{
    public class UserOrdenes
    {
        public string CustomerID { get; set; }
        public string EmpleoyessID { get; set; }
        public string OrderDate { get; set; }
        public string RequireDate { get; set; }
        public string ShippedDate { get; set; }

        public string ShoVIa { get; set; }
        public string Freigt { get; set; }
        public string ShiName { get; set; }
        public string Shipaddress { get; set; }
        public string ShiCity { get; set; }
        public string Shipregion { get; set; }
        public string ShipPostalcode { get; set; }
        public string Shipcomtry { get; set; }
       /*public string ProductoID { get; set; }
        public string Precio { get; set; }
        public string Cantidad { get; set; }
        public string Discout { get; set; }*/

    }
    public class OrdenesValidator : AbstractValidator<UserOrdenes>
    {
        public OrdenesValidator()
        {

          RuleFor(a => a.CustomerID).NotEmpty().WithMessage("El Cliente no puede estar vacio.");

            RuleFor(a => a.EmpleoyessID).NotEmpty().WithMessage("El empleado  no puede estar vacio.");
            RuleFor(a => a.OrderDate).NotEmpty().WithMessage("La fecha de ordern no puede estar vacia.");


            RuleFor(a => a.RequireDate).NotEmpty().WithMessage("La fecha requerida no puede estar vacia.");
            RuleFor(a => a.ShippedDate).NotEmpty().WithMessage("La fecha de envio no puede estar vacia.");

            RuleFor(a => a.RequireDate).NotEmpty().WithMessage("La fecha requerida no puede estar vacia.");
            RuleFor(a => a.ShoVIa).NotEmpty().WithMessage("Debe seleccionar el medio de envio.");
            RuleFor(a => a.Freigt).NotEmpty().WithMessage("Ingrese el flete.");
                     RuleFor(a => a.ShiName).NotEmpty().WithMessage("Ingrese el nombre del envio.");
            RuleFor(a => a.Shipaddress).NotEmpty().WithMessage("Ingrese la dirrecion de envio.");
            RuleFor(a => a.ShiCity).NotEmpty().WithMessage("ingrese la ciudad de envio.");
            RuleFor(a => a.Shipregion).NotEmpty().WithMessage("ingrese la region de envio.");
            RuleFor(a => a.ShipPostalcode).NotEmpty().WithMessage("ingrese el codigo postal del envio.");
            RuleFor(a => a.Shipcomtry).NotEmpty().WithMessage("ingrese el pais del envio.");
            /*RuleFor(a => a.ProductoID).NotEmpty().WithMessage("El producto no puede estar vacio.");
            RuleFor(a => a.Precio).NotEmpty().WithMessage("El precio no puede estar vacio.");
            RuleFor(a => a.Cantidad).NotEmpty().WithMessage("La cantidad no puede estar vacia.");*/
        
          





        }
    }
}
