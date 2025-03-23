using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pin_Throw
{
    public partial class FSettings : Form
    {
        public FSettings()
        {
            InitializeComponent();
        }

        public void SetDifficulty(string difficulty)
        {
            switch (difficulty)
            {
                case "Easy":
                    RBEasy.Checked = true;
                    break;
                case "Medium":
                    RBMedium.Checked = true;
                    break;
                case "Hard":
                    RBHard.Checked = true;
                    break;
            }
        }

        public string GetDifficulty()
        {
            if (RBEasy.Checked)
            {
                return "Easy";
            }
            else if(RBMedium.Checked)
            {
                return "Medium";
            }
            else
            {
                return "Hard";
            }
        }

        public void SetMuted(bool sound)
        {
            CBSound.Checked = sound;
        }

        public bool GetMuted()
        {
            return CBSound.Checked;
        }
    }
}
