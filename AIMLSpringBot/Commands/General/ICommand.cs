using System;
using System.Collections.Generic;
using System.Text;

namespace AIMLSpringBot.Commands
{
    public interface  ICommand
    {
        string Execute(string input);
    }
}
