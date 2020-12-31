using System;

interface INamedValue
{
    string Name { get; set; }
    string Value { get; set; }
}


class NamedValue : INamedValue
{
    public string Name { get; set; }
    public string Value { get; set; }


}

class MainApp
{
    static void Main(string[] args)
    {
        NamedValue name = new NamedValue()
        {
            Name = "name",
            Value = "Nerve"
        };

        NamedValue height = new NamedValue()
        {
            Name = "height",
            Value = "100cm"

        };

        NamedValue weight = new NamedValue()
        {
            Name = "weight",
            Value = "10kg"
        };

        Console.WriteLine($"{name.Name} : {name.Value}");
        Console.WriteLine($"{height.Name} : {height.Value}");
        Console.WriteLine($"{weight.Name} : {weight.Value}");

        /*
        name: Nerve
        height : 100cm
        weight : 10kg
        */

    }

}

