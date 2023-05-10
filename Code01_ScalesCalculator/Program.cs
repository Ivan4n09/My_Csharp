int Prompt(string message)
{
    System.Console.WriteLine(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int interval = Prompt("Input musical interval >");

int calculatedNotePosition = 0 + interval;

Console.WriteLine();

string[] noteNames = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
string calculatedNote = noteNames[calculatedNotePosition % 12];

System.Console.WriteLine("The note " + interval + " halfsteps away from C is " + calculatedNote + ".");