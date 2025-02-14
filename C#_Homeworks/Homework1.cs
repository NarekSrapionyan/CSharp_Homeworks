
/* 1. Number Guessing Game
Generate a random number between 1 and 100.
Ask the user to guess the number.
Provide hints if the guessed number is too high or too low.
Repeat until the user guesses correctly. */

/*
Random random = new Random();
int randomNumber = random.Next(1, 101);

bool guessed = true;
Console.WriteLine("Try to guess the number: ");
while (guessed)
{

    int number = Convert.ToInt32(Console.ReadLine());
    if (number == randomNumber)
    {
        guessed = false;
    }
    else if (number > randomNumber)
    {
        Console.WriteLine("Your number is greather than my number: ");
    }
    else
    {
        Console.WriteLine("Your number is smaller than my number: ");
    }
}

Console.WriteLine("Congratulations!,you guessed the number,the number was: " + randomNumber);
*/

/* 2. Find the Maximum Number
Create an array of 10 random numbers (between 1 and 100).
Print the numbers.
Find and display the largest number in the array. */

/*
Random random = new Random();
int[] arr = new int[10];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(1, 101);
}

Console.WriteLine("Array: " + string.Join(" ", arr)); // string.join kpcnuma irar tpuma toxov.

int maxNumber = arr[0];
foreach (int i in arr)
{
    if (maxNumber < i)
    {
        maxNumber = i;
    }
}

Console.WriteLine("Max number: " + maxNumber);
*/

/* 3. Count Even and Odd Numbers
Generate an array of 20 random numbers (1-50).
Count and display how many numbers are even and how many are odd. */

/*
Random random = new Random();
int[] arr = new int[20];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(1, 51);
}

int CountofODD = 0;
int CountofEVEN = 0;
for (int j = 0; j < arr.Length; j++)
{
    if (arr[j] % 2 != 0)
    {
        CountofODD++;
    }
    else
    {
        CountofEVEN++;
    }
}
Console.WriteLine("Array: " + string.Join(", ", arr));
Console.WriteLine($"Even numbers count: {CountofEVEN}, Odd numbers count: {CountofODD}");
*/

/* 4. Sum of Array Elements
Generate an array of 10 random numbers.
Calculate and display the sum of all numbers in the array.

int[] arr = new int[10];
Random random = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(1, 31);
}

Console.WriteLine("Array " + string.Join(" ", arr));

int sum = 0;
foreach (int i in arr)
{
    sum += i;
}

Console.WriteLine(sum); */

/* 5. Simple Password Generator
Generate a random password of 8 characters.
The password should contain uppercase letters, lowercase letters, and digits.
Display the generated password.*/

/* 

string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
Random random = new Random();
string password = "";
for (int i = 0; i < 8; i++)
{
    password += chars[random.Next(chars.Length)];

}
Console.WriteLine("Generated Password: " + password); */




/* 6. Find the Smallest and Largest Element
Create an array of 15 random numbers.
Identify and print the smallest and largest numbers.*/

/*
Random random = new Random();
int[] arr = new int[15];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(1, 50);
}
Console.WriteLine("Array: " + string.Join(", ", arr));
var MaxValue = Int32.MinValue;
var MinValue = Int32.MaxValue;
foreach (int num in arr)
{
    if (num > MaxValue) MaxValue = num;
    if (num < MinValue) MinValue = num;
}
Console.WriteLine($"Max Value: {MaxValue}, Min Value: {MinValue}");
*/

/* 7.Reverse an Array
Generate an array of 10 random numbers.
Print the array in normal order and then in reverse order. */

/*
Random random = new Random();
int[] arr = new int[11];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(1, 51);
}
Console.WriteLine("Array: " + string.Join(", ", arr));

for (int i = 0;i < arr.Length / 2; i++)
{
    int temp = arr[i];
    arr[i] = arr[arr.Length - i - 1];
    arr[arr.Length - i - 1] = temp;
}
Console.WriteLine("Array: " + string.Join(", ", arr)); */


/* 8.Guess the Secret Word
Store a predefined list of words ({ "apple", "banana", "cherry", "grape" }).
Select one word randomly.
Ask the user to guess the word.
Continue until they guess correctly. */

/*
List<string> words = new List<string>() { "apple", "banana", "cherry", "grape" };
Random random = new Random();
string selectedWord = words[random.Next(words.Count)];

Console.WriteLine("Try to guess the random word from the list: ");
Console.WriteLine($"Possible words: {string.Join(", ", words)}");
string guessedWord = Console.ReadLine();

while(guessedWord != selectedWord)
{
    Console.WriteLine("Wrong guess! Try again: ");
    guessedWord = Console.ReadLine(); 

}
Console.WriteLine("Congratulations! You guessed the word correctly.");
*/

