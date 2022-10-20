// Richard Johnson
//10-19-22

Console.Clear();

bool playAgain;
bool isConverted = false;
bool isNumber;
int validNum = 0;
int num = 0;
int reverseNum = 0;


// This while loop will play as long as playAgain is true
while(playAgain == true)
{
    // 
    Console.WriteLine("Want to reverse some numbers?");
    Console.Write("Please type YES or NO: ");
    string yesNo = Console.ReadLine();
    yesNo = yesNo.ToUpper();
    isNumber = Int32.TryParse(yesNo, out validNum);

    if(yesNo == "NO" && isNumber != true)
    {
        // This will run if the input is no, and not a number
        Console.WriteLine("Alright, goodbye then.");
        Console.WriteLine(" ");
        playAgain = false;
    }
    else if(yesNo == "YES" && isNumber != true)
    {
        // 
        Console.WriteLine("Alright, that's good to hear.");
        Console.Write("Please enter a sequence of numbers for us to reverse: ");
        string userInput = Console.ReadLine();
        isNumber = Int32.TryParse(userInput, out num);
    }
    else
    {
        Console.WriteLine("Invalid input");
    }


}