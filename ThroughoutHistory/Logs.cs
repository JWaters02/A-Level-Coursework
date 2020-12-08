using System;

namespace ThroughoutHistory {
	/// <summary>
	/// Does all logs based processing
	/// </summary>
	public partial class MainForm {
        void clearText() {
            // Get index of selected tab
            int selectedTab = tabControl2.SelectedIndex;
            switch (selectedTab) {
                // Story
                case 0:
                    rtxtStoryLogs.Text = "";
                    break;
                // Upgrades
                case 1:
                    rtxtUpgrades.Text = "";
                    break;
                // Combat
                case 2:
                    rtxtCombat.Text = "";
                    break;
                // Loot
                case 3:
                    rtxtLoot.Text = "";
                    break;
                // Saves
                case 4:
                    rtxtSaves.Text = "";
                    break;
            }
        }

        private void btnClearLogs_Click(object sender, EventArgs e) {
            clearText();
        }
    }
}
