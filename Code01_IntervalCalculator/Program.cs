int Prompt(string message)
{
    System.Console.WriteLine(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int interval = Prompt("Input musical interval in halfsteps>");

int calculatedNotePosition = 0 + interval;

Console.WriteLine();

string[] noteNames = { "C", "C# or Db", "D", "D# or Eb", "E", "F", "F# or Gb", "G", "G# or Ab", "A", "A# or Bb", "B" };
string calculatedNote = noteNames[calculatedNotePosition % 12];

// System.Console.WriteLine("The note " + interval + " halfsteps away from C is " + calculatedNote + ".");

string[] intervalNames = { "", "minor second", "major second", "minor third", "major third", "perfect fourth", "tritone", "perfect fifth", "minor sixth", "major sixth", "minor seventh", "major seventh" };
int intervalIndex = (calculatedNotePosition - 0) % 12;
string intervalName = intervalNames[intervalIndex];

// System.Console.WriteLine($"The {intervalName} from C is {calculatedNote}.");

// System.Console.WriteLine("The " + intervalName + " from C is " + calculatedNote + ".")

System.Console.WriteLine($"{interval} semitones from C is the {intervalName} - {calculatedNote}.");