// Andrea Burr
// 10-18-2022
//mini5 redo - github push
Console.Clear();

int easyLvl = 10;
int medLvl = 50;
int hardLvl = 100;
int winningNumber = 0;
string option;
string userInput;
bool validNum = false;
bool playagain = true;

while (playagain){
    

Console.WriteLine("guessing game! what level would you like to play");
Console.WriteLine("easy - 1-10");
Console.WriteLine("Medium -  1-50");
Console.WriteLine("hard -  1-100");
Console.WriteLine("enter easy medium or hard");

option = Console.ReadLine();

while(option != "easy" && option != "medium" && option != "hard");{
Console.WriteLine("did i enter a valid choice? ");

option = Console.ReadLine();
}
Console.WriteLine (" you chose " + option);

Random random = new Random();

if(option == "easy"){
    winningNumber = random.Next(0, easyLvl);
    Console.WriteLine(winningNumber);
}
if(option == "medium"){
    winningNumber = random.Next(0, medLvl);
    Console.WriteLine(winningNumber);
}
if(option == "hard"){
    winningNumber = random.Next(0, hardLvl);
    Console.WriteLine(winningNumber);
}
string userGuess = Console.ReadLine();
Console.WriteLine(winningNumber);


Console.WriteLine("if you would like to play again press any key or else type no");

string contPlay = Console.ReadLine();


  if (contPlay == "no"){

 playagain = false; 
  }else{
    playagain = true;
  }
}
