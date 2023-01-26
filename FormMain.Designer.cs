using System.Drawing;
namespace PicEnc
{
    partial class FormMain
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
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.labelKey = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonLoadText = new System.Windows.Forms.Button();
            this.checkBoxSave = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelLink = new System.Windows.Forms.Label();
            this.buttonClrImage = new System.Windows.Forms.Button();
            this.buttonClrText = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(89)))), ((int)(((byte)(130)))));
            this.buttonLoadImage.FlatAppearance.BorderSize = 0;
            this.buttonLoadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadImage.ForeColor = System.Drawing.Color.White;
            this.buttonLoadImage.Location = new System.Drawing.Point(34, 26);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(162, 38);
            this.buttonLoadImage.TabIndex = 0;
            this.buttonLoadImage.Text = "Load Image";
            this.buttonLoadImage.UseVisualStyleBackColor = false;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelKey.Location = new System.Drawing.Point(31, 123);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(36, 17);
            this.labelKey.TabIndex = 1;
            this.labelKey.Text = "Key:";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(34, 143);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(162, 22);
            this.textBoxKey.TabIndex = 2;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(89)))), ((int)(((byte)(130)))));
            this.buttonEncrypt.FlatAppearance.BorderSize = 0;
            this.buttonEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEncrypt.Location = new System.Drawing.Point(34, 281);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(162, 38);
            this.buttonEncrypt.TabIndex = 0;
            this.buttonEncrypt.Text = "Encrypt and Save";
            this.buttonEncrypt.UseVisualStyleBackColor = false;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(89)))), ((int)(((byte)(130)))));
            this.buttonDecrypt.FlatAppearance.BorderSize = 0;
            this.buttonDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDecrypt.Location = new System.Drawing.Point(34, 362);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(162, 38);
            this.buttonDecrypt.TabIndex = 0;
            this.buttonDecrypt.Text = "Decrypt and Save";
            this.buttonDecrypt.UseVisualStyleBackColor = false;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 211);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(568, 211);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(3, 245);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(568, 123);
            this.textBox1.TabIndex = 1;
            // 
            // buttonLoadText
            // 
            this.buttonLoadText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(89)))), ((int)(((byte)(130)))));
            this.buttonLoadText.FlatAppearance.BorderSize = 0;
            this.buttonLoadText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadText.Location = new System.Drawing.Point(34, 70);
            this.buttonLoadText.Name = "buttonLoadText";
            this.buttonLoadText.Size = new System.Drawing.Size(162, 38);
            this.buttonLoadText.TabIndex = 5;
            this.buttonLoadText.Text = "Load Text";
            this.buttonLoadText.UseVisualStyleBackColor = false;
            this.buttonLoadText.Click += new System.EventHandler(this.buttonLoadText_Click);
            // 
            // checkBoxSave
            // 
            this.checkBoxSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxSave.AutoSize = true;
            this.checkBoxSave.ForeColor = System.Drawing.Color.White;
            this.checkBoxSave.Location = new System.Drawing.Point(34, 334);
            this.checkBoxSave.Name = "checkBoxSave";
            this.checkBoxSave.Size = new System.Drawing.Size(106, 21);
            this.checkBoxSave.TabIndex = 6;
            this.checkBoxSave.Text = "Save .txt file";
            this.checkBoxSave.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelLink, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(216, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.66942F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.33058F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(574, 371);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // labelLink
            // 
            this.labelLink.AutoSize = true;
            this.labelLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLink.Location = new System.Drawing.Point(3, 217);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(568, 25);
            this.labelLink.TabIndex = 1;
            // 
            // buttonClrImage
            // 
            this.buttonClrImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(89)))), ((int)(((byte)(130)))));
            this.buttonClrImage.FlatAppearance.BorderSize = 0;
            this.buttonClrImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClrImage.ForeColor = System.Drawing.Color.White;
            this.buttonClrImage.Location = new System.Drawing.Point(34, 179);
            this.buttonClrImage.Name = "buttonClrImage";
            this.buttonClrImage.Size = new System.Drawing.Size(80, 45);
            this.buttonClrImage.TabIndex = 8;
            this.buttonClrImage.Text = "Clear Image";
            this.buttonClrImage.UseVisualStyleBackColor = false;
            this.buttonClrImage.Click += new System.EventHandler(this.buttonClrImage_Click_1);
            // 
            // buttonClrText
            // 
            this.buttonClrText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(89)))), ((int)(((byte)(130)))));
            this.buttonClrText.FlatAppearance.BorderSize = 0;
            this.buttonClrText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClrText.ForeColor = System.Drawing.Color.White;
            this.buttonClrText.Location = new System.Drawing.Point(120, 179);
            this.buttonClrText.Name = "buttonClrText";
            this.buttonClrText.Size = new System.Drawing.Size(76, 45);
            this.buttonClrText.TabIndex = 9;
            this.buttonClrText.Text = "Clear Text";
            this.buttonClrText.UseVisualStyleBackColor = false;
            this.buttonClrText.Click += new System.EventHandler(this.buttonClrText_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(802, 422);
            this.Controls.Add(this.buttonClrText);
            this.Controls.Add(this.buttonClrImage);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.checkBoxSave);
            this.Controls.Add(this.buttonLoadText);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.buttonLoadImage);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(820, 469);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PicEnc";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonLoadText;
        private System.Windows.Forms.CheckBox checkBoxSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonClrImage;
        private System.Windows.Forms.Button buttonClrText;
        private System.Windows.Forms.Label labelLink;
    }
}

