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
            this.RoadOne = new System.Windows.Forms.PictureBox();
            this.RoadThree = new System.Windows.Forms.PictureBox();
            this.RoadFour = new System.Windows.Forms.PictureBox();
            this.RoadTwo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RoadOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // RoadOne
            // 
            this.RoadOne.Image = global::Traffic_Light_Simple_Project.Properties.Resources.Red1;
            this.RoadOne.Location = new System.Drawing.Point(446, 431);
            this.RoadOne.Name = "RoadOne";
            this.RoadOne.Size = new System.Drawing.Size(72, 139);
            this.RoadOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RoadOne.TabIndex = 3;
            this.RoadOne.TabStop = false;
            // 
            // RoadThree
            // 
            this.RoadThree.Image = global::Traffic_Light_Simple_Project.Properties.Resources.Red___Copy;
            this.RoadThree.Location = new System.Drawing.Point(200, 53);
            this.RoadThree.Name = "RoadThree";
            this.RoadThree.Size = new System.Drawing.Size(72, 139);
            this.RoadThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RoadThree.TabIndex = 5;
            this.RoadThree.TabStop = false;
            // 
            // RoadFour
            // 
            this.RoadFour.Image = global::Traffic_Light_Simple_Project.Properties.Resources.Red3;
            this.RoadFour.Location = new System.Drawing.Point(79, 369);
            this.RoadFour.Name = "RoadFour";
            this.RoadFour.Size = new System.Drawing.Size(139, 72);
            this.RoadFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RoadFour.TabIndex = 7;
            this.RoadFour.TabStop = false;
            // 
            // RoadTwo
            // 
            this.RoadTwo.Image = global::Traffic_Light_Simple_Project.Properties.Resources.Red2;
            this.RoadTwo.Location = new System.Drawing.Point(446, 189);
            this.RoadTwo.Name = "RoadTwo";
            this.RoadTwo.Size = new System.Drawing.Size(139, 72);
            this.RoadTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RoadTwo.TabIndex = 9;
            this.RoadTwo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Road 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Road 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Road 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Road 4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cntrlTrafficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoadTwo);
            this.Controls.Add(this.RoadFour);
            this.Controls.Add(this.RoadThree);
            this.Controls.Add(this.RoadOne);
            this.Name = "cntrlTrafficLight";
            this.Size = new System.Drawing.Size(664, 623);
            this.Load += new System.EventHandler(this.cntrlTrafficLight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoadOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTwo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox RoadOne;
        private System.Windows.Forms.PictureBox RoadThree;
        private System.Windows.Forms.PictureBox RoadFour;
        private System.Windows.Forms.PictureBox RoadTwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
