namespace SimcorpMobilePhone.Model {
    public interface IMicrophone {
        int Sensitivity { get; set; }
        string MicrophoneModel { get; set; }

        void Record();
    }
}
