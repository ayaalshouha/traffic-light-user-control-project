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
        public class TraficLightEventArgs : EventArgs
        {
            public enLights CurrentLight { get; }
            public int LightDuration { get; }

            public TraficLightEventArgs(enLights CurrentLight, int LightDuration)
            {
                this.CurrentLight = CurrentLight;
                this.LightDuration = LightDuration;
            }
        }

        //red light on event
        public event EventHandler<TraficLightEventArgs> RedLightOn;
        public void RaiseRedLightOn()
        {
            RaiseRedLightOn(new TraficLightEventArgs(enLights.Red, _RedTime));
        }
        protected virtual void RaiseRedLightOn(TraficLightEventArgs e)
        {
            RedLightOn?.Invoke(this, e);
        }

        //orange light on
        public event EventHandler<TraficLightEventArgs> OrangeLightOn;
        public void RaiseOrangeLightOn()
        {
            RaiseOrangeLightOn(new TraficLightEventArgs(enLights.Orange, _OrangeTime));
        }
        protected virtual void RaiseOrangeLightOn(TraficLightEventArgs e)
        {
            OrangeLightOn?.Invoke(this, e);
        }

        //green light on 
        public event EventHandler<TraficLightEventArgs> GreenLightOn;
        public void RaiseGreenLightOn()
        {
            RaiseGreenLightOn(new TraficLightEventArgs(enLights.Green, _GreenTime));
        }
        protected virtual void RaiseGreenLightOn(TraficLightEventArgs e)
        {
            GreenLightOn?.Invoke(this, e);
        }

        private int _RedTime = 10;
        private int _OrangeTime = 3;
        private int _GreenTime = 10;

        public enum enLights { Red, Orange, Green }

        private enLights _CurrentLight;
        public enLights CurrentLight
        {
            get
            {
                return _CurrentLight;
            }
            set
            {
                _CurrentLight = value;

                switch (_CurrentLight)
                {
                    case enLights.Red:
                        LightImage.Image = Resources.Red1;
                        break;
                    case enLights.Green:
                        LightImage.Image = Resources.Green1;
                        break;
                    case enLights.Orange:
                        LightImage.Image = Resources.Orange1;
                        break;
                    default:
                        LightImage.Image = Resources.Red1;
                        break;
                }
            }
        }

        public string Label
        {
            get { return RoadLabel.Text; }
            set { RoadLabel.Text = value; }
        }
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

        private int _CurrentTimerValue;

        public int getCurrentTime()
        {
            switch(CurrentLight)
            {
                case enLights.Red:
                    return RedTime;
                case enLights.Green:
                    return GreenTime;
                case enLights.Orange:
                    return OrangeTime;

                default: return RedTime;
            }
        }

        public cntrlTrafficLight()
        {
            InitializeComponent();
        }

        public void Start()
        {
            _CurrentTimerValue = getCurrentTime();
            LightTimer.Start();
        }

        private enLights NextLightAfterOrange = enLights.Green; 
        private void _ChangeLight()
        {
            switch(CurrentLight)
            {
                case enLights.Red:
                    NextLightAfterOrange = enLights.Green; 
                    CurrentLight = enLights.Orange;
                    _CurrentTimerValue = OrangeTime;
                    RaiseOrangeLightOn();
                    break; 


                case enLights.Orange:

                    //change orange to red or green 

                    if (NextLightAfterOrange == enLights.Green)
                    {
                        CurrentLight = enLights.Green;
                        _CurrentTimerValue = GreenTime;
                        NextLightAfterOrange = enLights.Red;
                        RaiseGreenLightOn();
                        break;
                    }
                    else
                    {
                        CurrentLight = enLights.Red;
                        _CurrentTimerValue = RedTime;
                        NextLightAfterOrange = enLights.Green;
                        RaiseRedLightOn();
                        break;
                    }
                   

                case enLights.Green:
                    NextLightAfterOrange = enLights.Red;
                    CurrentLight = enLights.Orange;
                    _CurrentTimerValue = OrangeTime;
                    RaiseOrangeLightOn();
                    break;
            }
        }
        private void LightTimer_Tick(object sender, EventArgs e)
        {
            if(_CurrentTimerValue == 0)
            {
                _ChangeLight(); 
            }
            else
            {
                --_CurrentTimerValue; 
            }
        }

        public void Stop()
        {
            LightTimer.Stop();
        }

    }
}
