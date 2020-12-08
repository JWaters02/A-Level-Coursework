using System;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;

namespace ThroughoutHistory {
	public partial class MainForm {
		bool[] btnToggled = new bool[4] {false, false, false, false};
        bool isPauseToggled = false;

		#region Buttons & Timers
		void BtnGatherClick(object sender, EventArgs e) {
			toggleButton(0);
			checkOtherButtons(0);
		}
		
		void BtnQuarrierClick(object sender, EventArgs e) {
			toggleButton(1);
            checkOtherButtons(1);
        }
		
		void BtnFarmClick(object sender, EventArgs e) {
			toggleButton(2);
            checkOtherButtons(2);
        }
		
		void BtnMineClick(object sender, EventArgs e) {
			toggleButton(3);
            checkOtherButtons(3);
        }
		
		void GlobalTimerTick(object sender, EventArgs e) {
			GlobalData.tickCounter += 1;
			resourceCollection(0, btnGather, lblWoodAmount, lblWoodRate, pbWood);
			resourceCollection(1, btnQuarrier, lblStoneAmount, lblStoneRate, pbStone);
			resourceCollection(2, btnFarm, lblFoodAmount, lblFoodRate, pbFood);
			resourceCollection(3, btnMine, lblMetalAmount, lblMetalRate, pbMetal);

            currentTime();
            yearCounter();
            startWar();

            // Call the housing and science functions to update values if needed
			housing();
            science();
		}

        // Fun temp stuff (might actually add into finished game)
        private void btnPauseGame_Click(object sender, EventArgs e) {
            if (isPauseToggled) {
                globalTimer.Start();
                combatTimer.Start();
                isPauseToggled = false;
            } else {
                globalTimer.Stop();
                combatTimer.Stop();
                isPauseToggled = true;
            }
        }
        #endregion

        #region Procedures
        void yearCounter() {
            // If tick counter has reached a multiple of 60
            if ((GlobalData.tickCounter % 60) == 0) {
                // Increment year by 1
                GlobalData.year++;
                // If the year is negative
                if (GlobalData.year < 0) {
                    // Get the positive year version
                    GlobalData.actualYear = (GlobalData.year * -2) + GlobalData.year;
                    // Set the era to BC
                    GlobalData.era = "BC";
                } else {
                    GlobalData.actualYear = GlobalData.year;
                    // Set the era to AD
                    GlobalData.era = "AD";
                }
                rtxtStoryLogs.Text += ("\nA new year has begun: " + GlobalData.actualYear + GlobalData.era);
            }
        }

        /// <summary>
		/// Calculates how much each resource will be increased by each tick
		/// </summary>
		/// <param name="arraySlot">The resource type</param>
		/// <param name="buttonType">The button type</param>
		/// <param name="labelAmounts">The resource type's labelAmount</param>
		/// <param name="labelRates">The resource type's labelRate</param>
		/// <param name="pBarType">The progress bar type</param>
		void resourceCollection(int arraySlot, Button buttonType, Label labelAmounts, Label labelRates, ProgressBar pBarType) {
			int currentRate = GlobalData.resourcesData[1][arraySlot];
			int currentAmount = GlobalData.resourcesData[0][arraySlot];
            int currentCapacity = GlobalData.resourcesData[2][arraySlot];

            // If button is toggled off
            if (!btnToggled[arraySlot]) {
                // Set its colour to grey
                buttonType.BackColor = SystemColors.ControlLight;
            } else {
                // Set its colour to brown, and increase the currentRate by gatherMultiplier
                currentRate += GlobalData.resourcesData[3][arraySlot];
                buttonType.BackColor = Color.Chocolate;
            }

            // If the currentAmount = 0, set it to 1 just in case it is divided by 0 (which would crash program)
            amountCheck();
			
			// Set the text of label rates
			labelRates.Text = ("+" + currentRate + "/sec");
            // Set the progress bar maximum to the capacity of the resource
            pBarType.Maximum = currentCapacity;

            // If there is space to increase the value of the bar
            if (currentAmount <= (currentCapacity - currentRate)) {
                currentAmount += currentRate;
            } else {
                currentAmount = currentCapacity;
            }

            // Update the progress bar
            pBarType.Value = currentAmount;
            // Set the new current amount to show in the output label
            GlobalData.resourcesData[0][arraySlot] = currentAmount;
            labelAmounts.Text = currentAmount.ToString();
        }

        void housing() {
			// Make locally scoped variables for easier access
			int currentHousingCapacity = GlobalData.totalHousing;
			int currentHousingRemaining = GlobalData.housingRemaining;
			
			// Set the current housing amount to the amount in global data
			lblHousingCapacity.Text = currentHousingCapacity.ToString() + " housing capacity";
            lblHousingSpace.Text = currentHousingRemaining.ToString() + " housing remaining";
            // Set the value and maximum of the housing progress bar
            pbHousing.Maximum = currentHousingCapacity;
            pbHousing.Value = currentHousingRemaining;	
		}

        void science() {
            // Make locally scoped variables for easier access
            int currentScience = GlobalData.scienceData;

            // Set the current science amount in the global data
            lblScienceAmount.Text = currentScience.ToString();
        }

		/// <summary>
		/// Makes sure the amount of a resource NEVER goes below 1
		/// </summary>
		void amountCheck() {
			for (int i = 0; i < 4; i++) {
				if (GlobalData.resourcesData[i][0] < 1) {
					GlobalData.resourcesData[i][0] = 1;
				}
			}
		}

        /// <summary>
        /// When a button is clicked, the button is toggled on, or if it is already on, toggle it off
        /// </summary>
        /// <param name="arraySlot">The array slot of the btnToggled array</param>
		void toggleButton(int arraySlot) {
            // If button is toggled on, set it to false
			if (btnToggled[arraySlot]) {
				btnToggled[arraySlot] = false;
            // If button is toggled off, set is to true, then make sure all other buttons are off (calling checkOtherButtons)
			} else {
				btnToggled[arraySlot] = true;
				checkOtherButtons(arraySlot);
			}
		}
		
        /// <summary>
        /// When a button is toggled on, make sure all other buttons are toggled off
        /// </summary>
        /// <param name="arraySlot">The array slot of the btnToggled array</param>
		void checkOtherButtons(int arraySlot) {
        	//Check if the button being clicked is being toggled on
        	if (btnToggled[arraySlot]) {
        		//Loop through all the buttons
        		for (int i = 0; i < btnToggled.Length; i++) {
        			// Set all the buttons to false
        			btnToggled[i] = false;
        		}
                // Then set currently clicked button to true
                btnToggled[arraySlot] = true;
        	}
		}
		#endregion
	}
}
