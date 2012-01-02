using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Fault
{
    class Fault_Genesis
    {
        private int Fault_Length;
        private int Shift_volume;
        private int Fault_Depth;

        public void Setlength(int Length)
        {
            Fault_Length = Length;
        }

        public void SetShift(int num)
        {
            Shift_volume = num;
        }

        public void SetDepth(int Depth)
        {
            Fault_Depth = Depth;
        }

        public  int getLenght()
        {
            return Fault_Length;
        }

        public int getShift()
        {
            return Shift_volume;
        }

        public int getDepth()
        {
            return Fault_Depth;
        }
    }
}
