using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl_Example
{
    public class MacroCommand : Command
    {
        private Command[] Commands { get; set; }

        MacroCommand(Command[] commands)
        {
            this.Commands = commands; 
        }
          
        public void Execute()
        {
            foreach (var command in Commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach (var command in Commands)
            {
                command.Undo();
            }
        }

        /* Example of Macro commands
         All these are command objects. 
         Command[] partyOn = { lightOn, stereoOn, tcOn, hottubOn };
         MacroCommand partyMacro = new MacroCommand(partyOn);          
         */
    }
}
