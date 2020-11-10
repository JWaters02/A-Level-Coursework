using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ThroughoutHistory {
	public partial class MainForm {
        #region Buttons
        /// <summary>
        /// All storage buttons
        /// </summary>
        private void btnWoodStorage_Click(object sender, EventArgs e) {
            buyingStorage(GlobalData.upgradesCosts[0][0], 0, 0, 1000, lblWoodStorageCost);
        }

        private void btnStoneStorage_Click(object sender, EventArgs e) {
            buyingStorage(GlobalData.upgradesCosts[0][1], 0, 1, 1000, lblStoneStorageCost);
        }

        private void btnFoodStorage_Click(object sender, EventArgs e) {
            buyingStorage(GlobalData.upgradesCosts[0][2], 0, 2, 1000, lblFoodStorageCost);
        }

        private void btnMetalStorage_Click(object sender, EventArgs e) {
            buyingStorage(GlobalData.upgradesCosts[0][3], 0, 3, 1000, lblMetalStorageCost);
        }

        /// <summary>
        /// All workers buttons
        /// </summary>
        private void btnGatherer_Click(object sender, EventArgs e) {
            buyingWorkers(GlobalData.upgradesCosts[1][0], 2, 0, 5, lblGathererCost);
        }

        private void btnQuarring_Click(object sender, EventArgs e) {
            buyingWorkers(GlobalData.upgradesCosts[1][1], 2, 1, 2, lblQuarrierCost);
        }

        private void btnButcher_Click(object sender, EventArgs e) {
            buyingWorkers(GlobalData.upgradesCosts[1][2], 2, 2, 5, lblButcherCost);
        }

        private void btnMiner_Click(object sender, EventArgs e) {
            buyingWorkers(GlobalData.upgradesCosts[1][3], 2, 3, 1, lblMinerCost);
        }

        private void btnTroop_Click(object sender, EventArgs e) {
            buyingTroops(GlobalData.upgradesCosts[4][3], 3, lblTroopCost);
        }

        /// <summary>
        /// All housing buttons
        /// </summary>
        private void btnShack_Click(object sender, EventArgs e) {
            buyingHousing(GlobalData.upgradesCosts[3][0], 1, 0, lblShackCost);
        }

        private void btnBootcamp_Click(object sender, EventArgs e) {
            buyingHousing(GlobalData.upgradesCosts[3][1], 1, 1, lblBootcampCost);
        }

        private void btnBarracks_Click(object sender, EventArgs e) {
            buyingHousing(GlobalData.upgradesCosts[3][2], 1, 2, lblBarracksCost);
        }

        /// <summary>
        /// All combat buttons
        /// </summary>
        private void btnHealth_Click(object sender, EventArgs e) {
            buyingCombat(GlobalData.upgradesCosts[4][0], 3, 0, 100, lblHealthCost);
        }

        private void btnBlock_Click(object sender, EventArgs e) {
            buyingCombat(GlobalData.upgradesCosts[4][1], 3, 1, 250, lblBlockCost);
        }

        private void btnAttack_Click(object sender, EventArgs e) {
            buyingCombat(GlobalData.upgradesCosts[4][2], 3, 2, 150, lblAttackCost);
        }

        /// <summary>
        /// Research buttons
        /// </summary>
        private void btnAquaducts_Click(object sender, EventArgs e) {
            buyingResearch(GlobalData.upgradesCosts[2][0], 0, lblAqueductsCost);
        }

        private void btnStampMill_Click(object sender, EventArgs e) {
            buyingResearch(GlobalData.upgradesCosts[2][1], 1, lblStampMillCost);
        }

        private void btnTripHammer_Click(object sender, EventArgs e) {
            buyingResearch(GlobalData.upgradesCosts[2][2], 2, lblTripHammerCost);
        }

        private void btnHushing_Click(object sender, EventArgs e) {
            buyingResearch(GlobalData.upgradesCosts[2][3], 3, lblHushingCost);
        }

        private void btnVilla_Click(object sender, EventArgs e) {
            buyingResearch(GlobalData.upgradesCosts[2][4], 4, lblVillaCost);
        }
        #endregion

        #region Procedures
        /// <param name="cost">The cost of the storage</param>
        /// <param name="typeToBuy">What resource is needed to buy it</param>
        /// <param name="typeToBuyFor">What resource storage it is being bought for</param>
        /// <param name="storageIncrease">The amount of storage the upgrade increased by</param>
        void buyingStorage(int cost, int typeToBuy, int typeToBuyFor, int storageIncrease, Label labelCosts) {
            // If the player does not have enough wood
            if (GlobalData.resourcesData[0][typeToBuy] < cost) {
                // Print to upgrades tab in logs
                rtxtUpgrades.Text += ("\n" + GlobalData.currentTime + ": You do not have enough wood for this upgrade");
            } else {
                // Deduct the cost from the number of resources
                GlobalData.resourcesData[0][typeToBuy] -= cost;
                // Increase the cost of this upgrade
                GlobalData.upgradesCosts[0][typeToBuyFor] *= GlobalData.costMultipliers[0];
                // Increase the storage amount by the amount specified
                GlobalData.resourcesData[2][typeToBuyFor] += storageIncrease;
                // Print the new cost to the cost label
                labelCosts.Text = ("Cost: " + GlobalData.upgradesCosts[0][typeToBuyFor] + " wood");
            }
        }

        /// <param name="cost">The cost of the workers</param>
        /// <param name="typeToBuy">What resource is needed to buy it</param>
        /// <param name="typeToBuyFor">The resource worker it is being bought for</param>
        void buyingWorkers(int cost, int typeToBuy, int typeToBuyFor, int rateIncrease, Label labelCosts) {
            // If the player does not have enough food OR enough housing space
            if (GlobalData.resourcesData[0][typeToBuy] < cost || GlobalData.housingRemaining == 0) {
                // Print to upgrades tab in logs
                rtxtUpgrades.Text += ("\n" + GlobalData.currentTime + ": You do not have enough food for this upgrade");
            } else {
                // Deduct the cost from the number of resources
                GlobalData.resourcesData[0][typeToBuy] -= cost;
                // Increase the cost of this upgrade
                GlobalData.upgradesCosts[1][typeToBuyFor] *= GlobalData.costMultipliers[1];
                // Increase the rate of the resource
                GlobalData.resourcesData[1][typeToBuyFor] += rateIncrease;
                // Decreasing the housing space by 1
                GlobalData.housingRemaining -= 1;
                // Print the new cost to the cost label
                labelCosts.Text = ("Cost: " + GlobalData.upgradesCosts[1][typeToBuyFor] + " food, 1 housing");
            }
        }

        /// <param name="cost">Cost of the troop</param>
        /// <param name="typeToBuy">What resource is needed to buy the troop</param>
        void buyingTroops(int cost, int typeToBuy, Label labelCosts) {
            // If there is not enough metal or housing space
            if (GlobalData.resourcesData[0][typeToBuy] < cost || GlobalData.housingRemaining == 0) {
                // Print to upgrades tab in logs
                rtxtUpgrades.Text += ("\n" + GlobalData.currentTime + ": You do not have enough metal or housing for this upgrade");
            } else {
                // Deduct cost from number of resources
                GlobalData.resourcesData[0][typeToBuy] -= cost;
                // Increase cost of this upgrade
                GlobalData.upgradesCosts[4][3] *= GlobalData.costMultipliers[1];
                // Increase the number of troops in the army
                GlobalData.combatData[3][0] += 1;
                // Decrease the housing space by 1
                GlobalData.housingRemaining -= 1;
                // Print the new cost to the cost label
                labelCosts.Text = ("Cost: " + GlobalData.upgradesCosts[4][3] + " metal, 1 housing");
                // Print the new number of troops to upgrades logs
                rtxtUpgrades.Text += ("\n" + GlobalData.currentTime + ": Troop number increased by 1, total is " + GlobalData.combatData[3][0].ToString());
            }
        }

        /// <param name="cost">Cost of upgrade</param>
        /// <param name="typeToBuy">Resource type needed to buy upgrade</param>
        /// <param name="housingType">Type of housing being upgraded</param>
        void buyingHousing(int cost, int typeToBuy, int housingType, Label labelCosts) {
            // If there are enough resources to buy the upgrade
            if (GlobalData.resourcesData[0][typeToBuy] < cost) {
                // Print to upgrades tab in logs
                rtxtUpgrades.Text += ("\n" + GlobalData.currentTime + ": You do not have enough stone for this upgrade");
            } else {
                // Deduct cost from number of resources
                GlobalData.resourcesData[0][typeToBuy] -= cost;
                // Increase cost of this upgrade
                GlobalData.upgradesCosts[3][housingType] *= GlobalData.costMultipliers[3];
                // Increase the total housing and housing remaining this upgrade provides
                GlobalData.totalHousing += GlobalData.housingData[housingType];
                GlobalData.housingRemaining += GlobalData.housingData[housingType];
                // Print the new cost to the cost label
                labelCosts.Text = ("Cost: " + GlobalData.upgradesCosts[3][housingType] + " stone");
            }
        }

        /// <param name="cost">Cost of upgrade</param>
        /// <param name="typeToBuy">Type of resource needed to buy upgrade</param>
        /// <param name="combatType">Type of combat being bought for</param>
        /// <param name="buff">Amount the combat type is being buffed by</param>
        void buyingCombat(int cost, int typeToBuy, int combatType, int buff, Label labelCosts) {
            // If the player does not have enough resources
            if (GlobalData.resourcesData[0][typeToBuy] < cost) {
                // Print message into upgrades logs
                rtxtUpgrades.Text += ("\n" + GlobalData.currentTime + ": You do not have enough metal for this upgrade");
            } else {
                // Deduct cost from number of resources
                GlobalData.resourcesData[0][typeToBuy] -= cost;
                // Increase cost of this upgrade
                GlobalData.upgradesCosts[4][combatType] *= GlobalData.costMultipliers[4];
                // Buff the combat type
                GlobalData.combatData[combatType][0] += buff;
                // Print the new cost to the cost label
                labelCosts.Text = ("Cost: " + GlobalData.upgradesCosts[4][combatType] + " metal");
                switch (combatType) {
                    case 0:
                        // Print health increase to logs
                        rtxtCombat.Text += ("\n" + GlobalData.currentTime + " Troop health increased by 100, total is " + GlobalData.combatData[0][0].ToString());
                        break;
                    case 1:
                        // Print block increase to logs
                        rtxtCombat.Text += ("\n" + GlobalData.currentTime + " Troop block increased by 250, total is " + GlobalData.combatData[1][0].ToString());
                        break;
                    case 2:
                        // Print attack increase to logs
                        rtxtCombat.Text += ("\n" + GlobalData.currentTime + " Troop attack increased by 150, total is " + GlobalData.combatData[2][0].ToString());
                        break;
                }
            }
        }

        /// <param name="cost">Cost of upgrade</param>
        /// <param name="researchType">Type of research being bought</param>
        void buyingResearch(int cost, int researchType, Label labelCosts) {
            // If the player does not have enough science
            if (GlobalData.scienceData < cost) {
                // Print in upgrades logs
                rtxtUpgrades.Text += ("\n" + GlobalData.currentTime + ": You do not have enough science for this upgrade");
            } else {
                // Deduct cost from total science
                GlobalData.scienceData -= cost;
                // Increase cost
                GlobalData.upgradesCosts[2][researchType] *= GlobalData.costMultipliers[2];
                // Output new cost
                labelCosts.Text = ("Cost: " + GlobalData.upgradesCosts[2][researchType] + " science");

                switch (researchType) {
                    // Aqueducts
                    case 0:
                        GlobalData.resourcesData[1][0] *= 5;
                        GlobalData.resourcesData[1][2] *= 5;
                        rtxtStoryLogs.Text += ("\n" + "You have learned the art of aqueducts! These towering structures made of stone automate the carrying of water into your farms.");
                        break;
                    // Stamp-mill
                    case 1:
                        GlobalData.resourcesData[1][1] *= 2;
                        rtxtStoryLogs.Text += ("\n" + "You have created the blueprints for stamp mills! These crush metal ore by pounding them to bits, making it faster to extract metal!");
                        break;
                    // Trip-hammer
                    case 2:
                        GlobalData.resourcesData[1][3] *= 2;
                        rtxtStoryLogs.Text += ("\n" + "You have invented the trip-hammer! This will help you to shape your metals into more usable shapes!");
                        break;
                    // Hushing
                    case 3:
                        GlobalData.resourcesData[1][3] *= 5;
                        rtxtStoryLogs.Text += ("\n" + "You have stolen the secret of hushing from another civilisation! It allows you to use floods of water to reveal mineral veins.");
                        break;
                    // Villa
                    case 4:
                        GlobalData.totalHousing *= 3;
                        rtxtStoryLogs.Text += ("\n" + "You have earned yourself enough to construct a villa! This magnificent structure increases your housing space by 3 times!");
                        break;
                }
            }
        }
        #endregion
    }
}