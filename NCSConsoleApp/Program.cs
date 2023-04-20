// See https://aka.ms/new-console-template for more information
using NCSConsoleApp;

Console.WriteLine("Hello, World!");

Console.WriteLine("window Size:" + 3);

SimpleMovingAverage simpleMovingAverage = new SimpleMovingAverage(3);
simpleMovingAverage.Submit(2);
simpleMovingAverage.Submit(5);

double result = simpleMovingAverage.ComputeAverage();

Console.WriteLine("Average is :" + result);

simpleMovingAverage.Submit(4);

double result2 = simpleMovingAverage.ComputeAverage();

Console.WriteLine("Average is :" + result2);

simpleMovingAverage.Submit(3);

double result3 = simpleMovingAverage.ComputeAverage();

Console.WriteLine("Average is :" + result3);

simpleMovingAverage.Submit(3);

double result4 = simpleMovingAverage.ComputeAverage();

Console.WriteLine("Average is :" + result4);

