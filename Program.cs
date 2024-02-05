using System.ComponentModel.DataAnnotations;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
       Random random = new Random();
       bool play = true;
       String player;
       String computer;
       String answer;
       int playercount =0;
       int computercount=0;
       int tie=0;
       int round = 1;
       
        while (play = true)
       {
        
        player = "";
        computer = "";
        answer = "";
               
        while ( player != "R" && player != "P" && player != "S"){
            Console.WriteLine("********************************");
            Console.WriteLine("Game number :" + round);
            Console.WriteLine("Enter R as ROCK, P as PAPER, OR S as SCISSORS, the best of 5 games WIN!!");
            
            player = Console.ReadLine();
            player = player.ToUpper();
        }
        switch (random.Next(1,4))
        {
            case 1:
                computer = "R";
                break;
            case 2:
                computer = "P";
                break;
            case 3:
                computer = "S";  
                break;          
        }
        Console.WriteLine("Player: " + player);
        Console.WriteLine("Computer : " + computer); 
        
        switch (player)
        {
            case "R":
            if (computer == "R") {
                tie++;
                Console.WriteLine("It is a tie " + playercount + " " + computercount);
            }
            else if (computer == "P") {
               computercount++;
               Console.WriteLine("You Lose! " + playercount + " " + computercount); 
            }
            else {
                playercount++;
                Console.WriteLine("You WIN !!" + playercount + " " + computercount);
            }
            break;
            case "P":
            if (computer == "R") {
                playercount++;            
                Console.WriteLine("You WIN!!" + playercount +  " " + computercount);
            }
            else if (computer == "P") {
               tie++; 
               Console.WriteLine("It is a tie! " + playercount + " " + computercount); 
            }
            else {
                computercount++;
                Console.WriteLine("You lose!!" + playercount + " " + computercount);
            }
            break;
            case "S":
            if (computer == "R") {
                computercount++;
                Console.WriteLine("You lose!!" + playercount + " " + computercount);
            }
            else if (computer == "P") {
                playercount++;
               Console.WriteLine("you WIN!" + playercount + " " + computercount); 
            }
            else {
                tie++;
                Console.WriteLine("It is a tie !!" + playercount + " " + computercount);
            }
            break;
           }
       if (round < 5){
        round++;
       }  
       else {
        Console.WriteLine("*******************************");
        Console.WriteLine("Final results are :");
        Console.WriteLine("player :" + playercount);
        Console.WriteLine("Computer :" + computercount);
        Console.WriteLine("tie :" + tie);
        if(playercount > computercount){
            Console.WriteLine("THE WINNER IS THE PLAYER!!!");
        }
        else {
           Console.WriteLine("THE WINNER IS THE COMPUTER!!!"); 
        }
        Console.WriteLine("Would you like another play again ? (Y/N):");
        answer = Console.ReadLine();
        answer = answer.ToUpper();
        if (answer == "Y") {
        play = true;
        round = 1;
        playercount=0;
        computercount=0;
        tie=0;
    }
    
     else 
    {
    play = false;
    Console.WriteLine("Thank for playing!, I hope you seen soon");
    break;
    }
    }
    }
    }
}
    
    
    

    
 



