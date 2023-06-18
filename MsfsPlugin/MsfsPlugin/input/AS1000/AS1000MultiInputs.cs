namespace Loupedeck.MsfsPlugin.folder
{
    using System;
    using System.Collections.Generic;

    using Loupedeck.MsfsPlugin.tools;

    public class AS1000MultiInputs : PluginDynamicCommand, Notifiable
    {
        protected readonly List<Binding> _bindings = new List<Binding>();
        public AS1000MultiInputs() : base()
        {
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_SOFTKEYS_1)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_SOFTKEYS_2)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_SOFTKEYS_3)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_SOFTKEYS_4)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_SOFTKEYS_5)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_SOFTKEYS_6)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_SOFTKEYS_7)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_SOFTKEYS_8)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_SOFTKEYS_9)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_SOFTKEYS_10)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_SOFTKEYS_11)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_SOFTKEYS_12)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_DIRECTTO)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_ENT_Push)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_CLR_Long)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_CLR)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_MENU_Push)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_FPL_Push)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_PROC_Push)));

            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_MFD_SOFTKEYS_1)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_MFD_SOFTKEYS_2)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_MFD_SOFTKEYS_3)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_MFD_SOFTKEYS_4)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_MFD_SOFTKEYS_5)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_MFD_SOFTKEYS_6)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_MFD_SOFTKEYS_7)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_MFD_SOFTKEYS_8)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_MFD_SOFTKEYS_9)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_MFD_SOFTKEYS_10)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_MFD_SOFTKEYS_11)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_MFD_SOFTKEYS_12)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_MFD_DIRECTTO)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_MFD_ENT_Push)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_MFD_CLR_Long)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_MFD_CLR)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_MFD_MENU_Push)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_MFD_FPL_Push)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_MFD_PROC_Push)));

            this.AddParameter("Key 1(PFD)", "G1000 PFD Softkey 1", "G1000 PFD");
            this.AddParameter("Key 2(PFD)", "G1000 PFD Softkey 2", "G1000 PFD");
            this.AddParameter("Key 3(PFD)", "G1000 PFD Softkey 3", "G1000 PFD");
            this.AddParameter("Key 4(PFD)", "G1000 PFD Softkey 4", "G1000 PFD");
            this.AddParameter("Key 5(PFD)", "G1000 PFD Softkey 5", "G1000 PFD");
            this.AddParameter("Key 6(PFD)", "G1000 PFD Softkey 6", "G1000 PFD");
            this.AddParameter("Key 7(PFD)", "G1000 PFD Softkey 7", "G1000 PFD");
            this.AddParameter("Key 8(PFD)", "G1000 PFD Softkey 8", "G1000 PFD");
            this.AddParameter("Key 9(PFD)", "G1000 PFD Softkey 9", "G1000 PFD");
            this.AddParameter("Key 10(PFD)", "G1000 PFD Softkey 10", "G1000 PFD");
            this.AddParameter("Key 11(PFD)", "G1000 PFD Softkey 11", "G1000 PFD");
            this.AddParameter("Key 12(PFD)", "G1000 PFD Softkey 12", "G1000 PFD");
            this.AddParameter("Direct To(PFD)", "G1000 PFD Direct To", "G1000 PFD");
            this.AddParameter("ENT(PFD)", "G1000 PFD Ent", "G1000 PFD");
            this.AddParameter("CLR(PFD)", "G1000 PFD Clr", "G1000 PFD");
            this.AddParameter("MENU(PFD)", "G1000 PFD Menu Push", "G1000 PFD");
            this.AddParameter("FPL(PFD)", "G1000 PFD FPL Push", "G1000 PFD");
            this.AddParameter("PROC(PFD)", "G1000 PFD Proc Push", "G1000 PFD");

            this.AddParameter("Key 1(MFD)", "G1000 MFD Softkey 1", "G1000 MFD");
            this.AddParameter("Key 2(MFD)", "G1000 MFD Softkey 2", "G1000 MFD");
            this.AddParameter("Key 3(MFD)", "G1000 MFD Softkey 3", "G1000 MFD");
            this.AddParameter("Key 4(MFD)", "G1000 MFD Softkey 4", "G1000 MFD");
            this.AddParameter("Key 5(MFD)", "G1000 MFD Softkey 5", "G1000 MFD");
            this.AddParameter("Key 6(MFD)", "G1000 MFD Softkey 6", "G1000 MFD");
            this.AddParameter("Key 7(MFD)", "G1000 MFD Softkey 7", "G1000 MFD");
            this.AddParameter("Key 8(MFD)", "G1000 MFD Softkey 8", "G1000 MFD");
            this.AddParameter("Key 9(MFD)", "G1000 MFD Softkey 9", "G1000 MFD");
            this.AddParameter("Key 10(MFD)", "G1000 MFD Softkey 10", "G1000 MFD");
            this.AddParameter("Key 11(MFD)", "G1000 MFD Softkey 11", "G1000 MFD");
            this.AddParameter("Key 12(MFD)", "G1000 MFD Softkey 12", "G1000 MFD");
            this.AddParameter("Direct To(MFD)", "G1000 MFD Direct To", "G1000 MFD");
            this.AddParameter("ENT(MFD)", "G1000 MFD Ent", "G1000 MFD");
            this.AddParameter("CLR(MFD)", "G1000 MFD Clr", "G1000 MFD");
            this.AddParameter("MENU(MFD)", "G1000 MFD Menu Push", "G1000 MFD");
            this.AddParameter("FPL(MFD)", "G1000 MFD FPL Push", "G1000 MFD");
            this.AddParameter("PROC(MFD)", "G1000 MFD PROC", "G1000 MFD");

            MsfsData.Instance.Register(this);
        }

        protected override String GetCommandDisplayName(String actionParameter, PluginImageSize imageSize) => actionParameter;

        protected override void RunCommand(String actionParameter)
        {
            switch (actionParameter)
            {
                case "Key 1(PFD)":
                    this._bindings[0].SetControllerValue(1);
                    break;
                case "Key 2(PFD)":
                    this._bindings[1].SetControllerValue(1);
                    break;
                case "Key 3(PFD)":
                    this._bindings[2].SetControllerValue(1);
                    break;
                case "Key 4(PFD)":
                    this._bindings[3].SetControllerValue(1);
                    break;
                case "Key 5(PFD)":
                    this._bindings[4].SetControllerValue(1);
                    break;
                case "Key 6(PFD)":
                    this._bindings[5].SetControllerValue(1);
                    break;
                case "Key 7(PFD)":
                    this._bindings[6].SetControllerValue(1);
                    break;
                case "Key 8(PFD)":
                    this._bindings[7].SetControllerValue(1);
                    break;
                case "Key 9(PFD)":
                    this._bindings[8].SetControllerValue(1);
                    break;
                case "Key 10(PFD)":
                    this._bindings[9].SetControllerValue(1);
                    break;
                case "Key 11(PFD)":
                    this._bindings[10].SetControllerValue(1);
                    break;
                case "Key 12(PFD)":
                    this._bindings[11].SetControllerValue(1);
                    break;
                case "Direct To(PFD)":
                    this._bindings[12].SetControllerValue(1);
                    break;
                case "ENT(PFD)":
                    this._bindings[13].SetControllerValue(1);
                    break;
                case "CLR(PFD)":
                    this._bindings[15].SetControllerValue(1);
                    break;
                case "MENU(PFD)":
                    this._bindings[16].SetControllerValue(1);
                    break;
                case "FPL(PFD)":
                    this._bindings[17].SetControllerValue(1);
                    break;
                case "PROC(PFD)":
                    this._bindings[18].SetControllerValue(1);
                    break;
                case "Key 1(MFD)":
                    this._bindings[19].SetControllerValue(1);
                    break;
                case "Key 2(MFD)":
                    this._bindings[20].SetControllerValue(1);
                    break;
                case "Key 3(MFD)":
                    this._bindings[21].SetControllerValue(1);
                    break;
                case "Key 4(MFD)":
                    this._bindings[22].SetControllerValue(1);
                    break;
                case "Key 5(MFD)":
                    this._bindings[23].SetControllerValue(1);
                    break;
                case "Key 6(MFD)":
                    this._bindings[24].SetControllerValue(1);
                    break;
                case "Key 7(MFD)":
                    this._bindings[25].SetControllerValue(1);
                    break;
                case "Key 8(MFD)":
                    this._bindings[26].SetControllerValue(1);
                    break;
                case "Key 9(MFD)":
                    this._bindings[27].SetControllerValue(1);
                    break;
                case "Key 10(MFD)":
                    this._bindings[28].SetControllerValue(1);
                    break;
                case "Key 11(MFD)":
                    this._bindings[29].SetControllerValue(1);
                    break;
                case "Key 12(MFD)":
                    this._bindings[30].SetControllerValue(1);
                    break;
                case "Direct To(MFD)":
                    this._bindings[31].SetControllerValue(1);
                    break;
                case "ENT(MFD)":
                    this._bindings[32].SetControllerValue(1);
                    break;
                case "CLR(MFD)":
                    this._bindings[34].SetControllerValue(1);
                    break;
                case "MENU(MFD)":
                    this._bindings[36].SetControllerValue(1);
                    break;
                case "FPL(MFD)":
                    this._bindings[37].SetControllerValue(1);
                    break;
                case "PROC(MFD)":
                    this._bindings[38].SetControllerValue(1);
                    break;
            }
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            var bitmapBuilder = new BitmapBuilder(imageSize);
            switch (actionParameter)
            {
                case "Key 1(PFD)":
                case "Key 2(PFD)":
                case "Key 3(PFD)":
                case "Key 4(PFD)":
                case "Key 5(PFD)":
                case "Key 6(PFD)":
                case "Key 7(PFD)":
                case "Key 8(PFD)":
                case "Key 9(PFD)":
                case "Key 10(PFD)":
                case "Key 11(PFD)":
                case "Key 12(PFD)":
                case "Key 1(MFD)":
                case "Key 2(MFD)":
                case "Key 3(MFD)":
                case "Key 4(MFD)":
                case "Key 5(MFD)":
                case "Key 6(MFD)":
                case "Key 7(MFD)":
                case "Key 8(MFD)":
                case "Key 9(MFD)":
                case "Key 10(MFD)":
                case "Key 11(MFD)":
                case "Key 12(MFD)":
                    bitmapBuilder.SetBackgroundImage(ImageTool.GetButtonArrowImage());
                    break;
                case "ENT(PFD)":
                case "CLR(PFD)":
                case "MENU(PFD)":
                case "FPL(PFD)":
                case "PROC(PFD)":
                case "ENT(MFD)":
                case "CLR(MFD)":
                case "MENU(MFD)":
                case "FPL(MFD)":
                case "PROC(MFD)":
                    bitmapBuilder.SetBackgroundImage(ImageTool.GetButtonImage());
                    break;
                case "Direct To(PFD)":
                case "Direct To(MFD)":
                    bitmapBuilder.SetBackgroundImage(ImageTool.GetDirectToImage());
                    break;
            }

            var buttonText = actionParameter;
           
            if (buttonText.Contains("(PFD)") || buttonText.Contains("(MFD)"))
            {
                buttonText = buttonText.Substring(0, buttonText.Length - 5);
            }

            if (!buttonText.Equals("Direct To"))
            {
                bitmapBuilder.DrawText(buttonText);
            }

            return bitmapBuilder.ToImage();
        }

    protected override Boolean ProcessButtonEvent2(String actionParameter, DeviceButtonEvent2 buttonEvent)
    {
        if (buttonEvent.EventType == DeviceButtonEventType.LongPress)
        {
            switch (actionParameter)
            {
                case "Clr(PFD)":
                    this._bindings[14].SetControllerValue(1);
                    return true;
                case "Clr(MFD)":
                    this._bindings[33].SetControllerValue(1);
                    return true;
            }
        }
        return false;
    }

    public void Notify()
    {
        foreach (Binding binding in this._bindings)
        {
            if (binding.HasMSFSChanged())
            {
                binding.Reset();
            }
        }
    }
}

}
