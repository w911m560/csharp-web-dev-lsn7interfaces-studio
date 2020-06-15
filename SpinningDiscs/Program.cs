using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            CD backInBlack = new CD("Back in Black", 2, "ACDC albumn", "Rock");
            DVD lOTR = new DVD("Lord of the Rings", 12, "Director's cut", "Fantasy");
            // TODO: Call each CD and DVD method to verify that they work as expected.

            backInBlack.ReadDisc();
            backInBlack.ReportInfo();
            backInBlack.SpinDisc();
            backInBlack.StoreData();
            backInBlack.WriteDisc();

            lOTR.ReadDisc();
            lOTR.ReportInfo();
            lOTR.SpinDisc();
            lOTR.StoreData();
            lOTR.WriteDisc();
        }
    }
}
