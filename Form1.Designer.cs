namespace Traffic_Light_Simple_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cntrlTrafficLight1 = new Traffic_Light_Simple_Project.cntrlTrafficLight();
            this.cntrlTrafficLight2 = new Traffic_Light_Simple_Project.cntrlTrafficLight();
            this.cntrlTrafficLight3 = new Traffic_Light_Simple_Project.cntrlTrafficLight();
            this.cntrlTrafficLight4 = new Traffic_Light_Simple_Project.cntrlTrafficLight();
            this.SuspendLayout();
            // 
            // cntrlTrafficLight1
            // 
            this.cntrlTrafficLight1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cntrlTrafficLight1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cntrlTrafficLight1.CurrentLight = Traffic_Light_Simple_Project.cntrlTrafficLight.enLights.Green;
            this.cntrlTrafficLight1.GreenTime = 5;
            this.cntrlTrafficLight1.Label = "Road 1";
            this.cntrlTrafficLight1.Location = new System.Drawing.Point(545, 439);
            this.cntrlTrafficLight1.Name = "cntrlTrafficLight1";
            this.cntrlTrafficLight1.OrangeTime = 1;
            this.cntrlTrafficLight1.RedTime = 5;
            this.cntrlTrafficLight1.Size = new System.Drawing.Size(245, 236);
            this.cntrlTrafficLight1.TabIndex = 0;
            this.cntrlTrafficLight1.RedLightOn += new System.EventHandler<Traffic_Light_Simple_Project.cntrlTrafficLight.TraficLightEventArgs>(this.cntrlTrafficLight1_RedLightOn);
            // 
            // cntrlTrafficLight2
            // 
            this.cntrlTrafficLight2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cntrlTrafficLight2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cntrlTrafficLight2.CurrentLight = Traffic_Light_Simple_Project.cntrlTrafficLight.enLights.Red;
            this.cntrlTrafficLight2.GreenTime = 5;
            this.cntrlTrafficLight2.Label = "Road 2";
            this.cntrlTrafficLight2.Location = new System.Drawing.Point(942, 180);
            this.cntrlTrafficLight2.Name = "cntrlTrafficLight2";
            this.cntrlTrafficLight2.OrangeTime = 1;
            this.cntrlTrafficLight2.RedTime = 5;
            this.cntrlTrafficLight2.Size = new System.Drawing.Size(200, 222);
            this.cntrlTrafficLight2.TabIndex = 1;
            this.cntrlTrafficLight2.RedLightOn += new System.EventHandler<Traffic_Light_Simple_Project.cntrlTrafficLight.TraficLightEventArgs>(this.cntrlTrafficLight2_RedLightOn);
            // 
            // cntrlTrafficLight3
            // 
            this.cntrlTrafficLight3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cntrlTrafficLight3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cntrlTrafficLight3.CurrentLight = Traffic_Light_Simple_Project.cntrlTrafficLight.enLights.Red;
            this.cntrlTrafficLight3.GreenTime = 5;
            this.cntrlTrafficLight3.Label = "Road 3";
            this.cntrlTrafficLight3.Location = new System.Drawing.Point(530, 12);
            this.cntrlTrafficLight3.Name = "cntrlTrafficLight3";
            this.cntrlTrafficLight3.OrangeTime = 1;
            this.cntrlTrafficLight3.RedTime = 5;
            this.cntrlTrafficLight3.Size = new System.Drawing.Size(260, 228);
            this.cntrlTrafficLight3.TabIndex = 2;
            this.cntrlTrafficLight3.RedLightOn += new System.EventHandler<Traffic_Light_Simple_Project.cntrlTrafficLight.TraficLightEventArgs>(this.cntrlTrafficLight3_RedLightOn);
            // 
            // cntrlTrafficLight4
            // 
            this.cntrlTrafficLight4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cntrlTrafficLight4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cntrlTrafficLight4.CurrentLight = Traffic_Light_Simple_Project.cntrlTrafficLight.enLights.Red;
            this.cntrlTrafficLight4.GreenTime = 5;
            this.cntrlTrafficLight4.Label = "Road 4";
            this.cntrlTrafficLight4.Location = new System.Drawing.Point(47, 180);
            this.cntrlTrafficLight4.Name = "cntrlTrafficLight4";
            this.cntrlTrafficLight4.OrangeTime = 1;
            this.cntrlTrafficLight4.RedTime = 5;
            this.cntrlTrafficLight4.Size = new System.Drawing.Size(262, 269);
            this.cntrlTrafficLight4.TabIndex = 3;
            this.cntrlTrafficLight4.RedLightOn += new System.EventHandler<Traffic_Light_Simple_Project.cntrlTrafficLight.TraficLightEventArgs>(this.cntrlTrafficLight4_RedLightOn);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1195, 704);
            this.Controls.Add(this.cntrlTrafficLight4);
            this.Controls.Add(this.cntrlTrafficLight3);
            this.Controls.Add(this.cntrlTrafficLight2);
            this.Controls.Add(this.cntrlTrafficLight1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Traffic Light";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private cntrlTrafficLight cntrlTrafficLight1;
        private cntrlTrafficLight cntrlTrafficLight2;
        private cntrlTrafficLight cntrlTrafficLight3;
        private cntrlTrafficLight cntrlTrafficLight4;
    }
}

