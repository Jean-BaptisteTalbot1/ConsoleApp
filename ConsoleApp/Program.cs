using ConsoleApp;

PrintMessage();

void PrintMessage()
{
    var anagramChecker = new annagram();
    Console.WriteLine(anagramChecker.IsAnagram("acc", "abc"));
}