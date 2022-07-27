// See https://aka.ms/new-console-template for more information

//print("welcome");
////print<string>("welcome");

//print(2);
//print('s');

using System.Collections;

var numbers = new Any<int>() ;
 numbers.Add(1);
 numbers.Add(2);
 numbers.Add(3);
 numbers.Add(4);

numbers.Remove(1);

numbers.DisplayList();
Console.WriteLine($"Length:{numbers.count} items");
Console.WriteLine($"Empty:{numbers.IsEmpty}");



var people = new Any<person>();
people.Add(new person { Fname="Ahmad",Lname="Ali"});
people.Add(new person { Fname = "Omar", Lname = "Rami" });



people.DisplayList();
Console.WriteLine($"Length:{people.count} person");
Console.WriteLine($"Empty:{people.IsEmpty}");


var list = new ArrayList();

list.Add(1);
list.Add("Welcome");
foreach (var item in list)
    Console.WriteLine(item); ;

//Generic Method
void print<T>(T obj)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(typeof(T));
    Console.WriteLine(obj);
    
}

//Generic Class
public class person
{

    public string Fname { get; set; }
    public string Lname { get; set; }

    public override string ToString()
    {
        return $"'{Fname} {Lname}'";
    }
}



class Any<T>//class مرتبط بنوع البياناتT
{
         List<T> _items;

    public void Add(T item)
    {
        if (_items == null)
        {
            _items=new List<T>() { item};
        }
        else
        {
            _items.Add(item);
        }
    }

    public void Remove(int position)
    {
        var temp = _items[position];

    if (temp != null)
        _items.Remove(temp);

        return;
    }

    public bool IsEmpty =>_items is null || _items.Count == 0;

    public int count => _items is null ? 0 : _items.Count;

    public void DisplayList()
    {
        for(int i = 0; i <= _items.Count()-1; i++)
        {
            Console.Write(_items[i]);

            if (i < _items.Count - 1)
                Console.Write(",");
        }
        Console.WriteLine();

    }
}