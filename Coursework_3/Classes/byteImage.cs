using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Media.Imaging;

public class ByteImage
{
        private static readonly ImageConverter _imageConverter = new ImageConverter();
	    /// <summary>
	    /// Метод "преобразования" объекта Image в массив байтов, отформатированный в формат файла PNG, который  
	    /// обеспечивает сжатие без потерь. Его можно использовать вместе с методом GetImageFromByteArray() 
	    /// для сериализации/десериализации. 
	    /// </summary>
	    /// <param name="theImage">Объект изображения, должен быть конвертируемым в формат PNG</param>
	    /// <returns>массив байтов изображение PNG-файла, содержащего изображение</returns>
	    public static byte[] CopyImageToByteArray(Image theImage)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                theImage.Save(memoryStream, ImageFormat.Png);
                return memoryStream.ToArray();
            }
        }
	    /// <summary>
	    /// Метод, использующий объект ImageConverter в .Net Framework для преобразования массива байтов, 
	    /// предположительно содержащий изображение файла JPEG или PNG, в объект Bitmap, который также может быть 
	    /// использоваться как объект Image.
	    /// </summary>
	    /// <param name="byteArray">массив байтов, содержащий изображение файла JPEG или PNG или аналогичного файла</param>
	    /// <returns>Объект Bitmap, если он работает, в противном случае выбрасывается исключение</returns>
	    public static Bitmap GetImageFromByteArray(byte[] byteArray)
        {
            Bitmap bm = (Bitmap)_imageConverter.ConvertFrom(byteArray);

            if (bm != null && (bm.HorizontalResolution != (int)bm.HorizontalResolution ||
                               bm.VerticalResolution != (int)bm.VerticalResolution))
            {
			    // Исправьте странный глюк, который наблюдался в тестовой программе при конвертации 
			    // из PNG-файла изображения, созданного функцией CopyImageToByteArray() - значение dpi "дрейфует" 
			    // немного отклоняется от номинального целочисленного значения
			    bm.SetResolution((int)(bm.HorizontalResolution + 0.5f),
                                 (int)(bm.VerticalResolution + 0.5f));
            }

            return bm;
        }
        public static BitmapImage Convert(Bitmap src)
        {
            MemoryStream ms = new MemoryStream();
            ((Bitmap)src).Save(ms, ImageFormat.Bmp);
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            ms.Seek(0, SeekOrigin.Begin);
            image.StreamSource = ms;
            image.EndInit();
            return image;
        }
}
