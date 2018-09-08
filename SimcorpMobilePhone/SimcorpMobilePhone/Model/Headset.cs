using System;

namespace SimcorpMobilePhone.Model {
    public class Headset : ISpeaker {
        public string SpeakerModel { get; set; }
        public Boolean IsWireless { get; set; }

        public Headset() { }
        public Headset(string speakerModel, Boolean isWireless) {
            this.SpeakerModel = speakerModel;
            this.IsWireless = isWireless;
        }

        public void Play() { }

        public override string ToString() {
            return "Model = " + SpeakerModel + "; Is " + (IsWireless ? "" : "not") + " wireless";
        }
    }
}
