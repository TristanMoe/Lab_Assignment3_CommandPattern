using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_Assignment3_CommandPattern.Receivers;

namespace Lab_Assignment3_CommandPattern
{
    public interface Command
    {
        void Execute(); 
    }

    //Null object 
    public class NoCommand : Command
    {
        public void Execute()
        {
            //Do nothing
        }
    }

    public class OrderShakeCommand : Command
    {
        public Cooks Cook { get; set; }

        public OrderShakeCommand(Cooks cook)
        {
            Cook = cook;
        }

        public void Execute()
        {
            Cook.MakeItem1();
        }
    }


    public class MacroCommand : Command
    {
        private Command[] Commands { get; set; }

        public MacroCommand(Command[] commands)
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
