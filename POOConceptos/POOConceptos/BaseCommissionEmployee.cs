using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOConceptos
{
    class BaseCommissionEmployee : CommissionEmployee
    {
        public decimal Base { get; set; }

        public override decimal GetValueToPay()
        {
            return base.GetValueToPay();
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\t Base................: {Base:C2}";
        }
    }
}
