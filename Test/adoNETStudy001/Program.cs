// See https://aka.ms/new-console-template for more information
using adoNETStudy001;

Console.WriteLine("Hello, World!");


SQL_INFO info1 = new SQL_INFO("new Conneciton");
SQL_INFO info2 = new SQL_INFO();

Console.WriteLine(info1.sqlConnection);
// new Connection
Console.WriteLine(info2.sqlConnection);
// Connection


