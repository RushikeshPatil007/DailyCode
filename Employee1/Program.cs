using Microsoft.EntityFrameworkCore;
using Emp.Data;

using var shop=new ShopDbContext();

if(args.Length==0)
{
    foreach(var Employee in shop.Employees)
    
        Console.WriteLine($"{0,-8}{1,16:0.00}",Employee.Id,Employee.SAL);
    
}
else
{
    var employee =shop.Employees
     .Where(c=> c.Id == args[0])
     .Include(c=>c.Departments)
     .FirstOrDefault();
     if(employee!=null)
    {
        Console.WriteLine($"Employee ID: {employee.Id}, Salary: {employee.SAL}");
        foreach(var department in employee.Departments)
            Console.WriteLine($"Department ID: {department.deptId}, Hire Date: {department.hiredate:d}");
    }
} 
