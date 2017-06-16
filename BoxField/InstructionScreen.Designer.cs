namespace BoxField
{
    partial class InstructionScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructionScreen));
            this.arrowLabel = new System.Windows.Forms.Label();
            this.arrowInstructionLabel = new System.Windows.Forms.Label();
            this.mouseLabel = new System.Windows.Forms.Label();
            this.mouseInstructionsLabel = new System.Windows.Forms.Label();
            this.clickLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // arrowLabel
            // 
            this.arrowLabel.BackColor = System.Drawing.Color.Transparent;
            this.arrowLabel.Image = ((System.Drawing.Image)(resources.GetObject("arrowLabel.Image")));
            this.arrowLabel.Location = new System.Drawing.Point(23, 228);
            this.arrowLabel.Name = "arrowLabel";
            this.arrowLabel.Size = new System.Drawing.Size(442, 259);
            this.arrowLabel.TabIndex = 0;
            // 
            // arrowInstructionLabel
            // 
            this.arrowInstructionLabel.AutoSize = true;
            this.arrowInstructionLabel.BackColor = System.Drawing.Color.Transparent;
            this.arrowInstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrowInstructionLabel.ForeColor = System.Drawing.Color.Red;
            this.arrowInstructionLabel.Location = new System.Drawing.Point(60, 40);
            this.arrowInstructionLabel.Name = "arrowInstructionLabel";
            this.arrowInstructionLabel.Size = new System.Drawing.Size(0, 31);
            this.arrowInstructionLabel.TabIndex = 1;
            // 
            // mouseLabel
            // 
            this.mouseLabel.BackColor = System.Drawing.Color.Transparent;
            this.mouseLabel.Image = ((System.Drawing.Image)(resources.GetObject("mouseLabel.Image")));
            this.mouseLabel.Location = new System.Drawing.Point(494, 175);
            this.mouseLabel.Name = "mouseLabel";
            this.mouseLabel.Size = new System.Drawing.Size(346, 290);
            this.mouseLabel.TabIndex = 2;
            // 
            // mouseInstructionsLabel
            // 
            this.mouseInstructionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.mouseInstructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouseInstructionsLabel.ForeColor = System.Drawing.Color.Red;
            this.mouseInstructionsLabel.Location = new System.Drawing.Point(496, 28);
            this.mouseInstructionsLabel.Name = "mouseInstructionsLabel";
            this.mouseInstructionsLabel.Size = new System.Drawing.Size(299, 76);
            this.mouseInstructionsLabel.TabIndex = 3;
            // 
            // clickLabel
            // 
            this.clickLabel.BackColor = System.Drawing.Color.Transparent;
            this.clickLabel.Image = ((System.Drawing.Image)(resources.GetObject("clickLabel.Image")));
            this.clickLabel.Location = new System.Drawing.Point(593, 248);
            this.clickLabel.Name = "clickLabel";
            this.clickLabel.Size = new System.Drawing.Size(106, 108);
            this.clickLabel.TabIndex = 4;
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.LimeGreen;
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(436, 379);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(122, 65);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // InstructionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.clickLabel);
            this.Controls.Add(this.mouseInstructionsLabel);
            this.Controls.Add(this.mouseLabel);
            this.Controls.Add(this.arrowInstructionLabel);
            this.Controls.Add(this.arrowLabel);
            this.Name = "InstructionScreen";
            this.Size = new System.Drawing.Size(898, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label arrowLabel;
        private System.Windows.Forms.Label arrowInstructionLabel;
        private System.Windows.Forms.Label mouseLabel;
        private System.Windows.Forms.Label mouseInstructionsLabel;
        private System.Windows.Forms.Label clickLabel;
        private System.Windows.Forms.Button okButton;
    }
}
