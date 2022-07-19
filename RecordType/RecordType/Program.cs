// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using RecordType;

var memberObj = new Member
{
    Id = 1,
    FirstName = "Suravaram",
    LastName = "Venkateshwar Reddy",
    Address = "Ameenpur"
};


var newMember = memberObj with { Address = "Mumbai" };

Console.WriteLine("****************START - Member Details***********");

Console.WriteLine("ID :- " + memberObj.Id);
Console.WriteLine("FirstName :- " + memberObj.FirstName);
Console.WriteLine("LastName :- " + memberObj.LastName);
Console.WriteLine("Address:- " + memberObj.Address);
Console.ReadLine();

Console.WriteLine("****************END - Member Details***********");
