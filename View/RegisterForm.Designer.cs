namespace facial_recognition
{
	partial class RegisterForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.FullnameTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.AddressTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.EmailTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.PNumberTextBox = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.AgeTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.GenderComboBox = new System.Windows.Forms.ComboBox();
			this.gENDERBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.facialDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.facialDataSet = new facial_recognition.Properties.DataSources.FacialDataSet();
			this.label8 = new System.Windows.Forms.Label();
			this.GuardianTextBox = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.CivilStatusComboBox = new System.Windows.Forms.ComboBox();
			this.cIVILSTATUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.facialDataSet1 = new facial_recognition.Properties.DataSources.FacialDataSet1();
			this.WorkStatusComboBox = new System.Windows.Forms.ComboBox();
			this.wORKSTATUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.facialDataSet2 = new facial_recognition.Properties.DataSources.FacialDataSet2();
			this.label9 = new System.Windows.Forms.Label();
			this.DateOfBirthTextBox = new System.Windows.Forms.DateTimePicker();
			this.label11 = new System.Windows.Forms.Label();
			this.ReferenceNumberTextBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.StartCameraButton = new System.Windows.Forms.Button();
			this.CaptureButton = new System.Windows.Forms.Button();
			this.gENDERTableAdapter = new facial_recognition.Properties.DataSources.FacialDataSetTableAdapters.GENDERTableAdapter();
			this.cIVILSTATUSTableAdapter = new facial_recognition.Properties.DataSources.FacialDataSet1TableAdapters.CIVILSTATUSTableAdapter();
			this.wORKSTATUSTableAdapter = new facial_recognition.Properties.DataSources.FacialDataSet2TableAdapters.WORKSTATUSTableAdapter();
			this.ErrorLabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gENDERBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.facialDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.facialDataSet)).BeginInit();
			this.tableLayoutPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cIVILSTATUSBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.facialDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.wORKSTATUSBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.facialDataSet2)).BeginInit();
			this.flowLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 781);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this.FullnameTextBox);
			this.flowLayoutPanel1.Controls.Add(this.label2);
			this.flowLayoutPanel1.Controls.Add(this.AddressTextBox);
			this.flowLayoutPanel1.Controls.Add(this.label3);
			this.flowLayoutPanel1.Controls.Add(this.EmailTextBox);
			this.flowLayoutPanel1.Controls.Add(this.label4);
			this.flowLayoutPanel1.Controls.Add(this.PNumberTextBox);
			this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel2);
			this.flowLayoutPanel1.Controls.Add(this.label8);
			this.flowLayoutPanel1.Controls.Add(this.GuardianTextBox);
			this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel4);
			this.flowLayoutPanel1.Controls.Add(this.label9);
			this.flowLayoutPanel1.Controls.Add(this.DateOfBirthTextBox);
			this.flowLayoutPanel1.Controls.Add(this.label11);
			this.flowLayoutPanel1.Controls.Add(this.ReferenceNumberTextBox);
			this.flowLayoutPanel1.Controls.Add(this.ErrorLabel);
			this.flowLayoutPanel1.Controls.Add(this.button1);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(94, 64);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
			this.flowLayoutPanel1.Size = new System.Drawing.Size(403, 652);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(9, 5);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Full Name";
			// 
			// FullnameTextBox
			// 
			this.FullnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.FullnameTextBox.Location = new System.Drawing.Point(8, 29);
			this.FullnameTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
			this.FullnameTextBox.Name = "FullnameTextBox";
			this.FullnameTextBox.Size = new System.Drawing.Size(377, 29);
			this.FullnameTextBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(9, 63);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 21);
			this.label2.TabIndex = 0;
			this.label2.Text = "Address";
			// 
			// AddressTextBox
			// 
			this.AddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.AddressTextBox.Location = new System.Drawing.Point(8, 87);
			this.AddressTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
			this.AddressTextBox.Name = "AddressTextBox";
			this.AddressTextBox.Size = new System.Drawing.Size(377, 29);
			this.AddressTextBox.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(9, 121);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 21);
			this.label3.TabIndex = 0;
			this.label3.Text = "Email Address";
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.EmailTextBox.Location = new System.Drawing.Point(8, 145);
			this.EmailTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.Size = new System.Drawing.Size(377, 29);
			this.EmailTextBox.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(9, 179);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(126, 21);
			this.label4.TabIndex = 0;
			this.label4.Text = "Phone Number";
			// 
			// PNumberTextBox
			// 
			this.PNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.PNumberTextBox.Location = new System.Drawing.Point(8, 203);
			this.PNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
			this.PNumberTextBox.Name = "PNumberTextBox";
			this.PNumberTextBox.Size = new System.Drawing.Size(377, 29);
			this.PNumberTextBox.TabIndex = 1;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.AgeTextBox, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.label6, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.GenderComboBox, 1, 1);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 240);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(3);
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(377, 64);
			this.tableLayoutPanel2.TabIndex = 2;
			// 
			// AgeTextBox
			// 
			this.AgeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.AgeTextBox.Location = new System.Drawing.Point(6, 27);
			this.AgeTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
			this.AgeTextBox.Name = "AgeTextBox";
			this.AgeTextBox.Size = new System.Drawing.Size(172, 29);
			this.AgeTextBox.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(72, 3);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 21);
			this.label5.TabIndex = 0;
			this.label5.Text = "Age";
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(245, 3);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 21);
			this.label6.TabIndex = 0;
			this.label6.Text = "Gender";
			// 
			// GenderComboBox
			// 
			this.GenderComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.GenderComboBox.DataSource = this.gENDERBindingSource;
			this.GenderComboBox.DisplayMember = "TYPE";
			this.GenderComboBox.FormattingEnabled = true;
			this.GenderComboBox.Location = new System.Drawing.Point(191, 27);
			this.GenderComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
			this.GenderComboBox.Name = "GenderComboBox";
			this.GenderComboBox.Size = new System.Drawing.Size(172, 29);
			this.GenderComboBox.TabIndex = 3;
			this.GenderComboBox.ValueMember = "TYPE";
			// 
			// gENDERBindingSource
			// 
			this.gENDERBindingSource.DataMember = "GENDER";
			this.gENDERBindingSource.DataSource = this.facialDataSetBindingSource;
			// 
			// facialDataSetBindingSource
			// 
			this.facialDataSetBindingSource.DataSource = this.facialDataSet;
			this.facialDataSetBindingSource.Position = 0;
			// 
			// facialDataSet
			// 
			this.facialDataSet.DataSetName = "FacialDataSet";
			this.facialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(9, 314);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(154, 21);
			this.label8.TabIndex = 4;
			this.label8.Text = "Guardian or Parent";
			// 
			// GuardianTextBox
			// 
			this.GuardianTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.GuardianTextBox.Location = new System.Drawing.Point(8, 338);
			this.GuardianTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
			this.GuardianTextBox.Name = "GuardianTextBox";
			this.GuardianTextBox.Size = new System.Drawing.Size(377, 29);
			this.GuardianTextBox.TabIndex = 1;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel4.AutoSize = true;
			this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel4.ColumnCount = 2;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.Controls.Add(this.label12, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.label13, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.CivilStatusComboBox, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.WorkStatusComboBox, 1, 1);
			this.tableLayoutPanel4.Location = new System.Drawing.Point(8, 375);
			this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(3);
			this.tableLayoutPanel4.RowCount = 2;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.Size = new System.Drawing.Size(377, 69);
			this.tableLayoutPanel4.TabIndex = 7;
			// 
			// label12
			// 
			this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(44, 3);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(95, 21);
			this.label12.TabIndex = 0;
			this.label12.Text = "Civil Status";
			// 
			// label13
			// 
			this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(226, 3);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(102, 21);
			this.label13.TabIndex = 0;
			this.label13.Text = "Work Status";
			// 
			// CivilStatusComboBox
			// 
			this.CivilStatusComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.CivilStatusComboBox.DataSource = this.cIVILSTATUSBindingSource;
			this.CivilStatusComboBox.DisplayMember = "STATUS";
			this.CivilStatusComboBox.FormattingEnabled = true;
			this.CivilStatusComboBox.Location = new System.Drawing.Point(6, 27);
			this.CivilStatusComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.CivilStatusComboBox.Name = "CivilStatusComboBox";
			this.CivilStatusComboBox.Size = new System.Drawing.Size(172, 29);
			this.CivilStatusComboBox.TabIndex = 3;
			this.CivilStatusComboBox.ValueMember = "STATUS";
			// 
			// cIVILSTATUSBindingSource
			// 
			this.cIVILSTATUSBindingSource.DataMember = "CIVILSTATUS";
			this.cIVILSTATUSBindingSource.DataSource = this.facialDataSet1;
			// 
			// facialDataSet1
			// 
			this.facialDataSet1.DataSetName = "FacialDataSet1";
			this.facialDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// WorkStatusComboBox
			// 
			this.WorkStatusComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.WorkStatusComboBox.DataSource = this.wORKSTATUSBindingSource;
			this.WorkStatusComboBox.DisplayMember = "STATUS";
			this.WorkStatusComboBox.FormattingEnabled = true;
			this.WorkStatusComboBox.Location = new System.Drawing.Point(191, 27);
			this.WorkStatusComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
			this.WorkStatusComboBox.Name = "WorkStatusComboBox";
			this.WorkStatusComboBox.Size = new System.Drawing.Size(172, 29);
			this.WorkStatusComboBox.TabIndex = 3;
			this.WorkStatusComboBox.ValueMember = "STATUS";
			// 
			// wORKSTATUSBindingSource
			// 
			this.wORKSTATUSBindingSource.DataMember = "WORKSTATUS";
			this.wORKSTATUSBindingSource.DataSource = this.facialDataSet2;
			// 
			// facialDataSet2
			// 
			this.facialDataSet2.DataSetName = "FacialDataSet2";
			this.facialDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label9
			// 
			this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(9, 454);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(107, 21);
			this.label9.TabIndex = 4;
			this.label9.Text = "Date of Birth";
			// 
			// DateOfBirthTextBox
			// 
			this.DateOfBirthTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.DateOfBirthTextBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DateOfBirthTextBox.Location = new System.Drawing.Point(8, 478);
			this.DateOfBirthTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
			this.DateOfBirthTextBox.Name = "DateOfBirthTextBox";
			this.DateOfBirthTextBox.Size = new System.Drawing.Size(377, 29);
			this.DateOfBirthTextBox.TabIndex = 5;
			// 
			// label11
			// 
			this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(9, 512);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(153, 21);
			this.label11.TabIndex = 0;
			this.label11.Text = "Reference Number";
			// 
			// ReferenceNumberTextBox
			// 
			this.ReferenceNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ReferenceNumberTextBox.Enabled = false;
			this.ReferenceNumberTextBox.Location = new System.Drawing.Point(8, 536);
			this.ReferenceNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.ReferenceNumberTextBox.Name = "ReferenceNumberTextBox";
			this.ReferenceNumberTextBox.Size = new System.Drawing.Size(377, 29);
			this.ReferenceNumberTextBox.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(8, 608);
			this.button1.MinimumSize = new System.Drawing.Size(355, 35);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(377, 35);
			this.button1.TabIndex = 6;
			this.button1.Text = "Register";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.flowLayoutPanel2.Controls.Add(this.pictureBox1);
			this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel3);
			this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(621, 134);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(533, 513);
			this.flowLayoutPanel2.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(530, 457);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel3.AutoSize = true;
			this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Controls.Add(this.StartCameraButton, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.CaptureButton, 1, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 466);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(530, 41);
			this.tableLayoutPanel3.TabIndex = 3;
			// 
			// StartCameraButton
			// 
			this.StartCameraButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.StartCameraButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.StartCameraButton.Location = new System.Drawing.Point(3, 3);
			this.StartCameraButton.MinimumSize = new System.Drawing.Size(100, 35);
			this.StartCameraButton.Name = "StartCameraButton";
			this.StartCameraButton.Size = new System.Drawing.Size(259, 35);
			this.StartCameraButton.TabIndex = 6;
			this.StartCameraButton.Text = "Start";
			this.StartCameraButton.UseVisualStyleBackColor = true;
			this.StartCameraButton.Click += new System.EventHandler(this.StartCameraButton_Click);
			// 
			// CaptureButton
			// 
			this.CaptureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.CaptureButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.CaptureButton.Location = new System.Drawing.Point(268, 3);
			this.CaptureButton.MinimumSize = new System.Drawing.Size(50, 35);
			this.CaptureButton.Name = "CaptureButton";
			this.CaptureButton.Size = new System.Drawing.Size(259, 35);
			this.CaptureButton.TabIndex = 6;
			this.CaptureButton.Text = "Capture";
			this.CaptureButton.UseVisualStyleBackColor = true;
			this.CaptureButton.Click += new System.EventHandler(this.CaptureButton_Click);
			// 
			// gENDERTableAdapter
			// 
			this.gENDERTableAdapter.ClearBeforeFill = true;
			// 
			// cIVILSTATUSTableAdapter
			// 
			this.cIVILSTATUSTableAdapter.ClearBeforeFill = true;
			// 
			// wORKSTATUSTableAdapter
			// 
			this.wORKSTATUSTableAdapter.ClearBeforeFill = true;
			// 
			// ErrorLabel
			// 
			this.ErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ErrorLabel.AutoSize = true;
			this.ErrorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
			this.ErrorLabel.Location = new System.Drawing.Point(9, 585);
			this.ErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 5);
			this.ErrorLabel.Name = "ErrorLabel";
			this.ErrorLabel.Size = new System.Drawing.Size(375, 15);
			this.ErrorLabel.TabIndex = 0;
			this.ErrorLabel.Text = "Sample Error";
			this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ErrorLabel.Visible = false;
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1184, 781);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.MinimumSize = new System.Drawing.Size(920, 720);
			this.Name = "RegisterForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.RegisterForm_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gENDERBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.facialDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.facialDataSet)).EndInit();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cIVILSTATUSBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.facialDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.wORKSTATUSBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.facialDataSet2)).EndInit();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox FullnameTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox AddressTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox EmailTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox PNumberTextBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox CivilStatusComboBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox GuardianTextBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DateTimePicker DateOfBirthTextBox;
		private System.Windows.Forms.ComboBox WorkStatusComboBox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox ReferenceNumberTextBox;
		private System.Windows.Forms.ComboBox GenderComboBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button StartCameraButton;
		private System.Windows.Forms.Button CaptureButton;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.TextBox AgeTextBox;
		private System.Windows.Forms.BindingSource facialDataSetBindingSource;
		private Properties.DataSources.FacialDataSet facialDataSet;
		private System.Windows.Forms.BindingSource gENDERBindingSource;
		private Properties.DataSources.FacialDataSetTableAdapters.GENDERTableAdapter gENDERTableAdapter;
		private Properties.DataSources.FacialDataSet1 facialDataSet1;
		private System.Windows.Forms.BindingSource cIVILSTATUSBindingSource;
		private Properties.DataSources.FacialDataSet1TableAdapters.CIVILSTATUSTableAdapter cIVILSTATUSTableAdapter;
		private Properties.DataSources.FacialDataSet2 facialDataSet2;
		private System.Windows.Forms.BindingSource wORKSTATUSBindingSource;
		private Properties.DataSources.FacialDataSet2TableAdapters.WORKSTATUSTableAdapter wORKSTATUSTableAdapter;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label ErrorLabel;
	}
}

