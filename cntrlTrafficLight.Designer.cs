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
            this.pbLight = new System.Windows.Forms.PictureBox();
            this.lblColor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLight)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLight
            // 
            this.pbLight.Image = global::Traffic_Light_Simple_Project.Properties.Resources.Red;
            this.pbLight.Location = new System.Drawing.Point(4, 3);
            this.pbLight.Name = "pbLight";
            this.pbLight.Size = new System.Drawing.Size(221, 432);
            this.pbLight.TabIndex = 0;
            this.pbLight.TabStop = false;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(75, 438);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(78, 32);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "[???]";
            // 
            // cntrlTrafficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.pbLight);
            this.Name = "cntrlTrafficLight";
            this.Size = new System.Drawing.Size(228, 481);
            this.Load += new System.EventHandler(this.cntrlTrafficLight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLight;
        private System.Windows.Forms.Label lblColor;
    }
}
