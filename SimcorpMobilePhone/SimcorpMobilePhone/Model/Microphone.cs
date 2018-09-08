namespace SimcorpMobilePhone.Model {
    class Microphone : IMicrophone {
        public int Sensitivity { get; set; }
        public string MicrophoneModel { get; set; }

        public Microphone(int sensitivity, string microphoneModel) {
            this.Sensitivity = sensitivity;
            this.MicrophoneModel = microphoneModel;
        }

        public void Record() { }
        public override string ToString() {
            return "Sensitivity = " + Sensitivity + "; Microphone Model = " + MicrophoneModel;
        }
    }
}
