namespace Exercise_3___CompanyTracker;

class Program
{
    static void Main(string[] args)
    {
            Company[] companies = new Company[3];
            companies[0] = new Company("TechCorp");
            companies[1] = new Company("SalesInc");
            companies[2] = new Company("BuildIt");

            companies[0].AddEmployee(new Administrator("Alice", 5000));
            companies[0].AddEmployee(new Worker("Bob", 20, 160));
            companies[0].AddEmployee(new Salesman("Charlie", 3000, 500));

            companies[1].AddEmployee(new Salesman("Dave", 2500, 700));
            companies[1].AddEmployee(new Salesman("Eve", 2700, 600));

            companies[2].AddEmployee(new Worker("Frank", 25, 150));
            companies[2].AddEmployee(new Worker("Grace", 22, 140));
            companies[2].AddEmployee(new Administrator("Heidi", 4500));

            foreach (var company in companies)
            {
                Console.WriteLine($"Company: {company.Name}");
                Console.WriteLine($"Number of Employees: {company.Employees.Count}");
                Console.WriteLine($"Total Salary Costs: {company.SalaryCosts()} lv.");
                Console.WriteLine("Employee Salaries:");
                Console.WriteLine(company.PrintAllEmployeeSalaries());
                Console.WriteLine();
            }
        }
}
