using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$ {

    /// <summary>
    /// Home Screen or landing page for the project
    /// </summary>
    public partial class HomeScreen : Screen {

        public HomeScreen() : base() {
            // set title to Home - $safeprojectname$
            title = "Home - " + Constants.APP_NAME; 
        }
    }
}
