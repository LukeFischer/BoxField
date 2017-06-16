namespace BoxField
{
    partial class GameScreen
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
            this.gameLoop = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gsdestroyedLabel = new System.Windows.Forms.Label();
            this.boundaryLabel = new System.Windows.Forms.Label();
            this.pfastLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameLoop
            // 
            this.gameLoop.Enabled = true;
            this.gameLoop.Interval = 8;
            this.gameLoop.Tick += new System.EventHandler(this.gameLoop_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.timeLabel.Location = new System.Drawing.Point(35, 20);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(255, 45);
            this.timeLabel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // gsdestroyedLabel
            // 
            this.gsdestroyedLabel.BackColor = System.Drawing.Color.Transparent;
            this.gsdestroyedLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.gsdestroyedLabel.Location = new System.Drawing.Point(210, 20);
            this.gsdestroyedLabel.Name = "gsdestroyedLabel";
            this.gsdestroyedLabel.Size = new System.Drawing.Size(270, 35);
            this.gsdestroyedLabel.TabIndex = 2;
            // 
            // boundaryLabel
            // 
            this.boundaryLabel.AutoSize = true;
            this.boundaryLabel.ForeColor = System.Drawing.Color.Lime;
            this.boundaryLabel.Location = new System.Drawing.Point(245, 141);
            this.boundaryLabel.Name = "boundaryLabel";
            this.boundaryLabel.Size = new System.Drawing.Size(0, 13);
            this.boundaryLabel.TabIndex = 3;
            // 
            // pfastLabel
            // 
            this.pfastLabel.AutoSize = true;
            this.pfastLabel.BackColor = System.Drawing.Color.Transparent;
            this.pfastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pfastLabel.ForeColor = System.Drawing.Color.White;
            this.pfastLabel.Location = new System.Drawing.Point(351, 203);
            this.pfastLabel.Name = "pfastLabel";
            this.pfastLabel.Size = new System.Drawing.Size(0, 42);
            this.pfastLabel.TabIndex = 4;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pfastLabel);
            this.Controls.Add(this.boundaryLabel);
            this.Controls.Add(this.gsdestroyedLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeLabel);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(900, 500);
            this.Click += new System.EventHandler(this.GameScreen_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameLoop;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label gsdestroyedLabel;
        private System.Windows.Forms.Label boundaryLabel;
        private System.Windows.Forms.Label pfastLabel;
    }
}
