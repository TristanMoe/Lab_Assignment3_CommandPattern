using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl_Example
{
    public interface Command
    {
        void Execute();
        /// <summary>
        /// Undo command, reverse the previous command
        /// Can be made with a stack, so it pops/reverses until no previous command
        /// can be found. 
        /// </summary>
        void Undo(); 
    }

    //Null object. 
    public class NoCommand : Command
    {
        public void Execute()
        {
            //Do nothing
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }

    public class LightOnCommand : Command
    {
        public Light Light { get; private set; }

        public LightOnCommand(Light light)
        {
            Light = light; 
        }

        public void Execute()
        {
            Light.On();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
