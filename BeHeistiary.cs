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

            bool Checkbox(string labelString, bool boolValue)
            {
                ImGui.Checkbox(labelString, ref boolValue);
                return boolValue;
            }

            base.DrawSettings();
        }
    }
}
