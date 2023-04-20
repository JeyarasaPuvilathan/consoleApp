using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSConsoleApp
{
    public class SimpleMovingAverage
    {
        public readonly int windowSize;
        List<int> storeWindow;
        public SimpleMovingAverage( int windowSize) { 
            this.windowSize = windowSize;
            storeWindow = new List<int>();

        }

        public void Submit( int value)
        {
            storeWindow.Add(value);
        } 

        public double ComputeAverage()
        {
            double average = 0;
            double total = 0;



            for (int i = 0; i < this.windowSize; i++)
            {

                if (storeWindow.Count > this.windowSize)
                {
                    total += storeWindow[(storeWindow.Count -1) - i];
                }
               
            }

            if (storeWindow.Count > this.windowSize)
            {
                average = (double)total / (double)this.windowSize;
                }
            else
            {
                var hh = storeWindow.Sum();
                average = (double)storeWindow.Sum() / (double)storeWindow.Count;
            }

            return average;
        }
    }
}
