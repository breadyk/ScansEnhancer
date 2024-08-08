using System.Diagnostics;
using System.IO.Compression;

namespace EasyUpscaler
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            SrcoreButton.Hide();

            string downloadPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "temp", "srcore.zip");

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "curl";
            startInfo.Arguments = $"-L -o {downloadPath} https://github.com/umzi2/sr-core/archive/main.zip";
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            using (Process process = Process.Start(startInfo))
            {
                process.WaitForExit();
            }

            string extractPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");

            try
            {
                ZipFile.ExtractToDirectory(downloadPath, extractPath);
            }
            catch (IOException ex) { }

            File.Copy(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "PyLayerBackup", "api.py"), Path.Combine(extractPath, "sr-core-main", "api.py"));
            srcoredone.Show();

            MessageBox.Show("Download completed.");
        }

        private void mutilsButton_Click(object sender, EventArgs e)
        {
            mutilsButton.Hide();

            string downloadPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "temp", "mangautils.zip");

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "curl";
            startInfo.Arguments = $"-L -o {downloadPath} https://github.com/umzi2/manga_utils/archive/master.zip";
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            using (Process process = Process.Start(startInfo))
            {
                process.WaitForExit();
            }

            string extractPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");

            try
            {
                ZipFile.ExtractToDirectory(downloadPath, extractPath);
            }
            catch (IOException ex) { }
            mutilsdone.Show();
            MessageBox.Show("Download completed.");
        }

        private void modelsbutton_Click(object sender, EventArgs e)
        {
            modelsbutton.Hide();
            string pipPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "python", "Python312", "Scripts", "pip");
            string[] requirements =
            { "pepeline",
              "tqdm",
              "opencv-python",
              "chainner-ext",
              "einops",
              "numpy",
              "moviepy",
            };
            for (int i = 0; i < requirements.Length; i++)
            {
                ProcessStartInfo startInfo = new ProcessStartInfo(pipPath);

                startInfo.Arguments = $"install {requirements[i]}";
                startInfo.RedirectStandardOutput = true;
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = false;

                using (Process process = Process.Start(startInfo))
                {
                    process.WaitForExit();
                }
            }
            modelsdone.Show();
            MessageBox.Show("Download completed.");
        }
        public int Lang = 1;
        private void LanguageButton_Click(object sender, EventArgs e)
        {
            if (Lang == 1)
            {
                Lang = 0;
                LanguageButton.Text = "Русский";
                groupBox3.Text = "Dependencies";
                srcoredone.Text = "Installed";
                mutilsdone.Text = "Installed";
                modelsdone.Text = "Installed";
                torchdone.Text = "Installed";
                SrcoreButton.Text = "Download";
                mutilsButton.Text = "Download";
                modelsbutton.Text = "Download";
                torchButton.Text = "Download";
                label1.Text = "~300 KB";
                label2.Text = "~9 MB";
                label4.Text = "~200 MB";
                label5.Text = "~5 GB";
                label6.Text = "Choose your GPU...";
            }
            else
            {
                Lang = 1;
                LanguageButton.Text = "English";
                groupBox3.Text = "Зависимости";
                srcoredone.Text = "Установлено";
                mutilsdone.Text = "Установлено";
                modelsdone.Text = "Установлено";
                torchdone.Text = "Установлено";
                SrcoreButton.Text = "Скачать";
                mutilsButton.Text = "Скачать";
                modelsbutton.Text = "Скачать";
                torchButton.Text = "Скачать";
                label1.Text = "~300 КБ";
                label2.Text = "~9 МБ";
                label4.Text = "~200 МБ";
                label5.Text = "~5 ГБ";
                label6.Text = "Выберите вашу GPU...";
            }
        }

        private void torchButton_Click(object sender, EventArgs e)
        {
            if (GPUbox.Text == "")
            {
                if (Lang == 1)
                {
                    MessageBox.Show("Вы не выбрали вашу GPU(Видеокарту)!");
                }
                else
                {
                    MessageBox.Show("You haven't selected your GPU(Graphics Card)!");
                }
            }
            else
            {
                torchButton.Hide();
                if (Lang == 1)
                {
                    MessageBox.Show("Процесс может занять много времени, не закрывайте программу!");
                }
                else
                {
                    MessageBox.Show("This may take a while, DO NOT close the programm!");
                }

                string pipPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "python", "Python312", "Scripts", "pip3.exe");
                string torch;
                if (GPUbox.Text == "Nvidia Geforce") { torch = "torch torchvision --index-url https://download.pytorch.org/whl/cu121"; }
                else { torch = "torch torchvision"; }

                ProcessStartInfo startInfo = new ProcessStartInfo(pipPath);

                startInfo.Arguments = $"install {torch}";
                startInfo.RedirectStandardOutput = true;
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = false;

                using (Process process = Process.Start(startInfo))
                {
                    process.WaitForExit();
                }

                torchdone.Show();
                MessageBox.Show("Download completed.");

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
