using fundamentals.oop;

Intern intern = new Intern();
Junior junior = new Junior();

intern.Name = "João";
intern.Age = 18;
intern.Genre = 'M';
Console.WriteLine($"Name:{intern.Name} \nAge:{intern.Age} \nGenre:{intern.Genre} \nSalary:{intern.Salary()}");

Console.WriteLine($"\n=================================================\n");

junior.Name = "Leticia";
junior.Age = 22;
junior.Genre = 'W';
Console.WriteLine($"Name:{junior.Name} \nAge:{junior.Age} \nGenre:{junior.Genre} \nSalary:{junior.Salary()}");

Console.WriteLine($"\n=================================================\n");

Console.WriteLine($"inheritance: properties name, age, gender, are inherited from the employee class\n");
Console.WriteLine($"polymorphism : base salary is defined in the employee class and modified with its values in the other classes\n");
Console.WriteLine($"Encapsulation: BaseSalary is a private property of the Employee class and cannot be modified by the others");
