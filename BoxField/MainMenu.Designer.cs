namespace BoxField
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.startButton = new System.Windows.Forms.Button();
            this.optionsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.instructionScreen = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.spaceshipLabel = new System.Windows.Forms.Label();
            this.spaceshipLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(291, 124);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(235, 68);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // optionsButton
            // 
            this.optionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsButton.Location = new System.Drawing.Point(291, 218);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(235, 68);
            this.optionsButton.TabIndex = 1;
            this.optionsButton.Text = "Options";
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(291, 398);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(235, 68);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // instructionScreen
            // 
            this.instructionScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionScreen.Location = new System.Drawing.Point(291, 310);
            this.instructionScreen.Name = "instructionScreen";
            this.instructionScreen.Size = new System.Drawing.Size(235, 68);
            this.instructionScreen.TabIndex = 4;
            this.instructionScreen.Text = "Instructions";
            this.instructionScreen.UseVisualStyleBackColor = true;
            this.instructionScreen.Click += new System.EventHandler(this.instructionScreen_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Red;
            this.titleLabel.Location = new System.Drawing.Point(152, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(537, 73);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Starship Survivor";
            // 
            // spaceshipLabel
            // 
            this.spaceshipLabel.BackColor = System.Drawing.Color.Transparent;
            this.spaceshipLabel.Image = ((System.Drawing.Image)(resources.GetObject("spaceshipLabel.Image")));
            this.spaceshipLabel.Location = new System.Drawing.Point(597, 156);
            this.spaceshipLabel.Name = "spaceshipLabel";
            this.spaceshipLabel.Size = new System.Drawing.Size(183, 310);
            this.spaceshipLabel.TabIndex = 6;
            // 
            // spaceshipLabel2
            // 
            this.spaceshipLabel2.BackColor = System.Drawing.Color.Transparent;
            this.spaceshipLabel2.Image = ((System.Drawing.Image)(resources.GetObject("spaceshipLabel2.Image")));
            this.spaceshipLabel2.Location = new System.Drawing.Point(44, 156);
            this.spaceshipLabel2.Name = "spaceshipLabel2";
            this.spaceshipLabel2.Size = new System.Drawing.Size(183, 310);
            this.spaceshipLabel2.TabIndex = 7;
            this.spaceshipLabel2.Text = "label1";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.spaceshipLabel2);
            this.Controls.Add(this.spaceshipLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.instructionScreen);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.startButton);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(900, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button instructionScreen;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label spaceshipLabel;
        private System.Windows.Forms.Label spaceshipLabel2;
    }
}
