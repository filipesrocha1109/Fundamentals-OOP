namespace fundamentals.oop
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public char Genre { get; set; }
        private double BaseSalary { get; set; } = 3000;
        public virtual double Salary()
        {
            return BaseSalary;
        }
    }
}
