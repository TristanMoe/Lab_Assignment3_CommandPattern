using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl_Example
{
    public class RemoteControl
    {
        private Command Slot { get; set; }
        public RemoteControl() { }

        public void SetCommand(Command command)
        {
            Slot = command;
        }

        public void ButtonWasPressed()
        {
            Slot.Execute();
        }
    }
}
