using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_Light_Simple_Project
{
    public partial class cntrlTrafficLight : UserControl
    {

        public enum enLights { red, orange, green }
        public enLights CurrentLight = enLights.red;

        public cntrlTrafficLight()
        {
            InitializeComponent();
        }

        private void cntrlTrafficLight_Load(object sender, EventArgs e)
        {

        }
    }
}
