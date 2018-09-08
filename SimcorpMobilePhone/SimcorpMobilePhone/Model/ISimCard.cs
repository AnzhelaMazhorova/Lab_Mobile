using System;

namespace SimcorpMobilePhone.Model {
    public interface ISimCard {
        SimCardType SimCardType { get; set; }
        int PinCode { get; set; }

        Boolean CheckPin(int code);
        Boolean SetPin(int code);
    }
}
