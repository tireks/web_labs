using System;

namespace leonov_lab11.Services
{
    public class ServiceActions : IServiceActions
    {
        public int value1 { get; set; }
        public int value2 { get; set; }
        public ServiceActions()
        {
            Random rand = new Random();
            value1 = rand.Next(11);
            value2 = rand.Next(11);
        }
        public int divide() { if (value2 != 0) return value1 / value2; else return -1; }
        public int subtraction() { return value1 - value2; }
        public int sum() { return value1 + value2; }
        public int multiply() { return value1 * value2; }
    }
    public interface IServiceActions
    {
        public int value1 { get; set; }
        public int value2 { get; set; }
        public int divide();
        public int subtraction();
        public int sum();
        public int multiply();
    }
}