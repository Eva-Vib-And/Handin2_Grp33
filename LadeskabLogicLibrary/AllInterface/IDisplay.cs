using System;
using System.Collections.Generic;
using System.Text;

namespace LadeskabLogicLibrary
{
    public interface IDisplay
    {
        public void ShowConnectPhone();
        public void ShowConnectionIsFailed();
        public void ShowOccupiedLocker();
        public void ShowCorrectId();
        public void ShowWrongId();
        public void ShowScanRfid();
    }
}
