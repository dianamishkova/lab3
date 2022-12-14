
namespace laba3
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
            this.parameterTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxBlurBtn = new System.Windows.Forms.Button();
            this.MedianFilterBtn = new System.Windows.Forms.Button();
            this.GaussianFilterBtn = new System.Windows.Forms.Button();
            this.LoadPictureBtn = new System.Windows.Forms.Button();
            this.outputPictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.outputPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // parameterTextBox
            // 
            this.parameterTextBox.Location = new System.Drawing.Point(14, 58);
            this.parameterTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.parameterTextBox.Name = "parameterTextBox";
            this.parameterTextBox.Size = new System.Drawing.Size(92, 27);
            this.parameterTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Параметр\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BoxBlurBtn
            // 
            this.BoxBlurBtn.Location = new System.Drawing.Point(14, 168);
            this.BoxBlurBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BoxBlurBtn.Name = "BoxBlurBtn";
            this.BoxBlurBtn.Size = new System.Drawing.Size(118, 58);
            this.BoxBlurBtn.TabIndex = 2;
            this.BoxBlurBtn.Text = "Скользящее усреднение";
            this.BoxBlurBtn.UseVisualStyleBackColor = true;
            this.BoxBlurBtn.Click += new System.EventHandler(this.BoxBlurBtn_Click);
            // 
            // MedianFilterBtn
            // 
            this.MedianFilterBtn.Location = new System.Drawing.Point(14, 233);
            this.MedianFilterBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MedianFilterBtn.Name = "MedianFilterBtn";
            this.MedianFilterBtn.Size = new System.Drawing.Size(118, 58);
            this.MedianFilterBtn.TabIndex = 3;
            this.MedianFilterBtn.Text = "Медианный фильтр";
            this.MedianFilterBtn.UseVisualStyleBackColor = true;
            this.MedianFilterBtn.Click += new System.EventHandler(this.MedianFilterBtn_Click);
            // 
            // GaussianFilterBtn
            // 
            this.GaussianFilterBtn.Location = new System.Drawing.Point(14, 299);
            this.GaussianFilterBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GaussianFilterBtn.Name = "GaussianFilterBtn";
            this.GaussianFilterBtn.Size = new System.Drawing.Size(118, 58);
            this.GaussianFilterBtn.TabIndex = 4;
            this.GaussianFilterBtn.Text = "Фильтр Гаусса";
            this.GaussianFilterBtn.UseVisualStyleBackColor = true;
            this.GaussianFilterBtn.Click += new System.EventHandler(this.GaussianFilterBtn_Click);
            // 
            // LoadPictureBtn
            // 
            this.LoadPictureBtn.Location = new System.Drawing.Point(14, 115);
            this.LoadPictureBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoadPictureBtn.Name = "LoadPictureBtn";
            this.LoadPictureBtn.Size = new System.Drawing.Size(118, 45);
            this.LoadPictureBtn.TabIndex = 6;
            this.LoadPictureBtn.Text = "Загрузить";
            this.LoadPictureBtn.UseVisualStyleBackColor = true;
            this.LoadPictureBtn.Click += new System.EventHandler(this.LoadPictureBtn_Click);
            // 
            // outputPictureBox
            // 
            this.outputPictureBox.Location = new System.Drawing.Point(161, 13);
            this.outputPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.outputPictureBox.Name = "outputPictureBox";
            this.outputPictureBox.Size = new System.Drawing.Size(877, 675);
            this.outputPictureBox.TabIndex = 7;
            this.outputPictureBox.TabStop = false;
            this.outputPictureBox.Click += new System.EventHandler(this.outputPictureBox_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 732);
            this.Controls.Add(this.outputPictureBox);
            this.Controls.Add(this.LoadPictureBtn);
            this.Controls.Add(this.GaussianFilterBtn);
            this.Controls.Add(this.MedianFilterBtn);
            this.Controls.Add(this.BoxBlurBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parameterTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outputPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox parameterTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BoxBlurBtn;
        private System.Windows.Forms.Button MedianFilterBtn;
        private System.Windows.Forms.Button GaussianFilterBtn;
        private System.Windows.Forms.Button LoadPictureBtn;
        private System.Windows.Forms.PictureBox outputPictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

