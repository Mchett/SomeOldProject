namespace курсач
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResizeButton = new System.Windows.Forms.Button();
            this.OriginalImageBox = new System.Windows.Forms.PictureBox();
            this.PathButton = new System.Windows.Forms.Button();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.restoreb = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SavePathButton = new System.Windows.Forms.Button();
            this.SavePathBox = new System.Windows.Forms.TextBox();
            this.SaveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.PB2 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ResizeButton
            // 
            this.ResizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResizeButton.Enabled = false;
            this.ResizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResizeButton.Location = new System.Drawing.Point(11, 302);
            this.ResizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.ResizeButton.Name = "ResizeButton";
            this.ResizeButton.Size = new System.Drawing.Size(120, 30);
            this.ResizeButton.TabIndex = 13;
            this.ResizeButton.Text = "delet pixel";
            this.ResizeButton.UseVisualStyleBackColor = true;
            this.ResizeButton.Click += new System.EventHandler(this.ResizeButton_Click);
            // 
            // OriginalImageBox
            // 
            this.OriginalImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OriginalImageBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.OriginalImageBox.Location = new System.Drawing.Point(10, 36);
            this.OriginalImageBox.Margin = new System.Windows.Forms.Padding(2);
            this.OriginalImageBox.Name = "OriginalImageBox";
            this.OriginalImageBox.Size = new System.Drawing.Size(305, 205);
            this.OriginalImageBox.TabIndex = 12;
            this.OriginalImageBox.TabStop = false;
            // 
            // PathButton
            // 
            this.PathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathButton.Location = new System.Drawing.Point(283, 6);
            this.PathButton.Margin = new System.Windows.Forms.Padding(2);
            this.PathButton.Name = "PathButton";
            this.PathButton.Size = new System.Drawing.Size(28, 26);
            this.PathButton.TabIndex = 10;
            this.PathButton.Text = "...";
            this.PathButton.UseVisualStyleBackColor = true;
            this.PathButton.Click += new System.EventHandler(this.PathButton_Click);
            // 
            // PathTextBox
            // 
            this.PathTextBox.Enabled = false;
            this.PathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathTextBox.Location = new System.Drawing.Point(51, 8);
            this.PathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.ReadOnly = true;
            this.PathTextBox.Size = new System.Drawing.Size(217, 24);
            this.PathTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Path:";
            // 
            // OpenImageDialog
            // 
            this.OpenImageDialog.FileName = "OpenImageDialog";
            // 
            // restoreb
            // 
            this.restoreb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.restoreb.Enabled = false;
            this.restoreb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restoreb.Location = new System.Drawing.Point(190, 302);
            this.restoreb.Margin = new System.Windows.Forms.Padding(2);
            this.restoreb.Name = "restoreb";
            this.restoreb.Size = new System.Drawing.Size(120, 30);
            this.restoreb.TabIndex = 17;
            this.restoreb.Text = "restore";
            this.restoreb.UseVisualStyleBackColor = true;
            this.restoreb.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(2, 344);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Save:";
            // 
            // SavePathButton
            // 
            this.SavePathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SavePathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SavePathButton.Location = new System.Drawing.Point(283, 344);
            this.SavePathButton.Margin = new System.Windows.Forms.Padding(2);
            this.SavePathButton.Name = "SavePathButton";
            this.SavePathButton.Size = new System.Drawing.Size(28, 26);
            this.SavePathButton.TabIndex = 19;
            this.SavePathButton.Text = "...";
            this.SavePathButton.UseVisualStyleBackColor = true;
            this.SavePathButton.Click += new System.EventHandler(this.SavePathButton_Click);
            // 
            // SavePathBox
            // 
            this.SavePathBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SavePathBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SavePathBox.Location = new System.Drawing.Point(51, 342);
            this.SavePathBox.Margin = new System.Windows.Forms.Padding(2);
            this.SavePathBox.Name = "SavePathBox";
            this.SavePathBox.ReadOnly = true;
            this.SavePathBox.Size = new System.Drawing.Size(217, 24);
            this.SavePathBox.TabIndex = 18;
            // 
            // SaveImageDialog
            // 
            this.SaveImageDialog.FileName = "saveFileDialog1";
            this.SaveImageDialog.Filter = "Image Files(*.JPG)|*.JPG";
            // 
            // PB2
            // 
            this.PB2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PB2.Location = new System.Drawing.Point(12, 276);
            this.PB2.Name = "PB2";
            this.PB2.Size = new System.Drawing.Size(303, 21);
            this.PB2.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Интерполяция";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 377);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PB2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SavePathButton);
            this.Controls.Add(this.SavePathBox);
            this.Controls.Add(this.restoreb);
            this.Controls.Add(this.ResizeButton);
            this.Controls.Add(this.OriginalImageBox);
            this.Controls.Add(this.PathButton);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ResizeButton;
        private System.Windows.Forms.PictureBox OriginalImageBox;
        private System.Windows.Forms.Button PathButton;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog OpenImageDialog;
        private System.Windows.Forms.Button restoreb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SavePathButton;
        private System.Windows.Forms.TextBox SavePathBox;
        private System.Windows.Forms.SaveFileDialog SaveImageDialog;
        private System.Windows.Forms.ProgressBar PB2;
        private System.Windows.Forms.Label label3;
    }
}

