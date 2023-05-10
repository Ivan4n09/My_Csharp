int Prompt(string message)
{
    System.Console.WriteLine(message);
    string readInput = Console.ReadLine();
    int? result = null;
    if (readInput != null)
    {
        result = int.Parse(readInput);
    }
    return result ?? 0;
}

// string PromptNote(string message)
// {
//     System.Console.WriteLine(message);
//     string noteInput = Console.ReadLine()?.Trim().ToUpper();
//     string[] noteNames = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
//     while (!noteNames.Contains(noteInput))
//     {
//         System.Console.WriteLine($"Invalid note name: {noteInput}. Please enter a valid note name with a sharp (e.g. C#).");
//         System.Console.WriteLine(message);
//         noteInput = Console.ReadLine()?.Trim().ToUpper();
//     }
//     return noteInput;
// }

// string startingNote = PromptNote("Input starting note (e.g. C#):");

// int interval = Prompt("Input musical interval in half-steps:");

// string[] noteNames = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
// int startingNotePosition = Array.IndexOf(noteNames, startingNote);

// int calculatedNotePosition = startingNotePosition + interval;
// string calculatedNote = noteNames[calculatedNotePosition % 12];

// string[] intervalNames = { "", "minor second", "major second", "minor third", "major third", "perfect fourth", "tritone", "perfect fifth", "minor sixth", "major sixth", "minor seventh", "major seventh" };
// int intervalIndex = (calculatedNotePosition - startingNotePosition) % 12;
// string intervalName = intervalNames[intervalIndex];

// System.Console.WriteLine($"{interval} semitones from {startingNote} is the {intervalName} - {calculatedNote}.");

int startingNotePosition = Prompt("Input starting note position (0-11):\n0=C, 1=C# or Db, 2=D, 3=D# or Eb, 4=E, 5=F, 6=F# or Gb, 7=G, 8=G# or Ab, 9=A, 10=A# or Bb, 11=B");

string[] noteNames = { "C", "C# or Db", "D", "D# or Eb", "E", "F", "F# or Gb", "G", "G# or Ab", "A", "A# or Bb", "B" };

string startingNote = noteNames[startingNotePosition];

int interval = Prompt("Input musical interval in half-steps:");

int calculatedNotePosition = startingNotePosition + interval;
string calculatedNote = noteNames[calculatedNotePosition % 12];

string[] intervalNames = { "", "minor second", "major second", "minor third", "major third", "perfect fourth", "tritone", "perfect fifth", "minor sixth", "major sixth", "minor seventh", "major seventh" };
int intervalIndex = (calculatedNotePosition - startingNotePosition) % 12;
string intervalName = intervalNames[intervalIndex];

System.Console.WriteLine($"{interval} semitones from {startingNote} is the {intervalName} - {calculatedNote}.");