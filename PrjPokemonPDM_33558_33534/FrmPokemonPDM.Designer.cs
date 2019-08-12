namespace PrjPokemonPDM_33558_33534
{
    partial class FrmPokemonPDM
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
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnMoveIceFang = new System.Windows.Forms.Button();
            this.lblPkmnAGlaceon = new System.Windows.Forms.Label();
            this.lblPkmnBGarchomp = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblLevelA = new System.Windows.Forms.Label();
            this.lblAttack = new System.Windows.Forms.Label();
            this.lblLevelB = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblDefense = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(12, 173);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(101, 35);
            this.btnAttack.TabIndex = 0;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            // 
            // btnMoveIceFang
            // 
            this.btnMoveIceFang.Location = new System.Drawing.Point(143, 173);
            this.btnMoveIceFang.Name = "btnMoveIceFang";
            this.btnMoveIceFang.Size = new System.Drawing.Size(101, 35);
            this.btnMoveIceFang.TabIndex = 1;
            this.btnMoveIceFang.Text = "Move (Ice Fang)";
            this.btnMoveIceFang.UseVisualStyleBackColor = true;
            // 
            // lblPkmnAGlaceon
            // 
            this.lblPkmnAGlaceon.AutoSize = true;
            this.lblPkmnAGlaceon.Location = new System.Drawing.Point(35, 21);
            this.lblPkmnAGlaceon.Name = "lblPkmnAGlaceon";
            this.lblPkmnAGlaceon.Size = new System.Drawing.Size(47, 13);
            this.lblPkmnAGlaceon.TabIndex = 2;
            this.lblPkmnAGlaceon.Text = "Glaceon";
            // 
            // lblPkmnBGarchomp
            // 
            this.lblPkmnBGarchomp.AutoSize = true;
            this.lblPkmnBGarchomp.Location = new System.Drawing.Point(165, 21);
            this.lblPkmnBGarchomp.Name = "lblPkmnBGarchomp";
            this.lblPkmnBGarchomp.Size = new System.Drawing.Size(56, 13);
            this.lblPkmnBGarchomp.TabIndex = 3;
            this.lblPkmnBGarchomp.Text = "Garchomp";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(74, 234);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 35);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblLevelA
            // 
            this.lblLevelA.AutoSize = true;
            this.lblLevelA.Enabled = false;
            this.lblLevelA.Location = new System.Drawing.Point(35, 59);
            this.lblLevelA.Name = "lblLevelA";
            this.lblLevelA.Size = new System.Drawing.Size(51, 13);
            this.lblLevelA.TabIndex = 5;
            this.lblLevelA.Text = "Level: 75";
            // 
            // lblAttack
            // 
            this.lblAttack.AutoSize = true;
            this.lblAttack.Enabled = false;
            this.lblAttack.Location = new System.Drawing.Point(35, 84);
            this.lblAttack.Name = "lblAttack";
            this.lblAttack.Size = new System.Drawing.Size(62, 13);
            this.lblAttack.TabIndex = 6;
            this.lblAttack.Text = "Attack: 123";
            // 
            // lblLevelB
            // 
            this.lblLevelB.AutoSize = true;
            this.lblLevelB.Enabled = false;
            this.lblLevelB.Location = new System.Drawing.Point(165, 59);
            this.lblLevelB.Name = "lblLevelB";
            this.lblLevelB.Size = new System.Drawing.Size(51, 13);
            this.lblLevelB.TabIndex = 7;
            this.lblLevelB.Text = "Level: 75";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Enabled = false;
            this.lblHP.Location = new System.Drawing.Point(165, 84);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(46, 13);
            this.lblHP.TabIndex = 8;
            this.lblHP.Text = "HP: 200";
            // 
            // lblDefense
            // 
            this.lblDefense.AutoSize = true;
            this.lblDefense.Enabled = false;
            this.lblDefense.Location = new System.Drawing.Point(165, 108);
            this.lblDefense.Name = "lblDefense";
            this.lblDefense.Size = new System.Drawing.Size(71, 13);
            this.lblDefense.TabIndex = 9;
            this.lblDefense.Text = "Defense: 163";
            // 
            // FrmPokemonPDM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 290);
            this.Controls.Add(this.lblDefense);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.lblLevelB);
            this.Controls.Add(this.lblAttack);
            this.Controls.Add(this.lblLevelA);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblPkmnBGarchomp);
            this.Controls.Add(this.lblPkmnAGlaceon);
            this.Controls.Add(this.btnMoveIceFang);
            this.Controls.Add(this.btnAttack);
            this.Name = "FrmPokemonPDM";
            this.Text = "Pokemon Battle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnMoveIceFang;
        private System.Windows.Forms.Label lblPkmnAGlaceon;
        private System.Windows.Forms.Label lblPkmnBGarchomp;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblLevelA;
        private System.Windows.Forms.Label lblAttack;
        private System.Windows.Forms.Label lblLevelB;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblDefense;
    }
}

