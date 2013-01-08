using System;
using System.Collections;

class classArray
{
    //method declarations

    private ArrayList list = new ArrayList();

    //method definitions
    public void start()
    {
        Console.WriteLine("Using ArrayList");


        string choice;
        do
        {
            Console.WriteLine("1.Add item\n2.Remove Item\n3.Count items\n4.Display all items");
            string ch;
            ch = Console.ReadLine();
            switch (ch)
            {
                case "1": addItem();
                    break;
                case "2": removeItem();
                    break;
                case "3": countItems();
                    break;
                case "4": displayall();
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
            Console.WriteLine("Do You wish to continue?\nY / N");
            choice = Console.ReadLine();
        } while (choice == "y" || choice == "Y");



    }


    public void addItem()
    {
        Console.WriteLine("Enter number of elements to add");
        string num = Console.ReadLine();
        int numint;
        bool flag = int.TryParse(num, out numint);
        for (int i = 0; i < numint; i++)
        {
            string str = Console.ReadLine();
            list.Add(str);
        }

    }

    public void removeItem()
    {
        Console.WriteLine("1.From the end\n2.From an index i");
        string str = Console.ReadLine();
        switch (str)
        {
            case "1": list.RemoveAt(list.Count - 1);
                break;
            case "2": Console.WriteLine("Enter position");
                string pos = Console.ReadLine();
                int pos1;
                if (int.TryParse(pos, out pos1))
                {
                    list.RemoveAt(pos1);
                }
                break;
            default: Console.WriteLine("Incorrect statement");
                break;
        }
    }

    public void countItems()
    {
        Console.WriteLine("No of items : " + list.Count);
    }

    public void displayall()
    {
        Console.WriteLine("Displaying all items in the ArrayList");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
    }



}

class classStack
{
    private Stack stack = new Stack();

    //method definitions
    public void start()
    {
        Console.WriteLine("Using Stack");


        string choice;
        do
        {
            Console.WriteLine("1.Add item\n2.Remove Item\n3.Count items\n4.Display all items");
            string ch;
            ch = Console.ReadLine();
            switch (ch)
            {
                case "1": Push();
                    break;
                case "2": Pop();
                    break;
                case "3": countItems();
                    break;
                case "4": peek();
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
            Console.WriteLine("Do You wish to continue?\nY / N");
            choice = Console.ReadLine();
        } while (choice == "y" || choice == "Y");



    }


    public void Push()
    {
        Console.WriteLine("Enter number of elements to add");
        string num = Console.ReadLine();
        int numint;
        bool flag = int.TryParse(num, out numint);
        for (int i = 0; i < numint; i++)
        {
            string str = Console.ReadLine();
            stack.Push(str);
        }

    }

    public void Pop()
    {
        Console.WriteLine("Pop-ing");
        string str = Console.ReadLine();
        stack.Pop();
    }

    public void countItems()
    {
        Console.WriteLine("No of items : " + stack.Count);
    }

    public void peek()
    {
        Console.WriteLine("Display last element added : " + stack.Peek());

    }

}

class classQueue
{
    private Queue que = new Queue();

    //method definitions
    public void start()
    {
        Console.WriteLine("Using Queue");


        string choice;
        do
        {
            Console.WriteLine("1.Add item\n2.Remove Item\n3.Count items\n4.Display all items");
            string ch;
            ch = Console.ReadLine();
            switch (ch)
            {
                case "1": enqueue();
                    break;
                case "2": dequeue();
                    break;
                case "3": countItems();
                    break;
                case "4": peek();
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
            Console.WriteLine("Do You wish to continue?\nY / N");
            choice = Console.ReadLine();
        } while (choice == "y" || choice == "Y");



    }


    public void enqueue()
    {
        Console.WriteLine("Enter number of elements to add");
        string num = Console.ReadLine();
        int numint;
        bool flag = int.TryParse(num, out numint);
        for (int i = 0; i < numint; i++)
        {
            string str = Console.ReadLine();
            que.Enqueue(str);
        }

    }

    public void dequeue()
    {
        Console.WriteLine("Pop-ing");
        string str = Console.ReadLine();
        que.Dequeue();
    }

    public void countItems()
    {
        Console.WriteLine("No of items : " + que.Count);
    }

    public void peek()
    {
        Console.WriteLine("Displaying first element added : " + que.Peek());

    }
}


class Program
{
    static void Main()
    {

        Console.WriteLine("Editing on GitHub here");
        classArray arr = new classArray();
        classStack sta = new classStack();
        classQueue que = new classQueue();
        string choice;
        do
        {

            Console.WriteLine("1.ArrayList\n2.Stack\n3.Queue");
            string ch;
            ch = Console.ReadLine();
            switch (ch)
            {
                case "1": arr.start();
                    break;
                case "2": sta.start();
                    break;
                case "3": que.start();
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
            Console.WriteLine("Do You wish to continue?\nY / N");
            choice = Console.ReadLine();
        } while (choice == "y" || choice == "Y");
    }
}
