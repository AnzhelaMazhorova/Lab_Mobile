namespace SimcorpMobilePhone.Model {
    public interface IMobile {
        IScreen Screen { get; set; }
        IBattery Battery { get; set; }
        IKeyboard Keyboard { get; set; }
        IMicrophone Microphone { get; set; }
        ISpeaker Speaker { get; set; }
        ISimCard SimCard { get; set; }

        string GetDescription();
        void AddContact();
        void SetRington();
        void MakeCall();
        void SendSMS();
    }
}
