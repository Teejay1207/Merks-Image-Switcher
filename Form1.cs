using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MaterialSkin;
using Newtonsoft.Json.Linq;

namespace MerksImageSwitcher;

public partial class Form1 : MaterialSkin.Controls.MaterialForm
{
    private readonly string configFilePath;

    public Form1()
    {
        InitializeComponent();
        InitializeMaterialSkinManager();
        configFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");
        LoadConfig();
    }

    private void InitializeMaterialSkinManager()
    {
        var materialSkinManager = MaterialSkinManager.Instance;
        materialSkinManager.AddFormToManage(this);
        materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Grey800,
            Primary.Grey900,
            Primary.Blue400,
            Accent.Blue400,
            TextShade.WHITE
        );
    }

    private void LoadConfig()
    {
        if (File.Exists(configFilePath))
        {
            var json = File.ReadAllText(configFilePath);
            var config = JObject.Parse(json);

            matSallTraders.Checked = config.Value<bool>("updateAllTraders");
            matAnime.Checked = config.Value<bool>("anime");
            matCustom.Checked = config.Value<bool>("custom");
            matMain.Checked = config.Value<bool>("main");
            matRealistic.Checked = config.Value<bool>("realistic");
            matExtension.Checked = config.Value<string>("extension") == "jpg"; // Assuming extension is jpg or png
        }
    }

    private void SaveConfig()
    {
        var config = new JObject
        {
            ["updateAllTraders"] = matSallTraders.Checked,
            ["main"] = matMain.Checked,
            ["custom"] = matCustom.Checked,
            ["anime"] = matAnime.Checked,
            ["realistic"] = matRealistic.Checked,
            ["extension"] = matExtension.Checked ? "jpg" : "png"
        };

        File.WriteAllText(configFilePath, config.ToString());
    }

    private void LoadImages(string folderName)
    {
        var exePath = AppDomain.CurrentDomain.BaseDirectory;
        var userFolder = Directory.GetParent(Directory.GetParent(exePath).FullName).FullName;
        var imagesFolderPath = Path.Combine(userFolder, "res", folderName); // Adjust the path as needed

        if (Directory.Exists(imagesFolderPath))
        {
            var imageFiles = Directory.GetFiles(imagesFolderPath, matExtension.Checked ? "*.jpg" : "*.png");
            if (imageFiles.Length > 0)
            {
                flowLayoutPanel.Controls.Clear();
                foreach (var imageFile in imageFiles)
                {
                    var pictureBox = new PictureBox
                    {
                        Image = Image.FromFile(imageFile),
                        Size = new Size(125, 125),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    flowLayoutPanel.Controls.Add(pictureBox);
                }
            }
            else
            {
                MessageBox.Show("No images found in the selected folder.");
            }
        }
        else
        {
            MessageBox.Show("The selected folder does not exist.");
        }
    }

    private void matSallTraders_CheckedChanged(object sender, EventArgs e)
    {
        if (matSallTraders.Checked)
        {
            matSallTraders.Text = "Switcher ON";
            SaveConfig();
        }
        else
        {
            matSallTraders.Text = "Switcher OFF";
            SaveConfig();
        }
    }

    private void matAnime_CheckedChanged(object sender, EventArgs e)
    {
        if (matAnime.Checked)
        {
            matCustom.Checked = false;
            matRealistic.Checked = false;
            matMain.Checked = false;
            LoadImages("anime");
        }
        SaveConfig();
    }

    private void matCustom_CheckedChanged(object sender, EventArgs e)
    {
        if (matCustom.Checked)
        {
            matAnime.Checked = false;
            matRealistic.Checked = false;
            matMain.Checked = false;
            LoadImages("custom");
        }
        SaveConfig();
    }

    private void matMain_CheckedChanged(object sender, EventArgs e)
    {
        if (matMain.Checked)
        {
            matCustom.Checked = false;
            matRealistic.Checked = false;
            matAnime.Checked = false;
            LoadImages("main");
        }
        SaveConfig();
    }

    private void matRealistic_CheckedChanged(object sender, EventArgs e)
    {
        if (matRealistic.Checked)
        {
            matCustom.Checked = false;
            matAnime.Checked = false;
            matMain.Checked = false;
            LoadImages("realistic");
        }
        SaveConfig();
    }

    private void matExtension_CheckedChanged(object sender, EventArgs e)
    {
        if (matExtension.Checked)
        {
            matExtension.Text = "jpg";
            SaveConfig();
        }
        else
        {
            matExtension.Text = "png";
            SaveConfig();
        }
    }

    private void mBtnClearTraders_Click(object sender, EventArgs e)
    {
        // Determine the path to the user's folder where the executable is located
        var exePath = AppDomain.CurrentDomain.BaseDirectory;
        var userFolder = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(exePath).FullName).FullName).FullName).FullName;
        var avatarFolderPath = Path.Combine(userFolder, "sptappdata", "files", "trader", "avatar");

        // MessageBox.Show("Clear Traders Button Clicked!"); // For debugging purposes My Best Friend!

        if (Directory.Exists(avatarFolderPath))
        {
            try
            {
                var files = Directory.GetFiles(avatarFolderPath);
                if (files.Length > 0)
                {
                    foreach (var file in files)
                    {
                        File.Delete(file);
                    }
                    mBtnClearTraders.Text = "Trader Images Set";
                }
                else
                {
                    mBtnClearTraders.Text = "Already Set";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting files in the avatar folder: " + ex.Message);
            }
        }
        else
        {
            mBtnClearTraders.Text = "Already Set";
        }

        // Set the timer to reset the button text to default after 5 seconds
        var tmr = new Timer();
        tmr.Interval = 5000; // 5 seconds
        tmr.Tick += (_sender, _e) =>
        {
            mBtnClearTraders.Text = "Set Trader Images";
            tmr.Stop();
            tmr.Dispose();
        };
        tmr.Start();
    }


}
