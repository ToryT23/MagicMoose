using System;

using System.Collections.Generic;

        {
    
            Console.WriteLine("Welcome to Magic Moose!");
        }
// Above, the loop executes until a < 50. The value of is set to 0 initially.
// The value of a decrements after each iteration since it is set to.
// Therefore the value of a will never be above 50 and the condition a <50 will be true always. 
// This will make the loop an infinite loop.        

for (int a = 0; a < 50; a--)
{
MooseSays("Ask A Question User.");

void MooseSays(string message)
{
  Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}


string response = Console.ReadLine();

// example of a list of arrays
// List<string> words = new List<string>() 
// { "do", "you", "understand", "the", "words", "coming", "out", "of", "my", "mouth?" };

List<string> AllResponse = new List<string>()
 {
 "As I see it, yes.",
"Ask again later.",
"Better not tell you now.",
" Cannot predict now.",
"Concentrate and ask again.",
"Don’t count on it.",
"It is certain.",
"It is decidedly so.",
"Most likely.",
"My reply is no.",
"My sources say no.",
"Outlook not so good.",
"Outlook good.",
"Reply hazy, try again.",
"Signs point to yes.",
"Very doubtful.",
"Without a doubt.",
 "Yes.",
 "Yes – definitely.",
"You may rely on it.",
};

Random rnd = new Random();
int AutoRespose = rnd.Next(0,20);

 

if( !String.IsNullOrEmpty(response)) {

    Console.WriteLine(AllResponse[AutoRespose]);

} else
{
    Console.WriteLine("Game Over");
    break;
}
 
}

    


//     List<string> foods = new List<string>()
// {
//     "Brussels Sprout", "Toast", "Steak", "Tomato"
// };
// foreach (string food in foods)
// {
//     Console.WriteLine($"You can eat {food}.");
// }

// Allow the user to continue to ask questions. 
// If the user hits ENTER without asking a question, the program should exit

//  Console.Write("Should we continue? (y/n) ");
// string input = Console.ReadLine();

// while (input == "y")
// {
//     Console.WriteLine("We're continuing!");
//     Console.Write("Should we continue? (y/n) ");
//     input = Console.ReadLine();
// }