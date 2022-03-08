using Dalamud.Configuration;
using Dalamud.Plugin;
using System;

namespace RandomScreenshot
{
    [Serializable]
    public class Configuration : IPluginConfiguration
    {
        public int Version { get; set; } = 0;

        public bool HideUI { get; set; } = true;
        public int ScreenshotIntervalInMS { get; set; } = 60000;
        // the below exist just to make saving less cumbersome

        [NonSerialized]
        private DalamudPluginInterface? pluginInterface;

        public void Initialize(DalamudPluginInterface pluginInterface)
        {
            this.pluginInterface = pluginInterface;
        }

        public void Save()
        {
            this.pluginInterface!.SavePluginConfig(this);
        }
    }
}
