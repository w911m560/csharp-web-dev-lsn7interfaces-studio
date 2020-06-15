using System;
namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.
        public void SpinDisc()
        {
            Console.WriteLine("A DVD spins at a rate of 570 - 1600 rpm.");
        }
        public void StoreData()
        {
            Console.WriteLine("DVD storing data.");
        }
        public void WriteDisc()
        {
            Console.WriteLine("DVD writing data.");
        }
        public void ReadDisc()
        {
            Console.WriteLine("Reading DVD.");
        }

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
        public DVD(string name, int capacity, string contents, string type) : base(name, capacity, contents, type)
        {
        }

        public override void ReportInfo()
        {
            Console.WriteLine($"DVD Name: {Name} Capacity: {Capacity} Contents: {Contents} Type: {Type}");
        }
    }
}
