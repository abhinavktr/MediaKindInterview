using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNETBASICS
{
    public class AsyncAwaitExceptionHandling
    {
        public void MainTaskAsync()
        {
            Task<int> One = TaskOneAsync();
            //tOne.Start();
            //Task<int> tTwo = TaskTwoAsync();
            //Task<int> tThree = TaskThreeAsync();
            ////try
            //{
                //Task.WaitAll(tOne);
            //}
            //catch (AggregateException agEx)
            //{
            //    foreach (var e in agEx.Flatten().InnerExceptions)
            //    {
            //        Console.WriteLine(e.Message);
            //    }
            //}
        }

        public async Task<int> TaskOneAsync()
        {
            int i = 10;

            if (i == 10)
            {
                i = i/0;
               // throw new Exception("Task One Exception");
            }
            await Task.Delay(1000);

            return i;
        }

        public async Task<int> TaskTwoAsync()
        {
            int i = 15;

            await Task.Delay(1000);

            return i;
        }

        public async Task<int> TaskThreeAsync()
        {
            int i = 20;

            if (i == 20)
            {
                throw new Exception("Task Three exception");
            }
            await Task.Delay(1000);

            return i;
        }
    }
}
