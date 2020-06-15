using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public interface IOpticalDisc
    {
        public void SpinDisc();
        public void StoreData();
        public void WriteDisc();
        public void ReadDisc();
    }
}
