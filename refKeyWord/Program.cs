// See https://aka.ms/new-console-template for more information

int a = 10;

var obj = new Calculator(a);
Console.WriteLine($"Starting value: {obj.Value}");

UpdateValueReference(ref obj);

void UpdateValueReference(ref Calculator obj)
{
    obj = new Calculator(45);
    obj.Value = 15;
}

Console.WriteLine(a);

void Add(ref int a)
{
    a += 5;
}


class Calculator
{
    public Calculator(int value)
    {
        Value = value;
    }

    public int Value { get; set; }
}