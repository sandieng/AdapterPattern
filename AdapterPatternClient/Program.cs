using AdapterPattern;
using System;

namespace AdapterPatternClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var piano = new Piano();
            IMusicDoReMi pianoToGuQinAdapter = new PianoToGuQinAdapter(piano);

            // Play a piano like a guqin
            pianoToGuQinAdapter.Do();
            pianoToGuQinAdapter.Re();
            pianoToGuQinAdapter.Mi();
            Console.ReadKey();
        }
    }
}
