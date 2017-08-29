using System;
using System.Windows.Forms;

namespace $safeprojectname$ {

    /// <summary>
    /// Base class for all Form Screens. Inherit from this to make your own.
    /// </summary>
    public partial class Screen : UserControl {

        public string title { get; private set; }

        /// <summary>
        /// Constructor for Screen
        /// </summary>
        /// <param name="title">
        /// Title to use for MainForm.instance.Text. 
        /// If title == "", MainForm.instance.Text is left untouched.
        /// </param>
        /// </param>
        public Screen(string title = "") {
            InitializeComponent();

            this.title = title;
            if (title != "") {
                MainForm.instance.Text = title;
            }
        }

        // needed so that inherited classes can use designer
        [Obsolete("For designer use only", true)]
        public Screen() {
            InitializeComponent();
        }
    }
}
