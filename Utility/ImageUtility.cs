using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV.Structure;
using Emgu.CV;

namespace facial_recognition.Utility
{
	public static class ImageUtility
	{

		public static Bitmap ByteToBitmap(byte[] img)
		{
			using(var ms = new MemoryStream(img))
			{
				var image = new Bitmap(ms);
				var resizedImg = ResizeImg(image);
				return resizedImg;
			}
		}

		private static Bitmap ResizeImg(Bitmap image)
		{
			return new Bitmap(image, new Size(150, 150));
		}

		public static byte[] NormalizeImage(byte[] imageBytes)
		{
			using (var ms = new MemoryStream(imageBytes))
			{
				var image = Image.FromStream(ms);
				var resizedImage = new Bitmap(image, new Size(100, 100)); // Resize to a consistent size
				var grayImage = new Bitmap(resizedImage.Width, resizedImage.Height, PixelFormat.Format24bppRgb);

				using (var g = Graphics.FromImage(grayImage))
				{
					var colorMatrix = new ColorMatrix(
						new float[][]
						{
					new float[] {0.3f, 0.3f, 0.3f, 0, 0},
					new float[] {0.59f, 0.59f, 0.59f, 0, 0},
					new float[] {0.11f, 0.11f, 0.11f, 0, 0},
					new float[] {0, 0, 0, 1, 0},
					new float[] {0, 0, 0, 0, 1}
						});

					var attributes = new ImageAttributes();
					attributes.SetColorMatrix(colorMatrix);

					g.DrawImage(resizedImage, new Rectangle(0, 0, grayImage.Width, grayImage.Height),
						0, 0, resizedImage.Width, resizedImage.Height, GraphicsUnit.Pixel, attributes);
				}

				using (var msGray = new MemoryStream())
				{
					grayImage.Save(msGray, ImageFormat.Bmp);
					return msGray.ToArray();
				}
			}
		}
	}
}
