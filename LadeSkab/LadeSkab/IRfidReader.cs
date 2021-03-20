﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LadeSkab
{
    public interface IRfidReader
    {
        event EventHandler<RfidDetectedEventArgs> RfidReaderEvent;
        void SetRfidTag(int RfidTag);
    }

    public class RfidDetectedEventArgs : EventArgs
    {
        public int Id { get; set; }
    }
}
