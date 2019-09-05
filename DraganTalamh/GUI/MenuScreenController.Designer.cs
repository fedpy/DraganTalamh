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
            this.SuspendLayout();
            // 
            // buttonMainScreen
            // 
            this.buttonMainScreen.Location = new System.Drawing.Point(3, 16);
            this.buttonMainScreen.Name = "buttonMainScreen";
            this.buttonMainScreen.Size = new System.Drawing.Size(175, 51);
            this.buttonMainScreen.TabIndex = 0;
            this.buttonMainScreen.Text = "Main Screen";
            this.buttonMainScreen.UseVisualStyleBackColor = true;
            this.buttonMainScreen.Click += new System.EventHandler(this.OnMainScreenButtonClick);
            // 
            // buttonRaceScreen
            // 
            this.buttonRaceScreen.Location = new System.Drawing.Point(3, 73);
            this.buttonRaceScreen.Name = "buttonRaceScreen";
            this.buttonRaceScreen.Size = new System.Drawing.Size(175, 53);
            this.buttonRaceScreen.TabIndex = 1;
            this.buttonRaceScreen.Text = "Character Race";
            this.buttonRaceScreen.UseVisualStyleBackColor = true;
            this.buttonRaceScreen.Click += new System.EventHandler(this.OnRaceScreenButtonClick);
            // 
            // PaginationScreenController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.buttonRaceScreen);
            this.Controls.Add(this.buttonMainScreen);
            this.Name = "PaginationScreenController";
            this.Size = new System.Drawing.Size(181, 508);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMainScreen;
        private System.Windows.Forms.Button buttonRaceScreen;
    }
}
