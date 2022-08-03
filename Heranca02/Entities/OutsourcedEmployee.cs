namespace Heranca02.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double AddicionalCharge { get; protected set; }

        public OutsourcedEmployee()
        { 
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double addicionalCharge)
            : base(name, hours, valuePerHour)
        {
            AddicionalCharge = addicionalCharge;
        }

        public override double Payment()
        {
            
            return base.Payment() + (AddicionalCharge * 1.1);
        }
    }
}
