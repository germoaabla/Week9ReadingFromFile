//Program to tell jokes about Chuck Norris


string fileDirectoryPath = @"C:\Users\germo\Documents\TKTK\c#";
string fileName = "chuck.txt";

string fullFilePath = Path.Combine(fileDirectoryPath, fileName);

//string fullFilePath = @"C:\Users\germo\Documents\TKTK\c#\chuck.txt";      //alternative for Path.Combine()

ReadFromFile(fullFilePath);




static void DisplayDataFromArray(string[] someArray)    //Displays all lines from the array
{
    foreach (string line in someArray)
    {
        Console.WriteLine(line);
    }
}


static void DisplayRandomElement(string[] someArray)        //Displays random line
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    Console.WriteLine(someArray[randomIndex]);
}


static void ReadFromFile(string filePath)               //Depending on user input gives answer
{
    if (File.Exists(filePath))
    {

        string[] tempArray = File.ReadAllLines(filePath);
        Console.WriteLine($"There are {tempArray.Length} lines this file.");
        Console.WriteLine("Do you want to see all lines or pick a random one? all/random");
        string userChoice = Console.ReadLine();
        if (userChoice == "all")
        {
            DisplayDataFromArray(tempArray);
        }
        else if (userChoice == "random")
        {
            DisplayRandomElement(tempArray);
        }
        else
        {
            Console.WriteLine("Wrong input!");
        }
    }
    else
    {
        Console.WriteLine($"File was not found.");
    }
}
