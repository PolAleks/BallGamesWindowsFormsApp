namespace FruitNinjaWinFormApp
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
            this.hitBallLabel = new System.Windows.Forms.Label();
            this.hitBallValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hitBallLabel
            // 
            this.hitBallLabel.AutoSize = true;
            this.hitBallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hitBallLabel.Location = new System.Drawing.Point(656, 50);
            this.hitBallLabel.Name = "hitBallLabel";
            this.hitBallLabel.Size = new System.Drawing.Size(105, 16);
            this.hitBallLabel.TabIndex = 0;
            this.hitBallLabel.Text = "Сбито мячей:";
            // 
            // hitBallValueLabel
            // 
            this.hitBallValueLabel.AutoSize = true;
            this.hitBallValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hitBallValueLabel.Location = new System.Drawing.Point(785, 50);
            this.hitBallValueLabel.Name = "hitBallValueLabel";
            this.hitBallValueLabel.Size = new System.Drawing.Size(15, 16);
            this.hitBallValueLabel.TabIndex = 1;
            this.hitBallValueLabel.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.hitBallValueLabel);
            this.Controls.Add(this.hitBallLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fruit Ninja";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hitBallLabel;
        private System.Windows.Forms.Label hitBallValueLabel;
    }
}

