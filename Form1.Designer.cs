using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace MerksImageSwitcher
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            matSallTraders = new MaterialSwitch();
            matAnime = new MaterialSwitch();
            matCustom = new MaterialSwitch();
            matMain = new MaterialSwitch();
            matRealistic = new MaterialSwitch();
            matExtension = new MaterialSwitch();
            gBfolders = new GroupBox();
            gBfiletypes = new GroupBox();
            gBallTraders = new GroupBox();
            mBtnClearTraders = new MaterialButton();
            pictureBox1 = new PictureBox();
            pnlGroup = new Panel();
            panel1 = new Panel();
            flowLayoutPanel = new FlowLayoutPanel();
            splitter1 = new Splitter();
            gBfolders.SuspendLayout();
            gBfiletypes.SuspendLayout();
            gBallTraders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlGroup.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // matSallTraders
            // 
            matSallTraders.AutoSize = true;
            matSallTraders.Depth = 0;
            matSallTraders.Location = new System.Drawing.Point(8, 19);
            matSallTraders.Margin = new Padding(0);
            matSallTraders.MouseLocation = new System.Drawing.Point(-1, -1);
            matSallTraders.MouseState = MouseState.HOVER;
            matSallTraders.Name = "matSallTraders";
            matSallTraders.Ripple = true;
            matSallTraders.Size = new System.Drawing.Size(119, 37);
            matSallTraders.TabIndex = 0;
            matSallTraders.Text = "Switcher";
            matSallTraders.UseVisualStyleBackColor = true;
            matSallTraders.CheckedChanged += matSallTraders_CheckedChanged;
            // 
            // matAnime
            // 
            matAnime.AutoSize = true;
            matAnime.Depth = 0;
            matAnime.Location = new System.Drawing.Point(8, 105);
            matAnime.Margin = new Padding(0);
            matAnime.MouseLocation = new System.Drawing.Point(-1, -1);
            matAnime.MouseState = MouseState.HOVER;
            matAnime.Name = "matAnime";
            matAnime.Ripple = true;
            matAnime.Size = new System.Drawing.Size(103, 37);
            matAnime.TabIndex = 1;
            matAnime.Text = "Anime";
            matAnime.UseVisualStyleBackColor = true;
            matAnime.CheckedChanged += matAnime_CheckedChanged;
            // 
            // matCustom
            // 
            matCustom.AutoSize = true;
            matCustom.Depth = 0;
            matCustom.Location = new System.Drawing.Point(8, 62);
            matCustom.Margin = new Padding(0);
            matCustom.MouseLocation = new System.Drawing.Point(-1, -1);
            matCustom.MouseState = MouseState.HOVER;
            matCustom.Name = "matCustom";
            matCustom.Ripple = true;
            matCustom.Size = new System.Drawing.Size(113, 37);
            matCustom.TabIndex = 2;
            matCustom.Text = "Custom";
            matCustom.UseVisualStyleBackColor = true;
            matCustom.CheckedChanged += matCustom_CheckedChanged;
            // 
            // matMain
            // 
            matMain.AutoSize = true;
            matMain.Depth = 0;
            matMain.Location = new System.Drawing.Point(8, 19);
            matMain.Margin = new Padding(0);
            matMain.MouseLocation = new System.Drawing.Point(-1, -1);
            matMain.MouseState = MouseState.HOVER;
            matMain.Name = "matMain";
            matMain.Ripple = true;
            matMain.Size = new System.Drawing.Size(94, 37);
            matMain.TabIndex = 3;
            matMain.Text = "Main";
            matMain.UseVisualStyleBackColor = true;
            matMain.CheckedChanged += matMain_CheckedChanged;
            // 
            // matRealistic
            // 
            matRealistic.AutoSize = true;
            matRealistic.Depth = 0;
            matRealistic.Location = new System.Drawing.Point(8, 148);
            matRealistic.Margin = new Padding(0);
            matRealistic.MouseLocation = new System.Drawing.Point(-1, -1);
            matRealistic.MouseState = MouseState.HOVER;
            matRealistic.Name = "matRealistic";
            matRealistic.Ripple = true;
            matRealistic.Size = new System.Drawing.Size(118, 37);
            matRealistic.TabIndex = 4;
            matRealistic.Text = "Realistic";
            matRealistic.UseVisualStyleBackColor = true;
            matRealistic.CheckedChanged += matRealistic_CheckedChanged;
            // 
            // matExtension
            // 
            matExtension.AutoSize = true;
            matExtension.Checked = true;
            matExtension.CheckState = CheckState.Checked;
            matExtension.Depth = 0;
            matExtension.Location = new System.Drawing.Point(8, 28);
            matExtension.Margin = new Padding(0);
            matExtension.MouseLocation = new System.Drawing.Point(-1, -1);
            matExtension.MouseState = MouseState.HOVER;
            matExtension.Name = "matExtension";
            matExtension.Ripple = true;
            matExtension.Size = new System.Drawing.Size(80, 37);
            matExtension.TabIndex = 5;
            matExtension.Text = "jpg";
            matExtension.UseVisualStyleBackColor = true;
            matExtension.CheckedChanged += matExtension_CheckedChanged;
            // 
            // gBfolders
            // 
            gBfolders.Controls.Add(matAnime);
            gBfolders.Controls.Add(matCustom);
            gBfolders.Controls.Add(matMain);
            gBfolders.Controls.Add(matRealistic);
            gBfolders.Location = new System.Drawing.Point(4, 76);
            gBfolders.Margin = new Padding(4, 3, 4, 3);
            gBfolders.Name = "gBfolders";
            gBfolders.Padding = new Padding(4, 3, 4, 3);
            gBfolders.Size = new System.Drawing.Size(233, 189);
            gBfolders.TabIndex = 6;
            gBfolders.TabStop = false;
            gBfolders.Text = "Choose a folder";
            // 
            // gBfiletypes
            // 
            gBfiletypes.Controls.Add(matExtension);
            gBfiletypes.Location = new System.Drawing.Point(4, 272);
            gBfiletypes.Margin = new Padding(4, 3, 4, 3);
            gBfiletypes.Name = "gBfiletypes";
            gBfiletypes.Padding = new Padding(4, 3, 4, 3);
            gBfiletypes.Size = new System.Drawing.Size(234, 76);
            gBfiletypes.TabIndex = 7;
            gBfiletypes.TabStop = false;
            gBfiletypes.Text = "PNG/JPG";
            // 
            // gBallTraders
            // 
            gBallTraders.Controls.Add(matSallTraders);
            gBallTraders.Location = new System.Drawing.Point(4, 3);
            gBallTraders.Margin = new Padding(4, 3, 4, 3);
            gBallTraders.Name = "gBallTraders";
            gBallTraders.Padding = new Padding(4, 3, 4, 3);
            gBallTraders.Size = new System.Drawing.Size(234, 69);
            gBallTraders.TabIndex = 8;
            gBallTraders.TabStop = false;
            gBallTraders.Text = "OFF/ON";
            // 
            // mBtnClearTraders
            // 
            mBtnClearTraders.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mBtnClearTraders.Density = MaterialButton.MaterialButtonDensity.Default;
            mBtnClearTraders.Depth = 0;
            mBtnClearTraders.Dock = DockStyle.Fill;
            mBtnClearTraders.HighEmphasis = true;
            mBtnClearTraders.Icon = null;
            mBtnClearTraders.Location = new System.Drawing.Point(0, 0);
            mBtnClearTraders.Margin = new Padding(5, 7, 5, 7);
            mBtnClearTraders.MouseState = MouseState.HOVER;
            mBtnClearTraders.Name = "mBtnClearTraders";
            mBtnClearTraders.NoAccentTextColor = System.Drawing.Color.Empty;
            mBtnClearTraders.Size = new System.Drawing.Size(234, 39);
            mBtnClearTraders.TabIndex = 9;
            mBtnClearTraders.Text = "Set Trader Images";
            mBtnClearTraders.Type = MaterialButton.MaterialButtonType.Contained;
            mBtnClearTraders.UseAccentColor = false;
            mBtnClearTraders.UseVisualStyleBackColor = true;
            mBtnClearTraders.Click += mBtnClearTraders_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(4, 26);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(35, 35);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pnlGroup
            // 
            pnlGroup.Controls.Add(panel1);
            pnlGroup.Controls.Add(gBallTraders);
            pnlGroup.Controls.Add(gBfolders);
            pnlGroup.Controls.Add(gBfiletypes);
            pnlGroup.Controls.Add(flowLayoutPanel);
            pnlGroup.Controls.Add(splitter1);
            pnlGroup.Dock = DockStyle.Fill;
            pnlGroup.Location = new System.Drawing.Point(4, 74);
            pnlGroup.Name = "pnlGroup";
            pnlGroup.Size = new System.Drawing.Size(676, 395);
            pnlGroup.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Controls.Add(mBtnClearTraders);
            panel1.Location = new System.Drawing.Point(4, 353);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(234, 39);
            panel1.TabIndex = 11;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.Location = new System.Drawing.Point(246, 0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new System.Drawing.Size(430, 395);
            flowLayoutPanel.TabIndex = 10;
            // 
            // splitter1
            // 
            splitter1.Location = new System.Drawing.Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new System.Drawing.Size(246, 395);
            splitter1.TabIndex = 9;
            splitter1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            ClientSize = new System.Drawing.Size(684, 472);
            Controls.Add(pnlGroup);
            Controls.Add(pictureBox1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Form1";
            Padding = new Padding(4, 74, 4, 3);
            Sizable = false;
            Text = "     Merks Image Switcher";
            gBfolders.ResumeLayout(false);
            gBfolders.PerformLayout();
            gBfiletypes.ResumeLayout(false);
            gBfiletypes.PerformLayout();
            gBallTraders.ResumeLayout(false);
            gBallTraders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlGroup.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialSwitch matSallTraders;
        private MaterialSkin.Controls.MaterialSwitch matAnime;
        private MaterialSkin.Controls.MaterialSwitch matCustom;
        private MaterialSkin.Controls.MaterialSwitch matMain;
        private MaterialSkin.Controls.MaterialSwitch matRealistic;
        private MaterialSkin.Controls.MaterialSwitch matExtension;
        private System.Windows.Forms.GroupBox gBfolders;
        private System.Windows.Forms.GroupBox gBfiletypes;
        private System.Windows.Forms.GroupBox gBallTraders;
        private MaterialButton mBtnClearTraders;
        private PictureBox pictureBox1;
        private Panel pnlGroup;
        private Splitter splitter1;
        private FlowLayoutPanel flowLayoutPanel;
        private Panel panel1;
    }
}
