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
            // dispose the last currentScreen if we are asked to, and if we can
            if (disposeOld && this.currentScreen != null)
            {
                this.currentScreen.Dispose();
            }

            // set the new currentScreen
            this.currentScreen = newScreen;

            // add newScreen to this.Controls if we haven't already
            if (!this.Controls.Contains(newScreen))
            {
                this.Controls.Add(newScreen);
            }

            // make sure newScreen is where it should be
            this.currentScreen.Show();
            this.currentScreen.BringToFront();
            this.currentScreen.Dock = DockStyle.Fill;
            this.currentScreen.Select();
            this.currentScreen.Focus();
        }

        #endregion

        private MainForm() {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            // switch to HomeScreen immediately after loading
            switchScreen(new HomeScreen(), false);
        }

        #endregion
    }
}
