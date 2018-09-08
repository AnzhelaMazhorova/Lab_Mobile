namespace SimcorpMobilePhone.Model {
    class MonochromeScreen : IScreen {
        public double ScreenSize { get; set; }
        public string ScreenModel { get; set; }
        public int Dpi { get; set; }

        public MonochromeScreen(double screenSize, string screenModel, int dpi) {
            this.ScreenSize = screenSize;
            this.ScreenModel = screenModel;
            this.Dpi = dpi;
        }

        public void DisplayInfo() { }
        public override string ToString() {
            return "Monochrome Screen";
        }
    }
}
