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
            this.SuspendLayout();
            // 
            // cntrlTrafficLight1
            // 
            this.cntrlTrafficLight1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cntrlTrafficLight1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cntrlTrafficLight1.GreenTime = 15;
            this.cntrlTrafficLight1.Location = new System.Drawing.Point(12, 12);
            this.cntrlTrafficLight1.Name = "cntrlTrafficLight1";
            this.cntrlTrafficLight1.OrangeTime = 3;
            this.cntrlTrafficLight1.RedTime = 15;
            this.cntrlTrafficLight1.Size = new System.Drawing.Size(235, 213);
            this.cntrlTrafficLight1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(750, 515);
            this.Controls.Add(this.cntrlTrafficLight1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Traffic Light";
            this.ResumeLayout(false);

        }

        #endregion

        private cntrlTrafficLight cntrlTrafficLight1;
    }
}

