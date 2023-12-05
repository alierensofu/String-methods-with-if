// See https://aka.ms/new-console-template for more information
string s1 = "";
string SearchCharcter = "";
Console.WriteLine("please enter a string here");
s1 = Console.ReadLine();
Console.WriteLine("please enter a character to search");
SearchCharcter = Console.ReadLine();
if (s1.Contains(SearchCharcter))
{
    Console.WriteLine("the characters index is {0}", s1.IndexOf(SearchCharcter));
}
else
{
    Console.WriteLine("please enter something contains in the string");
}
Console.WriteLine("please enter your first name");
string FirstName, LastName;
FirstName = Console.ReadLine();
Console.WriteLine("please enter your lastname");
LastName = Console.ReadLine();
string FullName = FirstName + LastName;
Console.WriteLine("Your full name is " + FullName);
Console.ReadKey();