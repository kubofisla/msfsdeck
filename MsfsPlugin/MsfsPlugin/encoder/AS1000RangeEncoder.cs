namespace Loupedeck.MsfsPlugin
{
    using System;

    using Loupedeck.MsfsPlugin.encoder;
    using Loupedeck.MsfsPlugin.tools;

    class AS1000RangeEncoder : NavigationEncoder
    {
        public AS1000RangeEncoder() : base()
        {
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_RANGE_DEC)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_RANGE_INC)));

            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_MFD_RANGE_DEC)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_MFD_RANGE_INC)));

            this.AddParameter("RANGE(PFD)", "PFD RANGE encoder", "G1000 PFD");
            this.AddParameter("RANGE(MFD)", "MFD RANGE encoder", "G1000 MFD");
        }

        protected override void ApplyAdjustment(String actionParameter, Int32 ticks)
        {
            switch (actionParameter)
            {
                case "RANGE(PFD)":
                    if (ticks > 0)
                    {
                        this.Trigger(this._bindings[0]);
                    }
                    else if (ticks < 0)
                    {
                        this.Trigger(this._bindings[1]);
                    }
                    break;
                case "RANGE(MFD)":
                    if (ticks > 0)
                    {
                        this.Trigger(this._bindings[2]);
                    }
                    else if (ticks < 0)
                    {
                        this.Trigger(this._bindings[3]);
                    }
                    break;
            }
        }

        protected override BitmapImage GetAdjustmentImage(String actionParameter, PluginImageSize imageSize)
        {
            var bitmapBuilder = new BitmapBuilder(imageSize);
            var displayText = "Range";
            bitmapBuilder.DrawText(displayText, null, 15, 13);
            return bitmapBuilder.ToImage();
        }
    }
}
