namespace BoxField
{
    partial class CharacterScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterScreen));
            this.heroRed = new System.Windows.Forms.Button();
            this.heroGreen = new System.Windows.Forms.Button();
            this.characterLabel = new System.Windows.Forms.Label();
            this.acceptbutton = new System.Windows.Forms.Button();
            this.heroYellow = new System.Windows.Forms.Button();
            this.selectLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // heroRed
            // 
            this.heroRed.BackColor = System.Drawing.Color.Black;
            this.heroRed.Image = ((System.Drawing.Image)(resources.GetObject("heroRed.Image")));
            this.heroRed.Location = new System.Drawing.Point(18, 255);
            this.heroRed.Name = "heroRed";
            this.heroRed.Size = new System.Drawing.Size(324, 118);
            this.heroRed.TabIndex = 1;
            this.heroRed.UseVisualStyleBackColor = false;
            this.heroRed.Click += new System.EventHandler(this.heroRed_Click);
            // 
            // heroGreen
            // 
            this.heroGreen.BackColor = System.Drawing.Color.Black;
            this.heroGreen.Image = ((System.Drawing.Image)(resources.GetObject("heroGreen.Image")));
            this.heroGreen.Location = new System.Drawing.Point(18, 131);
            this.heroGreen.Name = "heroGreen";
            this.heroGreen.Size = new System.Drawing.Size(324, 118);
            this.heroGreen.TabIndex = 2;
            this.heroGreen.UseVisualStyleBackColor = false;
            this.heroGreen.Click += new System.EventHandler(this.heroGreen_Click);
            // 
            // characterLabel
            // 
            this.characterLabel.AutoSize = true;
            this.characterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterLabel.ForeColor = System.Drawing.Color.Red;
            this.characterLabel.Location = new System.Drawing.Point(396, 141);
            this.characterLabel.Name = "characterLabel";
            this.characterLabel.Size = new System.Drawing.Size(0, 39);
            this.characterLabel.TabIndex = 3;
            // 
            // acceptbutton
            // 
            this.acceptbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptbutton.Location = new System.Drawing.Point(544, 366);
            this.acceptbutton.Name = "acceptbutton";
            this.acceptbutton.Size = new System.Drawing.Size(226, 131);
            this.acceptbutton.TabIndex = 4;
            this.acceptbutton.Text = "Accept";
            this.acceptbutton.UseVisualStyleBackColor = true;
            this.acceptbutton.Click += new System.EventHandler(this.acceptbutton_Click);
            // 
            // heroYellow
            // 
            this.heroYellow.BackColor = System.Drawing.Color.Black;
            this.heroYellow.Image = ((System.Drawing.Image)(resources.GetObject("heroYellow.Image")));
            this.heroYellow.Location = new System.Drawing.Point(18, 379);
            this.heroYellow.Name = "heroYellow";
            this.heroYellow.Size = new System.Drawing.Size(324, 118);
            this.heroYellow.TabIndex = 5;
            this.heroYellow.UseVisualStyleBackColor = false;
            this.heroYellow.Click += new System.EventHandler(this.heroYellow_Click);
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLabel.ForeColor = System.Drawing.Color.Red;
            this.selectLabel.Location = new System.Drawing.Point(267, 17);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(398, 55);
            this.selectLabel.TabIndex = 6;
            this.selectLabel.Text = "Select Character";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(542, 302);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 25);
            this.errorLabel.TabIndex = 7;
            // 
            // CharacterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.heroYellow);
            this.Controls.Add(this.acceptbutton);
            this.Controls.Add(this.characterLabel);
            this.Controls.Add(this.heroGreen);
            this.Controls.Add(this.heroRed);
            this.Name = "CharacterScreen";
            this.Size = new System.Drawing.Size(900, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button heroRed;
        private System.Windows.Forms.Button heroGreen;
        private System.Windows.Forms.Label characterLabel;
        private System.Windows.Forms.Button acceptbutton;
        private System.Windows.Forms.Button heroYellow;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.Label errorLabel;
    }
}
