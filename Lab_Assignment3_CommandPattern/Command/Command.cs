using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment3_CommandPattern
{
    public interface ICommand
    {
        void Execute(); 
    }

    //Null object 
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            //Do nothing
        }
    }

    public class MacroCommand : ICommand
    {
        private ICommand[] Commands { get; set; }

        public MacroCommand(ICommand[] commands)
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
    }
}
