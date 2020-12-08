/*
 * Created by SharpDevelop.
 * User: 13jwaters
 * Date: 03/10/2019
 * Time: 09:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ThroughoutHistory
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.resourceCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debuggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlResourceCollection = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpStorage = new System.Windows.Forms.TabPage();
            this.pnlIronStorage = new System.Windows.Forms.Panel();
            this.label28 = new System.Windows.Forms.Label();
            this.btnMetalStorage = new System.Windows.Forms.Button();
            this.lblMetalStorageCost = new System.Windows.Forms.Label();
            this.pnlFoodStorage = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.btnFoodStorage = new System.Windows.Forms.Button();
            this.lblFoodStorageCost = new System.Windows.Forms.Label();
            this.pnlStoneStorage = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.btnStoneStorage = new System.Windows.Forms.Button();
            this.lblStoneStorageCost = new System.Windows.Forms.Label();
            this.pnlWoodStorage = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.btnWoodStorage = new System.Windows.Forms.Button();
            this.lblWoodStorageCost = new System.Windows.Forms.Label();
            this.tpWorkers = new System.Windows.Forms.TabPage();
            this.pnlTroops = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.btnTroop = new System.Windows.Forms.Button();
            this.lblTroopCost = new System.Windows.Forms.Label();
            this.pnlMiner = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.btnMiner = new System.Windows.Forms.Button();
            this.lblMinerCost = new System.Windows.Forms.Label();
            this.pnlButcher = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.btnButcher = new System.Windows.Forms.Button();
            this.lblButcherCost = new System.Windows.Forms.Label();
            this.pnlQuarrier = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.btnQuarring = new System.Windows.Forms.Button();
            this.lblQuarrierCost = new System.Windows.Forms.Label();
            this.pnlGatherer = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.btnGatherer = new System.Windows.Forms.Button();
            this.lblGathererCost = new System.Windows.Forms.Label();
            this.tpHousing = new System.Windows.Forms.TabPage();
            this.pnlBootcamp = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.btnBootcamp = new System.Windows.Forms.Button();
            this.lblBootcampCost = new System.Windows.Forms.Label();
            this.pnlBarracks = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.btnBarracks = new System.Windows.Forms.Button();
            this.lblBarracksCost = new System.Windows.Forms.Label();
            this.pnlShack = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.btnShack = new System.Windows.Forms.Button();
            this.lblShackCost = new System.Windows.Forms.Label();
            this.tpCombat = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.lblAttackCost = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.btnBlock = new System.Windows.Forms.Button();
            this.lblBlockCost = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.btnHealth = new System.Windows.Forms.Button();
            this.lblHealthCost = new System.Windows.Forms.Label();
            this.tpResearch = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.btnVilla = new System.Windows.Forms.Button();
            this.lblVillaCost = new System.Windows.Forms.Label();
            this.pnlHushing = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnHushing = new System.Windows.Forms.Button();
            this.lblHushingCost = new System.Windows.Forms.Label();
            this.pnlTripHammer = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTripHammer = new System.Windows.Forms.Button();
            this.lblTripHammerCost = new System.Windows.Forms.Label();
            this.pnlStampMill = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnStampMill = new System.Windows.Forms.Button();
            this.lblStampMillCost = new System.Windows.Forms.Label();
            this.pnlAquaducts = new System.Windows.Forms.Panel();
            this.btnAquaducts = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAqueductsCost = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblScienceAmount = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblHousingSpace = new System.Windows.Forms.Label();
            this.lblHousingCapacity = new System.Windows.Forms.Label();
            this.pbHousing = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMetalAmount = new System.Windows.Forms.Label();
            this.lblMetalRate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbMetal = new System.Windows.Forms.ProgressBar();
            this.btnMine = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFoodAmount = new System.Windows.Forms.Label();
            this.lblFoodRate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbFood = new System.Windows.Forms.ProgressBar();
            this.btnFarm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStoneAmount = new System.Windows.Forms.Label();
            this.lblStoneRate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbStone = new System.Windows.Forms.ProgressBar();
            this.btnQuarrier = new System.Windows.Forms.Button();
            this.pnlWood = new System.Windows.Forms.Panel();
            this.lblWoodAmount = new System.Windows.Forms.Label();
            this.lblWoodRate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbWood = new System.Windows.Forms.ProgressBar();
            this.btnGather = new System.Windows.Forms.Button();
            this.globalTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlCombat = new System.Windows.Forms.Panel();
            this.lblCurrentYear = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.pbxGrid = new System.Windows.Forms.PictureBox();
            this.lblPlayerTiles = new System.Windows.Forms.Label();
            this.lblWarDesciption = new System.Windows.Forms.Label();
            this.lblEnemyTiles = new System.Windows.Forms.Label();
            this.lblPlayerStats = new System.Windows.Forms.Label();
            this.lblEnemyStats = new System.Windows.Forms.Label();
            this.pnlLogs = new System.Windows.Forms.Panel();
            this.btnClearLogs = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tpStoryLogs = new System.Windows.Forms.TabPage();
            this.rtxtStoryLogs = new System.Windows.Forms.RichTextBox();
            this.tpUpgradesLogs = new System.Windows.Forms.TabPage();
            this.rtxtUpgrades = new System.Windows.Forms.RichTextBox();
            this.tpCombatLogs = new System.Windows.Forms.TabPage();
            this.rtxtCombat = new System.Windows.Forms.RichTextBox();
            this.tpLootLogs = new System.Windows.Forms.TabPage();
            this.rtxtLoot = new System.Windows.Forms.RichTextBox();
            this.tpSavesLogs = new System.Windows.Forms.TabPage();
            this.rtxtSaves = new System.Windows.Forms.RichTextBox();
            this.pnlFileHandling = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnAutosaveOption = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAutosaveStatus = new System.Windows.Forms.Label();
            this.combatTimer = new System.Windows.Forms.Timer(this.components);
            this.nudChangeTick = new System.Windows.Forms.NumericUpDown();
            this.btnChangeTick = new System.Windows.Forms.Button();
            this.rtxtTempOutput = new System.Windows.Forms.RichTextBox();
            this.btnPauseGame = new System.Windows.Forms.Button();
            this.autosaveTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlDebugging = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.openDialogue = new System.Windows.Forms.OpenFileDialog();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.nudChangeHealth = new System.Windows.Forms.NumericUpDown();
            this.btnChangeHealth = new System.Windows.Forms.Button();
            this.btnChangeBlock = new System.Windows.Forms.Button();
            this.nudChangeBlock = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.msMain.SuspendLayout();
            this.pnlResourceCollection.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpStorage.SuspendLayout();
            this.pnlIronStorage.SuspendLayout();
            this.pnlFoodStorage.SuspendLayout();
            this.pnlStoneStorage.SuspendLayout();
            this.pnlWoodStorage.SuspendLayout();
            this.tpWorkers.SuspendLayout();
            this.pnlTroops.SuspendLayout();
            this.pnlMiner.SuspendLayout();
            this.pnlButcher.SuspendLayout();
            this.pnlQuarrier.SuspendLayout();
            this.pnlGatherer.SuspendLayout();
            this.tpHousing.SuspendLayout();
            this.pnlBootcamp.SuspendLayout();
            this.pnlBarracks.SuspendLayout();
            this.pnlShack.SuspendLayout();
            this.tpCombat.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tpResearch.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnlHushing.SuspendLayout();
            this.pnlTripHammer.SuspendLayout();
            this.pnlStampMill.SuspendLayout();
            this.pnlAquaducts.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlWood.SuspendLayout();
            this.pnlCombat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGrid)).BeginInit();
            this.pnlLogs.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tpStoryLogs.SuspendLayout();
            this.tpUpgradesLogs.SuspendLayout();
            this.tpCombatLogs.SuspendLayout();
            this.tpLootLogs.SuspendLayout();
            this.tpSavesLogs.SuspendLayout();
            this.pnlFileHandling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChangeTick)).BeginInit();
            this.pnlDebugging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChangeHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChangeBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseForm.BackColor = System.Drawing.Color.Red;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.Location = new System.Drawing.Point(645, 0);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(50, 50);
            this.btnCloseForm.TabIndex = 4;
            this.btnCloseForm.Text = "X";
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.BtnCloseFormClick);
            // 
            // msMain
            // 
            this.msMain.BackColor = System.Drawing.Color.Orange;
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resourceCollectionToolStripMenuItem,
            this.combatToolStripMenuItem,
            this.logsToolStripMenuItem,
            this.saveLoadToolStripMenuItem,
            this.debuggingToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(695, 29);
            this.msMain.TabIndex = 5;
            this.msMain.Text = "menuStrip1";
            this.msMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MsMainItemClicked);
            // 
            // resourceCollectionToolStripMenuItem
            // 
            this.resourceCollectionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resourceCollectionToolStripMenuItem.Name = "resourceCollectionToolStripMenuItem";
            this.resourceCollectionToolStripMenuItem.Size = new System.Drawing.Size(260, 25);
            this.resourceCollectionToolStripMenuItem.Text = "Resource Collection and Upgrades";
            this.resourceCollectionToolStripMenuItem.Click += new System.EventHandler(this.resourceCollectionToolStripMenuItem_Click);
            // 
            // combatToolStripMenuItem
            // 
            this.combatToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combatToolStripMenuItem.Name = "combatToolStripMenuItem";
            this.combatToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.combatToolStripMenuItem.Text = "Combat";
            this.combatToolStripMenuItem.Click += new System.EventHandler(this.combatToolStripMenuItem_Click);
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(55, 25);
            this.logsToolStripMenuItem.Text = "Logs";
            this.logsToolStripMenuItem.Click += new System.EventHandler(this.logsToolStripMenuItem_Click);
            // 
            // saveLoadToolStripMenuItem
            // 
            this.saveLoadToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLoadToolStripMenuItem.Name = "saveLoadToolStripMenuItem";
            this.saveLoadToolStripMenuItem.Size = new System.Drawing.Size(95, 25);
            this.saveLoadToolStripMenuItem.Text = "Save/Load";
            this.saveLoadToolStripMenuItem.Click += new System.EventHandler(this.saveLoadToolStripMenuItem_Click);
            // 
            // debuggingToolStripMenuItem
            // 
            this.debuggingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debuggingToolStripMenuItem.Name = "debuggingToolStripMenuItem";
            this.debuggingToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.debuggingToolStripMenuItem.Text = "Tutorial";
            this.debuggingToolStripMenuItem.Click += new System.EventHandler(this.debuggingToolStripMenuItem_Click);
            // 
            // pnlResourceCollection
            // 
            this.pnlResourceCollection.Controls.Add(this.tabControl1);
            this.pnlResourceCollection.Controls.Add(this.panel5);
            this.pnlResourceCollection.Controls.Add(this.panel4);
            this.pnlResourceCollection.Controls.Add(this.panel3);
            this.pnlResourceCollection.Controls.Add(this.panel2);
            this.pnlResourceCollection.Controls.Add(this.panel1);
            this.pnlResourceCollection.Controls.Add(this.pnlWood);
            this.pnlResourceCollection.Location = new System.Drawing.Point(5, 50);
            this.pnlResourceCollection.Name = "pnlResourceCollection";
            this.pnlResourceCollection.Size = new System.Drawing.Size(676, 415);
            this.pnlResourceCollection.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpStorage);
            this.tabControl1.Controls.Add(this.tpWorkers);
            this.tabControl1.Controls.Add(this.tpHousing);
            this.tabControl1.Controls.Add(this.tpCombat);
            this.tabControl1.Controls.Add(this.tpResearch);
            this.tabControl1.Location = new System.Drawing.Point(3, 245);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(668, 163);
            this.tabControl1.TabIndex = 0;
            // 
            // tpStorage
            // 
            this.tpStorage.BackColor = System.Drawing.Color.Tan;
            this.tpStorage.Controls.Add(this.pnlIronStorage);
            this.tpStorage.Controls.Add(this.pnlFoodStorage);
            this.tpStorage.Controls.Add(this.pnlStoneStorage);
            this.tpStorage.Controls.Add(this.pnlWoodStorage);
            this.tpStorage.Location = new System.Drawing.Point(4, 22);
            this.tpStorage.Name = "tpStorage";
            this.tpStorage.Padding = new System.Windows.Forms.Padding(3);
            this.tpStorage.Size = new System.Drawing.Size(660, 137);
            this.tpStorage.TabIndex = 0;
            this.tpStorage.Text = "Storage";
            // 
            // pnlIronStorage
            // 
            this.pnlIronStorage.Controls.Add(this.label28);
            this.pnlIronStorage.Controls.Add(this.btnMetalStorage);
            this.pnlIronStorage.Controls.Add(this.lblMetalStorageCost);
            this.pnlIronStorage.Location = new System.Drawing.Point(398, 15);
            this.pnlIronStorage.Name = "pnlIronStorage";
            this.pnlIronStorage.Size = new System.Drawing.Size(120, 113);
            this.pnlIronStorage.TabIndex = 14;
            // 
            // label28
            // 
            this.label28.Location = new System.Drawing.Point(0, 83);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(120, 30);
            this.label28.TabIndex = 22;
            this.label28.Text = "Increases metal storage by 500";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMetalStorage
            // 
            this.btnMetalStorage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMetalStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMetalStorage.Location = new System.Drawing.Point(0, 0);
            this.btnMetalStorage.Name = "btnMetalStorage";
            this.btnMetalStorage.Size = new System.Drawing.Size(120, 50);
            this.btnMetalStorage.TabIndex = 0;
            this.btnMetalStorage.Text = "Metal Storage";
            this.btnMetalStorage.UseVisualStyleBackColor = false;
            this.btnMetalStorage.Click += new System.EventHandler(this.btnMetalStorage_Click);
            // 
            // lblMetalStorageCost
            // 
            this.lblMetalStorageCost.Location = new System.Drawing.Point(0, 52);
            this.lblMetalStorageCost.Name = "lblMetalStorageCost";
            this.lblMetalStorageCost.Size = new System.Drawing.Size(120, 30);
            this.lblMetalStorageCost.TabIndex = 4;
            this.lblMetalStorageCost.Text = "Cost: 100 wood";
            this.lblMetalStorageCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlFoodStorage
            // 
            this.pnlFoodStorage.Controls.Add(this.label27);
            this.pnlFoodStorage.Controls.Add(this.btnFoodStorage);
            this.pnlFoodStorage.Controls.Add(this.lblFoodStorageCost);
            this.pnlFoodStorage.Location = new System.Drawing.Point(270, 15);
            this.pnlFoodStorage.Name = "pnlFoodStorage";
            this.pnlFoodStorage.Size = new System.Drawing.Size(120, 113);
            this.pnlFoodStorage.TabIndex = 15;
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(0, 83);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(120, 30);
            this.label27.TabIndex = 21;
            this.label27.Text = "Increases food storage by 1000";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFoodStorage
            // 
            this.btnFoodStorage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnFoodStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodStorage.Location = new System.Drawing.Point(0, 0);
            this.btnFoodStorage.Name = "btnFoodStorage";
            this.btnFoodStorage.Size = new System.Drawing.Size(120, 50);
            this.btnFoodStorage.TabIndex = 0;
            this.btnFoodStorage.Text = "Food Storage";
            this.btnFoodStorage.UseVisualStyleBackColor = false;
            this.btnFoodStorage.Click += new System.EventHandler(this.btnFoodStorage_Click);
            // 
            // lblFoodStorageCost
            // 
            this.lblFoodStorageCost.Location = new System.Drawing.Point(0, 52);
            this.lblFoodStorageCost.Name = "lblFoodStorageCost";
            this.lblFoodStorageCost.Size = new System.Drawing.Size(120, 31);
            this.lblFoodStorageCost.TabIndex = 4;
            this.lblFoodStorageCost.Text = "Cost: 50 wood";
            this.lblFoodStorageCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlStoneStorage
            // 
            this.pnlStoneStorage.Controls.Add(this.label26);
            this.pnlStoneStorage.Controls.Add(this.btnStoneStorage);
            this.pnlStoneStorage.Controls.Add(this.lblStoneStorageCost);
            this.pnlStoneStorage.Location = new System.Drawing.Point(142, 15);
            this.pnlStoneStorage.Name = "pnlStoneStorage";
            this.pnlStoneStorage.Size = new System.Drawing.Size(120, 113);
            this.pnlStoneStorage.TabIndex = 13;
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(0, 83);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(120, 30);
            this.label26.TabIndex = 20;
            this.label26.Text = "Increases stone storage by 1000";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStoneStorage
            // 
            this.btnStoneStorage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnStoneStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoneStorage.Location = new System.Drawing.Point(0, 0);
            this.btnStoneStorage.Name = "btnStoneStorage";
            this.btnStoneStorage.Size = new System.Drawing.Size(120, 50);
            this.btnStoneStorage.TabIndex = 0;
            this.btnStoneStorage.Text = "Stone Storage";
            this.btnStoneStorage.UseVisualStyleBackColor = false;
            this.btnStoneStorage.Click += new System.EventHandler(this.btnStoneStorage_Click);
            // 
            // lblStoneStorageCost
            // 
            this.lblStoneStorageCost.Location = new System.Drawing.Point(0, 53);
            this.lblStoneStorageCost.Name = "lblStoneStorageCost";
            this.lblStoneStorageCost.Size = new System.Drawing.Size(120, 30);
            this.lblStoneStorageCost.TabIndex = 4;
            this.lblStoneStorageCost.Text = "Cost: 50 wood";
            this.lblStoneStorageCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlWoodStorage
            // 
            this.pnlWoodStorage.Controls.Add(this.label25);
            this.pnlWoodStorage.Controls.Add(this.btnWoodStorage);
            this.pnlWoodStorage.Controls.Add(this.lblWoodStorageCost);
            this.pnlWoodStorage.Location = new System.Drawing.Point(15, 15);
            this.pnlWoodStorage.Name = "pnlWoodStorage";
            this.pnlWoodStorage.Size = new System.Drawing.Size(120, 113);
            this.pnlWoodStorage.TabIndex = 12;
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(0, 83);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(120, 30);
            this.label25.TabIndex = 19;
            this.label25.Text = "Increases wood storage by 1000";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWoodStorage
            // 
            this.btnWoodStorage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnWoodStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWoodStorage.Location = new System.Drawing.Point(0, 0);
            this.btnWoodStorage.Name = "btnWoodStorage";
            this.btnWoodStorage.Size = new System.Drawing.Size(120, 50);
            this.btnWoodStorage.TabIndex = 0;
            this.btnWoodStorage.Text = "Wood Storage";
            this.btnWoodStorage.UseVisualStyleBackColor = false;
            this.btnWoodStorage.Click += new System.EventHandler(this.btnWoodStorage_Click);
            // 
            // lblWoodStorageCost
            // 
            this.lblWoodStorageCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWoodStorageCost.Location = new System.Drawing.Point(0, 53);
            this.lblWoodStorageCost.Name = "lblWoodStorageCost";
            this.lblWoodStorageCost.Size = new System.Drawing.Size(120, 30);
            this.lblWoodStorageCost.TabIndex = 4;
            this.lblWoodStorageCost.Text = "Cost: 50 wood";
            this.lblWoodStorageCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tpWorkers
            // 
            this.tpWorkers.BackColor = System.Drawing.Color.Olive;
            this.tpWorkers.Controls.Add(this.pnlTroops);
            this.tpWorkers.Controls.Add(this.pnlMiner);
            this.tpWorkers.Controls.Add(this.pnlButcher);
            this.tpWorkers.Controls.Add(this.pnlQuarrier);
            this.tpWorkers.Controls.Add(this.pnlGatherer);
            this.tpWorkers.Location = new System.Drawing.Point(4, 22);
            this.tpWorkers.Name = "tpWorkers";
            this.tpWorkers.Padding = new System.Windows.Forms.Padding(3);
            this.tpWorkers.Size = new System.Drawing.Size(660, 137);
            this.tpWorkers.TabIndex = 1;
            this.tpWorkers.Text = "Workers";
            // 
            // pnlTroops
            // 
            this.pnlTroops.Controls.Add(this.label24);
            this.pnlTroops.Controls.Add(this.btnTroop);
            this.pnlTroops.Controls.Add(this.lblTroopCost);
            this.pnlTroops.Location = new System.Drawing.Point(525, 15);
            this.pnlTroops.Name = "pnlTroops";
            this.pnlTroops.Size = new System.Drawing.Size(120, 113);
            this.pnlTroops.TabIndex = 17;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(0, 83);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(120, 30);
            this.label24.TabIndex = 21;
            this.label24.Text = "Increases troop amount by 1";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTroop
            // 
            this.btnTroop.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTroop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTroop.Location = new System.Drawing.Point(0, 0);
            this.btnTroop.Name = "btnTroop";
            this.btnTroop.Size = new System.Drawing.Size(120, 50);
            this.btnTroop.TabIndex = 2;
            this.btnTroop.Text = "Troop";
            this.btnTroop.UseVisualStyleBackColor = false;
            this.btnTroop.Click += new System.EventHandler(this.btnTroop_Click);
            // 
            // lblTroopCost
            // 
            this.lblTroopCost.Location = new System.Drawing.Point(0, 53);
            this.lblTroopCost.Name = "lblTroopCost";
            this.lblTroopCost.Size = new System.Drawing.Size(120, 30);
            this.lblTroopCost.TabIndex = 7;
            this.lblTroopCost.Text = "Cost: 200 metal, 1 housing";
            this.lblTroopCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlMiner
            // 
            this.pnlMiner.Controls.Add(this.label23);
            this.pnlMiner.Controls.Add(this.btnMiner);
            this.pnlMiner.Controls.Add(this.lblMinerCost);
            this.pnlMiner.Location = new System.Drawing.Point(398, 15);
            this.pnlMiner.Name = "pnlMiner";
            this.pnlMiner.Size = new System.Drawing.Size(120, 113);
            this.pnlMiner.TabIndex = 16;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(0, 83);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(120, 30);
            this.label23.TabIndex = 21;
            this.label23.Text = "Increases metal rate by 1";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMiner
            // 
            this.btnMiner.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMiner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiner.Location = new System.Drawing.Point(0, 0);
            this.btnMiner.Name = "btnMiner";
            this.btnMiner.Size = new System.Drawing.Size(120, 50);
            this.btnMiner.TabIndex = 2;
            this.btnMiner.Text = "Miner";
            this.btnMiner.UseVisualStyleBackColor = false;
            this.btnMiner.Click += new System.EventHandler(this.btnMiner_Click);
            // 
            // lblMinerCost
            // 
            this.lblMinerCost.Location = new System.Drawing.Point(0, 53);
            this.lblMinerCost.Name = "lblMinerCost";
            this.lblMinerCost.Size = new System.Drawing.Size(120, 30);
            this.lblMinerCost.TabIndex = 7;
            this.lblMinerCost.Text = "Cost: 200 food, 1 housing";
            this.lblMinerCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlButcher
            // 
            this.pnlButcher.Controls.Add(this.label22);
            this.pnlButcher.Controls.Add(this.btnButcher);
            this.pnlButcher.Controls.Add(this.lblButcherCost);
            this.pnlButcher.Location = new System.Drawing.Point(270, 15);
            this.pnlButcher.Name = "pnlButcher";
            this.pnlButcher.Size = new System.Drawing.Size(120, 113);
            this.pnlButcher.TabIndex = 15;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(0, 83);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(120, 30);
            this.label22.TabIndex = 20;
            this.label22.Text = "Increases food rate by 5";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnButcher
            // 
            this.btnButcher.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnButcher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnButcher.Location = new System.Drawing.Point(0, 0);
            this.btnButcher.Name = "btnButcher";
            this.btnButcher.Size = new System.Drawing.Size(120, 50);
            this.btnButcher.TabIndex = 3;
            this.btnButcher.Text = "Butcher";
            this.btnButcher.UseVisualStyleBackColor = false;
            this.btnButcher.Click += new System.EventHandler(this.btnButcher_Click);
            // 
            // lblButcherCost
            // 
            this.lblButcherCost.Location = new System.Drawing.Point(0, 53);
            this.lblButcherCost.Name = "lblButcherCost";
            this.lblButcherCost.Size = new System.Drawing.Size(120, 30);
            this.lblButcherCost.TabIndex = 6;
            this.lblButcherCost.Text = "Cost: 100 food, 1 housing";
            this.lblButcherCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlQuarrier
            // 
            this.pnlQuarrier.Controls.Add(this.label21);
            this.pnlQuarrier.Controls.Add(this.btnQuarring);
            this.pnlQuarrier.Controls.Add(this.lblQuarrierCost);
            this.pnlQuarrier.Location = new System.Drawing.Point(142, 15);
            this.pnlQuarrier.Name = "pnlQuarrier";
            this.pnlQuarrier.Size = new System.Drawing.Size(120, 113);
            this.pnlQuarrier.TabIndex = 14;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(0, 83);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(120, 30);
            this.label21.TabIndex = 19;
            this.label21.Text = "Increases stone rate by 2";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuarring
            // 
            this.btnQuarring.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnQuarring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuarring.Location = new System.Drawing.Point(0, 0);
            this.btnQuarring.Name = "btnQuarring";
            this.btnQuarring.Size = new System.Drawing.Size(120, 50);
            this.btnQuarring.TabIndex = 1;
            this.btnQuarring.Text = "Quarrier";
            this.btnQuarring.UseVisualStyleBackColor = false;
            this.btnQuarring.Click += new System.EventHandler(this.btnQuarring_Click);
            // 
            // lblQuarrierCost
            // 
            this.lblQuarrierCost.Location = new System.Drawing.Point(0, 53);
            this.lblQuarrierCost.Name = "lblQuarrierCost";
            this.lblQuarrierCost.Size = new System.Drawing.Size(120, 30);
            this.lblQuarrierCost.TabIndex = 5;
            this.lblQuarrierCost.Text = "Cost: 100 food, 1 housing";
            this.lblQuarrierCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlGatherer
            // 
            this.pnlGatherer.Controls.Add(this.label20);
            this.pnlGatherer.Controls.Add(this.btnGatherer);
            this.pnlGatherer.Controls.Add(this.lblGathererCost);
            this.pnlGatherer.Location = new System.Drawing.Point(15, 15);
            this.pnlGatherer.Name = "pnlGatherer";
            this.pnlGatherer.Size = new System.Drawing.Size(120, 113);
            this.pnlGatherer.TabIndex = 13;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(0, 83);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 30);
            this.label20.TabIndex = 18;
            this.label20.Text = "Increases wood rate by 5";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGatherer
            // 
            this.btnGatherer.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGatherer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGatherer.Location = new System.Drawing.Point(0, 0);
            this.btnGatherer.Name = "btnGatherer";
            this.btnGatherer.Size = new System.Drawing.Size(120, 50);
            this.btnGatherer.TabIndex = 0;
            this.btnGatherer.Text = "Gatherer";
            this.btnGatherer.UseVisualStyleBackColor = false;
            this.btnGatherer.Click += new System.EventHandler(this.btnGatherer_Click);
            // 
            // lblGathererCost
            // 
            this.lblGathererCost.Location = new System.Drawing.Point(0, 53);
            this.lblGathererCost.Name = "lblGathererCost";
            this.lblGathererCost.Size = new System.Drawing.Size(120, 30);
            this.lblGathererCost.TabIndex = 4;
            this.lblGathererCost.Text = "Cost: 100 food, 1 housing";
            this.lblGathererCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tpHousing
            // 
            this.tpHousing.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tpHousing.Controls.Add(this.pnlBootcamp);
            this.tpHousing.Controls.Add(this.pnlBarracks);
            this.tpHousing.Controls.Add(this.pnlShack);
            this.tpHousing.Location = new System.Drawing.Point(4, 22);
            this.tpHousing.Name = "tpHousing";
            this.tpHousing.Size = new System.Drawing.Size(660, 137);
            this.tpHousing.TabIndex = 3;
            this.tpHousing.Text = "Housing";
            // 
            // pnlBootcamp
            // 
            this.pnlBootcamp.Controls.Add(this.label18);
            this.pnlBootcamp.Controls.Add(this.btnBootcamp);
            this.pnlBootcamp.Controls.Add(this.lblBootcampCost);
            this.pnlBootcamp.Location = new System.Drawing.Point(142, 15);
            this.pnlBootcamp.Name = "pnlBootcamp";
            this.pnlBootcamp.Size = new System.Drawing.Size(120, 113);
            this.pnlBootcamp.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(0, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(120, 30);
            this.label18.TabIndex = 12;
            this.label18.Text = "Increases housing space by 10";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBootcamp
            // 
            this.btnBootcamp.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBootcamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBootcamp.Location = new System.Drawing.Point(0, 0);
            this.btnBootcamp.Name = "btnBootcamp";
            this.btnBootcamp.Size = new System.Drawing.Size(120, 50);
            this.btnBootcamp.TabIndex = 1;
            this.btnBootcamp.Text = "Bootcamp";
            this.btnBootcamp.UseVisualStyleBackColor = false;
            this.btnBootcamp.Click += new System.EventHandler(this.btnBootcamp_Click);
            // 
            // lblBootcampCost
            // 
            this.lblBootcampCost.Location = new System.Drawing.Point(0, 53);
            this.lblBootcampCost.Name = "lblBootcampCost";
            this.lblBootcampCost.Size = new System.Drawing.Size(120, 30);
            this.lblBootcampCost.TabIndex = 2;
            this.lblBootcampCost.Text = "Cost: 100 stone";
            this.lblBootcampCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlBarracks
            // 
            this.pnlBarracks.Controls.Add(this.label19);
            this.pnlBarracks.Controls.Add(this.btnBarracks);
            this.pnlBarracks.Controls.Add(this.lblBarracksCost);
            this.pnlBarracks.Location = new System.Drawing.Point(270, 15);
            this.pnlBarracks.Name = "pnlBarracks";
            this.pnlBarracks.Size = new System.Drawing.Size(120, 113);
            this.pnlBarracks.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(0, 83);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 30);
            this.label19.TabIndex = 13;
            this.label19.Text = "Increases housing space by 20";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBarracks
            // 
            this.btnBarracks.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBarracks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarracks.Location = new System.Drawing.Point(0, 0);
            this.btnBarracks.Name = "btnBarracks";
            this.btnBarracks.Size = new System.Drawing.Size(120, 50);
            this.btnBarracks.TabIndex = 1;
            this.btnBarracks.Text = "Barracks";
            this.btnBarracks.UseVisualStyleBackColor = false;
            this.btnBarracks.Click += new System.EventHandler(this.btnBarracks_Click);
            // 
            // lblBarracksCost
            // 
            this.lblBarracksCost.Location = new System.Drawing.Point(0, 53);
            this.lblBarracksCost.Name = "lblBarracksCost";
            this.lblBarracksCost.Size = new System.Drawing.Size(120, 30);
            this.lblBarracksCost.TabIndex = 2;
            this.lblBarracksCost.Text = "Cost: 500 stone";
            this.lblBarracksCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlShack
            // 
            this.pnlShack.Controls.Add(this.label17);
            this.pnlShack.Controls.Add(this.btnShack);
            this.pnlShack.Controls.Add(this.lblShackCost);
            this.pnlShack.Location = new System.Drawing.Point(15, 15);
            this.pnlShack.Name = "pnlShack";
            this.pnlShack.Size = new System.Drawing.Size(120, 113);
            this.pnlShack.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(0, 83);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 30);
            this.label17.TabIndex = 11;
            this.label17.Text = "Increases housing space by 5";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShack
            // 
            this.btnShack.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnShack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShack.Location = new System.Drawing.Point(0, 0);
            this.btnShack.Name = "btnShack";
            this.btnShack.Size = new System.Drawing.Size(120, 50);
            this.btnShack.TabIndex = 1;
            this.btnShack.Text = "Shack";
            this.btnShack.UseVisualStyleBackColor = false;
            this.btnShack.Click += new System.EventHandler(this.btnShack_Click);
            // 
            // lblShackCost
            // 
            this.lblShackCost.Location = new System.Drawing.Point(0, 53);
            this.lblShackCost.Name = "lblShackCost";
            this.lblShackCost.Size = new System.Drawing.Size(120, 30);
            this.lblShackCost.TabIndex = 2;
            this.lblShackCost.Text = "Cost: 50 stone";
            this.lblShackCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tpCombat
            // 
            this.tpCombat.BackColor = System.Drawing.Color.Firebrick;
            this.tpCombat.Controls.Add(this.panel7);
            this.tpCombat.Controls.Add(this.panel8);
            this.tpCombat.Controls.Add(this.panel9);
            this.tpCombat.Location = new System.Drawing.Point(4, 22);
            this.tpCombat.Name = "tpCombat";
            this.tpCombat.Size = new System.Drawing.Size(660, 137);
            this.tpCombat.TabIndex = 4;
            this.tpCombat.Text = "Combat";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.btnAttack);
            this.panel7.Controls.Add(this.lblAttackCost);
            this.panel7.Location = new System.Drawing.Point(270, 15);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(120, 113);
            this.panel7.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(0, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 30);
            this.label16.TabIndex = 12;
            this.label16.Text = "Increases troop damage by 300";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAttack
            // 
            this.btnAttack.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttack.Location = new System.Drawing.Point(0, 0);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(120, 50);
            this.btnAttack.TabIndex = 1;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // lblAttackCost
            // 
            this.lblAttackCost.Location = new System.Drawing.Point(0, 53);
            this.lblAttackCost.Name = "lblAttackCost";
            this.lblAttackCost.Size = new System.Drawing.Size(120, 30);
            this.lblAttackCost.TabIndex = 2;
            this.lblAttackCost.Text = "Cost:  300 metal";
            this.lblAttackCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label15);
            this.panel8.Controls.Add(this.btnBlock);
            this.panel8.Controls.Add(this.lblBlockCost);
            this.panel8.Location = new System.Drawing.Point(142, 15);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(120, 113);
            this.panel8.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(0, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 30);
            this.label15.TabIndex = 11;
            this.label15.Text = "Increases troop block by 250";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBlock
            // 
            this.btnBlock.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlock.Location = new System.Drawing.Point(0, 0);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(120, 50);
            this.btnBlock.TabIndex = 1;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = false;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // lblBlockCost
            // 
            this.lblBlockCost.Location = new System.Drawing.Point(0, 53);
            this.lblBlockCost.Name = "lblBlockCost";
            this.lblBlockCost.Size = new System.Drawing.Size(120, 30);
            this.lblBlockCost.TabIndex = 2;
            this.lblBlockCost.Text = "Cost: 500 metal";
            this.lblBlockCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label14);
            this.panel9.Controls.Add(this.btnHealth);
            this.panel9.Controls.Add(this.lblHealthCost);
            this.panel9.Location = new System.Drawing.Point(15, 15);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(120, 113);
            this.panel9.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(0, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 30);
            this.label14.TabIndex = 10;
            this.label14.Text = "Increases troop health by 100";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHealth
            // 
            this.btnHealth.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnHealth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHealth.Location = new System.Drawing.Point(0, 0);
            this.btnHealth.Name = "btnHealth";
            this.btnHealth.Size = new System.Drawing.Size(120, 50);
            this.btnHealth.TabIndex = 1;
            this.btnHealth.Text = "Health";
            this.btnHealth.UseVisualStyleBackColor = false;
            this.btnHealth.Click += new System.EventHandler(this.btnHealth_Click);
            // 
            // lblHealthCost
            // 
            this.lblHealthCost.Location = new System.Drawing.Point(0, 53);
            this.lblHealthCost.Name = "lblHealthCost";
            this.lblHealthCost.Size = new System.Drawing.Size(120, 30);
            this.lblHealthCost.TabIndex = 2;
            this.lblHealthCost.Text = "Cost: 200 metal";
            this.lblHealthCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tpResearch
            // 
            this.tpResearch.BackColor = System.Drawing.Color.MediumPurple;
            this.tpResearch.Controls.Add(this.panel6);
            this.tpResearch.Controls.Add(this.pnlHushing);
            this.tpResearch.Controls.Add(this.pnlTripHammer);
            this.tpResearch.Controls.Add(this.pnlStampMill);
            this.tpResearch.Controls.Add(this.pnlAquaducts);
            this.tpResearch.Location = new System.Drawing.Point(4, 22);
            this.tpResearch.Name = "tpResearch";
            this.tpResearch.Size = new System.Drawing.Size(660, 137);
            this.tpResearch.TabIndex = 2;
            this.tpResearch.Text = "Research";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.btnVilla);
            this.panel6.Controls.Add(this.lblVillaCost);
            this.panel6.Location = new System.Drawing.Point(525, 15);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(120, 113);
            this.panel6.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(0, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 30);
            this.label13.TabIndex = 12;
            this.label13.Text = "Increases housing space by 3x";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVilla
            // 
            this.btnVilla.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnVilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVilla.Location = new System.Drawing.Point(0, 0);
            this.btnVilla.Name = "btnVilla";
            this.btnVilla.Size = new System.Drawing.Size(120, 50);
            this.btnVilla.TabIndex = 1;
            this.btnVilla.Text = "Villa";
            this.btnVilla.UseVisualStyleBackColor = false;
            this.btnVilla.Click += new System.EventHandler(this.btnVilla_Click);
            // 
            // lblVillaCost
            // 
            this.lblVillaCost.Location = new System.Drawing.Point(0, 53);
            this.lblVillaCost.Name = "lblVillaCost";
            this.lblVillaCost.Size = new System.Drawing.Size(120, 30);
            this.lblVillaCost.TabIndex = 2;
            this.lblVillaCost.Text = "Cost: 5000 science";
            this.lblVillaCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlHushing
            // 
            this.pnlHushing.Controls.Add(this.label12);
            this.pnlHushing.Controls.Add(this.btnHushing);
            this.pnlHushing.Controls.Add(this.lblHushingCost);
            this.pnlHushing.Location = new System.Drawing.Point(398, 15);
            this.pnlHushing.Name = "pnlHushing";
            this.pnlHushing.Size = new System.Drawing.Size(120, 113);
            this.pnlHushing.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(0, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 30);
            this.label12.TabIndex = 11;
            this.label12.Text = "Increases metal rate by 5x";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHushing
            // 
            this.btnHushing.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnHushing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHushing.Location = new System.Drawing.Point(0, 0);
            this.btnHushing.Name = "btnHushing";
            this.btnHushing.Size = new System.Drawing.Size(120, 50);
            this.btnHushing.TabIndex = 1;
            this.btnHushing.Text = "Hushing";
            this.btnHushing.UseVisualStyleBackColor = false;
            this.btnHushing.Click += new System.EventHandler(this.btnHushing_Click);
            // 
            // lblHushingCost
            // 
            this.lblHushingCost.Location = new System.Drawing.Point(0, 53);
            this.lblHushingCost.Name = "lblHushingCost";
            this.lblHushingCost.Size = new System.Drawing.Size(120, 30);
            this.lblHushingCost.TabIndex = 2;
            this.lblHushingCost.Text = "Cost: 3000 science";
            this.lblHushingCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlTripHammer
            // 
            this.pnlTripHammer.Controls.Add(this.label11);
            this.pnlTripHammer.Controls.Add(this.btnTripHammer);
            this.pnlTripHammer.Controls.Add(this.lblTripHammerCost);
            this.pnlTripHammer.Location = new System.Drawing.Point(270, 15);
            this.pnlTripHammer.Name = "pnlTripHammer";
            this.pnlTripHammer.Size = new System.Drawing.Size(120, 113);
            this.pnlTripHammer.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(0, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 30);
            this.label11.TabIndex = 10;
            this.label11.Text = "Increases metal rate by 2x";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTripHammer
            // 
            this.btnTripHammer.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTripHammer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTripHammer.Location = new System.Drawing.Point(0, 0);
            this.btnTripHammer.Name = "btnTripHammer";
            this.btnTripHammer.Size = new System.Drawing.Size(120, 50);
            this.btnTripHammer.TabIndex = 1;
            this.btnTripHammer.Text = "Trip-hammer";
            this.btnTripHammer.UseVisualStyleBackColor = false;
            this.btnTripHammer.Click += new System.EventHandler(this.btnTripHammer_Click);
            // 
            // lblTripHammerCost
            // 
            this.lblTripHammerCost.Location = new System.Drawing.Point(0, 53);
            this.lblTripHammerCost.Name = "lblTripHammerCost";
            this.lblTripHammerCost.Size = new System.Drawing.Size(120, 30);
            this.lblTripHammerCost.TabIndex = 2;
            this.lblTripHammerCost.Text = "Cost: 1000 science";
            this.lblTripHammerCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlStampMill
            // 
            this.pnlStampMill.Controls.Add(this.label10);
            this.pnlStampMill.Controls.Add(this.btnStampMill);
            this.pnlStampMill.Controls.Add(this.lblStampMillCost);
            this.pnlStampMill.Location = new System.Drawing.Point(142, 15);
            this.pnlStampMill.Name = "pnlStampMill";
            this.pnlStampMill.Size = new System.Drawing.Size(120, 113);
            this.pnlStampMill.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(0, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 30);
            this.label10.TabIndex = 9;
            this.label10.Text = "Increases stone rate by 2x";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStampMill
            // 
            this.btnStampMill.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnStampMill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStampMill.Location = new System.Drawing.Point(0, 0);
            this.btnStampMill.Name = "btnStampMill";
            this.btnStampMill.Size = new System.Drawing.Size(120, 50);
            this.btnStampMill.TabIndex = 1;
            this.btnStampMill.Text = "Stamp-mill";
            this.btnStampMill.UseVisualStyleBackColor = false;
            this.btnStampMill.Click += new System.EventHandler(this.btnStampMill_Click);
            // 
            // lblStampMillCost
            // 
            this.lblStampMillCost.Location = new System.Drawing.Point(0, 53);
            this.lblStampMillCost.Name = "lblStampMillCost";
            this.lblStampMillCost.Size = new System.Drawing.Size(120, 30);
            this.lblStampMillCost.TabIndex = 2;
            this.lblStampMillCost.Text = "Cost: 500 science";
            this.lblStampMillCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlAquaducts
            // 
            this.pnlAquaducts.Controls.Add(this.btnAquaducts);
            this.pnlAquaducts.Controls.Add(this.label3);
            this.pnlAquaducts.Controls.Add(this.lblAqueductsCost);
            this.pnlAquaducts.Location = new System.Drawing.Point(15, 15);
            this.pnlAquaducts.Name = "pnlAquaducts";
            this.pnlAquaducts.Size = new System.Drawing.Size(120, 113);
            this.pnlAquaducts.TabIndex = 4;
            // 
            // btnAquaducts
            // 
            this.btnAquaducts.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAquaducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAquaducts.Location = new System.Drawing.Point(0, 0);
            this.btnAquaducts.Name = "btnAquaducts";
            this.btnAquaducts.Size = new System.Drawing.Size(120, 50);
            this.btnAquaducts.TabIndex = 1;
            this.btnAquaducts.Text = "Aqueducts";
            this.btnAquaducts.UseVisualStyleBackColor = false;
            this.btnAquaducts.Click += new System.EventHandler(this.btnAquaducts_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Increases food and wood rate by 5x";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAqueductsCost
            // 
            this.lblAqueductsCost.Location = new System.Drawing.Point(0, 53);
            this.lblAqueductsCost.Name = "lblAqueductsCost";
            this.lblAqueductsCost.Size = new System.Drawing.Size(120, 30);
            this.lblAqueductsCost.TabIndex = 2;
            this.lblAqueductsCost.Text = "Cost: 100 science";
            this.lblAqueductsCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumPurple;
            this.panel5.Controls.Add(this.lblScienceAmount);
            this.panel5.Controls.Add(this.label30);
            this.panel5.Location = new System.Drawing.Point(466, 123);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 116);
            this.panel5.TabIndex = 8;
            // 
            // lblScienceAmount
            // 
            this.lblScienceAmount.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScienceAmount.Location = new System.Drawing.Point(4, 42);
            this.lblScienceAmount.Name = "lblScienceAmount";
            this.lblScienceAmount.Size = new System.Drawing.Size(193, 74);
            this.lblScienceAmount.TabIndex = 5;
            this.lblScienceAmount.Text = "0";
            this.lblScienceAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(57, 11);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(85, 28);
            this.label30.TabIndex = 5;
            this.label30.Text = "Science";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SkyBlue;
            this.panel4.Controls.Add(this.lblHousingSpace);
            this.panel4.Controls.Add(this.lblHousingCapacity);
            this.panel4.Controls.Add(this.pbHousing);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(466, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 116);
            this.panel4.TabIndex = 7;
            // 
            // lblHousingSpace
            // 
            this.lblHousingSpace.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHousingSpace.Location = new System.Drawing.Point(4, 92);
            this.lblHousingSpace.Name = "lblHousingSpace";
            this.lblHousingSpace.Size = new System.Drawing.Size(193, 21);
            this.lblHousingSpace.TabIndex = 6;
            this.lblHousingSpace.Text = "0 housing remaining";
            this.lblHousingSpace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHousingCapacity
            // 
            this.lblHousingCapacity.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHousingCapacity.Location = new System.Drawing.Point(4, 71);
            this.lblHousingCapacity.Name = "lblHousingCapacity";
            this.lblHousingCapacity.Size = new System.Drawing.Size(193, 21);
            this.lblHousingCapacity.TabIndex = 5;
            this.lblHousingCapacity.Text = "0 housing capacity";
            this.lblHousingCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbHousing
            // 
            this.pbHousing.Location = new System.Drawing.Point(4, 42);
            this.pbHousing.Name = "pbHousing";
            this.pbHousing.Size = new System.Drawing.Size(194, 23);
            this.pbHousing.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Housing";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Firebrick;
            this.panel3.Controls.Add(this.lblMetalAmount);
            this.panel3.Controls.Add(this.lblMetalRate);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.pbMetal);
            this.panel3.Controls.Add(this.btnMine);
            this.panel3.Location = new System.Drawing.Point(235, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 116);
            this.panel3.TabIndex = 6;
            // 
            // lblMetalAmount
            // 
            this.lblMetalAmount.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetalAmount.Location = new System.Drawing.Point(157, 68);
            this.lblMetalAmount.Name = "lblMetalAmount";
            this.lblMetalAmount.Size = new System.Drawing.Size(69, 48);
            this.lblMetalAmount.TabIndex = 4;
            this.lblMetalAmount.Text = "0";
            this.lblMetalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetalRate
            // 
            this.lblMetalRate.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetalRate.Location = new System.Drawing.Point(3, 68);
            this.lblMetalRate.Name = "lblMetalRate";
            this.lblMetalRate.Size = new System.Drawing.Size(72, 48);
            this.lblMetalRate.TabIndex = 3;
            this.lblMetalRate.Text = "+0/sec";
            this.lblMetalRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Metal";
            // 
            // pbMetal
            // 
            this.pbMetal.Location = new System.Drawing.Point(3, 42);
            this.pbMetal.Name = "pbMetal";
            this.pbMetal.Size = new System.Drawing.Size(223, 23);
            this.pbMetal.TabIndex = 1;
            // 
            // btnMine
            // 
            this.btnMine.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMine.Location = new System.Drawing.Point(76, 71);
            this.btnMine.Name = "btnMine";
            this.btnMine.Size = new System.Drawing.Size(75, 23);
            this.btnMine.TabIndex = 0;
            this.btnMine.Text = "Mine";
            this.btnMine.UseVisualStyleBackColor = false;
            this.btnMine.Click += new System.EventHandler(this.BtnMineClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Olive;
            this.panel2.Controls.Add(this.lblFoodAmount);
            this.panel2.Controls.Add(this.lblFoodRate);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pbFood);
            this.panel2.Controls.Add(this.btnFarm);
            this.panel2.Location = new System.Drawing.Point(3, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 116);
            this.panel2.TabIndex = 5;
            // 
            // lblFoodAmount
            // 
            this.lblFoodAmount.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodAmount.Location = new System.Drawing.Point(157, 68);
            this.lblFoodAmount.Name = "lblFoodAmount";
            this.lblFoodAmount.Size = new System.Drawing.Size(69, 48);
            this.lblFoodAmount.TabIndex = 4;
            this.lblFoodAmount.Text = "0";
            this.lblFoodAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFoodRate
            // 
            this.lblFoodRate.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodRate.Location = new System.Drawing.Point(3, 68);
            this.lblFoodRate.Name = "lblFoodRate";
            this.lblFoodRate.Size = new System.Drawing.Size(72, 48);
            this.lblFoodRate.TabIndex = 3;
            this.lblFoodRate.Text = "+0/sec";
            this.lblFoodRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Food";
            // 
            // pbFood
            // 
            this.pbFood.Location = new System.Drawing.Point(3, 42);
            this.pbFood.Name = "pbFood";
            this.pbFood.Size = new System.Drawing.Size(223, 23);
            this.pbFood.TabIndex = 1;
            // 
            // btnFarm
            // 
            this.btnFarm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFarm.Location = new System.Drawing.Point(76, 71);
            this.btnFarm.Name = "btnFarm";
            this.btnFarm.Size = new System.Drawing.Size(75, 23);
            this.btnFarm.TabIndex = 0;
            this.btnFarm.Text = "Farm";
            this.btnFarm.UseVisualStyleBackColor = false;
            this.btnFarm.Click += new System.EventHandler(this.BtnFarmClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.lblStoneAmount);
            this.panel1.Controls.Add(this.lblStoneRate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pbStone);
            this.panel1.Controls.Add(this.btnQuarrier);
            this.panel1.Location = new System.Drawing.Point(235, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 116);
            this.panel1.TabIndex = 5;
            // 
            // lblStoneAmount
            // 
            this.lblStoneAmount.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoneAmount.Location = new System.Drawing.Point(157, 71);
            this.lblStoneAmount.Name = "lblStoneAmount";
            this.lblStoneAmount.Size = new System.Drawing.Size(69, 42);
            this.lblStoneAmount.TabIndex = 4;
            this.lblStoneAmount.Text = "0";
            this.lblStoneAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStoneRate
            // 
            this.lblStoneRate.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoneRate.Location = new System.Drawing.Point(3, 68);
            this.lblStoneRate.Name = "lblStoneRate";
            this.lblStoneRate.Size = new System.Drawing.Size(72, 45);
            this.lblStoneRate.TabIndex = 3;
            this.lblStoneRate.Text = "+0/sec";
            this.lblStoneRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Stone";
            // 
            // pbStone
            // 
            this.pbStone.Location = new System.Drawing.Point(3, 42);
            this.pbStone.Name = "pbStone";
            this.pbStone.Size = new System.Drawing.Size(223, 23);
            this.pbStone.TabIndex = 1;
            // 
            // btnQuarrier
            // 
            this.btnQuarrier.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnQuarrier.Location = new System.Drawing.Point(76, 73);
            this.btnQuarrier.Name = "btnQuarrier";
            this.btnQuarrier.Size = new System.Drawing.Size(75, 23);
            this.btnQuarrier.TabIndex = 0;
            this.btnQuarrier.Text = "Excavate";
            this.btnQuarrier.UseVisualStyleBackColor = false;
            this.btnQuarrier.Click += new System.EventHandler(this.BtnQuarrierClick);
            // 
            // pnlWood
            // 
            this.pnlWood.BackColor = System.Drawing.Color.Tan;
            this.pnlWood.Controls.Add(this.lblWoodAmount);
            this.pnlWood.Controls.Add(this.lblWoodRate);
            this.pnlWood.Controls.Add(this.label1);
            this.pnlWood.Controls.Add(this.pbWood);
            this.pnlWood.Controls.Add(this.btnGather);
            this.pnlWood.Location = new System.Drawing.Point(3, 3);
            this.pnlWood.Name = "pnlWood";
            this.pnlWood.Size = new System.Drawing.Size(229, 116);
            this.pnlWood.TabIndex = 0;
            // 
            // lblWoodAmount
            // 
            this.lblWoodAmount.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWoodAmount.Location = new System.Drawing.Point(157, 68);
            this.lblWoodAmount.Name = "lblWoodAmount";
            this.lblWoodAmount.Size = new System.Drawing.Size(69, 45);
            this.lblWoodAmount.TabIndex = 4;
            this.lblWoodAmount.Text = "0";
            this.lblWoodAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWoodRate
            // 
            this.lblWoodRate.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWoodRate.Location = new System.Drawing.Point(3, 68);
            this.lblWoodRate.Name = "lblWoodRate";
            this.lblWoodRate.Size = new System.Drawing.Size(72, 45);
            this.lblWoodRate.TabIndex = 3;
            this.lblWoodRate.Text = "+0/sec";
            this.lblWoodRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wood";
            // 
            // pbWood
            // 
            this.pbWood.Location = new System.Drawing.Point(3, 42);
            this.pbWood.Name = "pbWood";
            this.pbWood.Size = new System.Drawing.Size(223, 23);
            this.pbWood.TabIndex = 1;
            // 
            // btnGather
            // 
            this.btnGather.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGather.Location = new System.Drawing.Point(76, 71);
            this.btnGather.Name = "btnGather";
            this.btnGather.Size = new System.Drawing.Size(75, 23);
            this.btnGather.TabIndex = 0;
            this.btnGather.Text = "Gather";
            this.btnGather.UseVisualStyleBackColor = false;
            this.btnGather.Click += new System.EventHandler(this.BtnGatherClick);
            // 
            // globalTimer
            // 
            this.globalTimer.Enabled = true;
            this.globalTimer.Interval = 1000;
            this.globalTimer.Tick += new System.EventHandler(this.GlobalTimerTick);
            // 
            // pnlCombat
            // 
            this.pnlCombat.Controls.Add(this.lblCurrentYear);
            this.pnlCombat.Controls.Add(this.label34);
            this.pnlCombat.Controls.Add(this.label33);
            this.pnlCombat.Controls.Add(this.pbxGrid);
            this.pnlCombat.Controls.Add(this.lblPlayerTiles);
            this.pnlCombat.Controls.Add(this.lblWarDesciption);
            this.pnlCombat.Controls.Add(this.lblEnemyTiles);
            this.pnlCombat.Controls.Add(this.lblPlayerStats);
            this.pnlCombat.Controls.Add(this.lblEnemyStats);
            this.pnlCombat.Location = new System.Drawing.Point(4, 48);
            this.pnlCombat.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCombat.Name = "pnlCombat";
            this.pnlCombat.Size = new System.Drawing.Size(526, 415);
            this.pnlCombat.TabIndex = 7;
            // 
            // lblCurrentYear
            // 
            this.lblCurrentYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentYear.Location = new System.Drawing.Point(330, 177);
            this.lblCurrentYear.Name = "lblCurrentYear";
            this.lblCurrentYear.Size = new System.Drawing.Size(195, 28);
            this.lblCurrentYear.TabIndex = 8;
            this.lblCurrentYear.Text = "Year: 500 BC";
            // 
            // label34
            // 
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(83, 367);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(87, 39);
            this.label34.TabIndex = 7;
            this.label34.Text = "Player";
            // 
            // label33
            // 
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(83, 5);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(87, 39);
            this.label33.TabIndex = 6;
            this.label33.Text = "Enemy";
            // 
            // pbxGrid
            // 
            this.pbxGrid.Location = new System.Drawing.Point(3, 70);
            this.pbxGrid.Name = "pbxGrid";
            this.pbxGrid.Size = new System.Drawing.Size(325, 260);
            this.pbxGrid.TabIndex = 5;
            this.pbxGrid.TabStop = false;
            // 
            // lblPlayerTiles
            // 
            this.lblPlayerTiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTiles.Location = new System.Drawing.Point(334, 290);
            this.lblPlayerTiles.Name = "lblPlayerTiles";
            this.lblPlayerTiles.Size = new System.Drawing.Size(191, 45);
            this.lblPlayerTiles.TabIndex = 4;
            this.lblPlayerTiles.Text = "Allied occupied tiles: 10";
            // 
            // lblWarDesciption
            // 
            this.lblWarDesciption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarDesciption.Location = new System.Drawing.Point(330, 207);
            this.lblWarDesciption.Name = "lblWarDesciption";
            this.lblWarDesciption.Size = new System.Drawing.Size(195, 49);
            this.lblWarDesciption.TabIndex = 3;
            this.lblWarDesciption.Text = "The War of a War, 10 years remain";
            // 
            // lblEnemyTiles
            // 
            this.lblEnemyTiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyTiles.Location = new System.Drawing.Point(334, 81);
            this.lblEnemyTiles.Name = "lblEnemyTiles";
            this.lblEnemyTiles.Size = new System.Drawing.Size(191, 49);
            this.lblEnemyTiles.TabIndex = 2;
            this.lblEnemyTiles.Text = "Enemy occupied tiles: 10";
            // 
            // lblPlayerStats
            // 
            this.lblPlayerStats.AutoSize = true;
            this.lblPlayerStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerStats.Location = new System.Drawing.Point(20, 333);
            this.lblPlayerStats.Name = "lblPlayerStats";
            this.lblPlayerStats.Size = new System.Drawing.Size(202, 20);
            this.lblPlayerStats.TabIndex = 1;
            this.lblPlayerStats.Text = "0/0 health, 0 attack, 0 block";
            // 
            // lblEnemyStats
            // 
            this.lblEnemyStats.AutoSize = true;
            this.lblEnemyStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyStats.Location = new System.Drawing.Point(20, 47);
            this.lblEnemyStats.Name = "lblEnemyStats";
            this.lblEnemyStats.Size = new System.Drawing.Size(205, 20);
            this.lblEnemyStats.TabIndex = 0;
            this.lblEnemyStats.Text = "0/0 Health, 0 attack, 0 block";
            // 
            // pnlLogs
            // 
            this.pnlLogs.Controls.Add(this.btnClearLogs);
            this.pnlLogs.Controls.Add(this.tabControl2);
            this.pnlLogs.Location = new System.Drawing.Point(3, 50);
            this.pnlLogs.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLogs.Name = "pnlLogs";
            this.pnlLogs.Size = new System.Drawing.Size(676, 404);
            this.pnlLogs.TabIndex = 8;
            // 
            // btnClearLogs
            // 
            this.btnClearLogs.Location = new System.Drawing.Point(282, 384);
            this.btnClearLogs.Name = "btnClearLogs";
            this.btnClearLogs.Size = new System.Drawing.Size(75, 23);
            this.btnClearLogs.TabIndex = 1;
            this.btnClearLogs.Text = "Clear";
            this.btnClearLogs.UseVisualStyleBackColor = true;
            this.btnClearLogs.Click += new System.EventHandler(this.btnClearLogs_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tpStoryLogs);
            this.tabControl2.Controls.Add(this.tpUpgradesLogs);
            this.tabControl2.Controls.Add(this.tpCombatLogs);
            this.tabControl2.Controls.Add(this.tpLootLogs);
            this.tabControl2.Controls.Add(this.tpSavesLogs);
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(670, 380);
            this.tabControl2.TabIndex = 0;
            // 
            // tpStoryLogs
            // 
            this.tpStoryLogs.Controls.Add(this.rtxtStoryLogs);
            this.tpStoryLogs.Location = new System.Drawing.Point(4, 22);
            this.tpStoryLogs.Name = "tpStoryLogs";
            this.tpStoryLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tpStoryLogs.Size = new System.Drawing.Size(662, 354);
            this.tpStoryLogs.TabIndex = 0;
            this.tpStoryLogs.Text = "Story";
            this.tpStoryLogs.UseVisualStyleBackColor = true;
            // 
            // rtxtStoryLogs
            // 
            this.rtxtStoryLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtStoryLogs.Location = new System.Drawing.Point(3, 3);
            this.rtxtStoryLogs.Name = "rtxtStoryLogs";
            this.rtxtStoryLogs.Size = new System.Drawing.Size(660, 350);
            this.rtxtStoryLogs.TabIndex = 0;
            this.rtxtStoryLogs.Text = "";
            // 
            // tpUpgradesLogs
            // 
            this.tpUpgradesLogs.Controls.Add(this.rtxtUpgrades);
            this.tpUpgradesLogs.Location = new System.Drawing.Point(4, 22);
            this.tpUpgradesLogs.Name = "tpUpgradesLogs";
            this.tpUpgradesLogs.Size = new System.Drawing.Size(662, 355);
            this.tpUpgradesLogs.TabIndex = 3;
            this.tpUpgradesLogs.Text = "Upgrades";
            this.tpUpgradesLogs.UseVisualStyleBackColor = true;
            // 
            // rtxtUpgrades
            // 
            this.rtxtUpgrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtUpgrades.Location = new System.Drawing.Point(3, 3);
            this.rtxtUpgrades.Name = "rtxtUpgrades";
            this.rtxtUpgrades.Size = new System.Drawing.Size(660, 350);
            this.rtxtUpgrades.TabIndex = 10;
            this.rtxtUpgrades.Text = "";
            // 
            // tpCombatLogs
            // 
            this.tpCombatLogs.Controls.Add(this.rtxtCombat);
            this.tpCombatLogs.Location = new System.Drawing.Point(4, 22);
            this.tpCombatLogs.Name = "tpCombatLogs";
            this.tpCombatLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tpCombatLogs.Size = new System.Drawing.Size(662, 355);
            this.tpCombatLogs.TabIndex = 1;
            this.tpCombatLogs.Text = "Combat";
            this.tpCombatLogs.UseVisualStyleBackColor = true;
            // 
            // rtxtCombat
            // 
            this.rtxtCombat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtCombat.Location = new System.Drawing.Point(3, 3);
            this.rtxtCombat.Name = "rtxtCombat";
            this.rtxtCombat.Size = new System.Drawing.Size(660, 350);
            this.rtxtCombat.TabIndex = 10;
            this.rtxtCombat.Text = "";
            // 
            // tpLootLogs
            // 
            this.tpLootLogs.Controls.Add(this.rtxtLoot);
            this.tpLootLogs.Location = new System.Drawing.Point(4, 22);
            this.tpLootLogs.Name = "tpLootLogs";
            this.tpLootLogs.Size = new System.Drawing.Size(662, 355);
            this.tpLootLogs.TabIndex = 2;
            this.tpLootLogs.Text = "Loot";
            this.tpLootLogs.UseVisualStyleBackColor = true;
            // 
            // rtxtLoot
            // 
            this.rtxtLoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtLoot.Location = new System.Drawing.Point(3, 3);
            this.rtxtLoot.Name = "rtxtLoot";
            this.rtxtLoot.Size = new System.Drawing.Size(660, 350);
            this.rtxtLoot.TabIndex = 10;
            this.rtxtLoot.Text = "";
            // 
            // tpSavesLogs
            // 
            this.tpSavesLogs.Controls.Add(this.rtxtSaves);
            this.tpSavesLogs.Location = new System.Drawing.Point(4, 22);
            this.tpSavesLogs.Name = "tpSavesLogs";
            this.tpSavesLogs.Size = new System.Drawing.Size(662, 355);
            this.tpSavesLogs.TabIndex = 4;
            this.tpSavesLogs.Text = "Saves";
            this.tpSavesLogs.UseVisualStyleBackColor = true;
            // 
            // rtxtSaves
            // 
            this.rtxtSaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtSaves.Location = new System.Drawing.Point(3, 3);
            this.rtxtSaves.Name = "rtxtSaves";
            this.rtxtSaves.Size = new System.Drawing.Size(660, 350);
            this.rtxtSaves.TabIndex = 10;
            this.rtxtSaves.Text = "";
            // 
            // pnlFileHandling
            // 
            this.pnlFileHandling.Controls.Add(this.lblTime);
            this.pnlFileHandling.Controls.Add(this.btnAutosaveOption);
            this.pnlFileHandling.Controls.Add(this.btnLoad);
            this.pnlFileHandling.Controls.Add(this.btnDelete);
            this.pnlFileHandling.Controls.Add(this.label7);
            this.pnlFileHandling.Controls.Add(this.btnSave);
            this.pnlFileHandling.Controls.Add(this.lblAutosaveStatus);
            this.pnlFileHandling.Location = new System.Drawing.Point(2, 34);
            this.pnlFileHandling.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFileHandling.Name = "pnlFileHandling";
            this.pnlFileHandling.Size = new System.Drawing.Size(236, 237);
            this.pnlFileHandling.TabIndex = 9;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(3, 199);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(229, 23);
            this.lblTime.TabIndex = 22;
            this.lblTime.Text = "Current time:";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAutosaveOption
            // 
            this.btnAutosaveOption.Location = new System.Drawing.Point(62, 146);
            this.btnAutosaveOption.Name = "btnAutosaveOption";
            this.btnAutosaveOption.Size = new System.Drawing.Size(98, 23);
            this.btnAutosaveOption.TabIndex = 20;
            this.btnAutosaveOption.Text = "Toggle Autosave";
            this.btnAutosaveOption.UseVisualStyleBackColor = true;
            this.btnAutosaveOption.Click += new System.EventHandler(this.btnAutosaveOption_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(62, 88);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(98, 23);
            this.btnLoad.TabIndex = 19;
            this.btnLoad.Text = "Load Game";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(62, 117);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete Save";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 44);
            this.label7.TabIndex = 17;
            this.label7.Text = "Save/Load";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(62, 60);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save Current";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblAutosaveStatus
            // 
            this.lblAutosaveStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutosaveStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAutosaveStatus.Location = new System.Drawing.Point(3, 172);
            this.lblAutosaveStatus.Name = "lblAutosaveStatus";
            this.lblAutosaveStatus.Size = new System.Drawing.Size(229, 23);
            this.lblAutosaveStatus.TabIndex = 5;
            this.lblAutosaveStatus.Text = "Autosaving: Off";
            this.lblAutosaveStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combatTimer
            // 
            this.combatTimer.Interval = 1000;
            this.combatTimer.Tick += new System.EventHandler(this.combatTimer_Tick);
            // 
            // nudChangeTick
            // 
            this.nudChangeTick.Location = new System.Drawing.Point(720, 310);
            this.nudChangeTick.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.nudChangeTick.Name = "nudChangeTick";
            this.nudChangeTick.Size = new System.Drawing.Size(120, 20);
            this.nudChangeTick.TabIndex = 10;
            // 
            // btnChangeTick
            // 
            this.btnChangeTick.Location = new System.Drawing.Point(720, 339);
            this.btnChangeTick.Name = "btnChangeTick";
            this.btnChangeTick.Size = new System.Drawing.Size(103, 23);
            this.btnChangeTick.TabIndex = 11;
            this.btnChangeTick.Text = "Change Tick";
            this.btnChangeTick.UseVisualStyleBackColor = true;
            this.btnChangeTick.Click += new System.EventHandler(this.btnChangeTick_Click);
            // 
            // rtxtTempOutput
            // 
            this.rtxtTempOutput.Location = new System.Drawing.Point(774, 383);
            this.rtxtTempOutput.Name = "rtxtTempOutput";
            this.rtxtTempOutput.Size = new System.Drawing.Size(71, 52);
            this.rtxtTempOutput.TabIndex = 12;
            this.rtxtTempOutput.Text = "";
            // 
            // btnPauseGame
            // 
            this.btnPauseGame.Location = new System.Drawing.Point(734, 281);
            this.btnPauseGame.Name = "btnPauseGame";
            this.btnPauseGame.Size = new System.Drawing.Size(75, 23);
            this.btnPauseGame.TabIndex = 13;
            this.btnPauseGame.Text = "Pause";
            this.btnPauseGame.UseVisualStyleBackColor = true;
            this.btnPauseGame.Click += new System.EventHandler(this.btnPauseGame_Click);
            // 
            // autosaveTimer
            // 
            this.autosaveTimer.Interval = 1000;
            this.autosaveTimer.Tick += new System.EventHandler(this.autosaveTimer_Tick);
            // 
            // pnlDebugging
            // 
            this.pnlDebugging.Controls.Add(this.label8);
            this.pnlDebugging.Location = new System.Drawing.Point(8, 37);
            this.pnlDebugging.Name = "pnlDebugging";
            this.pnlDebugging.Size = new System.Drawing.Size(631, 378);
            this.pnlDebugging.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(410, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tutorial - Look at this before you start";
            // 
            // openDialogue
            // 
            this.openDialogue.FileName = "autosave";
            this.openDialogue.Title = "Load File";
            // 
            // nudChangeHealth
            // 
            this.nudChangeHealth.Location = new System.Drawing.Point(703, 50);
            this.nudChangeHealth.Name = "nudChangeHealth";
            this.nudChangeHealth.Size = new System.Drawing.Size(120, 20);
            this.nudChangeHealth.TabIndex = 15;
            // 
            // btnChangeHealth
            // 
            this.btnChangeHealth.Location = new System.Drawing.Point(703, 76);
            this.btnChangeHealth.Name = "btnChangeHealth";
            this.btnChangeHealth.Size = new System.Drawing.Size(103, 23);
            this.btnChangeHealth.TabIndex = 16;
            this.btnChangeHealth.Text = "Change Health";
            this.btnChangeHealth.UseVisualStyleBackColor = true;
            // 
            // btnChangeBlock
            // 
            this.btnChangeBlock.Location = new System.Drawing.Point(703, 131);
            this.btnChangeBlock.Name = "btnChangeBlock";
            this.btnChangeBlock.Size = new System.Drawing.Size(103, 23);
            this.btnChangeBlock.TabIndex = 18;
            this.btnChangeBlock.Text = "Change Block";
            this.btnChangeBlock.UseVisualStyleBackColor = true;
            // 
            // nudChangeBlock
            // 
            this.nudChangeBlock.Location = new System.Drawing.Point(703, 105);
            this.nudChangeBlock.Name = "nudChangeBlock";
            this.nudChangeBlock.Size = new System.Drawing.Size(120, 20);
            this.nudChangeBlock.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(703, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Change Health";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(703, 160);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(695, 475);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.btnChangeBlock);
            this.Controls.Add(this.nudChangeBlock);
            this.Controls.Add(this.btnChangeHealth);
            this.Controls.Add(this.nudChangeHealth);
            this.Controls.Add(this.btnPauseGame);
            this.Controls.Add(this.btnChangeTick);
            this.Controls.Add(this.rtxtTempOutput);
            this.Controls.Add(this.nudChangeTick);
            this.Controls.Add(this.pnlDebugging);
            this.Controls.Add(this.pnlFileHandling);
            this.Controls.Add(this.pnlLogs);
            this.Controls.Add(this.pnlCombat);
            this.Controls.Add(this.pnlResourceCollection);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.msMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.msMain;
            this.Name = "MainForm";
            this.Text = "ThroughoutHistory";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.pnlResourceCollection.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpStorage.ResumeLayout(false);
            this.pnlIronStorage.ResumeLayout(false);
            this.pnlFoodStorage.ResumeLayout(false);
            this.pnlStoneStorage.ResumeLayout(false);
            this.pnlWoodStorage.ResumeLayout(false);
            this.tpWorkers.ResumeLayout(false);
            this.pnlTroops.ResumeLayout(false);
            this.pnlMiner.ResumeLayout(false);
            this.pnlButcher.ResumeLayout(false);
            this.pnlQuarrier.ResumeLayout(false);
            this.pnlGatherer.ResumeLayout(false);
            this.tpHousing.ResumeLayout(false);
            this.pnlBootcamp.ResumeLayout(false);
            this.pnlBarracks.ResumeLayout(false);
            this.pnlShack.ResumeLayout(false);
            this.tpCombat.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.tpResearch.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.pnlHushing.ResumeLayout(false);
            this.pnlTripHammer.ResumeLayout(false);
            this.pnlStampMill.ResumeLayout(false);
            this.pnlAquaducts.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlWood.ResumeLayout(false);
            this.pnlWood.PerformLayout();
            this.pnlCombat.ResumeLayout(false);
            this.pnlCombat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGrid)).EndInit();
            this.pnlLogs.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tpStoryLogs.ResumeLayout(false);
            this.tpUpgradesLogs.ResumeLayout(false);
            this.tpCombatLogs.ResumeLayout(false);
            this.tpLootLogs.ResumeLayout(false);
            this.tpSavesLogs.ResumeLayout(false);
            this.pnlFileHandling.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudChangeTick)).EndInit();
            this.pnlDebugging.ResumeLayout(false);
            this.pnlDebugging.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChangeHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChangeBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Label lblAqueductsCost;
		private System.Windows.Forms.Button btnAquaducts;
		private System.Windows.Forms.Panel pnlAquaducts;
		private System.Windows.Forms.TabPage tpResearch;
		private System.Windows.Forms.Label lblHealthCost;
		private System.Windows.Forms.Button btnHealth;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Label lblBlockCost;
		private System.Windows.Forms.Button btnBlock;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Label lblAttackCost;
		private System.Windows.Forms.Button btnAttack;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.TabPage tpCombat;
		private System.Windows.Forms.Label lblShackCost;
		private System.Windows.Forms.Button btnShack;
		private System.Windows.Forms.Panel pnlShack;
		private System.Windows.Forms.Label lblBarracksCost;
		private System.Windows.Forms.Button btnBarracks;
		private System.Windows.Forms.Panel pnlBarracks;
		private System.Windows.Forms.Label lblBootcampCost;
		private System.Windows.Forms.Button btnBootcamp;
		private System.Windows.Forms.Panel pnlBootcamp;
		private System.Windows.Forms.TabPage tpHousing;
		private System.Windows.Forms.Label lblGathererCost;
		private System.Windows.Forms.Button btnGatherer;
		private System.Windows.Forms.Panel pnlGatherer;
		private System.Windows.Forms.Label lblQuarrierCost;
		private System.Windows.Forms.Button btnQuarring;
		private System.Windows.Forms.Panel pnlQuarrier;
		private System.Windows.Forms.Label lblButcherCost;
		private System.Windows.Forms.Button btnButcher;
		private System.Windows.Forms.Panel pnlButcher;
		private System.Windows.Forms.Label lblMinerCost;
		private System.Windows.Forms.Button btnMiner;
		private System.Windows.Forms.Panel pnlMiner;
		private System.Windows.Forms.Label lblTroopCost;
		private System.Windows.Forms.Button btnTroop;
		private System.Windows.Forms.Panel pnlTroops;
		private System.Windows.Forms.TabPage tpWorkers;
		private System.Windows.Forms.Label lblWoodStorageCost;
		private System.Windows.Forms.Button btnWoodStorage;
		private System.Windows.Forms.Panel pnlWoodStorage;
		private System.Windows.Forms.Label lblStoneStorageCost;
		private System.Windows.Forms.Button btnStoneStorage;
		private System.Windows.Forms.Panel pnlStoneStorage;
		private System.Windows.Forms.Label lblFoodStorageCost;
		private System.Windows.Forms.Button btnFoodStorage;
		private System.Windows.Forms.Panel pnlFoodStorage;
		private System.Windows.Forms.Label lblMetalStorageCost;
		private System.Windows.Forms.Button btnMetalStorage;
		private System.Windows.Forms.Panel pnlIronStorage;
		private System.Windows.Forms.TabPage tpStorage;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Timer globalTimer;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ProgressBar pbHousing;
		private System.Windows.Forms.Label lblHousingCapacity;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem resourceCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem combatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveLoadToolStripMenuItem;
        private System.Windows.Forms.Panel pnlResourceCollection;
        private System.Windows.Forms.Panel pnlWood;
        private System.Windows.Forms.ProgressBar pbWood;
        private System.Windows.Forms.Button btnGather;
        private System.Windows.Forms.Label lblWoodAmount;
        private System.Windows.Forms.Label lblWoodRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStoneAmount;
        private System.Windows.Forms.Label lblStoneRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pbStone;
        private System.Windows.Forms.Button btnQuarrier;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblMetalAmount;
        private System.Windows.Forms.Label lblMetalRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar pbMetal;
        private System.Windows.Forms.Button btnMine;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFoodAmount;
        private System.Windows.Forms.Label lblFoodRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pbFood;
        private System.Windows.Forms.Button btnFarm;
        private System.Windows.Forms.Panel pnlCombat;
        private System.Windows.Forms.Panel pnlLogs;
        private System.Windows.Forms.Panel pnlFileHandling;
        private System.Windows.Forms.Panel pnlHushing;
        private System.Windows.Forms.Button btnHushing;
        private System.Windows.Forms.Label lblHushingCost;
        private System.Windows.Forms.Panel pnlTripHammer;
        private System.Windows.Forms.Button btnTripHammer;
        private System.Windows.Forms.Label lblTripHammerCost;
        private System.Windows.Forms.Panel pnlStampMill;
        private System.Windows.Forms.Button btnStampMill;
        private System.Windows.Forms.Label lblStampMillCost;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnVilla;
        private System.Windows.Forms.Label lblVillaCost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblScienceAmount;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblHousingSpace;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tpStoryLogs;
        private System.Windows.Forms.RichTextBox rtxtStoryLogs;
        private System.Windows.Forms.TabPage tpUpgradesLogs;
        private System.Windows.Forms.TabPage tpCombatLogs;
        private System.Windows.Forms.TabPage tpLootLogs;
        private System.Windows.Forms.TabPage tpSavesLogs;
        private System.Windows.Forms.RichTextBox rtxtUpgrades;
        private System.Windows.Forms.RichTextBox rtxtCombat;
        private System.Windows.Forms.RichTextBox rtxtLoot;
        private System.Windows.Forms.RichTextBox rtxtSaves;
        private System.Windows.Forms.Button btnClearLogs;
        private System.Windows.Forms.Label lblPlayerTiles;
        private System.Windows.Forms.Label lblWarDesciption;
        private System.Windows.Forms.Label lblEnemyTiles;
        private System.Windows.Forms.Label lblPlayerStats;
        private System.Windows.Forms.Label lblEnemyStats;
        private System.Windows.Forms.Timer combatTimer;
        private System.Windows.Forms.PictureBox pbxGrid;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.NumericUpDown nudChangeTick;
        private System.Windows.Forms.Button btnChangeTick;
        private System.Windows.Forms.RichTextBox rtxtTempOutput;
        private System.Windows.Forms.Button btnPauseGame;
        private System.Windows.Forms.Label lblAutosaveStatus;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnAutosaveOption;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Timer autosaveTimer;
        private System.Windows.Forms.Label lblCurrentYear;
        private System.Windows.Forms.ToolStripMenuItem debuggingToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDebugging;
        private System.Windows.Forms.OpenFileDialog openDialogue;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudChangeHealth;
        private System.Windows.Forms.Button btnChangeHealth;
        private System.Windows.Forms.Button btnChangeBlock;
        private System.Windows.Forms.NumericUpDown nudChangeBlock;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}
