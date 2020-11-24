using ExileCore;
using ImGuiNET;

namespace BeHeistiary
{
    public class BeHeistiary : BaseSettingsPlugin<BeHeistiarySettings>
    {
        public override void DrawSettings()
        {
            if (ImGui.Button("Test"))
            {

            }

            if (ImGui.TreeNodeEx("Bestiary Options", ImGuiTreeNodeFlags.CollapsingHeader))
            {
                //Settings.Bestiary.Toggle1.Value = Checkbox("Tree Node for Bestiary", Settings.Bestiary.Toggle1.Value);
            }

            bool Checkbox(string labelString, bool boolValue)
            {
                ImGui.Checkbox(labelString, ref boolValue);
                return boolValue;
            }

            base.DrawSettings();
        }
    }
}
