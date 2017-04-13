namespace BoxField
{
    partial class OverScreen
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
            this.overLabel = new System.Windows.Forms.Label();
            this.replayButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // overLabel
            // 
            this.overLabel.Location = new System.Drawing.Point(139, 87);
            this.overLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.overLabel.Name = "overLabel";
            this.overLabel.Size = new System.Drawing.Size(531, 100);
            this.overLabel.TabIndex = 0;
            // 
            // replayButton
            // 
            this.replayButton.Location = new System.Drawing.Point(101, 238);
            this.replayButton.Name = "replayButton";
            this.replayButton.Size = new System.Drawing.Size(170, 52);
            this.replayButton.TabIndex = 1;
            this.replayButton.Text = "Replay";
            this.replayButton.UseVisualStyleBackColor = true;
            this.replayButton.Click += new System.EventHandler(this.replayButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(395, 238);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(201, 52);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.Location = new System.Drawing.Point(198, 169);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(316, 66);
            this.scoreLabel.TabIndex = 4;
            // 
            // OverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.replayButton);
            this.Controls.Add(this.overLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "OverScreen";
            this.Size = new System.Drawing.Size(802, 531);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label overLabel;
        private System.Windows.Forms.Button replayButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label scoreLabel;
    }
}
