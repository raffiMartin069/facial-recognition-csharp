using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace facial_recognition.Utility
{
	public class RecognizerUtility
	{
		private readonly CascadeClassifier _faceDetector;
		private readonly CascadeClassifier _eyeDetector;


		public RecognizerUtility(CascadeClassifier faceDetector, CascadeClassifier eyeDetector)
		{
			_faceDetector = faceDetector;
			_eyeDetector = eyeDetector;
		}

		public Image<Bgr, byte> DetectFace(Image<Bgr, byte> image)
		{
			var gray = image.Convert<Gray, byte>();
			var faces = _faceDetector.DetectMultiScale(gray, 1.1, 10, new Size(30, 30), Size.Empty);

			foreach (var face in faces)
			{
				// image.Draw(face, new Bgr(Color.Red), 2);

				// Define the region of interest (ROI) for eye detection within the face
				var faceROI = gray.GetSubRect(face);
				var eyes = _eyeDetector.DetectMultiScale(faceROI, 1.1, 10, new Size(10, 10), Size.Empty);

				foreach (var eye in eyes)
				{
					//var eyeRect = new Rectangle(
					//	face.X + eye.X,
					//	face.Y + eye.Y,
					//	eye.Width,
					//	eye.Height
					//);
					//image.Draw(eyeRect, new Bgr(Color.Green), 2);
				}
			}
			return image;
		}

		[Obsolete("This is method is will be soon removed, please use CompareFaces method instead", false)]
		public Image<Bgr, byte> RecognizeFace(Image<Bgr, byte> inputImage, Image<Bgr, byte> trainedImage)
		{
			// Convert images to grayscale
			var inputGray = inputImage.Convert<Gray, byte>();
			var trainedGray = trainedImage.Convert<Gray, byte>();

			// Create result image
			var result = new Image<Gray, float>(inputGray.Width - trainedGray.Width + 1,
												inputGray.Height - trainedGray.Height + 1);

			// Perform template matching
			CvInvoke.MatchTemplate(inputGray, trainedGray, result, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed);

			// Find minimum and maximum values
			double minVal = 0;
			double maxVal = 0;
			var minLoc = new System.Drawing.Point();
			var maxLoc = new System.Drawing.Point();
			CvInvoke.MinMaxLoc(result, ref minVal, ref maxVal, ref minLoc, ref maxLoc);

			// Draw rectangle around recognized face
			if (maxVal > 0.6)
			{
				inputImage.Draw(new Rectangle(maxLoc.X, maxLoc.Y, trainedGray.Width, trainedGray.Height),
								new Bgr(Color.Blue), 2);
			}

			return inputImage;

		}

		public static double CompareFaces(Mat face1, Mat face2)
		{
			if (face1.Size != face2.Size)
			{
				// Resize the faces to a common size for comparison
				CvInvoke.Resize(face2, face2, face1.Size);
			}

			var result = new Mat();
			CvInvoke.MatchTemplate(face1, face2, result, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed);

			double minVal = 0, maxVal = 0;
			Point minLoc = new Point(), maxLoc = new Point();
			CvInvoke.MinMaxLoc(result, ref minVal, ref maxVal, ref minLoc, ref maxLoc);

			return maxVal; // Return the highest similarity score
		}

		public static Mat ByteArrayToMat(byte[] faceBytes)
		{
			Mat mat = new Mat();
			CvInvoke.Imdecode(faceBytes, ImreadModes.Grayscale, mat);
			return mat;
		}

	}
}
