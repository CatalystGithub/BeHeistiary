using ExileCore;
using ImGuiNET;
using System.IO;

namespace BeHeistiary
{
    public class BeHeistiary : BaseSettingsPlugin<BeHeistiarySettings>
    {
        public override void DrawSettings()
        {
            if (ImGui.Button("Test"))
            {
                File.WriteAllText(DirectoryFullName + "/HeistChestRewardType.txt", GameController.Files.HeistChestRewardType.ToString());
                File.WriteAllText(DirectoryFullName + "/HeistJobs.txt", GameController.Files.HeistJobs.ToString());
                File.WriteAllText(DirectoryFullName + "/HeistNpcs.txt", GameController.Files.HeistNpcs.ToString());
                File.WriteAllText(DirectoryFullName + "/BestiaryCapturableMonsters.txt", GameController.Files.BestiaryCapturableMonsters.ToString());
            }

            if (ImGui.TreeNodeEx(DirectoryFullName, ImGuiTreeNodeFlags.CollapsingHeader))
            {
                Settings.Bestiary.Toggle1.Value = Checkbox("Tree Node for Bestiary", Settings.Bestiary.Toggle1.Value);
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
