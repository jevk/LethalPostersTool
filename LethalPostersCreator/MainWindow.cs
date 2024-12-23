namespace LethalPostersCreator
{
    public partial class MainWindow : Form
    {
        string modPath = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tipsLauncher_Click(object sender, EventArgs e)
        {
            TipsCreator tipsCreator = new TipsCreator(modPath);
            tipsCreator.Show();
        }

        private void postersLauncher_Click(object sender, EventArgs e)
        {
            Poster poster = new Poster(modPath);
            poster.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select an empty folder to create your mod to";
            folderBrowserDialog.ShowNewFolderButton = true;
            folderBrowserDialog.ShowDialog();
            string path = folderBrowserDialog.SelectedPath;
            if (path != "")
            {
                if (System.IO.Directory.GetFiles(path).Length > 0 || System.IO.Directory.GetDirectories(path).Length > 0)
                {
                    MessageBox.Show("The selected folder is not empty");
                    return;
                }
                MessageBox.Show("Mod created at " + path);
                ModConfig modConfig = new ModConfig(path);
                modConfig.Show();
                modPath = path;
            }
            label1.Text = "Selected mod: " + modPath;
            postersLauncher.Enabled = true;
            tipsLauncher.Enabled = true;
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select the mod folder";
            folderBrowserDialog.ShowNewFolderButton = false;
            folderBrowserDialog.ShowDialog();
            string path = folderBrowserDialog.SelectedPath;
            if (path != "")
            {
                if (!System.IO.File.Exists(path + "/manifest.json"))
                {
                    MessageBox.Show("The selected folder is not a mod folder");
                    return;
                }
                MessageBox.Show("Mod loaded from " + path);
                modPath = path;
            }
            label1.Text = "Selected mod: " + modPath;
            postersLauncher.Enabled = true;
            tipsLauncher.Enabled = true;
            return;
        }
    }
}
