using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ThroughoutHistory {
	public partial class MainForm {
        /// <summary>
        /// Runs every 5 ticks (seconds)
        /// </summary>
        private void combatTimer_Tick(object sender, EventArgs e) {
            warTicks += combatTimer.Interval / 1000;
            calculateAttack();
            winWarCheck();
        }

        #region Variables
        int maxPlayerHealth;
        int playerBlock;
        int playerDamage;

        int maxEnemyHealth;
        int enemyBlock;
        int enemyDamage;

        int enemyHealth = 100;
        int playerHealth = 100;

        bool playerTurn = true;
        int warTicks = 0;   
        Random rng = new Random();
        int playerTiles = 10;
        const int ROWS = 4;
        const int COLUMNS = 5;
        const int PLAYER = 1;
        const int ENEMY = 0;
        int[,] grid = new int[4, 5]
        {
                {0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0},
                {1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1}
        }; //Where 0 is red and 1 is green (enemy and player occupied respectively)
        #endregion

        /// <summary>
        /// Runs a bunch of stuff when a new war starts
        /// </summary>
        void startWar() {
            // Loop number of wars
            for (int i = 0; i < GlobalData.warTimes.Length; i++) {
                // If the current tick is equivalent to the current war time
                if (GlobalData.tickCounter == GlobalData.warTimes[i]) {
                    // New war starts
                    GlobalData.curretWar = GlobalData.warTimes[i];
                    GlobalData.warNumber++;
                    warTicks = 0;
                    // Print this in logs
                    rtxtCombat.Text += ("\n" + GlobalData.currentTime.ToString() + ": New war called " + GlobalData.warNames[i] + " started!");
                    lblWarDesciption.Text = ("Current war: " + GlobalData.warNames[i] + ".");

                    // Reset the board
                    resetBoard();
                    // Calculate new enemy stats
                    calculateNewEnemyStats();

                    // Update all the necessary variables
                    maxPlayerHealth = GlobalData.combatData[0][0] * GlobalData.combatData[3][0];
                    playerBlock = GlobalData.combatData[1][0] * GlobalData.combatData[3][0];
                    playerDamage = GlobalData.combatData[2][0] * GlobalData.combatData[3][0];

                    maxEnemyHealth = GlobalData.combatData[0][1] * GlobalData.combatData[3][1];
                    enemyBlock = GlobalData.combatData[1][1] * GlobalData.combatData[3][1];
                    enemyDamage = GlobalData.combatData[2][1] * GlobalData.combatData[3][1];

                    playerTiles = 10;
                    lblEnemyTiles.Text = ("Enemy tiles: " + 10);
                    lblPlayerTiles.Text = ("Allied tiles: " + 10);

                    // Start the combat timer
                    combatTimer.Start();
                } else {
                    lblCurrentYear.Text = ("Year: " + GlobalData.actualYear.ToString() + GlobalData.era + ".");
                }
            }
        }

        /// <summary>
        /// Resets the board at the start of every war
        /// </summary>
        void resetBoard() {
            // Setup the graphics and brushes
            Bitmap bitmap = new Bitmap(1000, 1000);
            Graphics GFX = Graphics.FromImage(bitmap);
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            SolidBrush redBrush = new SolidBrush(Color.Red);

            // Loop through each column (all are same)
            for (int x = 0; x < COLUMNS; x++) {
                // Loop through first 2 rows
                for (int y = 0; y < ROWS; y++) {
                    // Paint the red tiles
                    GFX.FillRectangle(redBrush, x * 65, y * 65, 60, 60);
                    grid[y, x] = ENEMY;
                }
                // Loop through last 2 rows
                for (int y = 2; y < ROWS; y++) {
                    // Paint the green tiles
                    GFX.FillRectangle(greenBrush, x * 65, y * 65, 60, 60);
                    grid[y, x] = PLAYER;
                }
            }
            // Show the image in the picture box
            pbxGrid.Image = bitmap;
        }

        /// <summary>
        /// Calculates each attack turn
        /// </summary>
        void calculateAttack() {
            // If it is the player's turn
            if (playerTurn) {
                playerTurn = false;
                // Add some random into the damage, using a bonus damage
                int bonusDamagePlayer = rng.Next(1, 3);
                int bonusDamage = 0;
                switch (bonusDamagePlayer) {
                    case 1:
                        bonusDamage = GlobalData.combatData[2][0] / 5;
                        break;
                    case 2:
                        bonusDamage = GlobalData.combatData[2][0] / 2;
                        break;
                }
                // Work out how much damage the player does
                int blockedPlayerDamage = (playerDamage + bonusDamage) - enemyBlock;
                enemyHealth -= blockedPlayerDamage;
                
                // If the enemy health is 0 or less
                if (enemyHealth <= 0) {
                    // Give the player a tile
                    playerTiles += 1;
                    int enemyTiles = 20 - playerTiles;
                    lblEnemyTiles.Text = ("Enemy tiles: " + enemyTiles);
                    lblPlayerTiles.Text = ("Allied tiles: " + playerTiles);
                    rtxtCombat.Text += ("\nYou have won the battle! You are one step closer to winning the war.");

                    int i = 19;
                    // While the current tile is owned by the player
                    while(grid[i / 5,i % 5] == PLAYER) {
                        i--;
                    }
                    // Next tile must be next in line to be claimed, thus set this to player
                    grid[i / 5, i % 5] = PLAYER;
                    
                    updateBoard();

                    // Reset player and enemy health back to normal
                    enemyHealth = maxEnemyHealth;
                    playerHealth = maxPlayerHealth;
                }
                // 0/0 Health, 0 attack, 0 block
                lblEnemyStats.Text = String.Format("{0}/{1}, {2} attack, {3} block", enemyHealth, maxEnemyHealth, enemyDamage, enemyBlock);
                lblPlayerStats.Text = String.Format("{0}/{1}, {2} attack, {3} block, +{4} bonus!", playerHealth, maxPlayerHealth, playerDamage, playerBlock, bonusDamage);
                rtxtTempOutput.Text += String.Format("\nPlayer's turn. New enemy health is {0} out of {1} total health, player tiles is {2}.", enemyHealth, maxEnemyHealth, playerTiles);
            } else {
                playerTurn = true;
                // Add some random into the damage, using a bonus damage
                int bonusDamageEnemy = rng.Next(1, 3);
                int bonusDamage = 0;
                switch (bonusDamageEnemy) {
                    case 1:
                        bonusDamage = GlobalData.combatData[2][0] / 5;
                        break;
                    case 2:
                        bonusDamage = GlobalData.combatData[2][0] / 10;
                        break;
                }
                // Work out how much damage the enemy does
                int blockedEnemyDamage = (enemyDamage + bonusDamage) - playerBlock;
                playerHealth -= blockedEnemyDamage;
                
                // If the player health is 0 or less
                if (playerHealth <= 0) {
                    // Give the enemy the tile
                    playerTiles -= 1;
                    int enemyTiles = 20 - playerTiles;
                    lblEnemyTiles.Text = ("Enemy tiles: " + enemyTiles);
                    lblPlayerTiles.Text = ("Allied tiles: " + playerTiles);
                    rtxtCombat.Text += ("\nYou have lost the battle! You are one step closer to losing the war.");

                    int i = 0;
                    // While the current tile is owned by the enemy
                    while (grid[i / 5, i % 5] == ENEMY) {
                        i++;
                    }
                    // Next tile must be next in line to be claimed, thus set this to enemy
                    grid[i / 5, i % 5] = ENEMY;

                    updateBoard();
                    
                    // Reset player and enemy health to normal
                    playerHealth = maxPlayerHealth;
                    enemyHealth = maxEnemyHealth;
                }
                // 0/0 Health, 0 attack, 0 block
                lblEnemyStats.Text = String.Format("{0}/{1}, {2} attack, {3} block, +{4} bonus!", enemyHealth, maxEnemyHealth, enemyDamage, enemyBlock, bonusDamage);
                lblPlayerStats.Text = String.Format("{0}/{1}, {2} attack, {3} block", playerHealth, maxPlayerHealth, playerDamage, playerBlock);
                rtxtTempOutput.Text += String.Format("\nEnemy's turn. New player health is {0} out of {1} total health, player tiles is {2}.", playerHealth, maxPlayerHealth, playerTiles);
            }
        }

        /// <summary>
        /// Updates the board based off the grid 2D array
        /// </summary>
        void updateBoard() {
            // Setup graphics and brushes
            Bitmap bitmap = new Bitmap(1000, 1000);
            Graphics GFX = Graphics.FromImage(bitmap);
            SolidBrush[] brushes = { new SolidBrush(Color.Red), new SolidBrush(Color.Green) };
            const int GRIDSIZE = 65;

            // Loop through each column
            for (int x = 0; x < COLUMNS; x++) {
                // Loop through each row
                for (int y = 0; y < ROWS; y++) {
                    // Redraw the grid according to what the values in the grid variable are
                    GFX.FillRectangle(brushes[grid[y, x]], Rectangle.FromLTRB(x * (GRIDSIZE), y * (GRIDSIZE), x * (GRIDSIZE) + 60, y * (GRIDSIZE) + 60));
                }
            }
            pbxGrid.Image = bitmap;
        }

        /// <summary>
        /// Checks if a war has been won or not
        /// </summary>
        void winWarCheck() {
            // A side wins all tiles, or the war timer has run out
            if (playerTiles == 0 || playerTiles == 20 || warTicks == 600) {
                // Reset allied and enemy tiles count labels
                lblPlayerTiles.Text = "Allied tiles: 10";
                lblEnemyTiles.Text = "Enemy tiles: 10";
                lblPlayerStats.Text = "No war running";
                lblEnemyStats.Text = "No war running";
                lblWarDesciption.Text = "Current war: None - Check loot and combat logs.";
                resetBoard();
                // If both sides have the same number of tiles
                if (playerTiles == 10) {
                    // Work out new enemy stats
                    int randomnNum = rng.Next(3, 5);
                    for (int i = 0; i < 3; i++) {
                        GlobalData.combatData[i][1] *= randomnNum;
                    }
                    GlobalData.combatData[3][1] += randomnNum;
                    // Print draw into logs
                    rtxtCombat.Text += ("\n" + GlobalData.currentTime.ToString() + ": Draw");
                    // Work out how much loot player receives
                    calculateLoot(0);
                    // If the enemy has more tiles than the player
                } else if (playerTiles == 0) {
                    // Work out new enemy stats
                    int randomNum = rng.Next(3, 7);
                    for (int i = 0; i < 3; i++) {
                        GlobalData.combatData[i][1] *= randomNum;
                    }
                    GlobalData.combatData[3][1] += randomNum;
                    // Print enemy wins into logs
                    rtxtCombat.Text += ("\n" + GlobalData.currentTime.ToString() + ": You have lost the war, the enemy will get much stronger :(");
                    // Work out how much loot player receives
                    calculateLoot(1);
                    // If the player has more tiles than the enemy
                } else if (playerTiles == 20) {
                    // Work out new enemy stats
                    int randomNum = rng.Next(3, 5);
                    for (int i = 0; i < 3; i++) {
                        GlobalData.combatData[i][1] *= randomNum;
                    }
                    GlobalData.combatData[3][1] += randomNum;
                    // Print player wins into logs
                    rtxtCombat.Text += ("\n" + GlobalData.currentTime.ToString() + ": You have won the war! The enemy will not get that much stronger!");
                    // Work out how much loot player receives
                    calculateLoot(2);
                }
                // Stop the combat timer until new war starts
                combatTimer.Stop();
            }
        }

        /// <summary>
        /// Calculates loot player gains/loses based on war outcome
        /// </summary>
        /// <param name="outcome">Value of outcome</param>
        void calculateLoot(int outcome) {
            switch (outcome) {
                case 0:
                    // Gets 200* war number for each resource
                    const int MULTIPLIERDRAW = 200;
                    for (int i = 0; i < 4; i++) {
                        GlobalData.resourcesData[0][i] += MULTIPLIERDRAW * GlobalData.warNumber;
                    }
                    // Gets 1000 * war number of science
                    const int MULTIPLIERWAR = 1000;
                    GlobalData.scienceData += MULTIPLIERWAR * GlobalData.warNumber;
                    // Print values to logs
                    rtxtLoot.Text += ("\n" + GlobalData.currentTime.ToString() + ": You have gained " + (MULTIPLIERDRAW * GlobalData.warNumber).ToString() + " of each resource + " + (MULTIPLIERWAR * GlobalData.warNumber).ToString() + " science!");
                    break;
                case 1:
                    // Loses 5-10 troops to the enemy
                    int randomNum = rng.Next(5, 10);
                    GlobalData.combatData[3][0] -= randomNum;
                    if (GlobalData.combatData[3][0] < 1) {
                        GlobalData.combatData[3][0] = 1;
                    }
                    GlobalData.combatData[3][1] += randomNum;
                    // Gets 500* war number of each resource
                    const int MULTIPLIERLOSS = 100;
                    for (int i = 0; i < 4; i++) {
                        GlobalData.resourcesData[0][i] += MULTIPLIERLOSS * GlobalData.warNumber;
                    }
                    // Gets 1000 * war number of science
                    GlobalData.scienceData += MULTIPLIERWAR * GlobalData.warNumber;
                    // Print values to logs
                    rtxtLoot.Text += ("\n" + GlobalData.currentTime.ToString() + ": You have lost " + randomNum.ToString() + " troops to the enemy, but gained " + (MULTIPLIERLOSS * GlobalData.warNumber).ToString() + " of each resource + " + (MULTIPLIERWAR * GlobalData.warNumber).ToString() + " science!");
                    break;
                case 2:
                    // Gets half number of troops enemy had
                    int noEnemyTroops = GlobalData.combatData[3][1];
                    // If it is odd, take 1 then half it
                    if (noEnemyTroops % 2 != 0) {
                        noEnemyTroops -= 1;
                    }
                    GlobalData.combatData[3][0] += (noEnemyTroops / 2);
                    // Gets 500* war number of each resource
                    const int MULTIPLIERWIN = 500;
                    for (int i = 0; i < 4; i++) {
                        GlobalData.resourcesData[0][i] += MULTIPLIERWIN * GlobalData.warNumber;
                    }
                    // Gets 1000 * war number of science
                    const int MULTIPLIERWARWIN = 5000;
                    GlobalData.scienceData += MULTIPLIERWARWIN * GlobalData.warNumber;
                    // Print values to logs
                    rtxtLoot.Text += ("\n" + GlobalData.currentTime.ToString() + ": You have gained half of the enemy's troops, and gained " + (MULTIPLIERWIN * GlobalData.warNumber).ToString() + " of each resource + " + (MULTIPLIERWARWIN * GlobalData.warNumber).ToString() + " science!");
                    break;
            }
        }

        /// <summary>
        /// Calculates the stats of the enemies on new war start
        /// </summary>
        void calculateNewEnemyStats() {
            // Enemy health 100-200% of player's (1x-2x)
            int randomHealth = rng.Next(1, 3); // MaxVal is exclusive
            GlobalData.combatData[0][1] = GlobalData.combatData[0][0] * randomHealth;
            // Enemy block 100-200% of player's (1x-2x)
            int randomBlock = rng.Next(1, 3);
            GlobalData.combatData[1][1] = GlobalData.combatData[1][0] * randomBlock;
            // Enemy damage 50-100% of player's (0.5x-1x)
            int randomAttack = rng.Next(1, 3);
            // Get around having to use random doubles
            if (randomAttack == 1) {
                GlobalData.combatData[2][1] = GlobalData.combatData[2][0] / 2;
            } else {
                GlobalData.combatData[2][1] = GlobalData.combatData[2][0];
            }
        }
    }
}