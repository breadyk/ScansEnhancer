namespace EasyUpscaler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            FolderSelection = new GroupBox();
            FolderBox = new TextBox();
            OpenButton = new Button();
            Model1 = new GroupBox();
            JaNaiCheck = new CheckBox();
            Description1 = new Label();
            LanguageButton = new Button();
            Model3 = new GroupBox();
            DWTPbox = new ComboBox();
            DWTPcheck = new CheckBox();
            Description3 = new Label();
            tilesize = new ComboBox();
            Model4 = new GroupBox();
            СennyCheck = new CheckBox();
            SharpCheck = new CheckBox();
            groupBox4 = new GroupBox();
            DiaBlack = new TextBox();
            DiaBlackBar = new TrackBar();
            groupBox3 = new GroupBox();
            DiaWhite = new TextBox();
            DiaWhiteBar = new TrackBar();
            groupBox2 = new GroupBox();
            lowInput = new TextBox();
            lowBar = new TrackBar();
            groupBox1 = new GroupBox();
            highInput = new TextBox();
            highBar = new TrackBar();
            groupBox6 = new GroupBox();
            DotSize = new TextBox();
            DotSizeBar = new TrackBar();
            ScreentoneCheck = new CheckBox();
            GeneralModels = new GroupBox();
            groupBox17 = new GroupBox();
            ModelOpenButton = new Button();
            ModelFolderBox = new TextBox();
            OwnModelCheck = new CheckBox();
            label6 = new Label();
            groupBox16 = new GroupBox();
            FastScaleBox = new ComboBox();
            FastScaleCheck = new CheckBox();
            label3 = new Label();
            tiletext = new Label();
            Model6 = new GroupBox();
            MangaJPEGbox = new ComboBox();
            MangaJPEGcheck = new CheckBox();
            Description6 = new Label();
            Model5 = new GroupBox();
            SaiyajinCheck = new CheckBox();
            Description5 = new Label();
            LaunchButton = new Button();
            OutputFolderSelection = new GroupBox();
            FolderBox2 = new TextBox();
            OpenButton2 = new Button();
            groupBox5 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            groupBox7 = new GroupBox();
            SizeCheck = new TextBox();
            groupBox8 = new GroupBox();
            InterBox = new ComboBox();
            groupBox9 = new GroupBox();
            WidthCheck = new ComboBox();
            groupBox10 = new GroupBox();
            PercentBox = new TextBox();
            groupBox11 = new GroupBox();
            SpreadSize = new TextBox();
            groupBox12 = new GroupBox();
            SpreadCheck = new ComboBox();
            groupBox13 = new GroupBox();
            ResizeCheck = new CheckBox();
            Description10 = new Label();
            groupBox14 = new GroupBox();
            Description4 = new Label();
            groupBox15 = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            DownloadButton = new Button();
            FolderSelection.SuspendLayout();
            Model1.SuspendLayout();
            Model3.SuspendLayout();
            Model4.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DiaBlackBar).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DiaWhiteBar).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lowBar).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)highBar).BeginInit();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DotSizeBar).BeginInit();
            GeneralModels.SuspendLayout();
            groupBox17.SuspendLayout();
            groupBox16.SuspendLayout();
            Model6.SuspendLayout();
            Model5.SuspendLayout();
            OutputFolderSelection.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox11.SuspendLayout();
            groupBox12.SuspendLayout();
            groupBox13.SuspendLayout();
            groupBox14.SuspendLayout();
            groupBox15.SuspendLayout();
            SuspendLayout();
            // 
            // FolderSelection
            // 
            FolderSelection.Controls.Add(FolderBox);
            FolderSelection.Controls.Add(OpenButton);
            FolderSelection.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FolderSelection.Location = new Point(14, 16);
            FolderSelection.Margin = new Padding(3, 4, 3, 4);
            FolderSelection.Name = "FolderSelection";
            FolderSelection.Padding = new Padding(3, 4, 3, 4);
            FolderSelection.Size = new Size(839, 92);
            FolderSelection.TabIndex = 1;
            FolderSelection.TabStop = false;
            FolderSelection.Text = "Выберите папку с нужными страницами";
            // 
            // FolderBox
            // 
            FolderBox.Font = new Font("Arial Narrow", 9F);
            FolderBox.Location = new Point(7, 41);
            FolderBox.Margin = new Padding(3, 4, 3, 4);
            FolderBox.Name = "FolderBox";
            FolderBox.Size = new Size(732, 25);
            FolderBox.TabIndex = 2;
            // 
            // OpenButton
            // 
            OpenButton.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OpenButton.Location = new Point(746, 41);
            OpenButton.Margin = new Padding(3, 4, 3, 4);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(86, 31);
            OpenButton.TabIndex = 3;
            OpenButton.Text = "Открыть...";
            OpenButton.UseVisualStyleBackColor = true;
            OpenButton.Click += button1_Click;
            // 
            // Model1
            // 
            Model1.Controls.Add(JaNaiCheck);
            Model1.Controls.Add(Description1);
            Model1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Model1.Location = new Point(424, 73);
            Model1.Margin = new Padding(3, 4, 3, 4);
            Model1.Name = "Model1";
            Model1.Padding = new Padding(3, 4, 3, 4);
            Model1.Size = new Size(408, 116);
            Model1.TabIndex = 2;
            Model1.TabStop = false;
            Model1.Text = "IllustrationJaNai V1";
            // 
            // JaNaiCheck
            // 
            JaNaiCheck.AutoSize = true;
            JaNaiCheck.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            JaNaiCheck.Location = new Point(7, 68);
            JaNaiCheck.Margin = new Padding(3, 4, 3, 4);
            JaNaiCheck.Name = "JaNaiCheck";
            JaNaiCheck.Size = new Size(148, 28);
            JaNaiCheck.TabIndex = 1;
            JaNaiCheck.Text = "Использовать";
            JaNaiCheck.UseVisualStyleBackColor = true;
            // 
            // Description1
            // 
            Description1.AutoSize = true;
            Description1.Font = new Font("Arial Narrow", 12F);
            Description1.ImageAlign = ContentAlignment.MiddleLeft;
            Description1.Location = new Point(7, 37);
            Description1.Name = "Description1";
            Description1.Size = new Size(337, 24);
            Description1.TabIndex = 0;
            Description1.Text = "4x Апскейл + шумодав. Только для цвета.";
            // 
            // LanguageButton
            // 
            LanguageButton.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LanguageButton.Location = new Point(14, 817);
            LanguageButton.Margin = new Padding(3, 4, 3, 4);
            LanguageButton.Name = "LanguageButton";
            LanguageButton.Size = new Size(86, 31);
            LanguageButton.TabIndex = 4;
            LanguageButton.Text = "English";
            LanguageButton.UseVisualStyleBackColor = true;
            LanguageButton.Click += LanguageButton_Click;
            // 
            // Model3
            // 
            Model3.Controls.Add(DWTPbox);
            Model3.Controls.Add(DWTPcheck);
            Model3.Controls.Add(Description3);
            Model3.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Model3.Location = new Point(7, 73);
            Model3.Margin = new Padding(3, 4, 3, 4);
            Model3.Name = "Model3";
            Model3.Padding = new Padding(3, 4, 3, 4);
            Model3.Size = new Size(408, 157);
            Model3.TabIndex = 3;
            Model3.TabStop = false;
            Model3.Text = "Семейство DWTP DS";
            // 
            // DWTPbox
            // 
            DWTPbox.DropDownStyle = ComboBoxStyle.DropDownList;
            DWTPbox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DWTPbox.FormattingEnabled = true;
            DWTPbox.Items.AddRange(new object[] { "4x_DWTP_DS_rgts_v1", "4x_DWTP_DS_dat2_v3_2", "4x_DWTP_DS_atdl", "4x_DWTP_DS_atdl2", "4x_DWTP_DS_atdl3" });
            DWTPbox.Location = new Point(7, 68);
            DWTPbox.Margin = new Padding(3, 4, 3, 4);
            DWTPbox.Name = "DWTPbox";
            DWTPbox.Size = new Size(394, 31);
            DWTPbox.TabIndex = 12;
            // 
            // DWTPcheck
            // 
            DWTPcheck.AutoSize = true;
            DWTPcheck.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            DWTPcheck.Location = new Point(7, 111);
            DWTPcheck.Margin = new Padding(3, 4, 3, 4);
            DWTPcheck.Name = "DWTPcheck";
            DWTPcheck.Size = new Size(148, 28);
            DWTPcheck.TabIndex = 1;
            DWTPcheck.Text = "Использовать";
            DWTPcheck.UseVisualStyleBackColor = true;
            // 
            // Description3
            // 
            Description3.AutoSize = true;
            Description3.Font = new Font("Arial Narrow", 12F);
            Description3.ImageAlign = ContentAlignment.MiddleLeft;
            Description3.Location = new Point(7, 37);
            Description3.Name = "Description3";
            Description3.Size = new Size(363, 24);
            Description3.TabIndex = 0;
            Description3.Text = "4х Апскейл ч/б. Рекомендуется для качества.";
            // 
            // tilesize
            // 
            tilesize.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tilesize.FormattingEnabled = true;
            tilesize.ImeMode = ImeMode.NoControl;
            tilesize.Items.AddRange(new object[] { "256", "512" });
            tilesize.Location = new Point(727, 31);
            tilesize.Margin = new Padding(3, 4, 3, 4);
            tilesize.Name = "tilesize";
            tilesize.Size = new Size(105, 31);
            tilesize.TabIndex = 11;
            // 
            // Model4
            // 
            Model4.Controls.Add(СennyCheck);
            Model4.Controls.Add(SharpCheck);
            Model4.Controls.Add(groupBox4);
            Model4.Controls.Add(groupBox3);
            Model4.Controls.Add(groupBox2);
            Model4.Controls.Add(groupBox1);
            Model4.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Model4.Location = new Point(859, 264);
            Model4.Margin = new Padding(3, 4, 3, 4);
            Model4.Name = "Model4";
            Model4.Padding = new Padding(3, 4, 3, 4);
            Model4.Size = new Size(393, 545);
            Model4.TabIndex = 0;
            Model4.TabStop = false;
            Model4.Text = "Sharp";
            // 
            // СennyCheck
            // 
            СennyCheck.AutoSize = true;
            СennyCheck.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            СennyCheck.Location = new Point(225, 505);
            СennyCheck.Margin = new Padding(3, 4, 3, 4);
            СennyCheck.Name = "СennyCheck";
            СennyCheck.Size = new Size(162, 28);
            СennyCheck.TabIndex = 10;
            СennyCheck.Text = "Алгоритм cenny";
            СennyCheck.UseVisualStyleBackColor = true;
            // 
            // SharpCheck
            // 
            SharpCheck.AutoSize = true;
            SharpCheck.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            SharpCheck.Location = new Point(7, 505);
            SharpCheck.Margin = new Padding(3, 4, 3, 4);
            SharpCheck.Name = "SharpCheck";
            SharpCheck.Size = new Size(148, 28);
            SharpCheck.TabIndex = 8;
            SharpCheck.Text = "Использовать";
            SharpCheck.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(DiaBlack);
            groupBox4.Controls.Add(DiaBlackBar);
            groupBox4.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox4.Location = new Point(7, 389);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(379, 108);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Диапазон чёрного";
            // 
            // DiaBlack
            // 
            DiaBlack.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DiaBlack.Location = new Point(326, 41);
            DiaBlack.Margin = new Padding(3, 4, 3, 4);
            DiaBlack.Name = "DiaBlack";
            DiaBlack.Size = new Size(46, 30);
            DiaBlack.TabIndex = 3;
            DiaBlack.Text = "-1";
            DiaBlack.TextAlign = HorizontalAlignment.Center;
            DiaBlack.TextChanged += DiaBlack_TextChanged;
            // 
            // DiaBlackBar
            // 
            DiaBlackBar.LargeChange = 0;
            DiaBlackBar.Location = new Point(7, 41);
            DiaBlackBar.Margin = new Padding(3, 4, 3, 4);
            DiaBlackBar.Maximum = 255;
            DiaBlackBar.Minimum = -1;
            DiaBlackBar.Name = "DiaBlackBar";
            DiaBlackBar.Size = new Size(312, 56);
            DiaBlackBar.TabIndex = 2;
            DiaBlackBar.TickFrequency = 15;
            DiaBlackBar.TickStyle = TickStyle.None;
            DiaBlackBar.Value = -1;
            DiaBlackBar.Scroll += DiaBlackBar_Scroll;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(DiaWhite);
            groupBox3.Controls.Add(DiaWhiteBar);
            groupBox3.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox3.Location = new Point(7, 273);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(379, 108);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Диапазон белого";
            // 
            // DiaWhite
            // 
            DiaWhite.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DiaWhite.Location = new Point(326, 43);
            DiaWhite.Margin = new Padding(3, 4, 3, 4);
            DiaWhite.Name = "DiaWhite";
            DiaWhite.Size = new Size(46, 30);
            DiaWhite.TabIndex = 3;
            DiaWhite.Text = "2";
            DiaWhite.TextAlign = HorizontalAlignment.Center;
            DiaWhite.TextChanged += DiaWhite_TextChanged;
            // 
            // DiaWhiteBar
            // 
            DiaWhiteBar.LargeChange = 0;
            DiaWhiteBar.Location = new Point(7, 41);
            DiaWhiteBar.Margin = new Padding(3, 4, 3, 4);
            DiaWhiteBar.Maximum = 255;
            DiaWhiteBar.Minimum = -1;
            DiaWhiteBar.Name = "DiaWhiteBar";
            DiaWhiteBar.Size = new Size(312, 56);
            DiaWhiteBar.TabIndex = 2;
            DiaWhiteBar.TickFrequency = 15;
            DiaWhiteBar.TickStyle = TickStyle.None;
            DiaWhiteBar.Value = 2;
            DiaWhiteBar.Scroll += DiaWhiteBar_Scroll;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lowInput);
            groupBox2.Controls.Add(lowBar);
            groupBox2.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox2.Location = new Point(7, 157);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(379, 108);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Нижняя граница";
            // 
            // lowInput
            // 
            lowInput.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lowInput.Location = new Point(326, 41);
            lowInput.Margin = new Padding(3, 4, 3, 4);
            lowInput.Name = "lowInput";
            lowInput.Size = new Size(46, 30);
            lowInput.TabIndex = 3;
            lowInput.Text = "0";
            lowInput.TextAlign = HorizontalAlignment.Center;
            lowInput.TextChanged += lowInput_TextChanged;
            // 
            // lowBar
            // 
            lowBar.LargeChange = 0;
            lowBar.Location = new Point(7, 41);
            lowBar.Margin = new Padding(3, 4, 3, 4);
            lowBar.Maximum = 255;
            lowBar.Name = "lowBar";
            lowBar.Size = new Size(312, 56);
            lowBar.TabIndex = 2;
            lowBar.TickFrequency = 15;
            lowBar.TickStyle = TickStyle.None;
            lowBar.Scroll += lowBar_Scroll;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(highInput);
            groupBox1.Controls.Add(highBar);
            groupBox1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(7, 41);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(379, 108);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Верхняя граница";
            // 
            // highInput
            // 
            highInput.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            highInput.Location = new Point(326, 41);
            highInput.Margin = new Padding(3, 4, 3, 4);
            highInput.Name = "highInput";
            highInput.Size = new Size(46, 30);
            highInput.TabIndex = 3;
            highInput.Text = "255";
            highInput.TextAlign = HorizontalAlignment.Center;
            highInput.TextChanged += highInput_TextChanged;
            // 
            // highBar
            // 
            highBar.LargeChange = 0;
            highBar.Location = new Point(7, 41);
            highBar.Margin = new Padding(3, 4, 3, 4);
            highBar.Maximum = 255;
            highBar.Name = "highBar";
            highBar.Size = new Size(312, 56);
            highBar.TabIndex = 2;
            highBar.TickFrequency = 15;
            highBar.TickStyle = TickStyle.None;
            highBar.Value = 255;
            highBar.Scroll += trackBar1_Scroll;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(DotSize);
            groupBox6.Controls.Add(DotSizeBar);
            groupBox6.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox6.Location = new Point(7, 84);
            groupBox6.Margin = new Padding(3, 4, 3, 4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 4, 3, 4);
            groupBox6.Size = new Size(379, 108);
            groupBox6.TabIndex = 8;
            groupBox6.TabStop = false;
            groupBox6.Text = "Размер точек";
            // 
            // DotSize
            // 
            DotSize.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DotSize.Location = new Point(326, 41);
            DotSize.Margin = new Padding(3, 4, 3, 4);
            DotSize.Name = "DotSize";
            DotSize.Size = new Size(46, 30);
            DotSize.TabIndex = 3;
            DotSize.Text = "7";
            DotSize.TextAlign = HorizontalAlignment.Center;
            DotSize.TextChanged += DotSize_TextChanged;
            // 
            // DotSizeBar
            // 
            DotSizeBar.LargeChange = 0;
            DotSizeBar.Location = new Point(7, 41);
            DotSizeBar.Margin = new Padding(3, 4, 3, 4);
            DotSizeBar.Maximum = 100;
            DotSizeBar.Minimum = 1;
            DotSizeBar.Name = "DotSizeBar";
            DotSizeBar.Size = new Size(312, 56);
            DotSizeBar.TabIndex = 2;
            DotSizeBar.TickFrequency = 15;
            DotSizeBar.TickStyle = TickStyle.None;
            DotSizeBar.Value = 7;
            DotSizeBar.Scroll += DotSizeBar_Scroll;
            // 
            // ScreentoneCheck
            // 
            ScreentoneCheck.AutoSize = true;
            ScreentoneCheck.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            ScreentoneCheck.Location = new Point(7, 200);
            ScreentoneCheck.Margin = new Padding(3, 4, 3, 4);
            ScreentoneCheck.Name = "ScreentoneCheck";
            ScreentoneCheck.Size = new Size(148, 28);
            ScreentoneCheck.TabIndex = 1;
            ScreentoneCheck.Text = "Использовать";
            ScreentoneCheck.UseVisualStyleBackColor = true;
            // 
            // GeneralModels
            // 
            GeneralModels.Controls.Add(groupBox17);
            GeneralModels.Controls.Add(groupBox16);
            GeneralModels.Controls.Add(tiletext);
            GeneralModels.Controls.Add(tilesize);
            GeneralModels.Controls.Add(Model1);
            GeneralModels.Controls.Add(Model6);
            GeneralModels.Controls.Add(Model5);
            GeneralModels.Controls.Add(Model3);
            GeneralModels.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            GeneralModels.Location = new Point(14, 216);
            GeneralModels.Margin = new Padding(3, 4, 3, 4);
            GeneralModels.Name = "GeneralModels";
            GeneralModels.Padding = new Padding(3, 4, 3, 4);
            GeneralModels.Size = new Size(839, 593);
            GeneralModels.TabIndex = 6;
            GeneralModels.TabStop = false;
            GeneralModels.Text = "Модели";
            // 
            // groupBox17
            // 
            groupBox17.Controls.Add(ModelOpenButton);
            groupBox17.Controls.Add(ModelFolderBox);
            groupBox17.Controls.Add(OwnModelCheck);
            groupBox17.Controls.Add(label6);
            groupBox17.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox17.Location = new Point(424, 321);
            groupBox17.Margin = new Padding(3, 4, 3, 4);
            groupBox17.Name = "groupBox17";
            groupBox17.Padding = new Padding(3, 4, 3, 4);
            groupBox17.Size = new Size(408, 224);
            groupBox17.TabIndex = 13;
            groupBox17.TabStop = false;
            groupBox17.Text = "Своя модель";
            // 
            // ModelOpenButton
            // 
            ModelOpenButton.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ModelOpenButton.Location = new Point(315, 148);
            ModelOpenButton.Margin = new Padding(3, 4, 3, 4);
            ModelOpenButton.Name = "ModelOpenButton";
            ModelOpenButton.Size = new Size(86, 31);
            ModelOpenButton.TabIndex = 4;
            ModelOpenButton.Text = "Открыть...";
            ModelOpenButton.UseVisualStyleBackColor = true;
            ModelOpenButton.Click += ModelOpenButton_Click;
            // 
            // ModelFolderBox
            // 
            ModelFolderBox.Font = new Font("Arial Narrow", 9F);
            ModelFolderBox.Location = new Point(7, 148);
            ModelFolderBox.Margin = new Padding(3, 4, 3, 4);
            ModelFolderBox.Name = "ModelFolderBox";
            ModelFolderBox.Size = new Size(301, 25);
            ModelFolderBox.TabIndex = 4;
            // 
            // OwnModelCheck
            // 
            OwnModelCheck.AutoSize = true;
            OwnModelCheck.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            OwnModelCheck.Location = new Point(7, 184);
            OwnModelCheck.Margin = new Padding(3, 4, 3, 4);
            OwnModelCheck.Name = "OwnModelCheck";
            OwnModelCheck.Size = new Size(148, 28);
            OwnModelCheck.TabIndex = 1;
            OwnModelCheck.Text = "Использовать";
            OwnModelCheck.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F);
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(7, 37);
            label6.Name = "label6";
            label6.Size = new Size(380, 96);
            label6.TabIndex = 0;
            label6.Text = "Сюда вы можете загрузить свою модель\r\nс раширением \".pth\".\r\nЖелательно использовать без других моделек.\r\n(Иначе может поломаться очередь)";
            // 
            // groupBox16
            // 
            groupBox16.Controls.Add(FastScaleBox);
            groupBox16.Controls.Add(FastScaleCheck);
            groupBox16.Controls.Add(label3);
            groupBox16.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox16.Location = new Point(7, 404);
            groupBox16.Margin = new Padding(3, 4, 3, 4);
            groupBox16.Name = "groupBox16";
            groupBox16.Padding = new Padding(3, 4, 3, 4);
            groupBox16.Size = new Size(408, 181);
            groupBox16.TabIndex = 12;
            groupBox16.TabStop = false;
            groupBox16.Text = "FastScale модели";
            // 
            // FastScaleBox
            // 
            FastScaleBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FastScaleBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FastScaleBox.FormattingEnabled = true;
            FastScaleBox.Items.AddRange(new object[] { "4x-eula-digimanga-bw-v2-nc1", "2x_MangaScaleV3", "4x_MangaJaNai_2048p_V1RC1", "4x_MangaJaNai_1920p_V1RC1", "4x_MangaJaNai_1600p_V1RC1", "4x_MangaJaNai_1500p_V1RC1", "4x_MangaJaNai_1400p_V1RC3", "4x_MangaJaNai_1300p_V1RC1", "4x_MangaJaNai_1200p_V1RC71" });
            FastScaleBox.Location = new Point(7, 95);
            FastScaleBox.Margin = new Padding(3, 4, 3, 4);
            FastScaleBox.Name = "FastScaleBox";
            FastScaleBox.Size = new Size(394, 31);
            FastScaleBox.TabIndex = 11;
            // 
            // FastScaleCheck
            // 
            FastScaleCheck.AutoSize = true;
            FastScaleCheck.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            FastScaleCheck.Location = new Point(7, 137);
            FastScaleCheck.Margin = new Padding(3, 4, 3, 4);
            FastScaleCheck.Name = "FastScaleCheck";
            FastScaleCheck.Size = new Size(148, 28);
            FastScaleCheck.TabIndex = 1;
            FastScaleCheck.Text = "Использовать";
            FastScaleCheck.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(7, 37);
            label3.Name = "label3";
            label3.Size = new Size(394, 48);
            label3.TabIndex = 0;
            label3.Text = "4/2x Апскейлер ч/б. Рекомендуется для скорости.\r\nИспользовать без других моделек.";
            // 
            // tiletext
            // 
            tiletext.AutoSize = true;
            tiletext.Font = new Font("Arial Narrow", 12F);
            tiletext.ImageAlign = ContentAlignment.MiddleLeft;
            tiletext.Location = new Point(518, 34);
            tiletext.Name = "tiletext";
            tiletext.Size = new Size(203, 24);
            tiletext.TabIndex = 2;
            tiletext.Text = "Выберите размер плитки";
            tiletext.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Model6
            // 
            Model6.Controls.Add(MangaJPEGbox);
            Model6.Controls.Add(MangaJPEGcheck);
            Model6.Controls.Add(Description6);
            Model6.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Model6.Location = new Point(7, 239);
            Model6.Margin = new Padding(3, 4, 3, 4);
            Model6.Name = "Model6";
            Model6.Padding = new Padding(3, 4, 3, 4);
            Model6.Size = new Size(408, 157);
            Model6.TabIndex = 6;
            Model6.TabStop = false;
            Model6.Text = "Семейство MangaJPEG";
            // 
            // MangaJPEGbox
            // 
            MangaJPEGbox.DropDownStyle = ComboBoxStyle.DropDownList;
            MangaJPEGbox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MangaJPEGbox.FormattingEnabled = true;
            MangaJPEGbox.Items.AddRange(new object[] { "High Quality Plus", "High Qulity", "Medium Quality", "Low Quality" });
            MangaJPEGbox.Location = new Point(7, 68);
            MangaJPEGbox.Margin = new Padding(3, 4, 3, 4);
            MangaJPEGbox.Name = "MangaJPEGbox";
            MangaJPEGbox.Size = new Size(394, 31);
            MangaJPEGbox.TabIndex = 11;
            // 
            // MangaJPEGcheck
            // 
            MangaJPEGcheck.AutoSize = true;
            MangaJPEGcheck.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            MangaJPEGcheck.Location = new Point(7, 111);
            MangaJPEGcheck.Margin = new Padding(3, 4, 3, 4);
            MangaJPEGcheck.Name = "MangaJPEGcheck";
            MangaJPEGcheck.Size = new Size(148, 28);
            MangaJPEGcheck.TabIndex = 1;
            MangaJPEGcheck.Text = "Использовать";
            MangaJPEGcheck.UseVisualStyleBackColor = true;
            // 
            // Description6
            // 
            Description6.AutoSize = true;
            Description6.Font = new Font("Arial Narrow", 12F);
            Description6.ImageAlign = ContentAlignment.MiddleLeft;
            Description6.Location = new Point(7, 37);
            Description6.Name = "Description6";
            Description6.Size = new Size(135, 24);
            Description6.TabIndex = 0;
            Description6.Text = "1x Шумодав ч/б.";
            // 
            // Model5
            // 
            Model5.Controls.Add(SaiyajinCheck);
            Model5.Controls.Add(Description5);
            Model5.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Model5.Location = new Point(424, 197);
            Model5.Margin = new Padding(3, 4, 3, 4);
            Model5.Name = "Model5";
            Model5.Padding = new Padding(3, 4, 3, 4);
            Model5.Size = new Size(408, 116);
            Model5.TabIndex = 4;
            Model5.TabStop = false;
            Model5.Text = "SaiyajinDeJpeg";
            // 
            // SaiyajinCheck
            // 
            SaiyajinCheck.AutoSize = true;
            SaiyajinCheck.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            SaiyajinCheck.Location = new Point(7, 68);
            SaiyajinCheck.Margin = new Padding(3, 4, 3, 4);
            SaiyajinCheck.Name = "SaiyajinCheck";
            SaiyajinCheck.Size = new Size(148, 28);
            SaiyajinCheck.TabIndex = 1;
            SaiyajinCheck.Text = "Использовать";
            SaiyajinCheck.UseVisualStyleBackColor = true;
            // 
            // Description5
            // 
            Description5.AutoSize = true;
            Description5.Font = new Font("Arial Narrow", 12F);
            Description5.ImageAlign = ContentAlignment.MiddleLeft;
            Description5.Location = new Point(7, 37);
            Description5.Name = "Description5";
            Description5.Size = new Size(414, 24);
            Description5.TabIndex = 0;
            Description5.Text = "1x Шумодав. Для убитых сканов(ломает скринтоны).\r\n";
            // 
            // LaunchButton
            // 
            LaunchButton.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LaunchButton.Location = new Point(7, 127);
            LaunchButton.Margin = new Padding(3, 4, 3, 4);
            LaunchButton.Name = "LaunchButton";
            LaunchButton.Size = new Size(398, 57);
            LaunchButton.TabIndex = 3;
            LaunchButton.Text = "Запуск";
            LaunchButton.UseVisualStyleBackColor = true;
            LaunchButton.Click += LaunchButton_Click;
            // 
            // OutputFolderSelection
            // 
            OutputFolderSelection.Controls.Add(FolderBox2);
            OutputFolderSelection.Controls.Add(OpenButton2);
            OutputFolderSelection.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OutputFolderSelection.Location = new Point(14, 116);
            OutputFolderSelection.Margin = new Padding(3, 4, 3, 4);
            OutputFolderSelection.Name = "OutputFolderSelection";
            OutputFolderSelection.Padding = new Padding(3, 4, 3, 4);
            OutputFolderSelection.Size = new Size(839, 92);
            OutputFolderSelection.TabIndex = 4;
            OutputFolderSelection.TabStop = false;
            OutputFolderSelection.Text = "Выберите папку для вывода";
            // 
            // FolderBox2
            // 
            FolderBox2.Font = new Font("Arial Narrow", 9F);
            FolderBox2.Location = new Point(7, 41);
            FolderBox2.Margin = new Padding(3, 4, 3, 4);
            FolderBox2.Name = "FolderBox2";
            FolderBox2.Size = new Size(732, 25);
            FolderBox2.TabIndex = 2;
            // 
            // OpenButton2
            // 
            OpenButton2.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OpenButton2.Location = new Point(746, 41);
            OpenButton2.Margin = new Padding(3, 4, 3, 4);
            OpenButton2.Name = "OpenButton2";
            OpenButton2.Size = new Size(86, 31);
            OpenButton2.TabIndex = 3;
            OpenButton2.Text = "Открыть...";
            OpenButton2.UseVisualStyleBackColor = true;
            OpenButton2.Click += OpenButton2_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label2);
            groupBox5.Controls.Add(label1);
            groupBox5.Controls.Add(LaunchButton);
            groupBox5.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox5.Location = new Point(1259, 661);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(431, 192);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "Меню запуска";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(7, 37);
            label2.Name = "label2";
            label2.Size = new Size(68, 24);
            label2.TabIndex = 9;
            label2.Text = "Важно!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(7, 64);
            label1.Name = "label1";
            label1.Size = new Size(410, 48);
            label1.TabIndex = 8;
            label1.Text = "После нажатия \"Запуск\", не закрывайте программу,\r\nпока не появится окно о завершении процесса.";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(SizeCheck);
            groupBox7.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox7.Location = new Point(7, 80);
            groupBox7.Margin = new Padding(3, 4, 3, 4);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(3, 4, 3, 4);
            groupBox7.Size = new Size(175, 108);
            groupBox7.TabIndex = 5;
            groupBox7.TabStop = false;
            groupBox7.Text = "Размер";
            // 
            // SizeCheck
            // 
            SizeCheck.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SizeCheck.Location = new Point(7, 41);
            SizeCheck.Margin = new Padding(3, 4, 3, 4);
            SizeCheck.Name = "SizeCheck";
            SizeCheck.Size = new Size(161, 30);
            SizeCheck.TabIndex = 3;
            SizeCheck.Text = "2000";
            SizeCheck.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(InterBox);
            groupBox8.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox8.Location = new Point(189, 80);
            groupBox8.Margin = new Padding(3, 4, 3, 4);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(3, 4, 3, 4);
            groupBox8.Size = new Size(236, 108);
            groupBox8.TabIndex = 9;
            groupBox8.TabStop = false;
            groupBox8.Text = "Интерполяция";
            // 
            // InterBox
            // 
            InterBox.DropDownStyle = ComboBoxStyle.DropDownList;
            InterBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            InterBox.FormattingEnabled = true;
            InterBox.ImeMode = ImeMode.NoControl;
            InterBox.Items.AddRange(new object[] { "linear", "nearest", "cubic_catrom", "cubic_mitchell", "cubic_bspline", "lanczos", "gauss", "lagrange" });
            InterBox.Location = new Point(7, 41);
            InterBox.Margin = new Padding(3, 4, 3, 4);
            InterBox.Name = "InterBox";
            InterBox.Size = new Size(223, 31);
            InterBox.TabIndex = 10;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(WidthCheck);
            groupBox9.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox9.Location = new Point(7, 196);
            groupBox9.Margin = new Padding(3, 4, 3, 4);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(3, 4, 3, 4);
            groupBox9.Size = new Size(175, 108);
            groupBox9.TabIndex = 11;
            groupBox9.TabStop = false;
            groupBox9.Text = "По ширине?";
            // 
            // WidthCheck
            // 
            WidthCheck.DropDownStyle = ComboBoxStyle.DropDownList;
            WidthCheck.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WidthCheck.FormattingEnabled = true;
            WidthCheck.Items.AddRange(new object[] { "true", "false" });
            WidthCheck.Location = new Point(7, 41);
            WidthCheck.Margin = new Padding(3, 4, 3, 4);
            WidthCheck.Name = "WidthCheck";
            WidthCheck.Size = new Size(161, 31);
            WidthCheck.TabIndex = 10;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(PercentBox);
            groupBox10.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox10.Location = new Point(189, 196);
            groupBox10.Margin = new Padding(3, 4, 3, 4);
            groupBox10.Name = "groupBox10";
            groupBox10.Padding = new Padding(3, 4, 3, 4);
            groupBox10.Size = new Size(236, 108);
            groupBox10.TabIndex = 12;
            groupBox10.TabStop = false;
            groupBox10.Text = "Проценты";
            // 
            // PercentBox
            // 
            PercentBox.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PercentBox.Location = new Point(7, 41);
            PercentBox.Margin = new Padding(3, 4, 3, 4);
            PercentBox.Name = "PercentBox";
            PercentBox.Size = new Size(223, 30);
            PercentBox.TabIndex = 4;
            PercentBox.Text = "100";
            PercentBox.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(SpreadSize);
            groupBox11.Font = new Font("Arial Narrow", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox11.Location = new Point(189, 312);
            groupBox11.Margin = new Padding(3, 4, 3, 4);
            groupBox11.Name = "groupBox11";
            groupBox11.Padding = new Padding(3, 4, 3, 4);
            groupBox11.Size = new Size(236, 108);
            groupBox11.TabIndex = 14;
            groupBox11.TabStop = false;
            groupBox11.Text = "Размер Разворота";
            // 
            // SpreadSize
            // 
            SpreadSize.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SpreadSize.Location = new Point(7, 41);
            SpreadSize.Margin = new Padding(3, 4, 3, 4);
            SpreadSize.Name = "SpreadSize";
            SpreadSize.Size = new Size(223, 30);
            SpreadSize.TabIndex = 4;
            SpreadSize.Text = "2800";
            SpreadSize.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox12
            // 
            groupBox12.Controls.Add(SpreadCheck);
            groupBox12.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox12.Location = new Point(7, 312);
            groupBox12.Margin = new Padding(3, 4, 3, 4);
            groupBox12.Name = "groupBox12";
            groupBox12.Padding = new Padding(3, 4, 3, 4);
            groupBox12.Size = new Size(175, 108);
            groupBox12.TabIndex = 13;
            groupBox12.TabStop = false;
            groupBox12.Text = "Разворот?";
            // 
            // SpreadCheck
            // 
            SpreadCheck.DropDownStyle = ComboBoxStyle.DropDownList;
            SpreadCheck.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SpreadCheck.FormattingEnabled = true;
            SpreadCheck.Items.AddRange(new object[] { "true", "false" });
            SpreadCheck.Location = new Point(7, 41);
            SpreadCheck.Margin = new Padding(3, 4, 3, 4);
            SpreadCheck.Name = "SpreadCheck";
            SpreadCheck.Size = new Size(161, 31);
            SpreadCheck.TabIndex = 10;
            // 
            // groupBox13
            // 
            groupBox13.Controls.Add(ResizeCheck);
            groupBox13.Controls.Add(groupBox12);
            groupBox13.Controls.Add(Description10);
            groupBox13.Controls.Add(groupBox11);
            groupBox13.Controls.Add(groupBox7);
            groupBox13.Controls.Add(groupBox8);
            groupBox13.Controls.Add(groupBox10);
            groupBox13.Controls.Add(groupBox9);
            groupBox13.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox13.Location = new Point(1259, 16);
            groupBox13.Margin = new Padding(3, 4, 3, 4);
            groupBox13.Name = "groupBox13";
            groupBox13.Padding = new Padding(3, 4, 3, 4);
            groupBox13.Size = new Size(431, 469);
            groupBox13.TabIndex = 9;
            groupBox13.TabStop = false;
            groupBox13.Text = "Resize";
            // 
            // ResizeCheck
            // 
            ResizeCheck.AutoSize = true;
            ResizeCheck.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            ResizeCheck.Location = new Point(7, 428);
            ResizeCheck.Margin = new Padding(3, 4, 3, 4);
            ResizeCheck.Name = "ResizeCheck";
            ResizeCheck.Size = new Size(148, 28);
            ResizeCheck.TabIndex = 1;
            ResizeCheck.Text = "Использовать";
            ResizeCheck.UseVisualStyleBackColor = true;
            ResizeCheck.CheckedChanged += ResizeCheck_CheckedChanged;
            // 
            // Description10
            // 
            Description10.AutoSize = true;
            Description10.Font = new Font("Arial Narrow", 12F);
            Description10.ImageAlign = ContentAlignment.MiddleLeft;
            Description10.Location = new Point(7, 37);
            Description10.Name = "Description10";
            Description10.Size = new Size(239, 24);
            Description10.TabIndex = 0;
            Description10.Text = "Меняет размер изображения.";
            // 
            // groupBox14
            // 
            groupBox14.BackColor = SystemColors.Control;
            groupBox14.Controls.Add(Description4);
            groupBox14.Controls.Add(groupBox6);
            groupBox14.Controls.Add(ScreentoneCheck);
            groupBox14.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox14.Location = new Point(859, 16);
            groupBox14.Margin = new Padding(3, 4, 3, 4);
            groupBox14.Name = "groupBox14";
            groupBox14.Padding = new Padding(3, 4, 3, 4);
            groupBox14.Size = new Size(393, 240);
            groupBox14.TabIndex = 9;
            groupBox14.TabStop = false;
            groupBox14.Text = "Screentone Maker";
            // 
            // Description4
            // 
            Description4.AutoSize = true;
            Description4.Font = new Font("Arial Narrow", 12F);
            Description4.ImageAlign = ContentAlignment.MiddleLeft;
            Description4.Location = new Point(7, 37);
            Description4.Name = "Description4";
            Description4.Size = new Size(309, 24);
            Description4.TabIndex = 0;
            Description4.Text = "Добавляет скринтоны. Только для ч/б.";
            // 
            // groupBox15
            // 
            groupBox15.Controls.Add(label4);
            groupBox15.Controls.Add(label5);
            groupBox15.Controls.Add(DownloadButton);
            groupBox15.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox15.Location = new Point(1259, 493);
            groupBox15.Margin = new Padding(3, 4, 3, 4);
            groupBox15.Name = "groupBox15";
            groupBox15.Padding = new Padding(3, 4, 3, 4);
            groupBox15.Size = new Size(431, 160);
            groupBox15.TabIndex = 10;
            groupBox15.TabStop = false;
            groupBox15.Text = "Скачать зависимости";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(7, 37);
            label4.Name = "label4";
            label4.Size = new Size(68, 24);
            label4.TabIndex = 9;
            label4.Text = "Важно!";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F);
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(7, 64);
            label5.Name = "label5";
            label5.Size = new Size(390, 24);
            label5.TabIndex = 8;
            label5.Text = "Перед началом работы установите зависимости.";
            // 
            // DownloadButton
            // 
            DownloadButton.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DownloadButton.Location = new Point(7, 95);
            DownloadButton.Margin = new Padding(3, 4, 3, 4);
            DownloadButton.Name = "DownloadButton";
            DownloadButton.Size = new Size(418, 57);
            DownloadButton.TabIndex = 3;
            DownloadButton.Text = "Скачать";
            DownloadButton.UseVisualStyleBackColor = true;
            DownloadButton.Click += button1_Click_3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1697, 862);
            Controls.Add(groupBox15);
            Controls.Add(groupBox14);
            Controls.Add(groupBox13);
            Controls.Add(groupBox5);
            Controls.Add(OutputFolderSelection);
            Controls.Add(GeneralModels);
            Controls.Add(LanguageButton);
            Controls.Add(FolderSelection);
            Controls.Add(Model4);
            Font = new Font("Segoe UI", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Scans Enhanser";
            FolderSelection.ResumeLayout(false);
            FolderSelection.PerformLayout();
            Model1.ResumeLayout(false);
            Model1.PerformLayout();
            Model3.ResumeLayout(false);
            Model3.PerformLayout();
            Model4.ResumeLayout(false);
            Model4.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DiaBlackBar).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DiaWhiteBar).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lowBar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)highBar).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DotSizeBar).EndInit();
            GeneralModels.ResumeLayout(false);
            GeneralModels.PerformLayout();
            groupBox17.ResumeLayout(false);
            groupBox17.PerformLayout();
            groupBox16.ResumeLayout(false);
            groupBox16.PerformLayout();
            Model6.ResumeLayout(false);
            Model6.PerformLayout();
            Model5.ResumeLayout(false);
            Model5.PerformLayout();
            OutputFolderSelection.ResumeLayout(false);
            OutputFolderSelection.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            groupBox12.ResumeLayout(false);
            groupBox13.ResumeLayout(false);
            groupBox13.PerformLayout();
            groupBox14.ResumeLayout(false);
            groupBox14.PerformLayout();
            groupBox15.ResumeLayout(false);
            groupBox15.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox FolderSelection;
        private TextBox FolderBox;
        private Button OpenButton;
        private GroupBox Model1;
        private Label Description1;
        private CheckBox JaNaiCheck;
        private Button LanguageButton;
        private GroupBox Model3;
        private CheckBox DWTPcheck;
        private Label Description3;
        private GroupBox Model4;
        private CheckBox ScreentoneCheck;
        private GroupBox GeneralModels;
        private Button LaunchButton;
        private GroupBox OutputFolderSelection;
        private TextBox FolderBox2;
        private Button OpenButton2;
        private TrackBar highBar;
        private GroupBox groupBox1;
        private TextBox highInput;
        private GroupBox groupBox2;
        private TextBox lowInput;
        private TrackBar lowBar;
        private GroupBox groupBox3;
        private TextBox DiaWhite;
        private TrackBar DiaWhiteBar;
        private GroupBox groupBox4;
        private TextBox DiaBlack;
        private TrackBar DiaBlackBar;
        private GroupBox Model5;
        private CheckBox SaiyajinCheck;
        private Label Description5;
        private GroupBox Model6;
        private CheckBox MangaJPEGcheck;
        private Label Description6;
        private GroupBox groupBox5;
        private Label label1;
        private Label label2;
        private GroupBox groupBox6;
        private TextBox DotSize;
        private TrackBar DotSizeBar;
        private GroupBox groupBox7;
        private TextBox SizeCheck;
        private GroupBox groupBox8;
        private ComboBox InterBox;
        private GroupBox groupBox9;
        private ComboBox WidthCheck;
        private GroupBox groupBox10;
        private GroupBox groupBox11;
        private TextBox SpreadSize;
        private GroupBox groupBox12;
        private ComboBox SpreadCheck;
        private TextBox PercentBox;
        private GroupBox groupBox13;
        private CheckBox ResizeCheck;
        private Label Description10;
        private CheckBox SharpCheck;
        private GroupBox groupBox14;
        private Label Description4;
        private GroupBox groupBox15;
        private Label label4;
        private Label label5;
        private Button DownloadButton;
        private ComboBox tilesize;
        private Label tiletext;
        private CheckBox СennyCheck;
        private ComboBox MangaJPEGbox;
        private ComboBox DWTPbox;
        private GroupBox groupBox16;
        private ComboBox FastScaleBox;
        private CheckBox FastScaleCheck;
        private Label label3;
        private GroupBox groupBox17;
        private CheckBox OwnModelCheck;
        private Label label6;
        private Button ModelOpenButton;
        private TextBox ModelFolderBox;
        private CheckBox cennyCheck;
    }
}
