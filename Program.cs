using System.Diagnostics.Metrics;
using System.Xml.Linq;

public class Node
{
    public object data;
    public Node link;

    public Node()
    {
        data = link = null;
    }
    public Node(object element)
    {
        data = element;
        link = null;
    }
}

public class Node2
{
    //Cài đặt lại như slide
    //Bổ sung các thủ tục FindMax, FindMin, Sum, Count
    //Bổ sung AddFirst, AddLast, AddBefore, AddAfter (Insert)
}
public class Program
{
    public static void Main(string[] args)
    {
        LinkedList llist = new LinkedList();
        llist.AddFirst(1);
        llist.Insert(2, 1);
        llist.Insert(3, 2);
        llist.Insert(5, 3);
        llist.Insert(6, 5);
        llist.Insert(7, 6);
        llist.Insert(8, 7);
        llist.Insert(9,8);
        llist.Insert(10,9);
        llist.Print();
        Console.WriteLine("---after insert 4 ---");
        llist.AddBefore(4, 5);
        llist.Print();
        llist.PrintPrime();
        //System.Console.WriteLine("---after removing Second ---");
        //llist.Remove("Second");
        //llist.Print();


            //Bài 3. Thử nghiệm với LinkedList trong NET
            //Bài 3. Thử nghiệm với LinkedList trong NET (cuối slide): với mỗi nút là số và thử nghiệm với các bài toán tìm max, min, sum, count
    }

}