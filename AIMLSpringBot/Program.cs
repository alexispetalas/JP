using System;
using AIMLbot;

namespace AIMLSpringBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Bot myBot = new Bot();
            myBot.loadSettings();
            User myUser = new User("consoleUser", myBot);
            myBot.isAcceptingUserInput = false;
            myBot.loadAIMLFromFiles();
            myBot.isAcceptingUserInput = true;
            while (true)
            {
                Console.Write("You: ");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    Request r = new Request(input, myUser, myBot);
                    Result res = myBot.Chat(r);
                    Console.WriteLine("Bot: " + AIMLSpringBot.Commands.CommandFactory.GetCommand(res.Output).Execute(input.ToLower()));
                }
            }
        }
    }
}
