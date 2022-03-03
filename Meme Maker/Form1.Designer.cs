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
            this.ColourDialog = new System.Windows.Forms.ColorDialog();
            this.FunnyMeme = new System.Windows.Forms.PictureBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.buttonFile = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSave = new System.Windows.Forms.ToolStripMenuItem();
            this.Style = new System.Windows.Forms.ToolStripMenuItem();
            this.Colour = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TopTextInput = new System.Windows.Forms.ToolStripTextBox();
            this.BottomTextInput = new System.Windows.Forms.ToolStripTextBox();
            this.TopLabel = new System.Windows.Forms.Label();
            this.BottomLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FunnyMeme)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // FunnyMeme
            // 
            this.FunnyMeme.BackColor = System.Drawing.SystemColors.WindowText;
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
            this.Style,
            this.TopTextInput,
            this.BottomTextInput});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(334, 27);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // buttonFile
            // 
            this.buttonFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonOpen,
            this.buttonSave});
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(37, 23);
            this.buttonFile.Text = "File";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(139, 22);
            this.buttonOpen.Text = "Open Image";
            this.buttonOpen.Click += new System.EventHandler(this.OpenImagePrompt);
            // 
            // buttonSave
            // 
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(139, 22);
            this.buttonSave.Text = "Save Image";
            this.buttonSave.Click += new System.EventHandler(this.SaveImagePrompt);
            // 
            // Style
            // 
            this.Style.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Colour,
            this.fontToolStripMenuItem});
            this.Style.Name = "Style";
            this.Style.Size = new System.Drawing.Size(44, 23);
            this.Style.Text = "Style";
            this.Style.Click += new System.EventHandler(this.colourToolStripMenuItem_Click);
            // 
            // Colour
            // 
            this.Colour.Name = "Colour";
            this.Colour.Size = new System.Drawing.Size(180, 22);
            this.Colour.Text = "Colour";
            this.Colour.Click += new System.EventHandler(this.ColorPickerPrompt);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.FontPickerDialog);
            // 
            // TopTextInput
            // 
            this.TopTextInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TopTextInput.Name = "TopTextInput";
            this.TopTextInput.Size = new System.Drawing.Size(100, 23);
            this.TopTextInput.Text = "Top Text";
            this.TopTextInput.TextChanged += new System.EventHandler(this.ChangeTopText);
            // 
            // BottomTextInput
            // 
            this.BottomTextInput.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // Meme_Maker
            // 
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.BottomLabel);
            this.Controls.Add(this.TopLabel);
            this.Controls.Add(this.FunnyMeme);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "Meme_Maker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ToolStripMenuItem Style;
        private System.Windows.Forms.ToolStripMenuItem Colour;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
    }
}

