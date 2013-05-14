using System;
using System.Collections.Generic;
using System.Text;

namespace AIMLSpringBot.Commands.Especific
{
    public class CommandDiagnostico: ICommand
    {
        public string Execute(string input)
        {
            return "soy diagnostico command procesando tu input: " + input;
        }
    }
}
