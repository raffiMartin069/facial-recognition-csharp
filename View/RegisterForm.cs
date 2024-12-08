using Emgu.CV;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using facial_recognition.Model;
using facial_recognition.Persistent.Data;
using facial_recognition.Utility;
using facial_recognition.View;
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
		private readonly string BASE_PATH = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug", "");
		private byte[] imageBytes;
		private bool _areBoxesVisible = false;


		public RegisterForm()
		{
			InitializeComponent();
			string eyeCascadePath = Path.Combine(BASE_PATH, EYE);
			string faceCascadePath = Path.Combine(BASE_PATH, FRONTAL);
			var faceDetector = new CascadeClassifier(faceCascadePath);
			var eyeDetector = new CascadeClassifier(eyeCascadePath);
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
				Image<Bgr, byte> processedImage = null;
				if (!_areBoxesVisible)
					processedImage = _recognizerUtility.DetectFace(image);
				else
					processedImage = _recognizerUtility.ToggleFaceAndEyeBoxes(image);

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

			CaptureButton.Enabled = true;
			TestButton.Enabled = true;
			StartCameraButton.Enabled = false;
		}

		private void CaptureButton_Click(object sender, EventArgs e)
		{

			if(_areBoxesVisible)
			{
				MessageBox.Show("NOTE: Please turn off Test Mode. The camera would capture the test boxes and would create unwanted bahaivior that might affect the end result.");
				return;
			}

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
					// Convert the first detected face to Bitmap and then to byte array
					using (var ms = new MemoryStream())
					{
						using (Bitmap bitmap = ConvertToBitmap(image))
						{
							bitmap.Save(ms, ImageFormat.Png); // Save in PNG format
							imageBytes = ms.ToArray();
						}
					}

					MessageBox.Show("Face captured successfully!");
					RegisterButton.Enabled = true;
				}
				else
				{
					MessageBox.Show("No face detected. Please try again.");
					RegisterButton.Enabled = false;
				}
			}
		}

		private void RegisterButton_Click(object sender, EventArgs e)
		{
			try
			{
				var register = new Register
					(FullnameTextBox.Text, AddressTextBox.Text, EmailTextBox.Text,
					PNumberTextBox.Text, AgeTextBox.Text, GenderComboBox.Text,
					GuardianTextBox.Text, CivilStatusComboBox.Text, WorkStatusComboBox.Text,
					DateOfBirthTextBox.Text, imageBytes);

				string refernceId = register.AddUser();

				if(string.IsNullOrEmpty(refernceId))
				{
					MessageBox.Show("Registration failed. Please try again.");
					return;
				}

				DialogResult dialogResult = MessageBox.Show($"Registration successful! Your reference ID is {refernceId}.", "Register Another User", MessageBoxButtons.YesNo);

				if(dialogResult == DialogResult.Yes || dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
				{
					Clear();
				}
			}
			catch (Exception ex)
			{
				ErrorLabel.Text = ex.Message;
				ErrorLabel.Visible = true;
			}
		}

		private void ClearFieldButton_Click(object sender, EventArgs e)
		{
			var login = new LoginForm();
			login.Show();
			this.Hide();
		}

		private void Clear()
		{
			FullnameTextBox.Clear();
			AddressTextBox.Clear();
			EmailTextBox.Clear();
			PNumberTextBox.Clear();
			AgeTextBox.Clear();
			GenderComboBox.SelectedIndex = -1;
			GuardianTextBox.Clear();
			CivilStatusComboBox.SelectedIndex = -1;
			WorkStatusComboBox.SelectedIndex = -1;
			DateOfBirthTextBox.Text = "";
			pictureBox1.Image = null;
			RegisterButton.Enabled = false;
			ErrorLabel.Visible = false;

			if (imageBytes != null)
				imageBytes.Cast<byte>().ToList().Clear();
		}

		private void TestButton_Click(object sender, EventArgs e)
		{
			_areBoxesVisible = !_areBoxesVisible;

			if (_areBoxesVisible)
				TestButton.Text = "Turn off Test Mode";
			else
				TestButton.Text = "Turn on Test Mode";
		}
	}
}
