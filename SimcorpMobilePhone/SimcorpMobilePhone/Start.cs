using System;
using SimcorpMobilePhone.Model;

namespace MobilePhone.model {
    class Start {
        static void Main(string[] args) {
            IScreen Screen = new ColorfulScreen(7.0, "T24", 500, true);
            IBattery Battery = new Battery(2000, "Li-ion");
            IKeyboard Keyboard = new Keyboard("Russian", "Samsung");
            IMicrophone Microphone = new Microphone(94, "model-xxx0155");
            ISpeaker Speaker = new SamsungHeadset("model-XXX", false);
            ISimCard SimCard = new SimCard(SimCardType.NanoSim, 1111);
            IMobile Samsung = new Mobile(Screen, Battery, Keyboard, Microphone, Speaker, SimCard);

            Console.WriteLine(Samsung.GetDescription());
            Console.ReadLine();
        }
    }
}
