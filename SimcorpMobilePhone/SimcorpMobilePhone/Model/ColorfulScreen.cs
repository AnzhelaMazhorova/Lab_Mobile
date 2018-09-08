using System;

namespace SimcorpMobilePhone.Model {
    class ColorfulScreen : IScreen {
        public double ScreenSize { get; set; }
        public string ScreenModel { get; set; }
        public int Dpi { get; set; }
        Boolean IsTouchScreen { set; get; }

        public ColorfulScreen(double screenSize, string screenModel, int dpi, Boolean isTouchScreen) {
            this.ScreenSize = screenSize;
            this.ScreenModel = screenModel;
            this.Dpi = dpi;
            this.IsTouchScreen = isTouchScreen;
        }

        public void DisplayInfo() { }
        public override string ToString() {
            return "Colorful Screen; " + "Screen Size = " + ScreenSize + "; Screem Model = " + ScreenModel + "; Dpi = " + Dpi + 
                (IsTouchScreen ? "; ": "; not") + "Touch screen";
        }
    }
}
