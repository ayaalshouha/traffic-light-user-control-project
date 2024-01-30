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

        private enLights _RoadOneCurrentLight = enLights.Red;
        private enLights _RoadTwoCurrentLight = enLights.Red;
        private enLights _RoadThreeCurrentLight = enLights.Red;
        private enLights _RoadFourCurrentLight = enLights.Red;

        public enLights RoadOneCurrentLight 
        {
            get {  return _RoadOneCurrentLight; }
            set
            {
                _RoadOneCurrentLight = value;

                switch (_RoadOneCurrentLight)
                {
                    case enLights.Red:
                        RoadOne.Image = Resources.Red1;
                        break;
                    case enLights.Orange:
                        RoadOne.Image = Resources.Orange1;
                        break;
                    case enLights.Green:
                        RoadOne.Image = Resources.Green1;
                        break;
                    default:
                        RoadOne.Image = Resources.Red1;
                        break;
                }
            }
        }

        public enLights RoadTwoCurrentLight
        {
            get { return _RoadTwoCurrentLight; }
            set
            {
                _RoadTwoCurrentLight = value;

                switch (_RoadTwoCurrentLight)
                {
                    case enLights.Red:
                        RoadTwo.Image = Resources.Red2;
                        break;
                    case enLights.Orange:
                        RoadTwo.Image = Resources.Orange2;
                        break;
                    case enLights.Green:
                        RoadTwo.Image = Resources.Green2;
                        break;
                    default:
                        RoadTwo.Image = Resources.Red2;
                        break;
                }
            }
        }

        public enLights RoadThreeCurrentLight
        {
            get { return _RoadThreeCurrentLight; }
            set
            {
                _RoadThreeCurrentLight = value;

                switch (_RoadThreeCurrentLight)
                {
                    case enLights.Red:
                        RoadThree.Image = Resources.Red___Copy;
                        break;
                    case enLights.Orange:
                        RoadThree.Image = Resources.Orange3;
                        break;
                    case enLights.Green:
                        RoadThree.Image = Resources.Green3;
                        break;
                    default:
                        RoadThree.Image = Resources.Red___Copy;
                        break;
                }
            }
        }

        public enLights RoadFourCurrentLight
        {
            get { return _RoadFourCurrentLight; }
            set
            {
                _RoadFourCurrentLight = value;

                switch (_RoadFourCurrentLight)
                {
                    case enLights.Red:
                        RoadFour.Image = Resources.Red3;
                        break;
                    case enLights.Orange:
                        RoadFour.Image = Resources.Orange4;
                        break;
                    case enLights.Green:
                        RoadFour.Image = Resources.Green4;
                        break;
                    default:
                        RoadFour.Image = Resources.Red3;
                        break;
                }
            }
        }

        private int _RedTime {  get; set; }
        private int _OrangeTime {  get; set; }
        private int _GreenTime {  get; set; }

        public int RedTime
        {
            get { return _RedTime; } set { _RedTime = value; }
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

        private void cntrlTrafficLight_Load(object sender, EventArgs e)
        {
           
        }
    }
}
