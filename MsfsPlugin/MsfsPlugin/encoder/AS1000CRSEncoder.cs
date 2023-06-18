namespace Loupedeck.MsfsPlugin
{
    using System;

    using Loupedeck.MsfsPlugin.encoder;
    using Loupedeck.MsfsPlugin.msfs;

    class AS1000CRSEncoder : NavigationEncoder
    {
        public AS1000CRSEncoder() : base(true)
        {
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_CRS_INC)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_CRS_DEC)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_CRS_PUSH)));

            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_CRS_INC)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_CRS_DEC)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.AS1000_PFD_CRS_PUSH)));

            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.NAV1_AVAILABLE)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.NAV2_AVAILABLE)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.NAV1_OBS)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.NAV2_OBS)));
            this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.GPS_OBS)));

            this.AddParameter("CRS PFD", "CRS", "G1000 PFD");
            this.AddParameter("CRS MFD", "CRS", "G1000 MFD");
        }
        protected override void ApplyAdjustment(String actionParameter, Int32 ticks)
        {
            SimConnectDAO.Instance.Connect();

            switch (actionParameter)
            {
                case "CRS PFD":
                    if (ticks > 0)
                    {
                        SimConnectDAO.Instance.IncrPfdCourseBUG();
                    }
                    else if (ticks < 0)
                    {
                        SimConnectDAO.Instance.DecrPfdCourseBUG();
                    }
                    break;
                case "CRS MFD":
                    if (ticks > 0)
                    {
                        SimConnectDAO.Instance.IncrMfdCourseBUG();
                    }
                    else if (ticks < 0)
                    {
                        SimConnectDAO.Instance.DecrMfdCourseBUG();
                    }
                    break;
            }
            this.ActionImageChanged();
        }
        protected override String GetDisplayValue()
        {
            return "[" + this._bindings[10].MsfsValue + "]\n" +
                "[" + this._bindings[8].MsfsValue + "]\n" +
                "[" + this._bindings[9].MsfsValue + "]\n";
        }

        protected override void RunCommand(String actionParameter)
        {
            switch (actionParameter)
            {
                case "CRS PFD":
                    this._bindings[2].SetControllerValue(1);
                    break;
                case "CRS MFD":
                    this._bindings[5].SetControllerValue(1);
                    break;
            }
        }
    }
}
