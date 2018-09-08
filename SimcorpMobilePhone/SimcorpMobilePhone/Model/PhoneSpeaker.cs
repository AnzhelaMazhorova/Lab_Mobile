namespace SimcorpMobilePhone.Model {
    class PhoneSpeaker : ISpeaker {
        public string SpeakerModel { get; set; }

        public PhoneSpeaker(string speakerModel) {
            this.SpeakerModel = speakerModel;
        }

        public void Play() { }

        public override string ToString() {
            return "Model = " + SpeakerModel;
        }
    }
}
