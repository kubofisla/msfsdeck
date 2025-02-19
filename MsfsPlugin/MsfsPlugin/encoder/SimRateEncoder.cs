﻿namespace Loupedeck.MsfsPlugin
{
    using System;

    using Loupedeck.MsfsPlugin.encoder;
    using Loupedeck.MsfsPlugin.tools;

    class SimRateEncoder : DefaultEncoder
    {
        public SimRateEncoder() : base("Sim Rate", "Simulation rate encoder", "Misc", true, 0, 12800, 100) => this._bindings.Add(MsfsData.Instance.Register(new Binding(BindingKeys.SIM_RATE)));
        protected override void RunCommand(String actionParameter) => this.SetValue(0);
        protected override Int64 GetValue() => this._bindings[0].ControllerValue;
        protected override String GetDisplayValue() => (this._bindings[0].ControllerValue / 100f).ToString();
        protected override void SetValue(Int64 newValue) => this._bindings[0].SetControllerValue(newValue);
        protected override void ApplyAdjustment(String actionParameter, Int32 ticks)
        {
            if (ticks > 0)
            {
                var newValue = this.GetValue() * 2;
                this.SetValue(newValue > 12800 ? 12800 : newValue);
            } else
            {
                var newValue = this.GetValue() / 2;
                this.SetValue(newValue < 25 ? 25 : newValue);
            }
            this.ActionImageChanged();
        }

    }
}
