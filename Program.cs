// Richard Johnson
//10-19-22

Console.Clear();

bool playAgain = true;
bool isConverted = false;
bool isNumber;
int validNum = 0;
int num = 0;
int reverseNum = 0;


// This while loop will play as long as playAgain is true
while(playAgain == true)
{
    // 
    reverseNum = 0;
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
        isConverted = false;
        while(!isConverted)
        {
            // 
            Console.WriteLine("Alright, that's good to hear.");
            Console.Write("Please enter a sequence of numbers for us to reverse: ");
            string userInput = Console.ReadLine();
            isNumber = Int32.TryParse(userInput, out num);
                if(isNumber == true)
                {
                    //
                    while(num > 0)
                    {
                        //
                        int remainder = num % 10;
                        reverseNum = (reverseNum * 10) + remainder;
                        num = num / 10;
                    }
                    Console.WriteLine($"{userInput} is {reverseNum} in reverse.");
                    isConverted = true;
                    
                }
                else
                {
                    //
                    Console.WriteLine("This isn't a valid whole number");
                }
        }
            
    }
    else
    {
        Console.WriteLine("Invalid input");
    }



}