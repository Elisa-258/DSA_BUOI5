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
public class LinkedList
{
    public bool isPrime(object A)
    {
        if (A is int)
        {
            if ((int)A == 1) return false;
            if ((int)A == 2) return true;
            for (int i = 2; i <= Math.Sqrt((int)(A)) +1; i++)
                if ((int)A % i == 0)
                    return false;
        }
        return true;
    }
    public Node header;
    public LinkedList()
    {
        header = new Node("Header");
    }
    public Node Find(object value)
    {
        Node current = header;
        while (current.link != null && current.data != value)
        {
            current = current.link;
        }
        return current;
    }

    public void Insert(object newdata, object after) //addAfter,addLast là cái này
    {
        Node current = Find(after);
        Node newnode = new Node(newdata);
        newnode.link = current.link;
        current.link = newnode;
    }
    public void AddFirst(object newdata)    
    {
        Node current = header; //node dummy
        Node newnode = new Node(newdata);
        newnode.link = header.link; //nối đuôi của node mới vào node đầu (cũ)
        current.link = newnode; //nối đầu của node mới vào dummy node
    }
    public void AddBefore(object newdata,object before)
    {
        Node current = header;
        Node next = header.link;
        while (next.link != null)
        {
            if (next.data.Equals(before)) 
            {
                break;
            }
            current = next;
            next = next.link;
                
        }
        Node newnode = new Node(newdata); 
        newnode.link = current.link; // nối đuôi của node mới vào đầu node cũ
        current.link = newnode; // thêm node mới vào đuôi node đằng trước node cần tìm
    }
    public Node FindPrev(object value)
    {
        Node current = header;
        do
        {
            current = current.link;
        } while (current.link != null && current.link.data != value);
        return current;
    }
    public void Remove(object deleteddata)
    {
        Node current = FindPrev(deleteddata);
        current.link = current.link.link;
    }
    public void Print()
    {
        Node current = header;
        do
        {
            Console.WriteLine(current.data);
            current = current.link;
        } while (current != null);
    }
    public object FindMax()
    {
        Node current = header.link;
        Node maxNode = current;
        while (current.link != null)
        {
            current = current.link;
            IComparable currentData = (IComparable)current.data;
            IComparable maxData = (IComparable)maxNode.data;
            if (currentData.CompareTo(maxData) > 0)
            {
                maxNode = current;
            }
        }
        return maxNode.data;
    }
    public object FindMin()
    {
        Node current = header.link;
        Node minNode = current;
        while (current.link != null)
        {
            current = current.link;
            IComparable currentData = (IComparable)current.data;
            IComparable minData = (IComparable)minNode.data;
            if (currentData.CompareTo(minData) < 0)
            {
                minNode = current;
            }
        }
        return minNode.data;
    }
    public object Sum()
    {
        Node current = header.link;
        int sum = (int)current.data;
        while (current.link != null)
        {
            current = current.link;
            sum = sum + (int)current.data;
        }
        return sum;
    }
    public int Count()
    {
        Node current = header.link;
        int count = 1;
        while (current.link != null)
        {
            current = current.link;
            count++;
        }
        return count;
    }
    public void PrintPrime()
    {
        Console.WriteLine("Cac so nguyen to trong list la: ");
        Node current = header;
        do
        {
            current = current.link;
            if (isPrime(current.data))
                Console.Write($"{current.data} ");
        } while (current.link != null);
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