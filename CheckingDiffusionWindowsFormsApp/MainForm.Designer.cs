namespace CheckingDiffusionWindowsFormsApp
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
            this.leftBlueLabel = new System.Windows.Forms.Label();
            this.rightBlueLabel = new System.Windows.Forms.Label();
            this.topBlueLabel = new System.Windows.Forms.Label();
            this.bottomBlueLabel = new System.Windows.Forms.Label();
            this.bottomRedLabel = new System.Windows.Forms.Label();
            this.topRedLabel = new System.Windows.Forms.Label();
            this.leftRedLabel = new System.Windows.Forms.Label();
            this.rightRedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leftBlueLabel
            // 
            this.leftBlueLabel.AutoSize = true;
            this.leftBlueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftBlueLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.leftBlueLabel.Location = new System.Drawing.Point(12, 338);
            this.leftBlueLabel.Name = "leftBlueLabel";
            this.leftBlueLabel.Size = new System.Drawing.Size(15, 16);
            this.leftBlueLabel.TabIndex = 0;
            this.leftBlueLabel.Text = "0";
            // 
            // rightBlueLabel
            // 
            this.rightBlueLabel.AutoSize = true;
            this.rightBlueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightBlueLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rightBlueLabel.Location = new System.Drawing.Point(857, 338);
            this.rightBlueLabel.Name = "rightBlueLabel";
            this.rightBlueLabel.Size = new System.Drawing.Size(15, 16);
            this.rightBlueLabel.TabIndex = 1;
            this.rightBlueLabel.Text = "0";
            // 
            // topBlueLabel
            // 
            this.topBlueLabel.AutoSize = true;
            this.topBlueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topBlueLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.topBlueLabel.Location = new System.Drawing.Point(402, 9);
            this.topBlueLabel.Name = "topBlueLabel";
            this.topBlueLabel.Size = new System.Drawing.Size(15, 16);
            this.topBlueLabel.TabIndex = 2;
            this.topBlueLabel.Text = "0";
            // 
            // bottomBlueLabel
            // 
            this.bottomBlueLabel.AutoSize = true;
            this.bottomBlueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bottomBlueLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bottomBlueLabel.Location = new System.Drawing.Point(402, 736);
            this.bottomBlueLabel.Name = "bottomBlueLabel";
            this.bottomBlueLabel.Size = new System.Drawing.Size(15, 16);
            this.bottomBlueLabel.TabIndex = 3;
            this.bottomBlueLabel.Text = "0";
            // 
            // bottomRedLabel
            // 
            this.bottomRedLabel.AutoSize = true;
            this.bottomRedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bottomRedLabel.ForeColor = System.Drawing.Color.Red;
            this.bottomRedLabel.Location = new System.Drawing.Point(466, 736);
            this.bottomRedLabel.Name = "bottomRedLabel";
            this.bottomRedLabel.Size = new System.Drawing.Size(15, 16);
            this.bottomRedLabel.TabIndex = 4;
            this.bottomRedLabel.Text = "0";
            // 
            // topRedLabel
            // 
            this.topRedLabel.AutoSize = true;
            this.topRedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topRedLabel.ForeColor = System.Drawing.Color.Red;
            this.topRedLabel.Location = new System.Drawing.Point(466, 9);
            this.topRedLabel.Name = "topRedLabel";
            this.topRedLabel.Size = new System.Drawing.Size(15, 16);
            this.topRedLabel.TabIndex = 5;
            this.topRedLabel.Text = "0";
            // 
            // leftRedLabel
            // 
            this.leftRedLabel.AutoSize = true;
            this.leftRedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftRedLabel.ForeColor = System.Drawing.Color.Red;
            this.leftRedLabel.Location = new System.Drawing.Point(12, 387);
            this.leftRedLabel.Name = "leftRedLabel";
            this.leftRedLabel.Size = new System.Drawing.Size(15, 16);
            this.leftRedLabel.TabIndex = 6;
            this.leftRedLabel.Text = "0";
            // 
            // rightRedLabel
            // 
            this.rightRedLabel.AutoSize = true;
            this.rightRedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightRedLabel.ForeColor = System.Drawing.Color.Red;
            this.rightRedLabel.Location = new System.Drawing.Point(857, 387);
            this.rightRedLabel.Name = "rightRedLabel";
            this.rightRedLabel.Size = new System.Drawing.Size(15, 16);
            this.rightRedLabel.TabIndex = 7;
            this.rightRedLabel.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 761);
            this.Controls.Add(this.rightRedLabel);
            this.Controls.Add(this.leftRedLabel);
            this.Controls.Add(this.topRedLabel);
            this.Controls.Add(this.bottomRedLabel);
            this.Controls.Add(this.bottomBlueLabel);
            this.Controls.Add(this.topBlueLabel);
            this.Controls.Add(this.rightBlueLabel);
            this.Controls.Add(this.leftBlueLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проверка на полное смешение газа";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label leftBlueLabel;
        private System.Windows.Forms.Label rightBlueLabel;
        private System.Windows.Forms.Label topBlueLabel;
        private System.Windows.Forms.Label bottomBlueLabel;
        private System.Windows.Forms.Label bottomRedLabel;
        private System.Windows.Forms.Label topRedLabel;
        private System.Windows.Forms.Label leftRedLabel;
        private System.Windows.Forms.Label rightRedLabel;
    }
}

