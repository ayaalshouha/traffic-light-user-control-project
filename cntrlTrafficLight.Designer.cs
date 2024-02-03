namespace Traffic_Light_Simple_Project
{
    partial class cntrlTrafficLight
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RoadOne = new System.Windows.Forms.PictureBox();
            this.RoadLabel = new System.Windows.Forms.Label();
            this.LightTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RoadOne)).BeginInit();
            this.SuspendLayout();
            // 
            // RoadOne
            // 
            this.RoadOne.Image = global::Traffic_Light_Simple_Project.Properties.Resources.Red1;
            this.RoadOne.Location = new System.Drawing.Point(81, 32);
            this.RoadOne.Name = "RoadOne";
            this.RoadOne.Size = new System.Drawing.Size(72, 139);
            this.RoadOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RoadOne.TabIndex = 3;
            this.RoadOne.TabStop = false;
            // 
            // RoadLabel
            // 
            this.RoadLabel.AutoSize = true;
            this.RoadLabel.Location = new System.Drawing.Point(13, 11);
            this.RoadLabel.Name = "RoadLabel";
            this.RoadLabel.Size = new System.Drawing.Size(61, 20);
            this.RoadLabel.TabIndex = 10;
            this.RoadLabel.Text = "Road 1";
            // 
            // LightTimer
            // 
            this.LightTimer.Interval = 10000;
            this.LightTimer.Tick += new System.EventHandler(this.LightTimer_Tick);
            // 
            // cntrlTrafficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.RoadLabel);
            this.Controls.Add(this.RoadOne);
            this.Name = "cntrlTrafficLight";
            this.Size = new System.Drawing.Size(235, 213);
            this.Load += new System.EventHandler(this.cntrlTrafficLight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoadOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox RoadOne;
        private System.Windows.Forms.Label RoadLabel;
        private System.Windows.Forms.Timer LightTimer;
    }
}
