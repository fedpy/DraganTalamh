namespace DraganTalamh.GUI
{
    partial class StartScreenController
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
            this.buttonCreateNewCharacter = new System.Windows.Forms.Button();
            this.buttonLoadCharacter = new System.Windows.Forms.Button();
            this.buttonCreateRandomCharacter = new System.Windows.Forms.Button();
            this.buttonBlankCharacterSheet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateNewCharacter
            // 
            this.buttonCreateNewCharacter.Location = new System.Drawing.Point(195, 64);
            this.buttonCreateNewCharacter.Name = "buttonCreateNewCharacter";
            this.buttonCreateNewCharacter.Size = new System.Drawing.Size(174, 48);
            this.buttonCreateNewCharacter.TabIndex = 0;
            this.buttonCreateNewCharacter.Text = "Create a new character";
            this.buttonCreateNewCharacter.UseVisualStyleBackColor = true;
            // 
            // buttonLoadCharacter
            // 
            this.buttonLoadCharacter.Location = new System.Drawing.Point(195, 145);
            this.buttonLoadCharacter.Name = "buttonLoadCharacter";
            this.buttonLoadCharacter.Size = new System.Drawing.Size(174, 48);
            this.buttonLoadCharacter.TabIndex = 1;
            this.buttonLoadCharacter.Text = "Load a character";
            this.buttonLoadCharacter.UseVisualStyleBackColor = true;
            // 
            // buttonCreateRandomCharacter
            // 
            this.buttonCreateRandomCharacter.Location = new System.Drawing.Point(195, 229);
            this.buttonCreateRandomCharacter.Name = "buttonCreateRandomCharacter";
            this.buttonCreateRandomCharacter.Size = new System.Drawing.Size(174, 49);
            this.buttonCreateRandomCharacter.TabIndex = 2;
            this.buttonCreateRandomCharacter.Text = "Create a random character";
            this.buttonCreateRandomCharacter.UseVisualStyleBackColor = true;
            // 
            // buttonBlankCharacterSheet
            // 
            this.buttonBlankCharacterSheet.Location = new System.Drawing.Point(195, 313);
            this.buttonBlankCharacterSheet.Name = "buttonBlankCharacterSheet";
            this.buttonBlankCharacterSheet.Size = new System.Drawing.Size(174, 49);
            this.buttonBlankCharacterSheet.TabIndex = 3;
            this.buttonBlankCharacterSheet.Text = "Blank character sheet";
            this.buttonBlankCharacterSheet.UseVisualStyleBackColor = true;
            // 
            // StartScreenController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.buttonBlankCharacterSheet);
            this.Controls.Add(this.buttonCreateRandomCharacter);
            this.Controls.Add(this.buttonLoadCharacter);
            this.Controls.Add(this.buttonCreateNewCharacter);
            this.Name = "StartScreenController";
            this.Size = new System.Drawing.Size(556, 415);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateNewCharacter;
        private System.Windows.Forms.Button buttonLoadCharacter;
        private System.Windows.Forms.Button buttonCreateRandomCharacter;
        private System.Windows.Forms.Button buttonBlankCharacterSheet;
    }
}
