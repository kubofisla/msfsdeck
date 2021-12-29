﻿namespace Loupedeck.MsfsPlugin.folder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LightsDynamicFolder : PluginDynamicFolder, Notifiable
    {
        public LightsDynamicFolder()
        {
            this.DisplayName = "Lights";
            this.GroupName = "System";
            this.Navigation = PluginDynamicFolderNavigation.EncoderArea;
            MsfsData.Instance.register(this);

        }
        public override IEnumerable<String> GetButtonPressActionNames()
        {
            return new[]
            {
                PluginDynamicFolder.NavigateUpActionName,
                this.CreateCommandName("Navigation"),
                this.CreateCommandName("Beacon"),
                this.CreateCommandName("Landing"),
                this.CreateCommandName("Taxi"),
                this.CreateCommandName("Strobes"),
                this.CreateCommandName("Instruments"),
                this.CreateCommandName("Recognition"),
                this.CreateCommandName("Wing"),
                this.CreateCommandName("Logo"),
                this.CreateCommandName("Cabin")
            };
        }

       public override String GetCommandDisplayName(String actionParameter, PluginImageSize imageSize)
        {
            var ret = actionParameter + " ";
            switch (actionParameter)
            {
                case "Navigation":
                    ret += MsfsData.Instance.NavigationLight ? "Off" : "On";
                    break;
                case "Beacon":
                    ret += MsfsData.Instance.BeaconLight ? "Off" : "On";
                    break;
                case "Landing":
                    ret += MsfsData.Instance.LandingLight ? "Off" : "On";
                    break;
                case "Taxi":
                    ret += MsfsData.Instance.TaxiLight ? "Off" : "On";
                    break;
                case "Strobes":
                    ret += MsfsData.Instance.StrobesLight ? "Off" : "On";
                    break;
                case "Instruments":
                    ret += MsfsData.Instance.InstrumentsLight ? "Off" : "On";
                    break;
                case "Recognition":
                    ret += MsfsData.Instance.RecognitionLight ? "Off" : "On";
                    break;
                case "Wing":
                    ret += MsfsData.Instance.WingLight ? "Off" : "On";
                    break;
                case "Logo":
                    ret += MsfsData.Instance.LogoLight ? "Off" : "On";
                    break;
                case "Cabin":
                    ret += MsfsData.Instance.CabinLight ? "Off" : "On";
                    break;
            }
            return ret;
        }
        public override void RunCommand(String actionParameter)
        {
            switch (actionParameter)
            {
                case "Navigation":
                    MsfsData.Instance.NavigationLight = !MsfsData.Instance.NavigationLight;
                    break;
                case "Beacon":
                    MsfsData.Instance.BeaconLight = !MsfsData.Instance.BeaconLight;
                    break;
                case "Landing":
                    MsfsData.Instance.LandingLight = !MsfsData.Instance.LandingLight;
                    break;
                case "Taxi":
                    MsfsData.Instance.TaxiLight = !MsfsData.Instance.TaxiLight;
                    break;
                case "Strobes":
                    MsfsData.Instance.StrobesLight = !MsfsData.Instance.StrobesLight;
                    break;
                case "Instruments":
                    MsfsData.Instance.InstrumentsLight = !MsfsData.Instance.InstrumentsLight;
                    break;
                case "Recognition":
                    MsfsData.Instance.RecognitionLight = !MsfsData.Instance.RecognitionLight;
                    break;
                case "Wing":
                    MsfsData.Instance.WingLight = !MsfsData.Instance.WingLight;
                    break;
                case "Logo":
                    MsfsData.Instance.LogoLight = !MsfsData.Instance.LogoLight;
                    break;
                case "Cabin":
                    MsfsData.Instance.CabinLight = !MsfsData.Instance.CabinLight;
                    break;
            }
        }

        public void Notify()
        {
            this.ButtonActionNamesChanged();
            this.EncoderActionNamesChanged();
        } 
    }

}