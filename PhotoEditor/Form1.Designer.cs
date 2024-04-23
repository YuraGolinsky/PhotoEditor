namespace PhotoEditor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownBrightness = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownContrast = new System.Windows.Forms.NumericUpDown();
            this.btnContrast = new System.Windows.Forms.Button();
            this.btnBrightness = new System.Windows.Forms.Button();
            this.btnConvertToGrayscale = new System.Windows.Forms.Button();
            this.btnResize = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(443, 102);
            this.numericUpDownWidth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(140, 20);
            this.numericUpDownWidth.TabIndex = 2;
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(447, 141);
            this.numericUpDownHeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(140, 20);
            this.numericUpDownHeight.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(440, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ширина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(443, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Висота";
            // 
            // numericUpDownBrightness
            // 
            this.numericUpDownBrightness.Location = new System.Drawing.Point(373, 216);
            this.numericUpDownBrightness.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDownBrightness.Name = "numericUpDownBrightness";
            this.numericUpDownBrightness.Size = new System.Drawing.Size(140, 20);
            this.numericUpDownBrightness.TabIndex = 9;
            // 
            // numericUpDownContrast
            // 
            this.numericUpDownContrast.Location = new System.Drawing.Point(532, 252);
            this.numericUpDownContrast.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDownContrast.Name = "numericUpDownContrast";
            this.numericUpDownContrast.Size = new System.Drawing.Size(140, 20);
            this.numericUpDownContrast.TabIndex = 10;
            // 
            // btnContrast
            // 
            this.btnContrast.ForeColor = System.Drawing.Color.Transparent;
            this.btnContrast.Image = global::PhotoEditor.Properties.Resources.Контраст_фото1;
            this.btnContrast.Location = new System.Drawing.Point(576, 278);
            this.btnContrast.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnContrast.Name = "btnContrast";
            this.btnContrast.Size = new System.Drawing.Size(55, 53);
            this.btnContrast.TabIndex = 12;
            this.btnContrast.UseVisualStyleBackColor = true;
            this.btnContrast.Click += new System.EventHandler(this.btnContrast_Click);
            // 
            // btnBrightness
            // 
            this.btnBrightness.ForeColor = System.Drawing.Color.Transparent;
            this.btnBrightness.Image = global::PhotoEditor.Properties.Resources.яскравість_фото;
            this.btnBrightness.Location = new System.Drawing.Point(411, 242);
            this.btnBrightness.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrightness.Name = "btnBrightness";
            this.btnBrightness.Size = new System.Drawing.Size(64, 58);
            this.btnBrightness.TabIndex = 11;
            this.btnBrightness.UseVisualStyleBackColor = true;
            this.btnBrightness.Click += new System.EventHandler(this.btnBrightness_Click);
            // 
            // btnConvertToGrayscale
            // 
            this.btnConvertToGrayscale.ForeColor = System.Drawing.Color.Transparent;
            this.btnConvertToGrayscale.Image = global::PhotoEditor.Properties.Resources.Чорно_біле_фото;
            this.btnConvertToGrayscale.Location = new System.Drawing.Point(371, 102);
            this.btnConvertToGrayscale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConvertToGrayscale.Name = "btnConvertToGrayscale";
            this.btnConvertToGrayscale.Size = new System.Drawing.Size(68, 59);
            this.btnConvertToGrayscale.TabIndex = 8;
            this.btnConvertToGrayscale.UseVisualStyleBackColor = true;
            this.btnConvertToGrayscale.Click += new System.EventHandler(this.btnConvertToGrayscale_Click);
            // 
            // btnResize
            // 
            this.btnResize.ForeColor = System.Drawing.Color.Transparent;
            this.btnResize.Image = global::PhotoEditor.Properties.Resources.Розмір_змінити_фото;
            this.btnResize.Location = new System.Drawing.Point(595, 102);
            this.btnResize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(64, 58);
            this.btnResize.TabIndex = 7;
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Image = global::PhotoEditor.Properties.Resources.Завантажити_фото;
            this.btnSave.Location = new System.Drawing.Point(82, 12);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 58);
            this.btnSave.TabIndex = 6;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 102);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 276);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.ForeColor = System.Drawing.Color.Transparent;
            this.btnOpen.Image = global::PhotoEditor.Properties.Resources.Вибрати_фото;
            this.btnOpen.Location = new System.Drawing.Point(14, 12);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(60, 58);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(530, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Змінити контрастність";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(373, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Змінити яскравість";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 403);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnContrast);
            this.Controls.Add(this.btnBrightness);
            this.Controls.Add(this.numericUpDownContrast);
            this.Controls.Add(this.numericUpDownBrightness);
            this.Controls.Add(this.btnConvertToGrayscale);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownHeight);
            this.Controls.Add(this.numericUpDownWidth);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOpen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "PhotoEditor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Button btnConvertToGrayscale;
        private System.Windows.Forms.NumericUpDown numericUpDownBrightness;
        private System.Windows.Forms.NumericUpDown numericUpDownContrast;
        private System.Windows.Forms.Button btnBrightness;
        private System.Windows.Forms.Button btnContrast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

