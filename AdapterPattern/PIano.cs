using System;

namespace AdapterPattern
{
    public class Piano : IMusicCDE
    {
        public void C()
        {
            Console.WriteLine("Playing the C note");
        }

        public void D()
        {
            Console.WriteLine("Playing the D note");
        }

        public void E()
        {
            Console.WriteLine("Playing the E note");
        }
    }
}
