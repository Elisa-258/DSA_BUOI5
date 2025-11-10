public class Node2
{
    public object data;
    public Node2 front, back;
    public Node2()
    {
        data = null;
        front = back = null;
    }
    public Node2(object element)
    {
        this.data = element;
        front = back = null;
    }
}

public class DoubleLinkedList
{
    public Node2 header,trailer;
    public DoubleLinkedList()
    {
        header = new Node2("Header");
        trailer = new Node2("Trailer");
        header.back = trailer;
        trailer.front = header;
    }
    private Node2 Find(object element)
    {
        Node2 current = new Node2();
        current = header.back;
        while (!current.data.Equals(element) && current.back != null)
        {
            current = current.back;
        }
        if (current.data.Equals("Trailer"))
            return current.front;
        return current;
    }
    public void Insert(object newele, object afterele) //addAfter
    {
        Node2 current = new Node2();
        Node2 newNode = new Node2(newele);
        current = Find(afterele);
        Node2 oldBack = current.back;
        newNode.front = current;
        newNode.back = oldBack;
        oldBack.front = newNode;
        current.back = newNode;
    }
    public void AddFirst(object newele)
    {
        Node2 newNode = new Node2(newele);
        Node2 oldFirst = header.back;
        newNode.back = oldFirst;
        newNode.front = header;
        header.back = newNode;
        oldFirst.front = newNode;
    }
    public void AddLast(object newele)
    {
        Node2 newNode = new Node2(newele);
        Node2 oldLast = trailer.front;
        newNode.front = oldLast;
        oldLast.back = newNode;
        newNode.back = trailer;
        trailer.front = newNode;
    }
    public void AddBefore(object newele, object beforeele)
    {
        Node2 current = new Node2();
        Node2 newNode = new Node2(newele);
        current = Find(beforeele);
        if (current == header)
        {
            AddFirst(newele);
            return;
        }
        Node2 oldFront = current.front;
        newNode.front = oldFront;
        oldFront.back = newNode;
        current.front = newNode;
        newNode.back = current;

    }
    public void Remove(object element)
    {
        Node2 current = Find(element);
        if (current.front != null)
        {
            current.back.front = current.front;
            current.front.back = current.back;
            current.back = null;
            current.front = null;
        }
    }
    public void Print()
    {
        Node2 current = header.back;
        while (!(current.back == null))
        {
            if (current.data.Equals("Trailer"))
                break;
            Console.WriteLine(current.data);
            current = current.back;
        }
    }
    public object FindMax()
    {
        Node2 current = header.back;
        Node2 maxNode = current;
        while (!current.back.data.Equals("Trailer"))
        {
            current = current.back;
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
        Node2 current = header.back;
        Node2 minNode = current;
        while (!current.back.data.Equals("Trailer"))
        {
            current = current.back;
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
        Node2 current = header.back;
        int sum = (int)current.data;
        while (!current.back.data.Equals("Trailer"))
        {
            current = current.back;
            sum = sum + (int)current.data;
        }
        return sum;
    }
    public int Count()
    {
        Node2 current = header.back;
        int count = 1;
        while (!current.data.Equals("Trailer"))
        {
            current = current.back;
            count++;
        }
        return --count; //bỏ thằng chặn cuối ra 
    }
}