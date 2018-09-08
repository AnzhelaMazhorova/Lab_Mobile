using System.Text;

namespace SimcorpMobilePhone.Model {
    public class Mobile : IMobile {
        public IScreen Screen { get; set; }
        public IBattery Battery { get; set; }
        public IKeyboard Keyboard { get; set; }
        public IMicrophone Microphone { get; set; }
        public ISpeaker Speaker { get; set; }
        public ISimCard SimCard { get; set; }

        public Mobile(IScreen screen, IBattery battery, IKeyboard keyboard, IMicrophone microphone, ISpeaker speaker, ISimCard simCard) {
            this.Screen = screen;
            this.Battery = battery;
            this.Keyboard = keyboard;
            this.Microphone = microphone;
            this.Speaker = speaker;
            this.SimCard = simCard;
        }

        public void AddContact() { }
        public void SetRington() { }
        public void MakeCall() { }
        public void SendSMS() { }
       
        public string GetDescription() {
            StringBuilder descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Screen: {Screen.ToString()}");
            descriptionBuilder.AppendLine($"Battery: {Battery.ToString()}");
            descriptionBuilder.AppendLine($"Keyboard: {Keyboard.ToString()}");
            descriptionBuilder.AppendLine($"Microphone: {Microphone.ToString()}");
            descriptionBuilder.AppendLine($"Speaker: {Speaker.ToString()}");
            descriptionBuilder.AppendLine($"Simcard: {SimCard.ToString()}");
            return descriptionBuilder.ToString();
        }
    }
}