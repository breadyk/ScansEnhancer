namespace EasyUpscaler
{
    partial class Form2
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
            groupBox1 = new GroupBox();
            srcoredone = new Label();
            label1 = new Label();
            SrcoreButton = new Button();
            groupBox2 = new GroupBox();
            mutilsdone = new Label();
            label2 = new Label();
            mutilsButton = new Button();
            groupBox3 = new GroupBox();
            modelsdone = new Label();
            label4 = new Label();
            modelsbutton = new Button();
            groupBox4 = new GroupBox();
            label6 = new Label();
            GPUbox = new ComboBox();
            torchdone = new Label();
            label5 = new Label();
            torchButton = new Button();
            LanguageButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(srcoredone);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(SrcoreButton);
            groupBox1.Font = new Font("Arial Narrow", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(208, 109);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "SR-Core";
            // 
            // srcoredone
            // 
            srcoredone.AutoSize = true;
            srcoredone.Location = new Point(43, 62);
            srcoredone.Name = "srcoredone";
            srcoredone.Size = new Size(115, 24);
            srcoredone.TabIndex = 4;
            srcoredone.Text = "Установлено";
            srcoredone.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(6, 26);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 2;
            label1.Text = "~300 КБ";
            // 
            // SrcoreButton
            // 
            SrcoreButton.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SrcoreButton.Location = new Point(6, 49);
            SrcoreButton.Name = "SrcoreButton";
            SrcoreButton.Size = new Size(196, 53);
            SrcoreButton.TabIndex = 1;
            SrcoreButton.Text = "Скачать";
            SrcoreButton.UseVisualStyleBackColor = true;
            SrcoreButton.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(mutilsdone);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(mutilsButton);
            groupBox2.Font = new Font("Arial Narrow", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox2.Location = new Point(12, 127);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(208, 109);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Manga Utils";
            // 
            // mutilsdone
            // 
            mutilsdone.AutoSize = true;
            mutilsdone.Location = new Point(43, 62);
            mutilsdone.Name = "mutilsdone";
            mutilsdone.Size = new Size(115, 24);
            mutilsdone.TabIndex = 5;
            mutilsdone.Text = "Установлено";
            mutilsdone.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(6, 26);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 2;
            label2.Text = "~9 МБ";
            // 
            // mutilsButton
            // 
            mutilsButton.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            mutilsButton.Location = new Point(6, 49);
            mutilsButton.Name = "mutilsButton";
            mutilsButton.Size = new Size(196, 53);
            mutilsButton.TabIndex = 1;
            mutilsButton.Text = "Скачать";
            mutilsButton.UseVisualStyleBackColor = true;
            mutilsButton.Click += mutilsButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(modelsdone);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(modelsbutton);
            groupBox3.Font = new Font("Arial Narrow", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox3.Location = new Point(226, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(208, 109);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Зависимости";
            // 
            // modelsdone
            // 
            modelsdone.AutoSize = true;
            modelsdone.Location = new Point(43, 62);
            modelsdone.Name = "modelsdone";
            modelsdone.Size = new Size(115, 24);
            modelsdone.TabIndex = 4;
            modelsdone.Text = "Установлено";
            modelsdone.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(6, 26);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 2;
            label4.Text = "~200 МБ";
            // 
            // modelsbutton
            // 
            modelsbutton.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            modelsbutton.Location = new Point(6, 49);
            modelsbutton.Name = "modelsbutton";
            modelsbutton.Size = new Size(196, 53);
            modelsbutton.TabIndex = 1;
            modelsbutton.Text = "Скачать";
            modelsbutton.UseVisualStyleBackColor = true;
            modelsbutton.Click += modelsbutton_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(GPUbox);
            groupBox4.Controls.Add(torchdone);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(torchButton);
            groupBox4.Font = new Font("Arial Narrow", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox4.Location = new Point(226, 127);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(208, 166);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "PyTorch";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(6, 46);
            label6.Name = "label6";
            label6.Size = new Size(152, 20);
            label6.TabIndex = 12;
            label6.Text = "Выберите вашу GPU...";
            // 
            // GPUbox
            // 
            GPUbox.DropDownStyle = ComboBoxStyle.DropDownList;
            GPUbox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            GPUbox.FormattingEnabled = true;
            GPUbox.ImeMode = ImeMode.NoControl;
            GPUbox.Items.AddRange(new object[] { "Nvidia Geforce", "AMD Radeon", "Intel ARC", "No discrete GPU" });
            GPUbox.Location = new Point(6, 69);
            GPUbox.Name = "GPUbox";
            GPUbox.Size = new Size(196, 26);
            GPUbox.TabIndex = 11;
            // 
            // torchdone
            // 
            torchdone.AutoSize = true;
            torchdone.Location = new Point(43, 114);
            torchdone.Name = "torchdone";
            torchdone.Size = new Size(115, 24);
            torchdone.TabIndex = 4;
            torchdone.Text = "Установлено";
            torchdone.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(6, 26);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 2;
            label5.Text = "~5 ГБ";
            // 
            // torchButton
            // 
            torchButton.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            torchButton.Location = new Point(6, 101);
            torchButton.Name = "torchButton";
            torchButton.Size = new Size(196, 53);
            torchButton.TabIndex = 1;
            torchButton.Text = "Скачать";
            torchButton.UseVisualStyleBackColor = true;
            torchButton.Click += torchButton_Click;
            // 
            // LanguageButton
            // 
            LanguageButton.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LanguageButton.Location = new Point(12, 270);
            LanguageButton.Name = "LanguageButton";
            LanguageButton.Size = new Size(75, 23);
            LanguageButton.TabIndex = 7;
            LanguageButton.Text = "English";
            LanguageButton.UseVisualStyleBackColor = true;
            LanguageButton.Click += LanguageButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 305);
            Controls.Add(LanguageButton);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button SrcoreButton;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private Button mutilsButton;
        private Label srcoredone;
        private Label mutilsdone;
        private GroupBox groupBox3;
        private Label modelsdone;
        private Label label4;
        private Button modelsbutton;
        private GroupBox groupBox4;
        private Label torchdone;
        private Label label5;
        private Button torchButton;
        private ComboBox GPUbox;
        private Label label6;
        private Button LanguageButton;
    }
}