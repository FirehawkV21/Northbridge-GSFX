namespace Northbridge_Game_SFX
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.ExtractButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AutoLaunchButton = new System.Windows.Forms.CheckBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.GamePathBox = new System.Windows.Forms.TextBox();
            this.GameVersionLabel = new System.Windows.Forms.Label();
            this.GameExtractPicker = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // ExtractButton
            // 
            resources.ApplyResources(this.ExtractButton, "ExtractButton");
            this.ExtractButton.Name = "ExtractButton";
            this.ExtractButton.UseVisualStyleBackColor = true;
            this.ExtractButton.Click += new System.EventHandler(this.ExtractButton_Click);
            // 
            // ExitButton
            // 
            resources.ApplyResources(this.ExitButton, "ExitButton");
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // AutoLaunchButton
            // 
            resources.ApplyResources(this.AutoLaunchButton, "AutoLaunchButton");
            this.AutoLaunchButton.Name = "AutoLaunchButton";
            this.AutoLaunchButton.UseVisualStyleBackColor = true;
            // 
            // BrowseButton
            // 
            resources.ApplyResources(this.BrowseButton, "BrowseButton");
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // GamePathBox
            // 
            resources.ApplyResources(this.GamePathBox, "GamePathBox");
            this.GamePathBox.Name = "GamePathBox";
            this.GamePathBox.TextChanged += new System.EventHandler(this.GamePathBox_TextChanged);
            // 
            // GameVersionLabel
            // 
            resources.ApplyResources(this.GameVersionLabel, "GameVersionLabel");
            this.GameVersionLabel.Name = "GameVersionLabel";
            // 
            // GameExtractPicker
            // 
            resources.ApplyResources(this.GameExtractPicker, "GameExtractPicker");
            // 
            // BaseForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GameVersionLabel);
            this.Controls.Add(this.GamePathBox);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.AutoLaunchButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ExtractButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BaseForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExtractButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.CheckBox AutoLaunchButton;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TextBox GamePathBox;
        private System.Windows.Forms.Label GameVersionLabel;
        private System.Windows.Forms.FolderBrowserDialog GameExtractPicker;
    }
}

