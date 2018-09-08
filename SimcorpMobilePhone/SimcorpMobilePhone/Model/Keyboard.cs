namespace SimcorpMobilePhone.Model {
    public class Keyboard : IKeyboard {
        public string Language { get; set; }
        public string KeyboardManufacturer { get; set; }

        public Keyboard(string language, string keyboardManufacturer)
        {
            this.Language = language;
            this.KeyboardManufacturer = keyboardManufacturer;
        }

        public void InputText() { }
        public override string ToString() {
            return Language + " Keyboard; " +  "Manufacturer = " + KeyboardManufacturer;
        }
    }
}
