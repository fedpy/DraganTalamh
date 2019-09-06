namespace DraganTalamh.GUI
{
    partial class MenuScreenController
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
            this.buttonMainScreen = new System.Windows.Forms.Button();
            this.buttonRaceScreen = new System.Windows.Forms.Button();
            this.buttonClassScreen = new System.Windows.Forms.Button();
            this.buttonAbilityPointsScreen = new System.Windows.Forms.Button();
            this.buttonClassAbilitiesScreen = new System.Windows.Forms.Button();
            this.buttonLayoutScreen = new System.Windows.Forms.Button();
            this.buttonBackgroundScreen = new System.Windows.Forms.Button();
            this.buttonOverviewScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMainScreen
            // 
            this.buttonMainScreen.Location = new System.Drawing.Point(3, 3);
            this.buttonMainScreen.Name = "buttonMainScreen";
            this.buttonMainScreen.Size = new System.Drawing.Size(175, 45);
            this.buttonMainScreen.TabIndex = 0;
            this.buttonMainScreen.Text = "Main Screen";
            this.buttonMainScreen.UseVisualStyleBackColor = true;
            this.buttonMainScreen.Click += new System.EventHandler(this.OnMainScreenButtonClick);
            // 
            // buttonRaceScreen
            // 
            this.buttonRaceScreen.Location = new System.Drawing.Point(3, 54);
            this.buttonRaceScreen.Name = "buttonRaceScreen";
            this.buttonRaceScreen.Size = new System.Drawing.Size(175, 45);
            this.buttonRaceScreen.TabIndex = 1;
            this.buttonRaceScreen.Text = "Character Race";
            this.buttonRaceScreen.UseVisualStyleBackColor = true;
            this.buttonRaceScreen.Click += new System.EventHandler(this.OnRaceScreenButtonClick);
            // 
            // buttonClassScreen
            // 
            this.buttonClassScreen.Location = new System.Drawing.Point(3, 105);
            this.buttonClassScreen.Name = "buttonClassScreen";
            this.buttonClassScreen.Size = new System.Drawing.Size(175, 45);
            this.buttonClassScreen.TabIndex = 2;
            this.buttonClassScreen.Text = "Character Class";
            this.buttonClassScreen.UseVisualStyleBackColor = true;
            this.buttonClassScreen.Click += new System.EventHandler(this.OnClassScreenButtonClick);
            // 
            // buttonAbilityPointsScreen
            // 
            this.buttonAbilityPointsScreen.Location = new System.Drawing.Point(3, 156);
            this.buttonAbilityPointsScreen.Name = "buttonAbilityPointsScreen";
            this.buttonAbilityPointsScreen.Size = new System.Drawing.Size(175, 45);
            this.buttonAbilityPointsScreen.TabIndex = 3;
            this.buttonAbilityPointsScreen.Text = "Ability Points";
            this.buttonAbilityPointsScreen.UseVisualStyleBackColor = true;
            this.buttonAbilityPointsScreen.Click += new System.EventHandler(this.OnAbilityPointsScreenButtonClick);
            // 
            // buttonClassAbilitiesScreen
            // 
            this.buttonClassAbilitiesScreen.Location = new System.Drawing.Point(3, 207);
            this.buttonClassAbilitiesScreen.Name = "buttonClassAbilitiesScreen";
            this.buttonClassAbilitiesScreen.Size = new System.Drawing.Size(175, 45);
            this.buttonClassAbilitiesScreen.TabIndex = 4;
            this.buttonClassAbilitiesScreen.Text = "Class Abilities";
            this.buttonClassAbilitiesScreen.UseVisualStyleBackColor = true;
            this.buttonClassAbilitiesScreen.Click += new System.EventHandler(this.OnClassAbilitiesButtonClick);
            // 
            // buttonLayoutScreen
            // 
            this.buttonLayoutScreen.Location = new System.Drawing.Point(3, 258);
            this.buttonLayoutScreen.Name = "buttonLayoutScreen";
            this.buttonLayoutScreen.Size = new System.Drawing.Size(175, 45);
            this.buttonLayoutScreen.TabIndex = 5;
            this.buttonLayoutScreen.Text = "Layout";
            this.buttonLayoutScreen.UseVisualStyleBackColor = true;
            this.buttonLayoutScreen.Click += new System.EventHandler(this.OnLayoutScreenButtonClick);
            // 
            // buttonBackgroundScreen
            // 
            this.buttonBackgroundScreen.Location = new System.Drawing.Point(3, 309);
            this.buttonBackgroundScreen.Name = "buttonBackgroundScreen";
            this.buttonBackgroundScreen.Size = new System.Drawing.Size(175, 45);
            this.buttonBackgroundScreen.TabIndex = 6;
            this.buttonBackgroundScreen.Text = "Background";
            this.buttonBackgroundScreen.UseVisualStyleBackColor = true;
            this.buttonBackgroundScreen.Click += new System.EventHandler(this.OnBackgroundScreenButtonClick);
            // 
            // buttonOverviewScreen
            // 
            this.buttonOverviewScreen.Location = new System.Drawing.Point(3, 360);
            this.buttonOverviewScreen.Name = "buttonOverviewScreen";
            this.buttonOverviewScreen.Size = new System.Drawing.Size(175, 45);
            this.buttonOverviewScreen.TabIndex = 7;
            this.buttonOverviewScreen.Text = "Overview";
            this.buttonOverviewScreen.UseVisualStyleBackColor = true;
            this.buttonOverviewScreen.Click += new System.EventHandler(this.OnOverviewScreenButtonClick);
            // 
            // MenuScreenController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.buttonOverviewScreen);
            this.Controls.Add(this.buttonBackgroundScreen);
            this.Controls.Add(this.buttonLayoutScreen);
            this.Controls.Add(this.buttonClassAbilitiesScreen);
            this.Controls.Add(this.buttonAbilityPointsScreen);
            this.Controls.Add(this.buttonClassScreen);
            this.Controls.Add(this.buttonRaceScreen);
            this.Controls.Add(this.buttonMainScreen);
            this.Name = "MenuScreenController";
            this.Size = new System.Drawing.Size(181, 508);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMainScreen;
        private System.Windows.Forms.Button buttonRaceScreen;
        private System.Windows.Forms.Button buttonClassScreen;
        private System.Windows.Forms.Button buttonAbilityPointsScreen;
        private System.Windows.Forms.Button buttonClassAbilitiesScreen;
        private System.Windows.Forms.Button buttonLayoutScreen;
        private System.Windows.Forms.Button buttonBackgroundScreen;
        private System.Windows.Forms.Button buttonOverviewScreen;
    }
}
