using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ThroughoutHistory {
    /// <summary>
    /// Responsible for showing the viewable parts of the program
    /// </summary>
    public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
            // Set the spawn location to be at the top left corner
			Point spawnLocation = new Point(0, 0);
			Location = spawnLocation;
			// Set each section panel to an element of the panel array
            panelSections[0] = pnlResourceCollection;
            panelSections[1] = pnlCombat;
            panelSections[2] = pnlLogs;
            panelSections[3] = pnlFileHandling;
            panelSections[4] = pnlDebugging;

            // Hide every single panel except the resource collection panel (on program start up)
            for (int i = 0; i < panelSections.Length; i++) {
            	// If the current panel is the tutorial one, show it
            	if (panelSections[i] == pnlResourceCollection) {
            		panelSections[4].Show();
            	// If not, hide it
            	} else {
            		panelSections[i].Hide();
            	}
            }

            // Output a first story log to explain what is going on
            rtxtStoryLogs.Text = "You feel an urge to grow the factory...";

            // Reset the combat grid to normal
            resetBoard();
        }

		#region customFormSetup
		//Set up some consts and dlls to allow form dragging
		private const int HT_CAPTION = 0x2;
		private const int WM_NCLBUTTONDOWN = 0x00A1;
		[DllImport("user32", CharSet = CharSet.Auto)]
		private static extern bool ReleaseCapture();
		[DllImport("user32", CharSet = CharSet.Auto)]
		private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
	
		protected override void OnMouseDown(MouseEventArgs e) {
			//When a mouse button is pressed
			if (e.Button == MouseButtons.Left) {
				Rectangle rct = DisplayRectangle;
                //If the button pressed is the left button
                if (rct.Contains(e.Location)) {
					//Move the form
					ReleaseCapture();
					SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
				}
			}
		}
		
		void BtnCloseFormClick(object sender, EventArgs e) {
            saveToFile(true);
			Close();
		}
        #endregion

        Panel[] panelSections = new Panel[5];
		
		void MsMainItemClicked(object sender, ToolStripItemClickedEventArgs e) {
        	// When a button on the menu strip is clicked, hide all panels
            for (int i = 0; i < panelSections.Length; i++) {
                panelSections[i].Hide();
            }
		}

        private void resourceCollectionToolStripMenuItem_Click(object sender, EventArgs e) {
        	// When the resource collection panel is clicked, show it
            pnlResourceCollection.Show();
        }

        private void combatToolStripMenuItem_Click(object sender, EventArgs e) {
            // When the combat panel is clicked, show it
        	pnlCombat.Show();
        }

        private void logsToolStripMenuItem_Click(object sender, EventArgs e) {
            // When the logs panel is clicked, show it
        	pnlLogs.Show();
        }

        private void saveLoadToolStripMenuItem_Click(object sender, EventArgs e) {
            // When the file handling panel is clicked, show it
        	pnlFileHandling.Show();
        }

        private void debuggingToolStripMenuItem_Click(object sender, EventArgs e) {
            pnlDebugging.Show();
        }

        void currentTime() {
            // Get current time in UTC from system clock
            GlobalData.currentTime = DateTime.UtcNow.ToShortTimeString();
            // Print into save/load label
            lblTime.Text = ("Current time (UTC): " + GlobalData.currentTime.ToString() + ".");
        }

        private void btnChangeTick_Click(object sender, EventArgs e) {
            GlobalData.tickCounter = Convert.ToInt32(nudChangeTick.Value);
        }
    }
}