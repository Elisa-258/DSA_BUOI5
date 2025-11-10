using System.Diagnostics.Metrics;
using System.Xml.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        DoubleLinkedList dbl = new DoubleLinkedList();
        dbl.AddFirst(1);
        dbl.Insert(5,1);
        dbl.Insert(3,1);
        dbl.Insert(4,3);
        dbl.AddLast(6);
        dbl.AddBefore(2, 3);
        dbl.Print();
        Console.WriteLine(dbl.Count());
        //Bài 3. Thử nghiệm với LinkedList trong NET
        //Bài 3. Thử nghiệm với LinkedList trong NET (cuối slide): với mỗi nút là số và thử nghiệm với các bài toán tìm max, min, sum, count
    }

}