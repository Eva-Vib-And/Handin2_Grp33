using System;
using LadeskabLogicLibrary;

namespace LadeSkab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assemble your system here from all the classes
            

            IDoor door = new Door();
            IUsbCharger usbCharger= new UsbChargerSimulator();
            IRfidReader rfidReader= new RfidReader();
            IChargeControl charge = new ChargeControl(usbCharger);

            bool finish = false;
            do
            {
                string input;
                System.Console.WriteLine("Indtast E, O, C, R: ");
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) continue;

                switch (input[0])
                {
                    case 'E':
                        finish = true;
                        break;

                    case 'O':
                        door.UnlockDoor();
                        break;

                    case 'C':
                        door.LockDoor();
                        break;

                    case 'R':
                        System.Console.WriteLine("Indtast RFID id: ");
                        string idString = System.Console.ReadLine();

                        int id = Convert.ToInt32(idString);
                        rfidReader.SetRfidTag(id);
                        
                        break;

                    default:
                        break;
                }

            } while (!finish);
        }
    }
}
