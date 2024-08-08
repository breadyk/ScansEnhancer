using System.Diagnostics;
using Newtonsoft.Json;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Png;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EasyUpscaler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//Сделать поддержку языка и исключений
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == DialogResult.OK)
            {
                FolderBox.Text = diag.SelectedPath;
            }
            else
            {
                if (Lang == 1) { FolderBox2.Text = "Вы ничего не выбрали!"; }
                else { FolderBox2.Text = "You haven't selected anything!"; }
            }
        }

 

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            bool FolderPathRight = false;
            bool ModelsAreChosen = false;
            bool UtilsAreChosen = false;
            if ((FolderBox.Text != "" && FolderBox2.Text != "") && (FolderBox.Text != "Вы ничего не выбрали!" && FolderBox2.Text != "Вы ничего не выбрали!") && (FolderBox.Text != "You haven't selected anything!" && FolderBox2.Text != "You haven't selected anything!"))
            {
                FolderPathRight = true;
            }
            else
            {
                if (Lang == 1)
                {
                    if (FolderBox.Text == "")
                    {
                        MessageBox.Show("Вы не выбрали папку со страницами!");
                    }
                    else
                    {
                        MessageBox.Show("Вы не выбрали папку для вывода!");
                    }
                }
                else
                {
                    if (FolderBox.Text == "")
                    {
                        MessageBox.Show("You haven't selected a folder with pages!");
                    }
                    else
                    {
                        MessageBox.Show("You haven't selected an output folder!");
                    }
                }
            }
            
            if (MangaJPEGcheck.Checked || SaiyajinCheck.Checked || JaNaiCheck.Checked || DWTPcheck.Checked || FastScaleCheck.Checked || OwnModelCheck.Checked)
            {
                ModelsAreChosen = true;
            }
            
            if (ScreentoneCheck.Checked || SharpCheck.Checked || ResizeCheck.Checked)
            {
                UtilsAreChosen = true;
            }

            if ((FolderPathRight == true) && (ModelsAreChosen == true || UtilsAreChosen == true))
            {
                string InputFolder = FolderBox.Text;
                string OutputFolder = FolderBox2.Text;
                string TempFolder = (Path.Combine(OutputFolder, "temp"));
                Directory.CreateDirectory(TempFolder);

                PNGconvert(InputFolder, TempFolder);
                if (ModelsAreChosen == true)
                {
                    if (tilesize.Text == "")
                    {
                        tilesize.Text = "256";
                    }
                    else if (int.Parse(tilesize.Text) > 1200)
                    {
                        tilesize.Text = "1200";
                    }
                    LaunchButton.Hide();
                    int TileSize = int.Parse(tilesize.Text);

                    List<string> modelsList = new List<string>();

                    if (MangaJPEGcheck.Checked)
                    {

                        if (MangaJPEGbox.Text == "")
                        {
                            MangaJPEGbox.SelectedIndex = 2;
                        }
                        else
                        {
                            switch (MangaJPEGbox.SelectedIndex)
                            {
                                case 0:
                                    modelsList.Add("1x-MangaJPEGHQPlus.pth");
                                    break;
                                case 1:
                                    modelsList.Add("1x-MangaJPEGHQ.pth");
                                    break;
                                case 2:
                                    modelsList.Add("1x-MangaJPEGMQ.pth");
                                    break;
                                case 3:
                                    modelsList.Add("1x-MangaJPEGLQ.pth");
                                    break;
                            }
                        }
                    }
                    if (SaiyajinCheck.Checked) { modelsList.Add("1x-SaiyaJin-DeJpeg.pth"); }
                    if (JaNaiCheck.Checked) { modelsList.Add("4x_IllustrationJaNai_V1_DAT2_190k.pth"); }
                    if (DWTPcheck.Checked)
                    {
                        if (DWTPbox.Text == "")
                        {
                            DWTPbox.SelectedIndex = 0;
                        }
                        else
                        {
                            switch (DWTPbox.SelectedIndex)
                            {
                                case 0:
                                    modelsList.Add("4x_DWTP_DS_rgts_v1.pth");
                                    break;
                                case 1:
                                    modelsList.Add("4x_DWTP_DS_dat2_v3_2.pth");
                                    break;
                                case 2:
                                    modelsList.Add("4x_DWTP_DS_atdl.pth");
                                    break;
                                case 3:
                                    modelsList.Add("4x_DWTP_DS_atdl2.pth");
                                    break;
                                case 4:
                                    modelsList.Add("4x_DWTP_DS_atdl3.pth");
                                    break;
                            }
                        }
                    }
                    if (FastScaleCheck.Checked)
                    {

                        if (FastScaleBox.Text == "")
                        {
                            FastScaleBox.SelectedIndex = 0;
                        }
                        else
                        {
                            switch (FastScaleBox.SelectedIndex)
                            {
                                case 0:
                                    modelsList.Add("4x-eula-digimanga-bw-v2-nc1.pth");
                                    break;
                                case 1:
                                    modelsList.Add("2x_MangaScaleV3.pth");
                                    break;
                                case 2:
                                    modelsList.Add("4x_MangaJaNai_2048p_V1RC1_ESRGAN_70k.pth");
                                    break;
                                case 3:
                                    modelsList.Add("4x_MangaJaNai_1920p_V1RC1_ESRGAN_105k.pth");
                                    break;
                                case 4:
                                    modelsList.Add("4x_MangaJaNai_1600p_V1RC1_ESRGAN_70k.pth");
                                    break;
                                case 5:
                                    modelsList.Add("4x_MangaJaNai_1500p_V1RC1_ESRGAN_105k.pth");
                                    break;
                                case 6:
                                    modelsList.Add("4x_MangaJaNai_1400p_V1RC3_ESRGAN_105k.pth");
                                    break;
                                case 7:
                                    modelsList.Add("4x_MangaJaNai_1300p_V1RC1_ESRGAN_75k.pth");
                                    break;
                                case 8:
                                    modelsList.Add("4x_MangaJaNai_1200p_V1RC71_ESRGAN_70k.pth");
                                    break;
                            }
                        }
                    }

                    if (modelsList.Count > 0)
                    {
                        for (int i = 0; i < modelsList.Count; i++)
                        {
                            string ModelPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "models", modelsList[i]);
                            SRcoreStart(TempFolder, ModelPath, TileSize);
                        }
                    }
                    if (OwnModelCheck.Checked)
                    {
                        if (ModelFolderBox.Text == "")
                        {
                            if (Lang == 1)
                            {
                                MessageBox.Show("Вы не выбрали свою модель!");
                            }
                            else
                            {
                                MessageBox.Show("You haven't selected your model!");
                            }
                        }
                        else { SRcoreStart(TempFolder, ModelFolderBox.Text, TileSize); }
                        
                    }
                }
                if (UtilsAreChosen == true)
                {
                    MangaUtilsStart(TempFolder);
                }
                string[] files = Directory.GetFiles(TempFolder);

                foreach (string filePath in files)
                {
                    string destFilePath = Path.Combine(OutputFolder, Path.GetFileName(filePath));
                    File.Move(filePath, destFilePath, true);
                }
                Directory.Delete(TempFolder);
                MessageBox.Show("Обработка завершена");
                LaunchButton.Show();
                Process.Start("explorer.exe", OutputFolder);

            }
            else if (ModelsAreChosen == false && UtilsAreChosen == false)
            {
                if (Lang == 1)
                {
                    MessageBox.Show("Вы не выбрали ни одной модели!");
                }
                else
                {
                    MessageBox.Show("You haven't selected any model!");
                }
            }

        }

        private void OpenButton2_Click(object sender, EventArgs e) //Сделать поддержку языка и исключений
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FolderBox2.Text = diag.SelectedPath;
            }
            else
            {
                if (Lang == 1){ FolderBox2.Text = "Вы ничего не выбрали!"; }
                else { FolderBox2.Text = "You haven't selected anything!"; }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            highInput.Text = highBar.Value.ToString();
        }

        private void highInput_TextChanged(object sender, EventArgs e)
        {
            if ((int.TryParse(highInput.Text, out int value) == true) && (int.Parse(highInput.Text) >= 0) && (int.Parse(highInput.Text) <= 255))
            {
                highBar.Value = int.Parse(highInput.Text);
            }
        }

        private void lowBar_Scroll(object sender, EventArgs e)
        {
            lowInput.Text = lowBar.Value.ToString();
        }

        private void lowInput_TextChanged(object sender, EventArgs e)
        {
            if ((int.TryParse(lowInput.Text, out int value) == true) && (int.Parse(lowInput.Text) >= 0) && (int.Parse(lowInput.Text) <= 255))
            {
                lowBar.Value = int.Parse(lowInput.Text);
            }
        }

        private void DiaWhiteBar_Scroll(object sender, EventArgs e)
        {
            DiaWhite.Text = DiaWhiteBar.Value.ToString();
        }

        private void DiaWhite_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(DiaWhite.Text, out int value) && int.Parse(DiaWhite.Text) >= -1 && int.Parse(DiaWhite.Text) <= 255)
            {
                DiaWhiteBar.Value = int.Parse(DiaWhite.Text);
            }
        }

        private void DiaBlackBar_Scroll(object sender, EventArgs e)
        {
            DiaBlack.Text = DiaBlackBar.Value.ToString();
        }

        private void DiaBlack_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(DiaBlack.Text, out int value) && int.Parse(DiaBlack.Text) >= -1 && int.Parse(DiaBlack.Text) <= 255)
            {
                DiaBlackBar.Value = int.Parse(DiaBlack.Text);
            }
        }

        private void DotSizeBar_Scroll(object sender, EventArgs e)
        {
            DotSize.Text = DotSizeBar.Value.ToString();
        }

        private void DotSize_TextChanged(object sender, EventArgs e)
        {
            if ((int.TryParse(DotSize.Text, out int value) == true) && (int.Parse(DotSize.Text) >= 1) && (int.Parse(DotSize.Text) <= 100))
            {
                DotSizeBar.Value = int.Parse(DotSize.Text);
            }
        }

        private void ResizeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (InterBox.Text == "")
            {
                InterBox.SelectedIndex = 0;
            }
            if (WidthCheck.Text == "")
            {
                WidthCheck.SelectedIndex = 0;
            }
            if (SpreadCheck.Text == "")
            {
                SpreadCheck.SelectedIndex = 1;
            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void ModelOpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();
            diag.Filter = "Файл модели (*.pth)|*.pth";
            diag.Title = "Выберите файл модели";
            diag.CheckFileExists = true;
            diag.CheckPathExists = true;
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ModelFolderBox.Text = diag.FileName;
            }
            else
            { if (Lang == 1) { ModelFolderBox.Text = "Вы ничего не выбрали!"; }
              else { ModelFolderBox.Text = "You haven't selected anything!"; }
            }
        }

        public void SRcoreStart(string TempFolder, string ModelPath, int TileSize)
        {
            var data = new
            {
                modelPath = ModelPath,
                inputFolder = TempFolder,
                outputFolder = TempFolder,
                tileSize = TileSize,
            };
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data1.json");
            string jsonData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(jsonFilePath, jsonData);
            string scriptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "sr-core-main", "api.py");
            PythonStart(scriptPath);
        }
        public void MangaUtilsStart(string TempFolder)
        {
            bool cennych = false;
            if (СennyCheck.Checked) { cennych = true; }
            var processed = new List<object>();

            if (SharpCheck.Checked)
            {
                processed.Add(new
                {
                    type = "sharp",
                    diapason_white = DiaWhiteBar.Value,
                    diapason_black = DiaBlackBar.Value,
                    high_input = highBar.Value,
                    low_input = lowBar.Value,
                    gamma = 1.0,
                    cenny = cennych
                });
            }

            if (ScreentoneCheck.Checked)
            {
                processed.Add(new
                {
                    type = "screentone",
                    dot_size = DotSizeBar.Value
                });
            }

            if (ResizeCheck.Checked)
            {
                processed.Add(new
                {
                    type = "resize",
                    size = int.Parse(SizeCheck.Text),
                    interpolation = InterBox.Text,
                    width = bool.Parse(WidthCheck.Text),
                    percent = int.Parse(PercentBox.Text),
                    spread = bool.Parse(SpreadCheck.Text),
                    spread_size = int.Parse(SpreadSize.Text),
                    color_fix = false,
                    gamma_correction = false
                });
            }

            var JSONconfig = new
            {
                in_folder = FolderBox.Text,
                out_folder = TempFolder, //Походу файлик сразу обрабатывается, обходя темп
                process_map = "thread",
                processed
            };

            string json = JsonConvert.SerializeObject(JSONconfig, Newtonsoft.Json.Formatting.Indented);

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");
            File.WriteAllText(filePath, json);

            string scriptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "manga_utils-master", "main.py");
            PythonStart(scriptPath);
        }
        public void PythonStart(string scriptPath)
        {
            string pythonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "python", "Python312", "python");

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = pythonPath;
            startInfo.Arguments = scriptPath;
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = false;

            using (Process process = Process.Start(startInfo))
            {
                process.WaitForExit();
            }
        }

        public void PNGconvert(string InputFolder, string TempFolder)
        {
            string[] files = Directory.GetFiles(InputFolder);

            foreach (string filePath in files)
            {
                string destFilePath = Path.Combine(TempFolder, $"{Path.GetFileNameWithoutExtension(filePath)}.png");
                string extension = Path.GetExtension(filePath).ToLower();
                if (extension == ".png")
                {
                    File.Copy(filePath, destFilePath, true);
                }
                else
                {
                    using (SixLabors.ImageSharp.Image image = SixLabors.ImageSharp.Image.Load(filePath))
                    {
                        image.Save(destFilePath, new PngEncoder());
                    }
                }
            }
        }

        public int Lang = 1;

        private void LanguageButton_Click(object sender, EventArgs e)
        {
            if (Lang == 1)
            {
                Lang = 0;
                LanguageButton.Text = "Русский";
                DownloadButton.Text = "Download";
                LaunchButton.Text = "Launch";
                FolderSelection.Text = "Select folder with pages";
                OutputFolderSelection.Text = "Select output folder";
                OpenButton.Text = "Open...";
                OpenButton2.Text = "Open...";
                Description1.Text = "4x Upscale + denoiser. Only for color.";
                Description3.Text = "4х Upscaler b/w. Recomended for quality.";
                Description4.Text = "Adds halftone dots. Only for b/w.";
                Description5.Text = "1x Denoiser. For damaged scans(breaks screentones).";
                Description6.Text = "1x Denoiser b/w. For almost not damaged scans.";
                Description10.Text = "Changes image's size.";
                JaNaiCheck.Text = "Use";
                DWTPcheck.Text = "Use";
                ScreentoneCheck.Text = "Use";
                SharpCheck.Text = "Use";
                ResizeCheck.Text = "Use";
                SaiyajinCheck.Text = "Use";
                MangaJPEGcheck.Text = "Use";
                GeneralModels.Text = "Models";
                groupBox1.Text = "High value";
                groupBox2.Text = "Low value";
                groupBox3.Text = "White diapason";
                groupBox4.Text = "Black diapason";
                groupBox5.Text = "Launch menu";
                groupBox6.Text = "Dots' size";
                groupBox7.Text = "Size";
                groupBox8.Text = "Interpolation";
                groupBox9.Text = "Width value?";
                groupBox10.Text = "Percents";
                groupBox12.Text = "Spread?";
                groupBox11.Text = "Spread size";
                groupBox15.Text = "Download dependencies";
                tiletext.Text = "                 Select tile size";
                label2.Text = "Attention!";
                label4.Text = "Attention!";
                label5.Text = "Install dependencies before running.";
                label1.Text = "After pressing \"Launch\" do NOT close the program\r\nuntil completion window wouldn't appear.\r\n";

            }
            else
            {
                Lang = 1;
                LanguageButton.Text = "English";
                DownloadButton.Text = "Скачать";
                LaunchButton.Text = "Запуск";
                FolderSelection.Text = "Выберите папку с нужными страницами";
                OutputFolderSelection.Text = "Выберите папку для вывода";
                OpenButton.Text = "Открыть...";
                OpenButton2.Text = "Открыть...";
                Description1.Text = "4x Апскейл + шумодав. Только для цвета.";
                Description3.Text = "4х Апскейл ч/б. Рекомендуется для качества.";
                Description4.Text = "Добавляет скринтоны. Только для ч/б.";
                Description5.Text = "1x Шумодав. Для убитых сканов(ломает скринтоны).";
                Description6.Text = "1x Шумодав ч/б. Для почти не убитых сканов.";
                Description10.Text = "Меняет размер изображения.";
                JaNaiCheck.Text = "Использовать";
                DWTPcheck.Text = "Использовать";
                ScreentoneCheck.Text = "Использовать";
                SharpCheck.Text = "Использовать";
                ResizeCheck.Text = "Использовать";
                SaiyajinCheck.Text = "Использовать";
                MangaJPEGcheck.Text = "Использовать";
                GeneralModels.Text = "Модели";
                groupBox1.Text = "Верхняя граница";
                groupBox2.Text = "Нижняя граница";
                groupBox3.Text = "Диапазон белого";
                groupBox4.Text = "Диапазон чёрного";
                groupBox5.Text = "Меню запуска";
                groupBox6.Text = "Размер точек";
                groupBox7.Text = "Размер";
                groupBox8.Text = "Интерполяция";
                groupBox9.Text = "По ширине?";
                groupBox10.Text = "Проценты";
                groupBox12.Text = "Разворот?";
                groupBox11.Text = "Размер разворота";
                groupBox15.Text = "Скачать зависимости";
                tiletext.Text = "Выберите размер плитки";
                label2.Text = "Важно!";
                label4.Text = "Важно!";
                label5.Text = "Перед началом работы установите зависимости.";
                label1.Text = "После нажатия \"Запуск\", не закрывайте программу,\r\nпока не появится окно о завершении процесса.\r\n";
            }
        }
    }
}