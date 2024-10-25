using System.ComponentModel.DataAnnotations.Schema;

namespace Emp.Data;


[Table("dept")]

public class Department
{
 [Column("DEPTNO")]

 public int deptId{get;set;}

 public DateOnly hiredate{get;set;}


  
}