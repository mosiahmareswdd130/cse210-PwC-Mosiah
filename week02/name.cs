public class Person
{
    public string _GivemName = "";
    public string _FamilyName = "";

    public Person(){
        
    }

    public void ShowEasterName()
    {
        Console.WriteLine($"{_FamilyName}, {_GivemName}");
    }

    public void ShowWWesterName()
    {
        Console.WriteLine($"{_GivemName}, {_FamilyName}");
    }
}