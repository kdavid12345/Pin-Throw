namespace Pin_Throw
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LTitle = new System.Windows.Forms.Label();
            this.BPlay = new System.Windows.Forms.Button();
            this.BSettings = new System.Windows.Forms.Button();
            this.BExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LTitle
            // 
            this.LTitle.Font = new System.Drawing.Font("Courier New", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LTitle.Location = new System.Drawing.Point(117, 70);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(600, 100);
            this.LTitle.TabIndex = 0;
            this.LTitle.Text = "Pin Throw";
            this.LTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BPlay
            // 
            this.BPlay.BackColor = System.Drawing.Color.White;
            this.BPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BPlay.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BPlay.Location = new System.Drawing.Point(317, 220);
            this.BPlay.Name = "BPlay";
            this.BPlay.Size = new System.Drawing.Size(200, 100);
            this.BPlay.TabIndex = 1;
            this.BPlay.Text = "Játék";
            this.BPlay.UseVisualStyleBackColor = false;
            this.BPlay.Click += new System.EventHandler(this.BPlay_Click);
            // 
            // BSettings
            // 
            this.BSettings.BackColor = System.Drawing.Color.White;
            this.BSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSettings.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BSettings.Location = new System.Drawing.Point(325, 345);
            this.BSettings.Name = "BSettings";
            this.BSettings.Size = new System.Drawing.Size(185, 90);
            this.BSettings.TabIndex = 2;
            this.BSettings.Text = "Beállítá-sok";
            this.BSettings.UseVisualStyleBackColor = false;
            this.BSettings.Click += new System.EventHandler(this.BSettings_Click);
            // 
            // BExit
            // 
            this.BExit.BackColor = System.Drawing.Color.White;
            this.BExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BExit.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BExit.Location = new System.Drawing.Point(335, 460);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(164, 80);
            this.BExit.TabIndex = 3;
            this.BExit.Text = "Kilépés";
            this.BExit.UseVisualStyleBackColor = false;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 611);
            this.Controls.Add(this.BExit);
            this.Controls.Add(this.BSettings);
            this.Controls.Add(this.BPlay);
            this.Controls.Add(this.LTitle);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 650);
            this.MinimumSize = new System.Drawing.Size(850, 650);
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private Label LTitle;
        private Button BPlay;
        private Button BSettings;
        private Button BExit;
    }
}