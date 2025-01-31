using System;
using System.Collections.Generic;

public class PromptGenerator // dunno if I actually need this or if it should roll into another class lol
{
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What made you feel uncomfortable today?",
        "Did anyone say anything that stood out?",
        "What did you accomplish today?",
        "What did you work on today?",
        "Where did you go?",
        "Are you happy with how the day went or would you rather something else happened?"
    };

    private Random random = new Random();

     public string GetRandomPrompt()
    {
        int index = random.Next(0,prompts.Count);
        return prompts[index]; // should these be attributes of the generator class?
    }
}
