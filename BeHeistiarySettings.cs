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
            unitsettings = new UnitSettings(0xffffffff, 0xffffffff);
        }

        public ToggleNode Enable { get; set; }
        [Menu("Bestiary Settings")]
        public BestiarySettings Bestiary { get; set; }
        [Menu("Burada baslik var")]
        public UnitSettings unitsettings { get; set; }

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
        
        [Menu("Toggle 1")]
        public ToggleNode Toggle1 { get; set; }
    }

    public class UnitSettings : ISettings
    {
        public UnitSettings(uint color, uint outline)
        {
            Enable = new ToggleNode(true);
            Width = new RangeNode<float>(100, 20, 250);
            Height = new RangeNode<float>(20, 5, 150);
            Color = color;
            Outline = outline;
            Under10Percent = 0xffffffff;
            PercentTextColor = 0xffffffff;
            HealthTextColor = 0xffffffff;
            HealthTextColorUnder10Percent = 0xffff00ff;
            ShowHealthPercents = new ToggleNode(false);
            ShowEnergyShieldPercents = new ToggleNode(false);
            ShowHealthText = new ToggleNode(false);
            ShowEnergyShieldText = new ToggleNode(false);
            ShowFloatingCombatDamage = new ToggleNode(false);
            FloatingCombatTextSize = new RangeNode<int>(15, 10, 30);
            FloatingCombatDamageColor = SharpDX.Color.Yellow;
            FloatingCombatHealColor = SharpDX.Color.Lime;
            BackGround = SharpDX.Color.Black;
            TextSize = new RangeNode<int>(15, 10, 50);
            FloatingCombatStackSize = new RangeNode<int>(1, 1, 10);
        }

        public UnitSettings(uint color, uint outline, uint percentTextColor, bool showText) : this(color, outline)
        {
            PercentTextColor = percentTextColor;
            ShowHealthPercents.Value = showText;
            ShowEnergyShieldPercents.Value = showText;
            ShowHealthText.Value = showText;
            ShowEnergyShieldText.Value = showText;
        }

        public RangeNode<float> Width { get; set; }
        public RangeNode<float> Height { get; set; }
        public ColorNode Color { get; set; }
        public ColorNode Outline { get; set; }
        public ColorNode BackGround { get; set; }
        public ColorNode Under10Percent { get; set; }
        public ColorNode PercentTextColor { get; set; }
        public ColorNode HealthTextColor { get; set; }
        public ColorNode HealthTextColorUnder10Percent { get; set; }
        public ToggleNode ShowHealthPercents { get; set; }
        public ToggleNode ShowEnergyShieldPercents { get; set; }
        public ToggleNode ShowHealthText { get; set; }
        public ToggleNode ShowEnergyShieldText { get; set; }
        public RangeNode<int> TextSize { get; set; }
        [Menu("Floating Combat Text")]
        public ToggleNode ShowFloatingCombatDamage { get; set; }
        [Menu("Damage Color")]
        public ColorNode FloatingCombatDamageColor { get; set; }
        [Menu("Heal Color")]
        public ColorNode FloatingCombatHealColor { get; set; }
        [Menu("Text Size")]
        public RangeNode<int> FloatingCombatTextSize { get; set; }
        [Menu("Number of Lines")]
        public RangeNode<int> FloatingCombatStackSize { get; set; }
        [Menu("Enable")]
        public ToggleNode Enable { get; set; }
    }
}
