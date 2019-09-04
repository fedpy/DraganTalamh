namespace DraganTalamh
{
    partial class MainForm
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
            this.SidebarPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // SidebarPanel
            // 
            this.SidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.SidebarPanel.Name = "SidebarPanel";
            this.SidebarPanel.Size = new System.Drawing.Size(181, 508);
            this.SidebarPanel.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(180, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(556, 415);
            this.MainPanel.TabIndex = 1;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Location = new System.Drawing.Point(187, 421);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(545, 80);
            this.BottomPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(738, 507);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.SidebarPanel);
            this.Name = "MainForm";
            this.Text = "Dragan Talamh Character Creator";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel SidebarPanel;
        public System.Windows.Forms.Panel MainPanel;
        public System.Windows.Forms.Panel BottomPanel;
    }
}