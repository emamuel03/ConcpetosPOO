namespace POOConceptos
{
    public class HourlyEmployee : Employee
    {
        public float Hours { get; set; }
        public decimal HourValue { get; set; }

        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HourValue;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\t Hours...............: {$"{Hours:N2}",18}" +
                $"\n\t Hour Value..........: {$"{HourValue:C2}",18}" +
                $"\n\t Value to pay........: {$"{GetValueToPay():C2}",18}";
        }
    }
}
