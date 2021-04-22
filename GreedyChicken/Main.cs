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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        List<string> names;
        List<Color> colors;
        int nameIndex = 0;
        int bank = 0;
        int chances = 0;
        int goal = Settings.Default.Goal;
        Panel[] panels;

        public List<string> Names
        {
            set
            {
                names = value;
            }
        }

        public List<Color> Colors
        {
            set
            {
                colors = value;
            }
        }

        public IEnumerable<Panel> AllPanels(bool visible)
        {
            var Panels = from control in Controls.OfType<Panel>()
                         where control.Visible == visible
                         orderby control.Name ascending
                         select control;

            return Panels;
        }

        public int RollDice()
        {
            Random rnd = new Random();
            int side = rnd.Next(1, 7);
            int bonus = 0;

            switch (side)
            {
                case 1:
                    picBoxDie.Image = Image.FromFile(".//Images//dice1.png");
                    bonus = 1;
                    break;
                case 2:
                    picBoxDie.Image = Image.FromFile(".//Images//dice2.png");
                    bonus = 2;
                    break;
                case 3:
                    picBoxDie.Image = Image.FromFile(".//Images//dice3.png");
                    bonus = 3;
                    break;
                case 4:
                    picBoxDie.Image = Image.FromFile(".//Images//dice4.png");
                    bonus = 4;
                    break;
                case 5:
                    picBoxDie.Image = Image.FromFile(".//Images//dice5.png");
                    bonus = 5;
                    break;
                case 6:
                    picBoxDie.Image = Image.FromFile(".//Images//dice6.png");
                    bonus = 6;
                    break;
                default:
                    picBoxDie.Image = Image.FromFile(".//Images//dice.png");
                    break;
            }

            return bonus;
        }

        public void Save()
        {
            panels = AllPanels(true).ToArray();
            foreach (Label label in panels[nameIndex].Controls.OfType<Label>())
            {
                if (label.Name.StartsWith("lblScore"))
                {
                    label.Text = (bank + int.Parse(label.Text)).ToString();
                    if (int.Parse(label.Text) >= goal)
                    {
                        MessageBox.Show($"{names[(nameIndex) % names.Count]} wins the game!", "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GameOver();
                        break;
                    }
                    Turns();
                    break;
                }
            }
        }
        public void Turns()
        {
            panels = AllPanels(true).ToArray();
            foreach (Label label in panels[nameIndex].Controls.OfType<Label>())
            {
                if (label.Name.StartsWith("lblBank"))
                {
                    label.Text = "0";
                }
            }

            bank = 0;
            chances = 0;
            nameIndex++;
            if (nameIndex >= names.Count)
            {
                nameIndex = 0;
            }
            lblTurns.Text = string.Format($"Its {names[nameIndex]}'s Turn.");
        }

        public void GameOver()
        {
            nameIndex = 0;
            bank = 0;
            chances = 0;
            lblTurns.Text = string.Format($"Its {names[nameIndex]}'s Turn.");
            picBoxDie.Image = Image.FromFile(".//Images//dice.png");

            foreach (Panel panel in AllPanels(true))
            {
                foreach (Label label in panel.Controls.OfType<Label>())
                {
                    if (label.Name.StartsWith("lblBank") || label.Name.StartsWith("lblScore"))
                    {
                        label.Text = "0";
                    }
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblTurns.Text = string.Format($"Its {names[nameIndex]}'s Turn.");
            int i = 0;
            foreach (Panel panel in AllPanels(false))
            {
                if ((i <= colors.Count - 1))
                {
                    panel.Visible = true;
                    panel.BackColor = colors[i];

                    foreach (Label label in panel.Controls.OfType<Label>())
                    {
                        if (label.Text == "Name")
                        {
                            label.Text = names[i];
                        }
                    }
                    i++;
                }
                else
                {
                    break;
                }
            }
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            Panel[] panels = AllPanels(true).ToArray();
            if (nameIndex >= names.Count)
            {
                nameIndex = 0;
            }

            foreach (Label label in panels[nameIndex].Controls.OfType<Label>())
            {
                if (chances < 2)
                {
                    if (label.Name.StartsWith("lblBank"))
                    {
                        int side = RollDice();
                        label.Text = side != 1 ? (side + int.Parse(label.Text)).ToString() : "0";
                        chances++;

                        if (side == 1)
                        {
                            lblInfo.Visible = true;
                            Turns();
                            break;
                        }
                        bank = int.Parse(label.Text);
                        break;
                    }
                }
                else
                {
                    Save();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
