using System;
using System.Collections.Generic;
using System.Text;


namespace AIMLSpringBot.Commands
{
    public class CommandFactory
    {
        public static ICommand GetCommand(string name)
        {
            name = name.Remove(name.Length - 1);
            return (ICommand) AppCtx.Resolve(name);
        }
    }

    
}
