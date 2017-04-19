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
            this.destroyedLabel = new System.Windows.Forms.Label();
            this.totalScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // overLabel
            // 
            this.overLabel.BackColor = System.Drawing.Color.Transparent;
            this.overLabel.Location = new System.Drawing.Point(325, 0);
            this.overLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.overLabel.Name = "overLabel";
            this.overLabel.Size = new System.Drawing.Size(202, 49);
            this.overLabel.TabIndex = 0;
            // 
            // replayButton
            // 
            this.replayButton.Location = new System.Drawing.Point(178, 423);
            this.replayButton.Name = "replayButton";
            this.replayButton.Size = new System.Drawing.Size(170, 52);
            this.replayButton.TabIndex = 1;
            this.replayButton.Text = "Replay";
            this.replayButton.UseVisualStyleBackColor = true;
            this.replayButton.Click += new System.EventHandler(this.replayButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(507, 423);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(201, 52);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Location = new System.Drawing.Point(282, 62);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(316, 66);
            this.scoreLabel.TabIndex = 4;
            // 
            // destroyedLabel
            // 
            this.destroyedLabel.BackColor = System.Drawing.Color.Transparent;
            this.destroyedLabel.Location = new System.Drawing.Point(267, 152);
            this.destroyedLabel.Name = "destroyedLabel";
            this.destroyedLabel.Size = new System.Drawing.Size(316, 49);
            this.destroyedLabel.TabIndex = 5;
            // 
            // totalScore
            // 
            this.totalScore.BackColor = System.Drawing.Color.Transparent;
            this.totalScore.Location = new System.Drawing.Point(247, 238);
            this.totalScore.Name = "totalScore";
            this.totalScore.Size = new System.Drawing.Size(630, 58);
            this.totalScore.TabIndex = 6;
            // 
            // OverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BoxField.Properties.Resources.PlaneCrash;
            this.Controls.Add(this.totalScore);
            this.Controls.Add(this.destroyedLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.replayButton);
            this.Controls.Add(this.overLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "OverScreen";
            this.Size = new System.Drawing.Size(900, 630);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label overLabel;
        private System.Windows.Forms.Button replayButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label destroyedLabel;
        private System.Windows.Forms.Label totalScore;
    }
}
