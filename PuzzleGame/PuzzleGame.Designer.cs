namespace PuzzleGame
{
    partial class PuzzleGame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddImage = new System.Windows.Forms.ToolStripMenuItem();
            this.VeryVeryEasyMode = new System.Windows.Forms.ToolStripMenuItem();
            this.VeryEasyMode = new System.Windows.Forms.ToolStripMenuItem();
            this.EasyMode = new System.Windows.Forms.ToolStripMenuItem();
            this.MediumMode = new System.Windows.Forms.ToolStripMenuItem();
            this.HardMode = new System.Windows.Forms.ToolStripMenuItem();
            this.GiperHardMode = new System.Windows.Forms.ToolStripMenuItem();
            this.SolveIt = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseSize = new System.Windows.Forms.ToolStripTextBox();
            this.puzzleImageBox = new System.Windows.Forms.PictureBox();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puzzleImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddImage,
            this.VeryVeryEasyMode,
            this.VeryEasyMode,
            this.EasyMode,
            this.MediumMode,
            this.HardMode,
            this.GiperHardMode,
            this.SolveIt,
            this.chooseSize});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddImage
            // 
            this.AddImage.Name = "AddImage";
            this.AddImage.Size = new System.Drawing.Size(119, 23);
            this.AddImage.Text = "Открыть картинку";
            this.AddImage.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.AddImage.Click += new System.EventHandler(this.AddImage_Click);
            // 
            // VeryVeryEasyMode
            // 
            this.VeryVeryEasyMode.Name = "VeryVeryEasyMode";
            this.VeryVeryEasyMode.Size = new System.Drawing.Size(94, 23);
            this.VeryVeryEasyMode.Text = "Супер лёгкий";
            this.VeryVeryEasyMode.Click += new System.EventHandler(this.SelectMode);
            // 
            // VeryEasyMode
            // 
            this.VeryEasyMode.Name = "VeryEasyMode";
            this.VeryEasyMode.Size = new System.Drawing.Size(95, 23);
            this.VeryEasyMode.Text = "Очень лёгкий";
            this.VeryEasyMode.Click += new System.EventHandler(this.SelectMode);
            // 
            // EasyMode
            // 
            this.EasyMode.Name = "EasyMode";
            this.EasyMode.Size = new System.Drawing.Size(58, 23);
            this.EasyMode.Text = "Лёгкий";
            this.EasyMode.Click += new System.EventHandler(this.SelectMode);
            // 
            // MediumMode
            // 
            this.MediumMode.Name = "MediumMode";
            this.MediumMode.Size = new System.Drawing.Size(67, 23);
            this.MediumMode.Text = "Средний";
            this.MediumMode.Click += new System.EventHandler(this.SelectMode);
            // 
            // HardMode
            // 
            this.HardMode.Name = "HardMode";
            this.HardMode.Size = new System.Drawing.Size(73, 23);
            this.HardMode.Text = "Сложный";
            this.HardMode.Click += new System.EventHandler(this.SelectMode);
            // 
            // GiperHardMode
            // 
            this.GiperHardMode.Name = "GiperHardMode";
            this.GiperHardMode.Size = new System.Drawing.Size(107, 23);
            this.GiperHardMode.Text = "Гипер сложный";
            this.GiperHardMode.Click += new System.EventHandler(this.SelectMode);
            // 
            // SolveIt
            // 
            this.SolveIt.Name = "SolveIt";
            this.SolveIt.Size = new System.Drawing.Size(72, 23);
            this.SolveIt.Text = "Результат";
            this.SolveIt.Click += new System.EventHandler(this.SolveIt_Click);
            // 
            // chooseSize
            // 
            this.chooseSize.MaxLength = 3;
            this.chooseSize.Name = "chooseSize";
            this.chooseSize.Size = new System.Drawing.Size(100, 23);
            this.chooseSize.Text = "1-400";
            this.chooseSize.KeyUp += new System.Windows.Forms.KeyEventHandler(this.chooseSize_KeyUp);
            this.chooseSize.TextChanged += new System.EventHandler(this.chooseSize_TextChanged);
            // 
            // puzzleImageBox
            // 
            this.puzzleImageBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.puzzleImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.puzzleImageBox.Location = new System.Drawing.Point(6, 30);
            this.puzzleImageBox.Name = "puzzleImageBox";
            this.puzzleImageBox.Size = new System.Drawing.Size(800, 600);
            this.puzzleImageBox.TabIndex = 1;
            this.puzzleImageBox.TabStop = false;
            this.puzzleImageBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.puzzleImage_MouseDown);
            this.puzzleImageBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.puzzleImage_MouseMove);
            this.puzzleImageBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.puzzleImage_MouseUp);
            // 
            // buttonAbout
            // 
            this.buttonAbout.AccessibleDescription = "";
            this.buttonAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAbout.Location = new System.Drawing.Point(794, 0);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(20, 23);
            this.buttonAbout.TabIndex = 2;
            this.buttonAbout.Text = "!";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // PuzzleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(814, 631);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.puzzleImageBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PuzzleGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Собери Димаса (или просто пазл) V3.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puzzleImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddImage;
        private System.Windows.Forms.ToolStripMenuItem EasyMode;
        private System.Windows.Forms.ToolStripMenuItem MediumMode;
        private System.Windows.Forms.ToolStripMenuItem HardMode;
        private System.Windows.Forms.ToolStripMenuItem SolveIt;
        private System.Windows.Forms.PictureBox puzzleImageBox;
        private System.Windows.Forms.ToolStripMenuItem VeryEasyMode;
        private System.Windows.Forms.ToolStripMenuItem VeryVeryEasyMode;
        private System.Windows.Forms.ToolStripMenuItem GiperHardMode;
        private System.Windows.Forms.ToolStripTextBox chooseSize;
        private System.Windows.Forms.Button buttonAbout;
    }
}

