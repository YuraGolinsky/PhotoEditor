using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace PhotoEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                Bitmap originalImage = new Bitmap(imagePath);

                // Показ оригінального зображення на PictureBox
                pictureBox1.Image = originalImage;
            }
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            // Перевірка наявності зображення
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Спочатку оберіть зображення!");
                return;
            }

            // Отримання вибраних розмірів
            int targetWidth = (int)numericUpDownWidth.Value;
            int targetHeight = (int)numericUpDownHeight.Value;

            // Отримання оригінального зображення з PictureBox
            Bitmap originalImage = new Bitmap(pictureBox1.Image);

            // Ресайз та конвертація в чорно-біле зображення
            Bitmap resizedImage = ResizeImage(originalImage, targetWidth, targetHeight);

            // Показ результуючого зображення на PictureBox
            pictureBox1.Image = resizedImage;
        }

        private void btnConvertToGrayscale_Click(object sender, EventArgs e)
        {
            // Перевірка наявності зображення
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Спочатку оберіть зображення!");
                return;
            }

            // Отримання оригінального зображення з PictureBox
            Bitmap originalImage = new Bitmap(pictureBox1.Image);

            // Конвертація кольорового зображення в чорно-біле
            Bitmap grayscaleImage = ConvertToGrayscale(originalImage);

            // Показ результуючого зображення на PictureBox
            pictureBox1.Image = grayscaleImage;
        }

        private void btnBrightness_Click(object sender, EventArgs e)
        {
            // Перевірка наявності зображення
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Спочатку оберіть зображення!");
                return;
            }

            // Отримання оригінального зображення з PictureBox
            Bitmap originalImage = new Bitmap(pictureBox1.Image);

            // Зміна яскравості
            float brightnessValue = (float)numericUpDownBrightness.Value / 100.0f;
            Bitmap brightenedImage = AdjustBrightness(originalImage, brightnessValue);

            // Показ результуючого зображення на PictureBox
            pictureBox1.Image = brightenedImage;
        }

        private void btnContrast_Click(object sender, EventArgs e)
        {
            // Перевірка наявності зображення
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Спочатку оберіть зображення!");
                return;
            }

            // Отримання оригінального зображення з PictureBox
            Bitmap originalImage = new Bitmap(pictureBox1.Image);

            // Зміна контрастності
            float contrastValue = (float)numericUpDownContrast.Value / 100.0f;
            Bitmap contrastedImage = AdjustContrast(originalImage, contrastValue);

            // Показ результуючого зображення на PictureBox
            pictureBox1.Image = contrastedImage;
        }

       
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Перевірка наявності зображення
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Немає зображення для збереження!");
                return;
            }

            // Відкриття діалогового вікна для збереження файлу
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png";
            saveFileDialog.Title = "Зберегти зображення як...";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Отримання шляху до файлу
                string filePath = saveFileDialog.FileName;

                // Отримання формату файлу
                ImageFormat format = ImageFormat.Jpeg;
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        format = ImageFormat.Jpeg;
                        break;
                    case 2:
                        format = ImageFormat.Bmp;
                        break;
                    case 3:
                        format = ImageFormat.Png;
                        break;
                }

                // Збереження зображення
                pictureBox1.Image.Save(filePath, format);
            }
        }

        // Функція для ресайзу зображення
        private Bitmap ResizeImage(Bitmap image, int targetWidth, int targetHeight)
        {
            Bitmap result = new Bitmap(targetWidth, targetHeight);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

                g.DrawImage(image, 0, 0, targetWidth, targetHeight);
            }
            return result;
        }

        // Функція для конвертації кольорової гами в чорно-білу
        private Bitmap ConvertToGrayscale(Bitmap image)
        {
            Bitmap result = new Bitmap(image.Width, image.Height);
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color color = image.GetPixel(x, y);
                    int grayValue = (int)(color.R * 0.3 + color.G * 0.59 + color.B * 0.11);
                    Color grayColor = Color.FromArgb(grayValue, grayValue, grayValue);
                    result.SetPixel(x, y, grayColor);
                }
            }
            return result;
        }

        
        

        private Bitmap AdjustBrightness(Bitmap image, float brightnessValue)
        {
            Bitmap adjustedImage = new Bitmap(image.Width, image.Height);

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color originalColor = image.GetPixel(x, y);
                    float brightness = originalColor.GetBrightness();
                    Color adjustedColor = originalColor;

                    if (brightnessValue < 0) // Зменшення яскравості
                    {
                        adjustedColor = Color.FromArgb(
                            (int)(originalColor.R * (1 + brightnessValue)),
                            (int)(originalColor.G * (1 + brightnessValue)),
                            (int)(originalColor.B * (1 + brightnessValue))
                        );
                    }
                    else if (brightnessValue > 0) // Збільшення яскравості
                    {
                        adjustedColor = Color.FromArgb(
                            (int)(originalColor.R + (255 - originalColor.R) * brightnessValue),
                            (int)(originalColor.G + (255 - originalColor.G) * brightnessValue),
                            (int)(originalColor.B + (255 - originalColor.B) * brightnessValue)
                        );
                    }

                    adjustedImage.SetPixel(x, y, adjustedColor);
                }
            }

            return adjustedImage;
        }

        private Bitmap AdjustContrast(Bitmap image, float contrastValue)
        {
            Bitmap adjustedImage = new Bitmap(image.Width, image.Height);

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color originalColor = image.GetPixel(x, y);

                    int red = (int)(((((originalColor.R / 255.0) - 0.5) * contrastValue) + 0.5) * 255);
                    int green = (int)(((((originalColor.G / 255.0) - 0.5) * contrastValue) + 0.5) * 255);
                    int blue = (int)(((((originalColor.B / 255.0) - 0.5) * contrastValue) + 0.5) * 255);

                    red = Math.Max(Math.Min(red, 255), 0);
                    green = Math.Max(Math.Min(green, 255), 0);
                    blue = Math.Max(Math.Min(blue, 255), 0);

                    Color adjustedColor = Color.FromArgb(red, green, blue);
                    adjustedImage.SetPixel(x, y, adjustedColor);
                }
            }

            return adjustedImage;
        }



       

       
    }
}
