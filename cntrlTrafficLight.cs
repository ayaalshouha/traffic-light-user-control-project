using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Traffic_Light_Simple_Project.Properties;

namespace Traffic_Light_Simple_Project
{
    public partial class cntrlTrafficLight : UserControl
    {
        public enum enLights { Red, Orange, Green }
        private int _RedTime { get; set; } = 15;
        private int _OrangeTime { get; set; } = 3;
        private int _GreenTime { get; set; } = 15;
        public int RedTime
        {
            get { return _RedTime; }
            set { _RedTime = value; }
        }
        public int GreenTime
        {
            get { return _GreenTime; }
            set { _GreenTime = value; }
        }
        public int OrangeTime
        {
            get { return _OrangeTime; }
            set { _OrangeTime = value; }
        }

        public cntrlTrafficLight()
        {
            InitializeComponent();
        }

        public void Start()
        {

        }

        private void cntrlTrafficLight_Load(object sender, EventArgs e)
        {
           
        }

        private void LightTimer_Tick(object sender, EventArgs e)
        {

        }


    }
}
