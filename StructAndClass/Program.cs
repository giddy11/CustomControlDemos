// See https://aka.ms/new-console-template for more information

var person = new Person("Gideon", 5);
var structPerson = new PersonStruct("Daniel", 10);

void ModifyNames(Person person)
{
    person.Name = "Changed";
    person.Id = 500;
}

void ModifyNamesStruct(PersonStruct personStruct)
{
    personStruct.Name = "Timothy";
    personStruct.Id = 100;
}

//var newPerson = person;
//person.Name = "Changed";
ModifyNames(person);
ModifyNamesStruct(structPerson);


//var newSt = structPerson;
//structPerson.Name = "Timothy";



Console.WriteLine(person.Name);
Console.WriteLine(structPerson.Name);
Console.WriteLine(person.Id);
Console.WriteLine(structPerson.Id);














Console.ReadLine();
public class Person
{
    public Person(string name, int id)
    {
        Name = name;
        Id = id;
    }
    public string Name { get; set; }
    public int Id { get; set; }
}


public struct PersonStruct
{
    public PersonStruct(string name, int id)
    {
        Name = name;
        Id = id;
    }
    public string Name { get; set; }
    public int Id { get; set; }
}




