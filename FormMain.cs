﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PicEnc
{
    public partial class FormMain : Form
    {
        string FileName;
        string textFilePath;
        string text;
        string V;
       // Stream fileStream;
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Файлы изображений|*.bmp";
            if (openDialog.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                pictureBox1.Image = Image.FromFile(openDialog.FileName);
                FileName = Path.GetFileNameWithoutExtension(openDialog.FileName);
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("Ошибка чтения картинки");
                return;
            }

            //pictureBox1.Dock = DockStyle.Fill;
            panel1.AutoScroll = true;
            panel1.AutoScrollMinSize = pictureBox1.Image.Size;
        }
        
        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Image == null)
            {
                MessageBox.Show("Загрузите изображение", "Уведомление",
                        MessageBoxButtons.OK);
                return;
            }
            if (textBox1.Text == "" & textFilePath ==" ")
            {
                MessageBox.Show("Загрузите текст или введите его в поле", "Уведомление",
                        MessageBoxButtons.OK);
                return;
            }
            if (textBoxKey.Text == "")
            {
                MessageBox.Show("Введите ключ", "Уведомление",
                        MessageBoxButtons.OK);
                return;
            }
            if((textBox1.Text !="") & (textFilePath != null))
            {
                MessageBox.Show("Оставте либо текстовый файл, либо текст в поле", "Уведомление",
                        MessageBoxButtons.OK);
                return;
            }
            int lenght = 0;
            try
            {
                if (textFilePath != "")
                {
                    var lines = File.ReadAllLines(textFilePath);
                    lenght = 0;
                    for (int i = 0; i < lines.Length; i++)
                    {
                        lenght += lines[i].Length;
                    }
                }
            }
            catch { }
            
            if (textBox1.Text.Length > pictureBox1.Image.Width * pictureBox1.Image.Height
                |lenght > pictureBox1.Image.Width * pictureBox1.Image.Height)
            {
                MessageBox.Show("Количество букв превышает количество пикселей", "Уведомление",
                        MessageBoxButtons.OK);
                return;
            }
            if (textBox1.Text != "")
            {
                text = textBox1.Text;
                V = "textBox";
            }
            else 
            {
                text = textFilePath;
                V = "File";
            } 

            Encrypter Enc = new Encrypter(pictureBox1.Image);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Файлы изображения(*.bmp)|*.bmp|Все файлы (*.*)|*.*";
            saveFileDialog.DefaultExt = "bmp";
            saveFileDialog.FileName = FileName + "NEW";

            if (saveFileDialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
            {
                try
                {
                    Enc.Encrypt(text, textBoxKey.Text, V, lenght).
                        Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);

                    MessageBox.Show("Преобразование прошло успешно.", "Уведомление",
                        MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                    //MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void buttonLoadText_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Текстовые файлы|*.txt";
            if (openDialog.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                textFilePath = openDialog.FileName;
                labelLink.Text = "Выбран файл: " + textFilePath;
                //fileStream = openDialog.OpenFile();
                //using(StreamReader reader = new StreamReader(fileStream))
                //{
                //    textBox1.Text = reader.ReadToEnd();
                //}
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("Ошибка чтения текста");
                return;
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            if (textBoxKey.Text == "")
            {
                MessageBox.Show("Введите ключ", "Уведомление",
                        MessageBoxButtons.OK);
                return;
            }
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Загрузите изображение", "Уведомление",
                        MessageBoxButtons.OK);
                return;
            }

            Encrypter Enc = new Encrypter(pictureBox1.Image);

            if (checkBoxSave.Checked)
            {
                bool check = true;
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Файлы текста(*.txt)|*.txt|Все файлы (*.*)|*.*";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.FileName = FileName + "NEW";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Enc.Decrypt(textBoxKey.Text, check, saveFileDialog.FileName);

                        //Enc.Decrypt(textBoxKey.Text);
                        //textBox1.Text = txt;
                        MessageBox.Show("Преобразование прошло успешно", "Уведомление",
                            MessageBoxButtons.OK);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить текст", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                try
                {
                    textBox1.Text = Enc.Decrypt(textBoxKey.Text, checkBoxSave.Checked);
                    MessageBox.Show("Преобразование прошло успешно", "Уведомление",
                        MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Невозможно сохранить текст", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonClrImage_Click_1(object sender, EventArgs e) => pictureBox1.Image = null;

        private void buttonClrText_Click(object sender, EventArgs e) 
        {
            textBox1.Text = null;
            labelLink.Text = null;
            textFilePath = null;
        }
    }
}
