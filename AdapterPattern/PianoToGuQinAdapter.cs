using System;

namespace AdapterPattern
{
    public class PianoToGuQinAdapter: IMusicDoReMi
    {
        private readonly Piano _piano;

        public PianoToGuQinAdapter(Piano piano)
        {
            _piano = piano;
        }

        public void Do()
        {
            _piano.C();
        }

        public void Re()
        {
            _piano.D();
        }

        public void Mi()
        {
            _piano.E();
        }
    }
}
