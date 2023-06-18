namespace Loupedeck.MsfsPlugin.encoder
{
    using System;
    using System.Collections.Generic;

    public abstract class NavigationEncoder : PluginDynamicAdjustment, Notifiable
    {
        protected readonly List<Binding> _bindings = new List<Binding>();

        public NavigationEncoder(Boolean hasReset = false) : base(hasReset) => MsfsData.Instance.Register(this);

        protected override String GetAdjustmentValue(String actionParameter) => this.GetDisplayValue();
        protected virtual String GetDisplayValue() => null;
        protected virtual void Trigger(Binding binding) => binding.SetControllerValue(1);

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
