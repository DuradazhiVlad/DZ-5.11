
using System.Collections.Generic;
using System.Xml.Linq;
using Черга_до_лікаря;
 object obd = new object();


    for (int i = 0; i < 1; i++)
    {
        Thread thread = new Thread(_Human);
        thread.Name = $"thread{i}";
        thread.Start();
Console.WriteLine();
    }

 static void _Human(object obd)
{
    
        PriorityQueue<Human, int> priority = new PriorityQueue<Human, int>();
        for (int i = 0; i < 10; i++)
        {

            priority.Enqueue(new Human(), i);

        }

   

        for (int i = 0; i < 10; i++)
        {


            Thread.Sleep(1000);
            Console.WriteLine($"delete{i}", priority.Dequeue());


        }
        for (int i = 3; i < 10; i++)
        {
            Console.WriteLine($"Peek{i}", priority.Peek());
        }
    
    
}




