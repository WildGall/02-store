using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue_at_the_store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int processedReceipt;
            int sumReceipt = 0;
            Queue<int> cashReceipt = new Queue<int>();
            cashReceipt.Enqueue(571);
            cashReceipt.Enqueue(634);
            cashReceipt.Enqueue(552);
            cashReceipt.Enqueue(573);
            cashReceipt.Enqueue(325);
            cashReceipt.Enqueue(292);
            cashReceipt.Enqueue(358);
            cashReceipt.Enqueue(257);
            cashReceipt.Enqueue(352);
            cashReceipt.Enqueue(226);          

            while (cashReceipt.Any())
            {
                Console.SetCursorPosition(40, 0);
                Console.Write(sumReceipt);
                Console.SetCursorPosition(0, 0);

                foreach (var receipt in cashReceipt)
                {
                    Console.WriteLine(receipt);
                }
                Console.ReadKey();

                processedReceipt = cashReceipt.Peek();
                sumReceipt = sumReceipt + processedReceipt;
                cashReceipt.Dequeue();
                
                Console.WriteLine(sumReceipt);
                Console.Clear();
            }
            Console.WriteLine("Очередь кончилась)");
        }        
    }
}
