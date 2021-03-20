using System;
using System.Collections.Generic;
using System.Text;

namespace LadeskabLogicLibrary
{
    public interface IDoor
    {
        event EventHandler<ChangeDoorStatusEvent> DoorChangedEvent;
        
        public void LockDoor();
        public void UnlockDoor();
        public void SetDoorStatus();
    }
    public class ChangeDoorStatusEvent : EventArgs
    {
        public bool Status { get; set; }
    }
}
