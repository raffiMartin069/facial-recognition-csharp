using Emgu.CV;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using facial_recognition.Model;
using facial_recognition.Persistent.Data;
using facial_recognition.Utility;
using System;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace facial_recognition
{
	public partial class RegisterForm : Form
	{
		private readonly FaceRecognizer _faceRecognizer;
		private readonly RecognizerUtility _recognizerUtility;
		private VideoCapture _camera;
		private bool _isCameraRunning;
		private readonly string FRONTAL = ConfigurationManager.AppSettings["FRONTAL_FACE_CASCADE"];
		private readonly string EYE = ConfigurationManager.AppSettings["EYE_CASCADE"];
		private readonly string BASE_PATH = AppDomain.CurrentDomain.BaseDirectory.Replace(@"bin\Debug", "");
		private byte[] imageBytes;

		public RegisterForm()
		{
			InitializeComponent();
			string eyePath = BASE_PATH + EYE;
			var faceDetector = new CascadeClassifier(BASE_PATH + FRONTAL);
			var eyeDetector = new CascadeClassifier(eyePath);
			_recognizerUtility = new RecognizerUtility(faceDetector, eyeDetector);
			_faceRecognizer = new EigenFaceRecognizer(); // or FisherFaceRecognizer, LBPHFaceRecognizer
		}

		private void RegisterForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'facialDataSet2.WORKSTATUS' table. You can move, or remove it, as needed.
			this.wORKSTATUSTableAdapter.Fill(this.facialDataSet2.WORKSTATUS);
			// TODO: This line of code loads data into the 'facialDataSet1.CIVILSTATUS' table. You can move, or remove it, as needed.
			this.cIVILSTATUSTableAdapter.Fill(this.facialDataSet1.CIVILSTATUS);
			// TODO: This line of code loads data into the 'facialDataSet.GENDER' table. You can move, or remove it, as needed.
			this.gENDERTableAdapter.Fill(this.facialDataSet.GENDER);
			// TODO: This line of code loads data into the 'facialDataSet2.WORKSTATUS' table. You can move, or remove it, as needed.
			this.wORKSTATUSTableAdapter.Fill(this.facialDataSet2.WORKSTATUS);
            // TODO: This line of code loads data into the 'facialDataSet1.CIVILSTATUS' table. You can move, or remove it, as needed.
            this.cIVILSTATUSTableAdapter.Fill(this.facialDataSet1.CIVILSTATUS);
            // TODO: This line of code loads data into the 'facialDataSet.GENDER' table. You can move, or remove it, as needed.
            this.gENDERTableAdapter.Fill(this.facialDataSet.GENDER);

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

		private Bitmap ConvertToBitmap(Image<Bgr, byte> image)
		{
			// Convert Image<Bgr, byte> to Mat
			Mat mat = image.Mat;

			// Convert Mat to Bitmap
			Bitmap bitmap = new Bitmap(mat.Width, mat.Height, (int)mat.Step, PixelFormat.Format24bppRgb, mat.DataPointer);
			return bitmap;
		}

		private void StartCameraButton_Click(object sender, EventArgs e)
		{
			_camera = new VideoCapture(0); // Open the default camera
			_camera.ImageGrabbed += ProcessFrame;
			_isCameraRunning = false;

			if (!_isCameraRunning)
			{
				_camera.Start();
				_isCameraRunning = true;
			}
		}

		private void CaptureButton_Click(object sender, EventArgs e)
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
					MessageBox.Show("Face captured and trained!");

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


		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				var register = new Register
					(FullnameTextBox.Text, AddressTextBox.Text, EmailTextBox.Text,
					PNumberTextBox.Text, AgeTextBox.Text, GenderComboBox.Text,
					GuardianTextBox.Text, CivilStatusComboBox.Text, WorkStatusComboBox.Text,
					DateOfBirthTextBox.Text, imageBytes);

				register.AddUser();
			}
			catch(Exception ex)
			{
				ErrorLabel.Text = ex.Message;
				ErrorLabel.Visible = true;
			}
		}
	}
}
