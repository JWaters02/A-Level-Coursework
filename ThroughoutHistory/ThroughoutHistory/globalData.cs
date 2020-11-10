using System;
using System.Collections.Generic;

namespace ThroughoutHistory {
	/// <summary>
	/// GlobalData stores ALL global scoped variables
	/// </summary>
	public static class GlobalData {
        // Resource data
        // [][0]Wood, [][1]Stone, [][2]Food, [][3]Metal
        public static List<int[]> resourcesData = new List<int[]> {
        	new int[4] {0, 0, 0, 0}, // Amount
        	new int[4] {1, 1, 1, 1}, // Rate, in milliseconds, by the timer (which is multiplied by 1000 later)
        	new int[4] {100, 100, 100, 100}, // Capacity
        	new int[4] {3, 1, 3, 1} // Gather multiplier (e.g. 2 would be +2/sec)
		};
        public static int scienceData = 0;
        public static int[] housingData = new int[3] {5, 10, 20}; // How much space each housing type gives
        public static int totalHousing = 5; // Total housing space
        public static int housingRemaining = 5;

        // Upgrades data
        public static List<int[]> upgradesCosts = new List<int[]> {
        	new int[4] {50, 50, 50, 100}, // Storage Costs
        	new int[4] {100, 100, 100, 200}, // Workers Costs
        	new int[5] {100, 500, 1000, 3000, 5000}, // Science Costs
        	new int[3] {50, 100, 500}, // Housing Costs
        	new int[4] {200, 500, 300, 200} // Combat Costs ([][0]Health, [][1]Block, [][2]Damage, [][3]NoTroops)
        };
        public static int[] costMultipliers = new int[] {2, 4, 5, 2, 2}; // Storage, workers, science, housing, combat
		
        // Combat data
        // [][0]Player combat data, [][1]Enemy combat data
        public static List<int[]> combatData = new List<int[]> {
        	new int[2] {100, 100}, // Health
        	new int[2] {20, 20}, // Block (e.g. 2 is *2 block)
        	new int[2] {50, 20}, // Damage
        	new int[2] {1, 1} // No of troops
        };
        
        // War data
        public static int tickCounter = 0;
        public static int[] warTimes = new int[]
        {180, 3240, 6000, 6800, 9600, 12300, 14160, 16920, 21000, 22200, 27540, 28200, 28920,
            32580, 33660, 39660, 47760, 50640}; // Measured in tick numbers (see tickCounter), each war lasts 10 minutes (600)
        public static int curretWar = 0;
        public static int warNumber = 0;
        public static int year = -500;
        public static int actualYear = 500;
        public static string era = "BC";
        public static string[] warNames = new string[18] { 
            "War of Lake Regillius", "War of Corbio", "War of Veii", "War of Allia River", "Latin War", "War of Aquilonia",
            "First Punic War", "Second Punic War", "Third Punic War", "Achaean War", "War of Alesia", "War of Zela",
            "War of Actium", "War of the Medway", "The Battle of Waiting Street", "First Persian Wars", "Second Persian Wars", "Third Persian Wars"
        };

        // Current time variable
        public static string currentTime;
	}
}
