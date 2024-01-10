// See https://aka.ms/new-console-template for more information
using ConAppEmp;

List<Employee> employees = new List<Employee>()
{
    new Employee(){Id=1,Name="Sam",Designation="Manager",Doj=new DateTime(day:25,month:04,year:2022)},
    new Employee(){Id=2,Name="Avi",Designation="Manager",Doj=new DateTime(day:24,month:05,year:2022)},
    new Employee(){Id=3,Name="Rohit",Designation="Developer",Doj=new DateTime(day:25,month:04,year:2022)},
    new Employee(){Id=4,Name="Arsh",Designation="Developer",Doj=new DateTime(day:25,month:04,year:2022)},
    new Employee(){Id=5,Name="Vipul",Designation="Manager",Doj=new DateTime(day:25,month:04,year:2022)},
    new Employee(){Id=6,Name="Simi",Designation="Manager",Doj=new DateTime(day:25,month:04,year:2022)},
};
Console.WriteLine("ID \tName \t   Designation \t Date of Joining");
foreach (Employee emp in employees)
{
    Console.Write(emp.Id + "\t");
    Console.Write(emp.Name + "\t \t");
    Console.Write(emp.Designation + "\t \t");
    Console.Write(emp.Doj.ToLongDateString());
    Console.WriteLine("\n");
}
