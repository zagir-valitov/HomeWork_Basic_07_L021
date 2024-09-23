using Exercise_1;
using System.Diagnostics;

Console.WriteLine(" ---- Home work 7. Exercise 1 ----\n");

long num1 = 5;
long num2 = 10;
long num3 = 20;

Console.WriteLine("Time to calculate Fibonachi number by recursive method:");
Console.WriteLine($"1. Fibonachi({num1}) = {TimeCalculateRecursiveMethod(num1).resultCalculate}," +
    $"\t\tTime: {TimeCalculateRecursiveMethod(num1).time} ticks");
Console.WriteLine($"1. Fibonachi({num2}) = {TimeCalculateRecursiveMethod(num2).resultCalculate}," +
    $"\t\tTime: {TimeCalculateRecursiveMethod(num2).time} ticks");
Console.WriteLine($"1. Fibonachi({num3}) = {TimeCalculateRecursiveMethod(num3).resultCalculate}," +
    $"\tTime: {TimeCalculateRecursiveMethod(num3).time} ticks");

Console.WriteLine("\nTime to calculate Fibonachi number by cyclic method:");
Console.WriteLine($"1. Fibonachi({num1}) = {TimeCalculateCyclicMethod(num1).resultCalculate}," +
    $"\t\tTime: {TimeCalculateCyclicMethod(num1).time} ticks");
Console.WriteLine($"1. Fibonachi({num2}) = {TimeCalculateCyclicMethod(num2).resultCalculate}," +
    $"\t\tTime: {TimeCalculateCyclicMethod(num2).time} ticks");
Console.WriteLine($"1. Fibonachi({num3}) = {TimeCalculateCyclicMethod(num3).resultCalculate}," +
    $"\tTime: {TimeCalculateCyclicMethod(num3).time} ticks");

(long time, long resultCalculate) TimeCalculateRecursiveMethod(long number)
{
    var st = Stopwatch.StartNew();
    long result = Fibonachi.RecursiveMethod(number);
    st.Stop();
    return (st.ElapsedTicks, result);

}
(long time, long resultCalculate) TimeCalculateCyclicMethod(long number)
{
    var st = Stopwatch.StartNew();
    long result = Fibonachi.CyclicMethod(number);
    st.Stop();
    return (st.ElapsedTicks, result);
}
