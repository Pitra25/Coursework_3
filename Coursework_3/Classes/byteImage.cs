using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Media.Imaging;

public class ByteImage
{
        private static readonly ImageConverter _imageConverter = new ImageConverter();
	    /// <summary>
	    /// ����� "��������������" ������� Image � ������ ������, ����������������� � ������ ����� PNG, �������  
	    /// ������������ ������ ��� ������. ��� ����� ������������ ������ � ������� GetImageFromByteArray() 
	    /// ��� ������������/��������������. 
	    /// </summary>
	    /// <param name="theImage">������ �����������, ������ ���� �������������� � ������ PNG</param>
	    /// <returns>������ ������ ����������� PNG-�����, ����������� �����������</returns>
	    public static byte[] CopyImageToByteArray(Image theImage)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                theImage.Save(memoryStream, ImageFormat.Png);
                return memoryStream.ToArray();
            }
        }
	    /// <summary>
	    /// �����, ������������ ������ ImageConverter � .Net Framework ��� �������������� ������� ������, 
	    /// ���������������� ���������� ����������� ����� JPEG ��� PNG, � ������ Bitmap, ������� ����� ����� ���� 
	    /// �������������� ��� ������ Image.
	    /// </summary>
	    /// <param name="byteArray">������ ������, ���������� ����������� ����� JPEG ��� PNG ��� ������������ �����</param>
	    /// <returns>������ Bitmap, ���� �� ��������, � ��������� ������ ������������� ����������</returns>
	    public static Bitmap GetImageFromByteArray(byte[] byteArray)
        {
            Bitmap bm = (Bitmap)_imageConverter.ConvertFrom(byteArray);

            if (bm != null && (bm.HorizontalResolution != (int)bm.HorizontalResolution ||
                               bm.VerticalResolution != (int)bm.VerticalResolution))
            {
			    // ��������� �������� ����, ������� ���������� � �������� ��������� ��� ����������� 
			    // �� PNG-����� �����������, ���������� �������� CopyImageToByteArray() - �������� dpi "��������" 
			    // ������� ����������� �� ������������ �������������� ��������
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
