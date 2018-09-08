using System;

namespace SimcorpMobilePhone.Model {
    class SamsungHeadset : Headset {
        private readonly string Manufacturer;

        public SamsungHeadset(string speakerModel, Boolean isWireless) {
            this.SpeakerModel = speakerModel;
            this.IsWireless = isWireless;
            this.Manufacturer = "Samsung";
        }

        public override string ToString() {
            return "Manufacturer = " + Manufacturer + "; Model = " + SpeakerModel + "; Is " + (IsWireless ? "" : "not") + " wireless";
        }
    }
}
