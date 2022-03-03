namespace Meme_Maker
{
    partial class Meme_Maker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meme_Maker));
            this.ColourDialog = new System.Windows.Forms.ColorDialog();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StretchToggle = new System.Windows.Forms.ToolStripMenuItem();
            this.TopTextInput = new System.Windows.Forms.ToolStripTextBox();
            this.BottomTextInput = new System.Windows.Forms.ToolStripTextBox();
            this.TopLabel = new System.Windows.Forms.Label();
            this.BottomLabel = new System.Windows.Forms.Label();
            this.FunnyMeme = new System.Windows.Forms.PictureBox();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FunnyMeme)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.styleToolStripMenuItem,
            this.TopTextInput,
            this.BottomTextInput});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(334, 27);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.metaToolStripMenuItem});
            this.fileToolStripMenuItem.Image = global::Meme_Maker.Properties.Resources.icons8_file_30;
            this.fileToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::Meme_Maker.Properties.Resources.icons8_image_file_30;
            this.openToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openToolStripMenuItem.Text = "Open Image";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenImagePrompt);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::Meme_Maker.Properties.Resources.icons8_save_40;
            this.saveToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.saveToolStripMenuItem.Text = "Save Image";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveImagePrompt);
            // 
            // metaToolStripMenuItem
            // 
            this.metaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.sourceCodeToolStripMenuItem});
            this.metaToolStripMenuItem.Image = global::Meme_Maker.Properties.Resources.icons8_circle_40;
            this.metaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metaToolStripMenuItem.Name = "metaToolStripMenuItem";
            this.metaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.metaToolStripMenuItem.Text = "Meta";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::Meme_Maker.Properties.Resources.icons8_about_40;
            this.aboutToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutPrompt);
            // 
            // sourceCodeToolStripMenuItem
            // 
            this.sourceCodeToolStripMenuItem.Image = global::Meme_Maker.Properties.Resources.icons8_source_code_40;
            this.sourceCodeToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sourceCodeToolStripMenuItem.Name = "sourceCodeToolStripMenuItem";
            this.sourceCodeToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.sourceCodeToolStripMenuItem.Text = "Source Code";
            this.sourceCodeToolStripMenuItem.Click += new System.EventHandler(this.OpenSourceCode);
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colourToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.StretchToggle});
            this.styleToolStripMenuItem.Image = global::Meme_Maker.Properties.Resources.icons8_rainbow_30;
            this.styleToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.styleToolStripMenuItem.Text = "Style";
            this.styleToolStripMenuItem.Click += new System.EventHandler(this.UpdateStretch);
            // 
            // colourToolStripMenuItem
            // 
            this.colourToolStripMenuItem.Image = global::Meme_Maker.Properties.Resources.icons8_color_swatch_30;
            this.colourToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            this.colourToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colourToolStripMenuItem.Text = "Colour";
            this.colourToolStripMenuItem.Click += new System.EventHandler(this.ColorPickerPrompt);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Image = global::Meme_Maker.Properties.Resources.icons8_type_30;
            this.fontToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.FontPickerDialog);
            // 
            // StretchToggle
            // 
            this.StretchToggle.Checked = true;
            this.StretchToggle.CheckOnClick = true;
            this.StretchToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StretchToggle.Image = global::Meme_Maker.Properties.Resources.icons8_screen_resolution_30;
            this.StretchToggle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StretchToggle.Name = "StretchToggle";
            this.StretchToggle.Size = new System.Drawing.Size(180, 22);
            this.StretchToggle.Text = "Stretch Image";
            this.StretchToggle.CheckedChanged += new System.EventHandler(this.UpdateStretch);
            this.StretchToggle.Click += new System.EventHandler(this.UpdateStretch);
            // 
            // TopTextInput
            // 
            this.TopTextInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TopTextInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.TopTextInput.Name = "TopTextInput";
            this.TopTextInput.Size = new System.Drawing.Size(100, 23);
            this.TopTextInput.Text = "Top Text";
            this.TopTextInput.TextChanged += new System.EventHandler(this.ChangeTopText);
            // 
            // BottomTextInput
            // 
            this.BottomTextInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.BottomTextInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.BottomTextInput.Name = "BottomTextInput";
            this.BottomTextInput.Size = new System.Drawing.Size(100, 23);
            this.BottomTextInput.Text = "Bottom Text";
            this.BottomTextInput.TextChanged += new System.EventHandler(this.ChangeBottomText);
            // 
            // TopLabel
            // 
            this.TopLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopLabel.BackColor = System.Drawing.Color.Transparent;
            this.TopLabel.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TopLabel.Location = new System.Drawing.Point(0, 27);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.TopLabel.Size = new System.Drawing.Size(334, 60);
            this.TopLabel.TabIndex = 3;
            this.TopLabel.Text = "Top Text";
            this.TopLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BottomLabel
            // 
            this.BottomLabel.BackColor = System.Drawing.Color.Transparent;
            this.BottomLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomLabel.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BottomLabel.Location = new System.Drawing.Point(0, 251);
            this.BottomLabel.Name = "BottomLabel";
            this.BottomLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.BottomLabel.Size = new System.Drawing.Size(334, 60);
            this.BottomLabel.TabIndex = 4;
            this.BottomLabel.Text = "Bottom Text";
            this.BottomLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // FunnyMeme
            // 
            this.FunnyMeme.BackColor = System.Drawing.SystemColors.WindowText;
            this.FunnyMeme.Cursor = System.Windows.Forms.Cursors.Default;
            this.FunnyMeme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FunnyMeme.Image = global::Meme_Maker.Properties.Resources.placeholder;
            this.FunnyMeme.Location = new System.Drawing.Point(0, 27);
            this.FunnyMeme.Name = "FunnyMeme";
            this.FunnyMeme.Size = new System.Drawing.Size(334, 284);
            this.FunnyMeme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FunnyMeme.TabIndex = 1;
            this.FunnyMeme.TabStop = false;
            // 
            // Meme_Maker
            // 
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.BottomLabel);
            this.Controls.Add(this.TopLabel);
            this.Controls.Add(this.FunnyMeme);
            this.Controls.Add(this.MenuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "Meme_Maker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meme Generator";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FunnyMeme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog ColourDialog;
        private System.Windows.Forms.PictureBox FunnyMeme;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox TopTextInput;
        private System.Windows.Forms.ToolStripTextBox BottomTextInput;
        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.Label BottomLabel;
        private System.Windows.Forms.ToolStripMenuItem metaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StretchToggle;
    }
}

