namespace fundamentals.oop
{
    public class Junior : Employee
    {
        private double AdditionalPayment { get; set; } = 1000;
        public override double Salary()
        {
            return (base.Salary() * 1) + AdditionalPayment;
        }
    }
}
