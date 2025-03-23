namespace Pin_Throw
{
    partial class FSettings
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GBDifficulty = new System.Windows.Forms.GroupBox();
            this.RBHard = new System.Windows.Forms.RadioButton();
            this.RBMedium = new System.Windows.Forms.RadioButton();
            this.RBEasy = new System.Windows.Forms.RadioButton();
            this.CBSound = new System.Windows.Forms.CheckBox();
            this.BOk = new System.Windows.Forms.Button();
            this.BCancel = new System.Windows.Forms.Button();
            this.GBDifficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBDifficulty
            // 
            this.GBDifficulty.Controls.Add(this.RBHard);
            this.GBDifficulty.Controls.Add(this.RBMedium);
            this.GBDifficulty.Controls.Add(this.RBEasy);
            this.GBDifficulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBDifficulty.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GBDifficulty.Location = new System.Drawing.Point(18, 32);
            this.GBDifficulty.Name = "GBDifficulty";
            this.GBDifficulty.Size = new System.Drawing.Size(269, 137);
            this.GBDifficulty.TabIndex = 0;
            this.GBDifficulty.TabStop = false;
            this.GBDifficulty.Text = "Nehézség";
            // 
            // RBHard
            // 
            this.RBHard.AutoSize = true;
            this.RBHard.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RBHard.Location = new System.Drawing.Point(21, 97);
            this.RBHard.Name = "RBHard";
            this.RBHard.Size = new System.Drawing.Size(83, 25);
            this.RBHard.TabIndex = 2;
            this.RBHard.TabStop = true;
            this.RBHard.Text = "Nehéz";
            this.RBHard.UseVisualStyleBackColor = true;
            // 
            // RBMedium
            // 
            this.RBMedium.AutoSize = true;
            this.RBMedium.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RBMedium.Location = new System.Drawing.Point(21, 66);
            this.RBMedium.Name = "RBMedium";
            this.RBMedium.Size = new System.Drawing.Size(105, 25);
            this.RBMedium.TabIndex = 1;
            this.RBMedium.TabStop = true;
            this.RBMedium.Text = "Közepes";
            this.RBMedium.UseVisualStyleBackColor = true;
            // 
            // RBEasy
            // 
            this.RBEasy.AutoSize = true;
            this.RBEasy.Checked = true;
            this.RBEasy.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RBEasy.Location = new System.Drawing.Point(21, 35);
            this.RBEasy.Name = "RBEasy";
            this.RBEasy.Size = new System.Drawing.Size(94, 25);
            this.RBEasy.TabIndex = 0;
            this.RBEasy.TabStop = true;
            this.RBEasy.Text = "Könnyű";
            this.RBEasy.UseVisualStyleBackColor = true;
            // 
            // CBSound
            // 
            this.CBSound.AutoSize = true;
            this.CBSound.Checked = true;
            this.CBSound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBSound.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBSound.Location = new System.Drawing.Point(28, 202);
            this.CBSound.Name = "CBSound";
            this.CBSound.Size = new System.Drawing.Size(87, 31);
            this.CBSound.TabIndex = 1;
            this.CBSound.Text = "Hang";
            this.CBSound.UseVisualStyleBackColor = true;
            // 
            // BOk
            // 
            this.BOk.BackColor = System.Drawing.Color.White;
            this.BOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BOk.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BOk.Location = new System.Drawing.Point(28, 276);
            this.BOk.Name = "BOk";
            this.BOk.Size = new System.Drawing.Size(120, 50);
            this.BOk.TabIndex = 2;
            this.BOk.Text = "Mentés";
            this.BOk.UseVisualStyleBackColor = false;
            // 
            // BCancel
            // 
            this.BCancel.BackColor = System.Drawing.Color.White;
            this.BCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BCancel.Location = new System.Drawing.Point(170, 276);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(120, 50);
            this.BCancel.TabIndex = 3;
            this.BCancel.Text = "Mégse";
            this.BCancel.UseVisualStyleBackColor = false;
            // 
            // FSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(319, 358);
            this.ControlBox = false;
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BOk);
            this.Controls.Add(this.CBSound);
            this.Controls.Add(this.GBDifficulty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Beállítások";
            this.GBDifficulty.ResumeLayout(false);
            this.GBDifficulty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox GBDifficulty;
        private RadioButton RBHard;
        private RadioButton RBMedium;
        private RadioButton RBEasy;
        private CheckBox CBSound;
        private Button BOk;
        private Button BCancel;
    }
}