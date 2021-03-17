using System;
using System.Collections.Generic;
using System.Text;

namespace LadeSkab
{
    public class ChargeControl : IChargeControl
    {
        private UsbChargerSimulator chargerSimulator;

        public ChargeControl(UsbChargerSimulator chargerSimulator_)
        {
            chargerSimulator = chargerSimulator_;
        }

        public bool IsConnected()
        {
            bool isConnected = chargerSimulator.Connected;

            return isConnected;

        }

        public void StartCharge()
        {
            chargerSimulator.StartCharge();
        }

        public void StopCharge()
        {
            chargerSimulator.StopCharge();
        }
    }
}
