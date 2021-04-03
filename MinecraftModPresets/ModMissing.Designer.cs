
namespace MinecraftModPresets
{
    partial class ModMissing
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
            this.missingModSearchButton = new System.Windows.Forms.Button();
            this.missingModPathTextBox = new System.Windows.Forms.TextBox();
            this.missingModMessageLabel = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // missingModSearchButton
            // 
            this.missingModSearchButton.Location = new System.Drawing.Point(331, 127);
            this.missingModSearchButton.Name = "missingModSearchButton";
            this.missingModSearchButton.Size = new System.Drawing.Size(30, 30);
            this.missingModSearchButton.TabIndex = 6;
            this.missingModSearchButton.UseVisualStyleBackColor = true;
            this.missingModSearchButton.Click += new System.EventHandler(this.missingModSearchButton_Click);
            // 
            // missingModPathTextBox
            // 
            this.missingModPathTextBox.Location = new System.Drawing.Point(12, 128);
            this.missingModPathTextBox.Name = "missingModPathTextBox";
            this.missingModPathTextBox.Size = new System.Drawing.Size(313, 30);
            this.missingModPathTextBox.TabIndex = 5;
            // 
            // missingModMessageLabel
            // 
            this.missingModMessageLabel.AutoSize = true;
            this.missingModMessageLabel.Location = new System.Drawing.Point(12, 42);
            this.missingModMessageLabel.Name = "missingModMessageLabel";
            this.missingModMessageLabel.Size = new System.Drawing.Size(150, 22);
            this.missingModMessageLabel.TabIndex = 4;
            this.missingModMessageLabel.Text = "<path message>";
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(122, 164);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(108, 45);
            this.DoneButton.TabIndex = 7;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // ModMissing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(367, 244);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.missingModSearchButton);
            this.Controls.Add(this.missingModPathTextBox);
            this.Controls.Add(this.missingModMessageLabel);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(178)))), ((int)(((byte)(245)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModMissing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mod Missing";
            this.Load += new System.EventHandler(this.ModMissing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button missingModSearchButton;
        private System.Windows.Forms.TextBox missingModPathTextBox;
        private System.Windows.Forms.Label missingModMessageLabel;
        private System.Windows.Forms.Button DoneButton;
    }
}