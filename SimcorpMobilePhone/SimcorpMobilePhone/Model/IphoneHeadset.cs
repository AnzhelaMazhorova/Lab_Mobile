using System;

namespace SimcorpMobilePhone.Model {
    public class IphoneHeadset : Headset {
        private readonly string Manufacturer;

        public IphoneHeadset(string speakerModel, Boolean isWireless) {
            this.SpeakerModel = speakerModel;
            this.IsWireless = isWireless;
            this.Manufacturer = "Iphone";
        }

        public override string ToString() {
            return "Manufacturer = " + Manufacturer + "; Model = " + SpeakerModel + "; Is " + (IsWireless ? "" : "not") + " wireless";
        }
    }
}
