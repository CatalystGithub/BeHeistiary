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

            base.DrawSettings();
        }
    }
}
