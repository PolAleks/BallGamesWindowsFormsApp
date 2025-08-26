namespace CatchMeWindowsFormsApp
{
    partial class MainForm
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
            this.createButton = new System.Windows.Forms.Button();
            this.caughtBallsLabel = new System.Windows.Forms.Label();
            this.caughtBallsValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createButton.Location = new System.Drawing.Point(39, 17);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(88, 30);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Создать";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // caughtBallsLabel
            // 
            this.caughtBallsLabel.AutoSize = true;
            this.caughtBallsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.caughtBallsLabel.Location = new System.Drawing.Point(384, 24);
            this.caughtBallsLabel.Name = "caughtBallsLabel";
            this.caughtBallsLabel.Size = new System.Drawing.Size(126, 16);
            this.caughtBallsLabel.TabIndex = 1;
            this.caughtBallsLabel.Text = "Поймано мячей:";
            // 
            // caughtBallsValueLabel
            // 
            this.caughtBallsValueLabel.AutoSize = true;
            this.caughtBallsValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.caughtBallsValueLabel.Location = new System.Drawing.Point(536, 24);
            this.caughtBallsValueLabel.Name = "caughtBallsValueLabel";
            this.caughtBallsValueLabel.Size = new System.Drawing.Size(15, 16);
            this.caughtBallsValueLabel.TabIndex = 2;
            this.caughtBallsValueLabel.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.caughtBallsValueLabel);
            this.Controls.Add(this.caughtBallsLabel);
            this.Controls.Add(this.createButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поймай меня";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label caughtBallsLabel;
        private System.Windows.Forms.Label caughtBallsValueLabel;
    }
}

