using ExileCore.Shared.Attributes;
using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;
using SharpDX;
using ImGuiNET;

namespace BeHeistiary
{
    public class BeHeistiarySettings : ISettings
    {
        public BeHeistiarySettings()
        {
            Enable = new ToggleNode(true);
        }

        public ToggleNode Enable { get; set; }

    }

    public class BestiarySettings : ISettings
    {
        public BestiarySettings()
        {
            Enable = new ToggleNode(true);
            EnableBestiary = new ToggleNode(true);
        }

        public ToggleNode Enable { get; set; }
        [Menu("Enable Bestiary")]
        public ToggleNode EnableBestiary { get; set; }
    }
}
