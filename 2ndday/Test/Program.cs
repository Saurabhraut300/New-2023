using Membership;
using HR;


//Entry Point code for ECommerce Solution

Console.WriteLine( "SR company ");
Console.WriteLine("******************************");

Console.WriteLine("Enter your Email ID");
string email=Console.ReadLine();

Console.WriteLine("Enter your password");
string password=Console.ReadLine();

if(AuthManager.Validate(email,password))
{
    Console.WriteLine("Welcome to SR Company");
    Employee emp=new SalesManager();
    emp.DoWork();
    Console.WriteLine(emp);
    float salary=emp.ComputePay();
    Console.WriteLine("Salary = "+ salary);
}
else{
     Console.WriteLine("valid User");
  
}

Console.WriteLine("Thank you for SR Company");