/* 9.Simulate Dice Rolls
Roll a virtual dice (generate a random number from 1-6) five times.
Display the results of each roll. */


/*
Random random = new Random();
Console.WriteLine("Welcome to the Dice Roll Simulator!");

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Roll {i}: Press ENTER to roll...");
    Console.ReadLine();

    int rolledDice = random.Next(1, 7);
    Console.WriteLine($"You rolled a {rolledDice}!\n");
}

Console.WriteLine("Thanks for playing!");

Random random = new Random();
Console.WriteLine("Welcome to the Dice Roll Simulator!");
Console.WriteLine("Press ENTER to roll the dice 5 times.\n");
Console.ReadLine();
var countofRolling = 0;
int rolledDice;
while(countofRolling != 5)
{
    rolledDice = random.Next(1,7);
    Console.WriteLine($"You rolled a {rolledDice}. Press ENTER to roll again {5 - countofRolling} left...");

    Console.ReadLine();
    countofRolling++;
}
Console.WriteLine("That's all, thanks for playing!"); */

/* 10. Multiplication Table
Ask the user for a number.
Display its multiplication table from 1 to 10. */

/*
Console.Write("Enter a number to generate its multiplication table: ");
if (int.TryParse(Console.ReadLine(), out int num))
{
    Console.WriteLine($"Multiplication Table for {num}:");

    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{num} × {i} = {num * i}");
    }
}
else
{
    Console.WriteLine("Invalid input! Please enter a valid number.");
} */

/* 11. Sum of Positive and Negative Numbers
Generate an array of 20 random numbers (from -50 to 50).
Calculate and display the sum of positive and negative numbers separately. */
/*
int[] arr = new int[20];
Random random = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(-50, 51);
}
Console.WriteLine("Array: " + string.Join(", ", arr));

var sumofArray = 0;
for(int i = 0;i < arr.Length; i++)
{
    sumofArray+= arr[i];
}
Console.WriteLine($"Sum of numbers from array equal: {sumofArray}");

//Console.WriteLine(arr.Sum()); */

/* 12. Find Duplicates in an Array
Generate an array of 10 random numbers between 1 and 10.
Identify and display any duplicate numbers. */
/*
int[] arr = new int[10];
Random random = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(1,11);
}
Console.WriteLine("Array: " + string.Join(", ", arr));

Console.WriteLine("Duplicate numbers:");
for (int i = 0; i < arr.Length; i++)
{
    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[i] == arr[j])
        {
            Console.WriteLine(arr[i]);
            break; 
        }
    }
}
*/

/* 13. Random Sentence Generator
Store arrays of subjects, verbs, and objects (e.g., { "The cat", "A dog", "The bird" }).
Randomly construct a simple sentence (e.g., "The cat jumps over the fence").*/

/*
Random random = new Random();

string[] subjects = { "The cat", "A dog", "The bird", "My friend", "A programmer" };
string[] verbs = { "jumps over", "runs to", "flies to", "codes", "watches" };
string[] objects = { "the fence", "the park", "a tree", "the computer", "the movie" };

string randomSentence = $"{subjects[random.Next(subjects.Length)]} {verbs[random.Next(verbs.Length)]} {objects[random.Next(objects.Length)]}.";


Console.WriteLine("Random sentence:");
Console.WriteLine(randomSentence);
*/

/* 14. Rock, Paper, Scissors
Let the user play Rock, Paper, Scissors against the computer.
Generate the computer’s move randomly.
Determine and display the winner.*/

/*
Random random = new Random();
string[] choices = { "rock", "paper", "scissors" };

Console.WriteLine("Welcome to Rock, Paper, Scissors!");
Console.WriteLine("Choose: rock, paper, or scissors");

string userChoice = Console.ReadLine().ToLower();

if (userChoice != "rock" && userChoice != "paper" && userChoice != "scissors")
{
    Console.WriteLine("Invalid choice! Please choose rock, paper, or scissors.");
    return;
}

string computerChoice = choices[random.Next(choices.Length)];

Console.WriteLine($" Computer chose: {computerChoice}");

        if (userChoice == computerChoice)
        {
            Console.WriteLine("Draw!");
        }
        else if ((userChoice == "rock" && computerChoice == "scissors") ||
                 (userChoice == "paper" && computerChoice == "rock") ||
                 (userChoice == "scissors" && computerChoice == "paper"))
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("You lose! Better luck next time.");
        }

*/
