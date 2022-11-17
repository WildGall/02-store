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
            int cursorPositionSumReceiptY = 40;
            int cursorPositionSumReceiptX = 0;
            int sumReceipt = 0;
            Queue<int> cashReceipts = new Queue<int>();
            cashReceipts.Enqueue(571);
            cashReceipts.Enqueue(634);
            cashReceipts.Enqueue(552);
            cashReceipts.Enqueue(573);
            cashReceipts.Enqueue(325);
            cashReceipts.Enqueue(292);
            cashReceipts.Enqueue(358);
            cashReceipts.Enqueue(257);
            cashReceipts.Enqueue(352);
            cashReceipts.Enqueue(226);          

            while (cashReceipts.Count > 0)
            {
                Console.SetCursorPosition(cursorPositionSumReceiptY, cursorPositionSumReceiptX);
                Console.Write(sumReceipt);
                Console.SetCursorPosition(0, 0);

                foreach (var receipts in cashReceipts)
                {
                    Console.WriteLine(receipts);
                }
                Console.ReadKey();

                sumReceipt += cashReceipts.Peek();
                cashReceipts.Dequeue();
                
                Console.Clear();
            }

            Console.WriteLine("Очередь кончилась)");
        }        
    }
}
