using System;

namespace AdapterPattern
{
    public class GuQin : IMusicDoReMi
    {
        public void Do()
        {
            Console.WriteLine("Playing the Do note");
        }

        public void Re()
        {
            Console.WriteLine("Playing the Re note");
        }

        public void Mi()
        {
            Console.WriteLine("Playing the Mi note");
        }
    }
}
