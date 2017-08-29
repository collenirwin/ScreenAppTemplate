using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$ {

    /// <summary>
    /// Singleton class for the main form of the project
    /// </summary>
    public partial class MainForm : Form {

        #region Vars

        #region Template Generated

        static MainForm _instance;

        /// <summary>
        /// Singleton object for the main form of the project
        /// </summary>
        public static MainForm instance {
            get {
                if (_instance == null) {
                    _instance = new MainForm();
                }

                return _instance;
            }
        }

        /// <summary>
        /// Screen object currently docked to fill the form
        /// </summary>
        public Screen currentScreen { get; private set; }

        #endregion

        #endregion

        #region Methods

        #region Template Generated

        /// <summary>
        /// Switches MainForm.instance.currentScreen to the specified screen,
        /// docks it to fill the form.
        /// </summary>
        /// <param name="newScreen">Screen to switch to</param>
        /// <param name="disposeOld">Call the Dispose method of the old Screen?</param>
        public void switchScreen(Screen newScreen, bool disposeOld) {
            if (disposeOld && this.currentScreen != null) {
                this.currentScreen.Dispose();
            }

            this.currentScreen = newScreen;

            this.Controls.Add(currentScreen);
            this.currentScreen.Dock = DockStyle.Fill;
            this.currentScreen.Show();

        }

        #endregion

        private MainForm() {
            InitializeComponent();
        }

        #endregion
    }
}
