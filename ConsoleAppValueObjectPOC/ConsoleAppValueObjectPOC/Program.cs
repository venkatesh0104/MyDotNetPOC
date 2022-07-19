// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//using ConsoleAppValueObjectPOC;

//var one = new Address("Microsoft Way", "Redmond", "WA", "US", "98052");
//var two = new Address("Microsoft Way", "Redmond", "WA", "US", "98052");

//Console.WriteLine(EqualityComparer<Address>.Default.Equals(one, two)); // True
//Console.WriteLine(object.Equals(one, two)); // True
//Console.WriteLine(one.Equals(two)); // True
//Console.WriteLine(one == two); // True

//int[] a = new int[10];
//a = MyFunc(2, 10);



//for (int i = 0; i < a.Length; i++)
//{
//    Console.WriteLine(a[i]);
//}
//Console.Read();


//static int[] MyFunc(int start, int number)
//{
//    int[] _number = new int[number];
//    for (int i = 0; i < number; i++)
//    {
//        _number[i] = start + 2 * i;
//    }
//    return _number;
//}

foreach(var item in MyFunc(2, 10))
{
    Console.WriteLine(item);
}

Console.Read();

static IEnumerable<int> MyFunc(int start, int number)
{
    for (int i = 0; i < number; i++)
    {
        yield return start + 2 * i;
    }
}
    
