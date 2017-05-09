namespace PlayString
{
    class PlayNote : Command
    {
        public char Note;
        public int Length;
        public bool Dotted;
        public bool Sharp;
        public bool Flat;

        public PlayNote(char note)
        {
            Note = note;
            Length = -1; // Note length is set by the Ln command 
        }
        public PlayNote(char note, int length)
        {
            Note = note;
            Length = length;
        }

        public PlayNote()
        {

        }

        public int getNumber()
        {

            // C, C#, D, D#, E,F, F#, G, G#, A, A#, H
            int number = 0;
            switch (Note)
            {
                case 'C': number = 0; break;
                case 'D': number = 2; break;
                case 'E': number = 4; break;
                case 'F': number = 5; break;
                case 'G': number = 7; break;
                case 'A': number = 9; break;
                case 'B': number = 11; break;
            }
            if (Sharp)
                number++;
            if (Flat)
                number--;
            return number;
        }

    }
}
