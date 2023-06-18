namespace Loupedeck.MsfsPlugin
{
    using System;

    using Loupedeck;
    using Loupedeck.MsfsPlugin.encoder;
    using Loupedeck.MsfsPlugin.msfs;
    using Loupedeck.MsfsPlugin.tools;

    class AS1000FMSEncoder : NavigationEncoder
    {
        public AS1000FMSEncoder() : base(true)
        {
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_FMS_Lower_INC)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_FMS_Lower_DEC)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_FMS_Upper_INC)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_FMS_Upper_DEC)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_FMS_Upper_PUSH)));

            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_MFD_FMS_Lower_INC)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_MFD_FMS_Lower_DEC)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_MFD_FMS_Upper_INC)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_MFD_FMS_Upper_DEC)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_MFD_FMS_Upper_PUSH)));

            this.AddParameter("FMS UPPER(PFD)", "G1000 PFD FMS UPPER encoder", "G1000 PFD");
            this.AddParameter("FMS LOWER(PFD)", "G1000 PFD FMS LOWER encoder", "G1000 PFD");

            this.AddParameter("FMS UPPER(MFD)", "G1000 MFD FMS UPPER encoder", "G1000 MFD");
            this.AddParameter("FMS LOWER(MFD)", "G1000 MFD FMS LOWER encoder", "G1000 MFD");
        }

        protected override void ApplyAdjustment(String actionParameter, Int32 ticks)
        {
            SimConnectDAO.Instance.Connect();

            switch (actionParameter)
            {
                case "FMS LOWER(PFD)":
                    if (ticks > 0)
                    {
                        SimConnectDAO.Instance.IncrPfdFmsLowerBUG();
                    }
                    else if (ticks < 0)
                    {
                        SimConnectDAO.Instance.DecrPfdFmsLowerBUG();
                    }
                    break;
                case "FMS LOWER(MFD)":
                    if (ticks > 0)
                    {
                        SimConnectDAO.Instance.IncrMfdFmsLowerBUG();
                    }
                    else if (ticks < 0)
                    {
                        SimConnectDAO.Instance.DecrMfdFmsLowerBUG();
                    }
                    break;
                case "FMS UPPER(PFD)":
                    if (ticks > 0)
                    {
                        SimConnectDAO.Instance.IncrPfdFmsUpperBUG();
                    }
                    else if (ticks < 0)
                    {
                        SimConnectDAO.Instance.DecrPfdFmsUpperBUG();
                    }
                    break;
                case "FMS UPPER(MFD)":
                    if (ticks > 0)
                    {
                        SimConnectDAO.Instance.IncrMfdFmsUpperBUG();
                    }
                    else if (ticks < 0)
                    {
                        SimConnectDAO.Instance.DecrMfdFmsUpperBUG();
                    }
                    break;
            }
        }

        protected override void RunCommand(String actionParameter)
        {
            switch (actionParameter)
            {
                case "FMS LOWER(PFD)":
                case "FMS UPPER(PFD)":
                    this.Trigger(this._bindings[4]);
                    break;
                case "FMS LOWER(MFD)":
                case "FMS UPPER(MFD)":
                    this.Trigger(this._bindings[9]);
                    break;
            }
        }

        protected override BitmapImage GetAdjustmentImage(String actionParameter, PluginImageSize imageSize)
        {
            var bitmapBuilder = new BitmapBuilder(imageSize);
            var displayText = "FMS";
            
            switch (actionParameter)
            {
            
                case "FMS LOWER(PFD)":
                case "FMS LOWER(MFD)":
                    bitmapBuilder.SetBackgroundImage(ImageTool.GetLowerEncoder());
                    break;
                case "FMS UPPER(PFD)":
                case "FMS UPPER(MFD)":
                    bitmapBuilder.SetBackgroundImage(ImageTool.GetUpperEncoder());
                    break;
            }

            bitmapBuilder.DrawText(displayText, null, 15, 50);
            return bitmapBuilder.ToImage();
        }
    } 
}
