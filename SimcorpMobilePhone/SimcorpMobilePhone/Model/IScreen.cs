namespace SimcorpMobilePhone.Model {
    public interface IScreen {
        double ScreenSize { get; set; }
        string ScreenModel { get; set; }
        int Dpi { get; set; }

        void DisplayInfo();
    }
}
