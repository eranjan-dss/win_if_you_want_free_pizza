using System;

class MainClass
{
  public static void Main (string[] args)
  {
    // the start
    string er = Console.ReadLine(); // the variable thats start the game
    // code to gess
    if(er == "start")
    {
      // the secret number
      string scNUM = "789";
      // the code to the user to gess
      Console.WriteLine("gess NUM");
      string oi = Console.ReadLine();
      // if the gess is simmilar to scNUM 
      if(oi == scNUM)
      {
        Console.WriteLine("here is your pizza");
      }else
      {
        // if the gess is not simmilar to scNUM
        if(oi != scNUM)
        {
          Console.WriteLine("try again by closing the window and opening again and win to get free pizza");
        }
      }
    }
  }
}