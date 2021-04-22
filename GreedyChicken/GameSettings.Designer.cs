namespace GreedyChicken
{
    partial class GameSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGoal = new System.Windows.Forms.TextBox();
            this.txtPlayers = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.gboNames = new System.Windows.Forms.GroupBox();
            this.btnColor4 = new System.Windows.Forms.Button();
            this.btnColor3 = new System.Windows.Forms.Button();
            this.btnColor2 = new System.Windows.Forms.Button();
            this.btnColor1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPlayer4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPlayer3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gboNames.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Game Settings";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGoal);
            this.groupBox1.Controls.Add(this.txtPlayers);
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 111);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Goal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "No. of Players:";
            // 
            // txtGoal
            // 
            this.txtGoal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoal.Location = new System.Drawing.Point(122, 62);
            this.txtGoal.Name = "txtGoal";
            this.txtGoal.Size = new System.Drawing.Size(159, 26);
            this.txtGoal.TabIndex = 3;
            // 
            // txtPlayers
            // 
            this.txtPlayers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayers.Location = new System.Drawing.Point(122, 24);
            this.txtPlayers.Name = "txtPlayers";
            this.txtPlayers.Size = new System.Drawing.Size(159, 26);
            this.txtPlayers.TabIndex = 2;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(347, 29);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(135, 53);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // gboNames
            // 
            this.gboNames.Controls.Add(this.btnColor4);
            this.gboNames.Controls.Add(this.btnColor3);
            this.gboNames.Controls.Add(this.btnColor2);
            this.gboNames.Controls.Add(this.btnColor1);
            this.gboNames.Controls.Add(this.label7);
            this.gboNames.Controls.Add(this.txtPlayer4);
            this.gboNames.Controls.Add(this.label6);
            this.gboNames.Controls.Add(this.txtPlayer3);
            this.gboNames.Controls.Add(this.label4);
            this.gboNames.Controls.Add(this.label5);
            this.gboNames.Controls.Add(this.txtPlayer2);
            this.gboNames.Controls.Add(this.txtPlayer1);
            this.gboNames.Enabled = false;
            this.gboNames.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboNames.Location = new System.Drawing.Point(5, 221);
            this.gboNames.Name = "gboNames";
            this.gboNames.Size = new System.Drawing.Size(530, 157);
            this.gboNames.TabIndex = 4;
            this.gboNames.TabStop = false;
            this.gboNames.Text = "Names";
            // 
            // btnColor4
            // 
            this.btnColor4.BackColor = System.Drawing.Color.Aqua;
            this.btnColor4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor4.Location = new System.Drawing.Point(502, 95);
            this.btnColor4.Name = "btnColor4";
            this.btnColor4.Size = new System.Drawing.Size(28, 28);
            this.btnColor4.TabIndex = 13;
            this.btnColor4.UseVisualStyleBackColor = false;
            this.btnColor4.Click += new System.EventHandler(this.btnColor4_Click);
            // 
            // btnColor3
            // 
            this.btnColor3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnColor3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor3.Location = new System.Drawing.Point(224, 95);
            this.btnColor3.Name = "btnColor3";
            this.btnColor3.Size = new System.Drawing.Size(28, 28);
            this.btnColor3.TabIndex = 12;
            this.btnColor3.UseVisualStyleBackColor = false;
            this.btnColor3.Click += new System.EventHandler(this.btnColor3_Click);
            // 
            // btnColor2
            // 
            this.btnColor2.BackColor = System.Drawing.Color.Red;
            this.btnColor2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor2.Location = new System.Drawing.Point(499, 28);
            this.btnColor2.Name = "btnColor2";
            this.btnColor2.Size = new System.Drawing.Size(28, 28);
            this.btnColor2.TabIndex = 11;
            this.btnColor2.UseVisualStyleBackColor = false;
            this.btnColor2.Click += new System.EventHandler(this.btnColor2_Click);
            // 
            // btnColor1
            // 
            this.btnColor1.BackColor = System.Drawing.Color.Lime;
            this.btnColor1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor1.Location = new System.Drawing.Point(224, 29);
            this.btnColor1.Name = "btnColor1";
            this.btnColor1.Size = new System.Drawing.Size(28, 28);
            this.btnColor1.TabIndex = 10;
            this.btnColor1.UseVisualStyleBackColor = false;
            this.btnColor1.Click += new System.EventHandler(this.btnColor1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Player 4:";
            // 
            // txtPlayer4
            // 
            this.txtPlayer4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer4.Location = new System.Drawing.Point(357, 96);
            this.txtPlayer4.Name = "txtPlayer4";
            this.txtPlayer4.Size = new System.Drawing.Size(136, 26);
            this.txtPlayer4.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Player 2:";
            // 
            // txtPlayer3
            // 
            this.txtPlayer3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer3.Location = new System.Drawing.Point(81, 96);
            this.txtPlayer3.Name = "txtPlayer3";
            this.txtPlayer3.Size = new System.Drawing.Size(136, 26);
            this.txtPlayer3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Player 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Player 1:";
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer2.Location = new System.Drawing.Point(357, 30);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(136, 26);
            this.txtPlayer2.TabIndex = 3;
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer1.Location = new System.Drawing.Point(82, 30);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(136, 26);
            this.txtPlayer1.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(193, 384);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(135, 53);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // GameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 463);
            this.ControlBox = false;
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gboNames);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboNames.ResumeLayout(false);
            this.gboNames.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGoal;
        private System.Windows.Forms.TextBox txtPlayers;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox gboNames;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPlayer4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPlayer3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.Button btnColor4;
        private System.Windows.Forms.Button btnColor3;
        private System.Windows.Forms.Button btnColor2;
        private System.Windows.Forms.Button btnColor1;
        private System.Windows.Forms.Button btnStart;
    }
}