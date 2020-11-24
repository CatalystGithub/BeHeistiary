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
            Bestiary = new BestiarySettings();
        }

        public ToggleNode Enable { get; set; }
        [Menu("Bestiary Settings")]
        public BestiarySettings Bestiary { get; set; }

    }

    public class BestiarySettings : ISettings
    {
        public BestiarySettings()
        {
            Enable = new ToggleNode(true);
            Toggle1 = new ToggleNode(true);
        }

        [Menu("Enable Bestiary")]
        public ToggleNode Enable { get; set; }
        
        public ToggleNode Toggle1 { get; set; }
    }
}
