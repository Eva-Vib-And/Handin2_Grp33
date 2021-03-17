using System;
using System.Collections.Generic;
using System.Text;

namespace LadeSkab
{
    public interface IChargeControl
    {
        public bool IsConnected();
        public void StartCharge();
        public void StopCharge();
    }
}
