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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cntrlTrafficLight1.Start();
        }

        private void cntrlTrafficLight1_RedLightOn(object sender, cntrlTrafficLight.TraficLightEventArgs e)
        {
            cntrlTrafficLight2.CurrentLight = cntrlTrafficLight.enLights.Green; 
            cntrlTrafficLight2.Start();
        }

        private void cntrlTrafficLight2_RedLightOn(object sender, cntrlTrafficLight.TraficLightEventArgs e)
        {
            cntrlTrafficLight3.CurrentLight = cntrlTrafficLight.enLights.Green; 
            cntrlTrafficLight3.Start();
        }

        private void cntrlTrafficLight3_RedLightOn(object sender, cntrlTrafficLight.TraficLightEventArgs e)
        {
            cntrlTrafficLight4.CurrentLight = cntrlTrafficLight.enLights.Green; 
            cntrlTrafficLight4.Start();
        }

        private void cntrlTrafficLight4_RedLightOn(object sender, cntrlTrafficLight.TraficLightEventArgs e)
        {
            cntrlTrafficLight1.CurrentLight = cntrlTrafficLight.enLights.Green; 
            cntrlTrafficLight1.Start();
        }
    }
}
