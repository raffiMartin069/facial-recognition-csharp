using Emgu.CV;
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
	public  class RecognizerUtility
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
			var faces = _faceDetector.DetectMultiScale(gray, 1.1, 10);

			foreach (var face in faces)
			{
				image.Draw(face, new Bgr(Color.Red), 2);
				var eyes = _eyeDetector.DetectMultiScale(gray.GetSubRect(face));
				foreach (var eye in eyes)
				{
					image.Draw(eye, new Bgr(Color.Green), 2);
				}
			}

			return image;
		}

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
			if (maxVal > 0.7)
			{
				inputImage.Draw(new Rectangle(maxLoc.X, maxLoc.Y, trainedGray.Width, trainedGray.Height),
								new Bgr(Color.Blue), 2);
			}

			return inputImage;

		}

	}
}
