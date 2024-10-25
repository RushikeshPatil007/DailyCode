using System.ComponentModel.DataAnnotations.Schema;


namespace Emp.Data;
[Table("emp69")]
public class Employee
{
[Column("EMPNO")]

public string Id{get;set;}

public decimal SAL{get;set;}

public List<Department> Departments{get;set;}
}