using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Meme_Maker
{
    public partial class Meme_Maker : Form
    {
        OpenFileDialog OpenImageFile;
        FontDialog FontPicker;

        bool ImageChanged = false;

        Font LabelFont = new Font("Impact", 18);

        public Meme_Maker()
        {
            InitializeComponent();

            FunnyMeme.Controls.Add(TopLabel);
            FunnyMeme.Controls.Add(BottomLabel);

            TopLabel.Location = new Point(0, this.MenuStrip.Height * 2);
            BottomLabel.Location = new Point(0, this.Height - this.MenuStrip.Height);

            TopLabel.Font = BottomLabel.Font = LabelFont;

            FunnyMeme.SendToBack();
        }

        private void ChangeTopText(object sender, EventArgs e)
        {
            TopLabel.Text = TopTextInput.Text;
        }

        private void ChangeBottomText(object sender, EventArgs e)
        {
            BottomLabel.Text = BottomTextInput.Text;
        }

        private void OpenImagePrompt(object sender, EventArgs e)
        {
            OpenImageFile = new OpenFileDialog();
            OpenImageFile.Filter = "Common Image Files | *.jpg; *.jpeg; *.png; *.gif";
            OpenImageFile.Title = "Select a funny meme.";

            if(OpenImageFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FunnyMeme.Image = Image.FromFile(OpenImageFile.FileName);
                    ImageChanged = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem opening that funny meme :(", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void SaveImagePrompt(object sender, EventArgs e)
        {   
            if(ImageChanged == false)
            {
                 MessageBox.Show("You have not changed the default image!\n\nPick your own image before trying to save.", "Steady on!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                this.Height = this.Width = 1080;

                int OldLabelHeights = TopLabel.Height;
                float OldLabelSize = TopLabel.Font.SizeInPoints;
                TopLabel.Font = BottomLabel.Font = new Font(LabelFont.FontFamily, LabelFont.SizeInPoints * 8);
                TopLabel.Height = BottomLabel.Height = this.Height / 2;

                SaveFileDialog SaveDialog = new SaveFileDialog();
                SaveDialog.FileName = $"{TopLabel.Text} {BottomLabel.Text}";
                SaveDialog.DefaultExt = "png";
                SaveDialog.Filter = "PNGs | *.png";
                SaveDialog.ValidateNames = true;

                if (SaveDialog.ShowDialog() == DialogResult.OK)
                {
                    int w = Convert.ToInt32(FunnyMeme.Width);
                    int h = Convert.ToInt32(FunnyMeme.Height);
                    Bitmap bmp = new Bitmap(w, h);

                    FunnyMeme.DrawToBitmap(bmp, new Rectangle(0, 0, w, h));

                    try
                    {
                        bmp.Save(SaveDialog.FileName, ImageFormat.Png);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Problem saving your masterpiece :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // user cancelled save :(
                }

                this.Height = this.Width = 350;
                TopLabel.Font = BottomLabel.Font = LabelFont;
                TopLabel.Height = BottomLabel.Height = OldLabelHeights;
            }
        }

        private void ColorPickerPrompt(object sender, EventArgs e)
        {
            if (ColourDialog.ShowDialog() == DialogResult.OK)
            {
                TopLabel.ForeColor = BottomLabel.ForeColor = ColourDialog.Color;
            }
        }

        private void FontPickerDialog(object sender, EventArgs e)
        {
            FontPicker = new FontDialog();
            FontPicker.Font = LabelFont;
            FontPicker.ShowDialog();

            //if (FontPicker.FontMustExist != false)
            //{
                TopLabel.Font = BottomLabel.Font = LabelFont = FontPicker.Font;
            //} else
            //{
            //    MessageBox.Show("You have tried to pick a font that doesn't exist!", "Woah there!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void AboutPrompt(object sender, EventArgs e)
        {
            MessageBox.Show("2022 SolCol.ThomasR.me\n\n" +
                            "Made at the request of Shaista, teaching Unit 6 C# Programming.\n\n" +
                            "With some inspiration from the MooICT.com tutorial.\n" +
                            "Additional thanks to Lewis.\nIcons from Icons8.",
                            "About this Program", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenSourceCode(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/itsmeimtom/solcol-mememaker");
        }

        private void UpdateStretch(object sender, EventArgs e)
        {
            if (StretchToggle.Checked)
            {
                FunnyMeme.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                FunnyMeme.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
