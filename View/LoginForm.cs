using Emgu.CV.Face;
using Emgu.CV;
using facial_recognition.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System.Drawing.Imaging;
using System.IO;
using facial_recognition.Repository;
using facial_recognition.FormIdentity;

namespace facial_recognition.View
{
	public partial class LoginForm : Form
	{

		private readonly FaceRecognizer _faceRecognizer;
		private readonly RecognizerUtility _recognizerUtility;
		private VideoCapture _camera;
		private bool _isCameraRunning;
		private readonly string FRONTAL = ConfigurationManager.AppSettings["FRONTAL_FACE_CASCADE"];
		private readonly string EYE = ConfigurationManager.AppSettings["EYE_CASCADE"];
		private readonly string BASE_PATH = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug", "");
		private byte[] imageBytes;

		public LoginForm()
		{
			InitializeComponent();
			string eyeCascadePath = Path.Combine(BASE_PATH, EYE);
			string faceCascadePath = Path.Combine(BASE_PATH, FRONTAL);
			var faceDetector = new CascadeClassifier(faceCascadePath);
			var eyeDetector = new CascadeClassifier(eyeCascadePath);
			_recognizerUtility = new RecognizerUtility(faceDetector, eyeDetector);
			_faceRecognizer = new EigenFaceRecognizer(); // or FisherFaceRecognizer, LBPHFaceRecognizer
		}

		private void CaptureVideo()
		{
			if (_camera != null && _camera.Ptr != IntPtr.Zero)
			{
				Mat frame = new Mat();
				_camera.Retrieve(frame);
				var image = frame.ToImage<Bgr, byte>();

				// Detect face
				var grayImage = image.Convert<Gray, byte>();
				var faces = _recognizerUtility.DetectFace(image);

				if (faces != null)
				{
					// Prepare training data
					var faceImages = new VectorOfMat();
					faceImages.Push(grayImage.Mat); // Add the detected face to the training set

					int[] labels = { 1 }; // Example label for the captured face

					// Train the recognizer
					_faceRecognizer.Train(faceImages, new VectorOfInt(labels));

					// Convert the image to Bitmap
					Bitmap bitmap = ConvertToBitmap(image);

					// Save Bitmap to byte array

					using (var ms = new MemoryStream())
					{
						bitmap.Save(ms, ImageFormat.Bmp);
						imageBytes = ms.ToArray();
					}

					// You can now use the byte array (imageBytes) as needed
				}
			}
		}

		private async Task<bool> StartCamera()
		{
			return await Task.Run(() =>
			{
				_camera = new VideoCapture(0); // Open the default camera
				_camera.ImageGrabbed += ProcessFrame;
				_isCameraRunning = false;

				if (!_isCameraRunning)
				{
					_camera.Start();
					_isCameraRunning = true;
				}

				return _isCameraRunning;
			});
		}

		private Bitmap ConvertToBitmap(Image<Bgr, byte> image)
		{
			// Convert Image<Bgr, byte> to Mat
			Mat mat = image.Mat;

			// Convert Mat to Bitmap
			Bitmap bitmap = new Bitmap(mat.Width, mat.Height, (int)mat.Step, PixelFormat.Format24bppRgb, mat.DataPointer);
			return bitmap;
		}

		private void ProcessFrame(object sender, EventArgs e)
		{
			if (_camera != null && _camera.Ptr != IntPtr.Zero)
			{
				Mat frame = new Mat();
				_camera.Retrieve(frame);
				var image = frame.ToImage<Bgr, byte>();

				// Detect and display faces
				var processedImage = _recognizerUtility.DetectFace(image);
				pictureBox1.Image = ConvertToBitmap(processedImage);
			}
		}

		private void LoginButton_Click(object sender, EventArgs e)
		{
			CaptureVideo();

			var repo = new LoginRepository();

			var facesInsideDatabase = repo.GetFaces();
			try
			{
				// Convert the uploaded profile image to a Mat
				Mat uploadedFaceMat = RecognizerUtility.ByteArrayToMat(imageBytes);

				// Check for duplicates
				foreach (var storedImage in facesInsideDatabase)
				{
					// Convert the stored image byte array to Mat
					Mat storedFaceMat = RecognizerUtility.ByteArrayToMat(storedImage.ByteImage);

					// Compare the two faces
					double similarity = RecognizerUtility.CompareFaces(uploadedFaceMat, storedFaceMat);

					// If similarity exceeds threshold, it's a duplicate
					if (similarity >= 0.6)  // Threshold for face comparison (adjust as necessary)
					{
						int id = storedImage.Id;
						Session.SetClaim("Id", id);

						var dashboard = new DashboardForm();
						dashboard.Show();
						this.Hide();
						return;
					}
				}
				MessageBox.Show("Face not recognized!");
			}
			catch(Exception)
			{
				MessageBox.Show("Something went wrong. Please restart the application.");
			}
		}

		private async void LoginForm_Load(object sender, EventArgs e)
		{
			await StartCamera();

			if (!_isCameraRunning)
			{
				MessageBox.Show("Camera not started!");
				return;
			}
		}

		private void RegisterButton_Click(object sender, EventArgs e)
		{
			var register = new RegisterForm();
			register.Show();
			this.Hide();
		}
	}
}
