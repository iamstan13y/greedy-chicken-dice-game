using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GreedyChicken.Properties;

namespace GreedyChicken
{
    public partial class GameSettings : Form
    {
        public GameSettings()
        {
            InitializeComponent();
        }

        private void btnColor1_Click(object sender, EventArgs e)
        {
            PickColor(btnColor1);
        }

        private void btnColor2_Click(object sender, EventArgs e)
        {
            PickColor(btnColor2);
        }

        private void btnColor3_Click(object sender, EventArgs e)
        {
            PickColor(btnColor3);
        }

        private void btnColor4_Click(object sender, EventArgs e)
        {
            PickColor(btnColor4);
        }

        public void PickColor(Button buttonName)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonName.BackColor = colorDialog.Color;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                int players = int.Parse(txtPlayers.Text);
                int goal = int.Parse(txtGoal.Text);

                if (!(players < 2 || players > 4))
                {
                    if (!(goal < 10 || goal > 1000))
                    {
                        gboNames.Enabled = true;
                        btnStart.Enabled = true;
                        PlayerCheck(players);
                    }
                    else
                    {
                        MessageBox.Show("Goal out range. Should be between 10 and 1000", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Number of players out range. Should be between 2 and 4", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PlayerCheck(int players)
        {
            if (players == 3)
            {
                txtPlayer4.Enabled = false;
                btnColor4.Enabled = false;
                txtPlayer3.Enabled = true;
                btnColor3.Enabled = true;
            }
            else if ( players < 3)
            {
                txtPlayer4.Enabled = false;
                btnColor4.Enabled = false;
                txtPlayer3.Enabled = false;
                btnColor3.Enabled = false;
            }
            else
            {
                txtPlayer4.Enabled = true;
                btnColor4.Enabled = true;
                txtPlayer3.Enabled = true;
                btnColor3.Enabled = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int Goal = int.Parse(txtGoal.Text);
            Properties.Settings.Default.Goal = Goal;
            Properties.Settings.Default.Save();

           List<string> names = new List<string>();
           List<Color> colors = new List<Color>();
             
            foreach(TextBox textbox in gboNames.Controls.OfType<TextBox>())
            {
                if (textbox.Enabled == true)
                {
                    names.Add(textbox.Text);
                }
            }

            foreach (Button button in gboNames.Controls.OfType<Button>())
            {
                if (button.Enabled == true)
                colors.Add(button.BackColor);
            }

            Main mainForm = new Main();
            mainForm.Names = names;
            mainForm.Colors = colors;
            mainForm.Show();
            Hide();
        }
        
    }
}
