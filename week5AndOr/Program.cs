// Or && And

string username, password;

Console.WriteLine("enter name");
username = Console.ReadLine();

Console.WriteLine("enter pass");
password = Console.ReadLine();


//OR


if (username != "admin" || password != "admin123")
{
    Console.WriteLine("WRONG");
}
else
{
    Console.WriteLine("Wellcome!");
}





//if (username == "admin" && password == "admin123")
//{
//    Console.WriteLine("wellcome");
//}
//else
//{
//    Console.WriteLine("WRONG");
//}