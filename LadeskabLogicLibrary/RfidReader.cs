﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LadeskabLogicLibrary
{
    public class RfidReader : IRfidReader
    {

        public event EventHandler<RfidDetectedEventArgs> RfidReaderEvent;

        public void SetRfidTag(int RfidTag)
        {
            if (RfidTag < 0000)
            {
                Console.WriteLine("false id");
                // muligvis en exception 
            }
            OnRfidDetected(new RfidDetectedEventArgs{Id= RfidTag});
            

        }

        protected virtual void OnRfidDetected(RfidDetectedEventArgs e)
        {
            RfidReaderEvent?.Invoke(this,e);
        }
    }
}
