// Richard Johnson
//10-21-22

Console.Clear();

bool playAgain = true;
bool isConverted = false;
bool isNumber;
int validNum = 0;
int num = 0;
int inputLength;
int inputLengthMax = 7;
int reverseNum = 0;


// This while loop will play as long as playAgain is true
while(playAgain == true)
{
    // The program will ask the user if they want to reverse some numbers
    reverseNum = 0;
    Console.WriteLine("Want to reverse some numbers?");
    Console.Write("Please type YES or NO: ");
    string yesNo = Console.ReadLine();
    yesNo = yesNo.ToUpper();
    isNumber = Int32.TryParse(yesNo, out validNum);

    if(yesNo == "NO" && isNumber != true)
    {
        // If the user enters NO, the program will print the text below and playAgain will be declared false, ending the program
        Console.WriteLine("Alright, goodbye then.");
        Console.WriteLine(" ");
        playAgain = false;
    }
    else if(yesNo == "YES" && isNumber != true)
    {
        Console.WriteLine("Alright, good.");
        isConverted = false;
        while(!isConverted)
        {
            // If the user enters yes, they will be asked to enter a sequence of numbers to reverse
            Console.Write("Please enter a sequence of numbers to reverse (no more than 7): ");
            string userInput = Console.ReadLine();
            isNumber = Int32.TryParse(userInput, out num);
            inputLength = userInput.Length;
                if(isNumber == true && inputLength <= inputLengthMax)
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
                else if (isNumber == true && inputLength > inputLengthMax)
                {
                    //
                    Console.WriteLine("That sequence is too long.");
                }
                else
                {
                    Console.WriteLine("That is not a valid input");
                }
        }
            
    }
    else
    {
        Console.WriteLine("Invalid input");
    }



}