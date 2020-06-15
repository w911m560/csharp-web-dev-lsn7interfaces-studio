using System;
namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.
        public void SpinDisc()
        {
            Console.WriteLine("A CD spins at a rate of 200 - 500 rpm.");
        }
        public void StoreData()
        {
            Console.WriteLine("CD storing data.");
        }
        public void WriteDisc()
        {
            Console.WriteLine("CD writing data.");
        }
        public void ReadDisc()
        {
            Console.WriteLine("Reading CD.");
        }

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
        public CD(string name, int capacity, string contents, string type) : base (name, capacity, contents, type)
        {
        }

        public override void ReportInfo()
        {
            Console.WriteLine($"CD Name: {Name} Capacity: {Capacity} Contents: {Contents} Type: {Type}");
        }
    }
}
