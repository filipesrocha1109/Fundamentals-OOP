namespace fundamentals.oop
{
    public class Intern : Employee
    {
        public override double Salary()
        {
            return base.Salary() * 0.5;
        }
    }
}
