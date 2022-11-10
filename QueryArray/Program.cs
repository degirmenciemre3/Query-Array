using QueryArray;
using System;

var arr = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

QueryArray<int> q = new QueryArray<int>();

q.LoadFromArray(arr);
//q.Add(10);
//q.Add(11);

q.AddRange(new[] { 10, 11 });

//foreach kullanabilmek için IEnumarable interface den kalıtım aldık.
//foreach (var item in q)
//{
//    Console.Write(item + " ");
//}


//while (q.Next())
//{
//    Console.Write(q.Current + " ");
//}

while (q.Next())
{
    Console.Write(q.Current + " ");
}

q.RemoveAt(5);

Console.WriteLine("");

while (q.Previous())
{
    Console.Write(q.Current + " ");
}

Console.ReadLine();
