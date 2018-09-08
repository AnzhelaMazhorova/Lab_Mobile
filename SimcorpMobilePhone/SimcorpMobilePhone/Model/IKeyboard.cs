namespace SimcorpMobilePhone.Model {
    public interface IKeyboard {
        string Language { get; set; }
        string KeyboardManufacturer { get; set; }

        void InputText();
    }
}
