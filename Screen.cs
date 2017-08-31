using System;
using System.Windows.Forms;

namespace $safeprojectname$ {

    /// <summary>
    /// Base class for all Form Screens. Inherit from this to make your own.
    /// </summary>
    public partial class Screen : UserControl {

        string _title;

        /// <summary>
        /// Sets MainForm.instance.Text
        /// </summary>
        public string title {
            get {
                return _title;
            }
            set {
                _title = value;
                MainForm.instance.Text = value;
            }
        }

        /// <summary>
        /// Constructor for Screen
        /// </summary>
        public Screen() {
            InitializeComponent();

            // optional: set defaults here
        }
    }
}
