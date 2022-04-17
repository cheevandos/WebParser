
namespace WebParser
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
            this.urlLabel = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.getContentButton = new System.Windows.Forms.Button();
            this.saveContentDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(12, 9);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(46, 20);
            this.urlLabel.TabIndex = 1;
            this.urlLabel.Text = "URL:";
            this.urlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(13, 33);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(559, 26);
            this.urlTextBox.TabIndex = 2;
            // 
            // getContentButton
            // 
            this.getContentButton.Location = new System.Drawing.Point(12, 65);
            this.getContentButton.Name = "getContentButton";
            this.getContentButton.Size = new System.Drawing.Size(560, 44);
            this.getContentButton.TabIndex = 3;
            this.getContentButton.Text = "Get website content";
            this.getContentButton.UseVisualStyleBackColor = true;
            this.getContentButton.Click += new System.EventHandler(this.GetContentButton_Click);
            // 
            // saveContentDialog
            // 
            this.saveContentDialog.Filter = "HTML Files|*.html";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 124);
            this.Controls.Add(this.getContentButton);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.urlLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Button getContentButton;
        private System.Windows.Forms.SaveFileDialog saveContentDialog;
    }
}

