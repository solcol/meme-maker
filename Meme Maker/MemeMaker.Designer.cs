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
            this.FunnyMeme = new System.Windows.Forms.PictureBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.buttonFile = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSave = new System.Windows.Forms.ToolStripMenuItem();
            this.metaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TopTextInput = new System.Windows.Forms.ToolStripTextBox();
            this.BottomTextInput = new System.Windows.Forms.ToolStripTextBox();
            this.TopLabel = new System.Windows.Forms.Label();
            this.BottomLabel = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.FunnyMeme)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // FunnyMeme
            // 
            this.FunnyMeme.BackColor = System.Drawing.SystemColors.WindowText;
            this.FunnyMeme.Cursor = System.Windows.Forms.Cursors.Default;
            this.FunnyMeme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FunnyMeme.Location = new System.Drawing.Point(0, 27);
            this.FunnyMeme.Name = "FunnyMeme";
            this.FunnyMeme.Size = new System.Drawing.Size(334, 284);
            this.FunnyMeme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FunnyMeme.TabIndex = 1;
            this.FunnyMeme.TabStop = false;
            this.FunnyMeme.Click += new System.EventHandler(this.ImageClick);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonFile,
            this.toolStripMenuItem1,
            this.TopTextInput,
            this.BottomTextInput});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(334, 27);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "Menu";
            // 
            // buttonFile
            // 
            this.buttonFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonOpen,
            this.buttonSave,
            this.metaToolStripMenuItem});
            this.buttonFile.Image = global::Meme_Maker.Properties.Resources.icons8_file_30;
            this.buttonFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(53, 23);
            this.buttonFile.Text = "File";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Image = global::Meme_Maker.Properties.Resources.icons8_image_file_30;
            this.buttonOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(139, 22);
            this.buttonOpen.Text = "Open Image";
            this.buttonOpen.Click += new System.EventHandler(this.OpenImagePrompt);
            // 
            // buttonSave
            // 
            this.buttonSave.Image = global::Meme_Maker.Properties.Resources.icons8_save_40;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(139, 22);
            this.buttonSave.Text = "Save Image";
            this.buttonSave.Click += new System.EventHandler(this.SaveImagePrompt);
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
            this.TopLabel.Size = new System.Drawing.Size(334, 100);
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
            this.BottomLabel.Location = new System.Drawing.Point(0, 211);
            this.BottomLabel.Name = "BottomLabel";
            this.BottomLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.BottomLabel.Size = new System.Drawing.Size(334, 100);
            this.BottomLabel.TabIndex = 4;
            this.BottomLabel.Text = "Bottom Text";
            this.BottomLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Image = global::Meme_Maker.Properties.Resources.icons8_rainbow_30;
            this.toolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 23);
            this.toolStripMenuItem1.Text = "Style";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::Meme_Maker.Properties.Resources.icons8_color_swatch_30;
            this.toolStripMenuItem2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Colour";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = global::Meme_Maker.Properties.Resources.icons8_type_30;
            this.toolStripMenuItem3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "Font";
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
            ((System.ComponentModel.ISupportInitialize)(this.FunnyMeme)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog ColourDialog;
        private System.Windows.Forms.PictureBox FunnyMeme;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem buttonFile;
        private System.Windows.Forms.ToolStripMenuItem buttonOpen;
        private System.Windows.Forms.ToolStripMenuItem buttonSave;
        private System.Windows.Forms.ToolStripTextBox TopTextInput;
        private System.Windows.Forms.ToolStripTextBox BottomTextInput;
        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.Label BottomLabel;
        private System.Windows.Forms.ToolStripMenuItem metaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}

