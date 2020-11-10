using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ThroughoutHistory {
	public partial class MainForm {
        bool isAutosaveToggled = false;
        int autosaveTick = 0;

        private void autosaveTimer_Tick(object sender, EventArgs e) {
            autosaveTick++;
            // If a multiple of 300 seconds (or 5 mins) has been reached
            if ((autosaveTick % 300) == 0) {
                // Call saving function with autosave setting
                saveToFile(true);
                rtxtSaves.Text += ("\n" + GlobalData.currentTime.ToString() + ": The game has been autosaved!");
            }
        }

        #region Buttons
        private void btnSave_Click(object sender, EventArgs e) {
            saveToFile(false);
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            loadFromFile();
        }

        private void btnAutosaveOption_Click(object sender, EventArgs e) {
            if (isAutosaveToggled) {
                autosaveTimer.Stop();
                isAutosaveToggled = false;
                lblAutosaveStatus.Text = ("Autosaving off.");
            } else {
                autosaveTimer.Start();
                isAutosaveToggled = true;
                lblAutosaveStatus.Text = ("Autosave interval: 5 minutes");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            deleteSave();
        }

        #endregion

        /// <summary>
        /// Uses the selected file to load info into the game
        /// </summary>
        void loadFromFile() {
            // Set filter to only text files
            openDialogue.Filter = "Text|*.txt";
            // Show dialog
            DialogResult result = openDialogue.ShowDialog();
            // If user presses OK button
            if (result == DialogResult.OK) {
                // Get file to load
                string selectedFile = openDialogue.FileName;
                // Load data from file
                try {
                    using (StreamReader sr = File.OpenText(selectedFile)) {
                        string s = "";
                        int lineNum = 1;
                        // While not end of file
                        while ((s = sr.ReadLine()) != null) {
                            // Split each part into this currentSplits array
                            string[] currentSplits = s.Split('#');
                            // Write to global data variables based on which line is on
                            switch (lineNum) {
                                // Amount
                                case 1:
                                    for (int i = 0; i < currentSplits.Length; i++) { GlobalData.resourcesData[0][i] = Convert.ToInt32(currentSplits[i]); }
                                    break;
                                // Rate
                                case 2:
                                    for (int i = 0; i < currentSplits.Length; i++) { GlobalData.resourcesData[1][i] = Convert.ToInt32(currentSplits[i]); }
                                    break;
                                // Capacity
                                case 3:
                                    for (int i = 0; i < currentSplits.Length; i++) { GlobalData.resourcesData[2][i] = Convert.ToInt32(currentSplits[i]); }
                                    break;
                                // Gather multiplier
                                case 4:
                                    for (int i = 0; i < currentSplits.Length; i++) { GlobalData.resourcesData[3][i] = Convert.ToInt32(currentSplits[i]); }
                                    break;
                                // Science data
                                case 5:
                                    GlobalData.scienceData = Convert.ToInt32(currentSplits[0]);
                                    break;
                                // Total housing
                                case 6:
                                    GlobalData.totalHousing = Convert.ToInt32(currentSplits[0]);
                                    break;
                                // Housing remaining
                                case 7:
                                    GlobalData.housingRemaining = Convert.ToInt32(currentSplits[0]);
                                    break;
                                // Storage costs
                                case 8:
                                    for (int i = 0; i < currentSplits.Length; i++) { GlobalData.upgradesCosts[0][i] = Convert.ToInt32(currentSplits[i]); }
                                    break;
                                // Workers costs
                                case 9:
                                    for (int i = 0; i < currentSplits.Length; i++) { GlobalData.upgradesCosts[1][i] = Convert.ToInt32(currentSplits[i]); }
                                    break;
                                // Science costs
                                case 10:
                                    for (int i = 0; i < currentSplits.Length; i++) { GlobalData.upgradesCosts[2][i] = Convert.ToInt32(currentSplits[i]); }
                                    break;
                                // Housing costs
                                case 11:
                                    for (int i = 0; i < currentSplits.Length; i++) { GlobalData.upgradesCosts[3][i] = Convert.ToInt32(currentSplits[i]); }
                                    break;
                                // Combat costs
                                case 12:
                                    for (int i = 0; i < currentSplits.Length; i++) { GlobalData.upgradesCosts[4][i] = Convert.ToInt32(currentSplits[i]); }
                                    break;
                                // Cost multipliers
                                case 13:
                                    for (int i = 0; i < currentSplits.Length; i++) { GlobalData.costMultipliers[i] = Convert.ToInt32(currentSplits[i]); }
                                    break;
                                // Health
                                case 14:
                                    for (int i = 0; i < currentSplits.Length; i++) { GlobalData.combatData[0][i] = Convert.ToInt32(currentSplits[i]); }
                                    break;
                                // Block
                                case 15:
                                    for (int i = 0; i < currentSplits.Length; i++) { GlobalData.combatData[1][i] = Convert.ToInt32(currentSplits[i]); }
                                    break;
                                // Damage
                                case 16:
                                    for (int i = 0; i < currentSplits.Length; i++) { GlobalData.combatData[2][i] = Convert.ToInt32(currentSplits[i]); }
                                    break;
                                // No of troops
                                case 17:
                                    for (int i = 0; i < currentSplits.Length; i++) { GlobalData.combatData[3][i] = Convert.ToInt32(currentSplits[i]); }
                                    break;
                                // Tick counter
                                case 18:
                                    GlobalData.tickCounter = Convert.ToInt32(currentSplits[0]);
                                    break;
                                // Current war
                                case 19:
                                    GlobalData.curretWar = Convert.ToInt32(currentSplits[0]);
                                    break;
                                // War number
                                case 20:
                                    GlobalData.warNumber = Convert.ToInt32(currentSplits[0]);
                                    break;
                                // Year
                                case 21:
                                    GlobalData.year = Convert.ToInt32(currentSplits[0]);
                                    break;
                                // Actual year
                                case 22:
                                    GlobalData.actualYear = Convert.ToInt32(currentSplits[0]);
                                    break;
                                // Era
                                case 23:
                                    GlobalData.era = currentSplits[0];
                                    break;
                            }
                            lineNum++;
                        }
                    }
                    // Output to logs
                    rtxtSaves.Text += ("\n" + GlobalData.currentTime.ToString() + ": " + selectedFile + ".txt has been loaded.");
                } catch (Exception ex) {
                    rtxtSaves.Text += ("\n" + ex.Message);
                }
            }   
        }

        /// <summary>
        /// Save all global data to a new file with user's name
        /// </summary>
        void saveToFile(bool isAutosave) {
            string selectedFile = "";
            bool goAhead = false;
            // If being called by autosave timer
            if (isAutosave) {
                selectedFile = "./autosave.txt";
                goAhead = true;
            // Being called by button press
            } else {
                // Set dialog filter to text files only
                saveDialog.Filter = "Text|*.txt";
                // Open saving dialog
                DialogResult result = saveDialog.ShowDialog();
                // If user clicks OK button
                if (result == DialogResult.OK) {
                    selectedFile = saveDialog.FileName;
                    goAhead = true;
                }
            }
            if (goAhead) {
                // Stop global timer so that all values are paused at the correct place
                globalTimer.Stop();
                // Now that validation is done, make new file in directory, open it and write to it
                Stream cs = File.Create(selectedFile);
                using (StreamWriter sw = new StreamWriter(cs)) {
                    // Write resourcesData to the file
                    for (int i = 0; i < 4; i++) {
                        sw.WriteLine(GlobalData.resourcesData[i][0] + "#" + GlobalData.resourcesData[i][1] + "#" + GlobalData.resourcesData[i][2] + "#" + GlobalData.resourcesData[i][3]);
                    }

                    sw.WriteLine(GlobalData.scienceData);
                    sw.WriteLine(GlobalData.totalHousing);
                    sw.WriteLine(GlobalData.housingRemaining);

                    // Write upgradesData to file
                    for (int i = 0; i < 2; i++) {
                        sw.WriteLine(GlobalData.upgradesCosts[i][0] + "#" + GlobalData.upgradesCosts[i][1] + "#" + GlobalData.upgradesCosts[i][2] + "#" + GlobalData.upgradesCosts[i][3]);
                    }
                    sw.WriteLine(GlobalData.upgradesCosts[2][0] + "#" + GlobalData.upgradesCosts[2][1] + "#" + GlobalData.upgradesCosts[2][2] + "#" + GlobalData.upgradesCosts[2][3] + "#" + GlobalData.upgradesCosts[2][4]);
                    sw.WriteLine(GlobalData.upgradesCosts[3][0] + "#" + GlobalData.upgradesCosts[3][1] + "#" + GlobalData.upgradesCosts[3][2]);
                    sw.WriteLine(GlobalData.upgradesCosts[4][0] + "#" + GlobalData.upgradesCosts[4][1] + "#" + GlobalData.upgradesCosts[4][2] + "#" + GlobalData.upgradesCosts[4][3]);

                    // Write costMultipliers to file
                    sw.WriteLine(GlobalData.costMultipliers[0] + "#" + GlobalData.costMultipliers[1] + "#" + GlobalData.costMultipliers[2] + "#" + GlobalData.costMultipliers[3] + "#" + GlobalData.costMultipliers[4]);

                    // Write combatData to file
                    for (int i = 0; i < 4; i++) {
                        sw.WriteLine(GlobalData.combatData[i][0] + "#" + GlobalData.combatData[i][1]);
                    }

                    sw.WriteLine(GlobalData.tickCounter);
                    sw.WriteLine(GlobalData.curretWar);
                    sw.WriteLine(GlobalData.warNumber);
                    sw.WriteLine(GlobalData.year);
                    sw.WriteLine(GlobalData.actualYear);
                    sw.WriteLine(GlobalData.era);
                }
                // Restart the global timer now that the saving is finished
                globalTimer.Start();
                rtxtSaves.Text += ("\n" + GlobalData.currentTime.ToString() + ": File has been saved to " + selectedFile);

            }
        }

        /// <summary>
        /// Deletes user selected file
        /// </summary>
        void deleteSave() {
            // Set dialog filter to text files only
            openDialogue.Filter = "Text|*.txt";
            // Show dialogue
            DialogResult result = openDialogue.ShowDialog();
            // If user pressed OK button
            if (result == DialogResult.OK) {
                string selectedFile = openDialogue.FileName;
                // Delete file
                File.Delete(selectedFile);
                rtxtSaves.Text += ("\n" + GlobalData.currentTime.ToString() + ": " + selectedFile + " has been deleted permanently.");
            }
        }
    }
}