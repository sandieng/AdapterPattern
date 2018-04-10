using AdapterPattern;
using System;

namespace AdapterPatternClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var piano = new Piano();
            IMusicDoReMi guQinToPianoAdapter = new PianoToGuQinAdapter(piano);

            guQinToPianoAdapter.Do();
            guQinToPianoAdapter.Re();
            guQinToPianoAdapter.Mi();
            Console.ReadKey();
        }
    }
}
