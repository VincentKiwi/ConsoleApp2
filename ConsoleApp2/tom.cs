using System;
using System.Collections.Generic;

public class tamagotchi
{
private int hunger;
private int boredom;
private List<string> words = new List<string>() {"booonk"};
private bool isAlive;
public string name;

public tamagotchi()
{
    isAlive = true;
}

public void Feed()
{
    Console.WriteLine($"[{name}] is fed, [{name}] is becoming more full ");
    hunger -= 2;
    if (hunger < 0)
    {
        hunger = 0;
    }
}



}
