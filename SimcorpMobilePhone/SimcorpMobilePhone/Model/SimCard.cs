using System;

namespace SimcorpMobilePhone.Model {
    class SimCard : ISimCard {
        public SimCardType SimCardType { get; set; }
        public int PinCode { get; set; }

        public SimCard(SimCardType simCardType, int pinCode) {
            this.SimCardType = simCardType;
            this.PinCode = pinCode;
        }

        public Boolean CheckPin(int code) {
            return false; //TODO
        }

        public Boolean SetPin(int code) {
            return false; //TODO
        }

        public override string ToString() {
            return "Type = " + SimCardType + "; PinCode = " + PinCode;
        }

    }
}
