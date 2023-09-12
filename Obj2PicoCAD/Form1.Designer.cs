namespace Obj2PicoCAD
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rotZ = new System.Windows.Forms.NumericUpDown();
			this.rotY = new System.Windows.Forms.NumericUpDown();
			this.rotX = new System.Windows.Forms.NumericUpDown();
			this.sizeInput = new System.Windows.Forms.NumericUpDown();
			this.posZ = new System.Windows.Forms.NumericUpDown();
			this.posY = new System.Windows.Forms.NumericUpDown();
			this.posX = new System.Windows.Forms.NumericUpDown();
			this.exportButton = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.backMeshMode = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.frontMeshMode = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.exportBrowseBtn = new System.Windows.Forms.Button();
			this.exportPathTextInput = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.objBrowseBtn = new System.Windows.Forms.Button();
			this.objPathTextInput = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.clearButton = new System.Windows.Forms.Button();
			this.recentListBox = new System.Windows.Forms.ListBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.rotZ)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rotY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rotX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sizeInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.posZ)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.posY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.posX)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rotZ);
			this.groupBox1.Controls.Add(this.rotY);
			this.groupBox1.Controls.Add(this.rotX);
			this.groupBox1.Controls.Add(this.sizeInput);
			this.groupBox1.Controls.Add(this.posZ);
			this.groupBox1.Controls.Add(this.posY);
			this.groupBox1.Controls.Add(this.posX);
			this.groupBox1.Controls.Add(this.exportButton);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.backMeshMode);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.frontMeshMode);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.exportBrowseBtn);
			this.groupBox1.Controls.Add(this.exportPathTextInput);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.objBrowseBtn);
			this.groupBox1.Controls.Add(this.objPathTextInput);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(347, 235);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "File Settings";
			// 
			// rotZ
			// 
			this.rotZ.DecimalPlaces = 1;
			this.rotZ.Location = new System.Drawing.Point(286, 158);
			this.rotZ.Name = "rotZ";
			this.rotZ.Size = new System.Drawing.Size(48, 23);
			this.rotZ.TabIndex = 27;
			this.rotZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// rotY
			// 
			this.rotY.DecimalPlaces = 1;
			this.rotY.Location = new System.Drawing.Point(232, 158);
			this.rotY.Name = "rotY";
			this.rotY.Size = new System.Drawing.Size(48, 23);
			this.rotY.TabIndex = 26;
			this.rotY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// rotX
			// 
			this.rotX.DecimalPlaces = 1;
			this.rotX.Location = new System.Drawing.Point(179, 158);
			this.rotX.Name = "rotX";
			this.rotX.Size = new System.Drawing.Size(48, 23);
			this.rotX.TabIndex = 25;
			this.rotX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// sizeInput
			// 
			this.sizeInput.DecimalPlaces = 1;
			this.sizeInput.Location = new System.Drawing.Point(81, 84);
			this.sizeInput.Name = "sizeInput";
			this.sizeInput.Size = new System.Drawing.Size(71, 23);
			this.sizeInput.TabIndex = 24;
			this.sizeInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// posZ
			// 
			this.posZ.DecimalPlaces = 1;
			this.posZ.Location = new System.Drawing.Point(114, 158);
			this.posZ.Name = "posZ";
			this.posZ.Size = new System.Drawing.Size(48, 23);
			this.posZ.TabIndex = 23;
			this.posZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// posY
			// 
			this.posY.DecimalPlaces = 1;
			this.posY.Location = new System.Drawing.Point(60, 158);
			this.posY.Name = "posY";
			this.posY.Size = new System.Drawing.Size(48, 23);
			this.posY.TabIndex = 22;
			this.posY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// posX
			// 
			this.posX.DecimalPlaces = 1;
			this.posX.Location = new System.Drawing.Point(6, 158);
			this.posX.Name = "posX";
			this.posX.Size = new System.Drawing.Size(48, 23);
			this.posX.TabIndex = 21;
			this.posX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// exportButton
			// 
			this.exportButton.Location = new System.Drawing.Point(6, 187);
			this.exportButton.Name = "exportButton";
			this.exportButton.Size = new System.Drawing.Size(328, 38);
			this.exportButton.TabIndex = 20;
			this.exportButton.Text = "Convert";
			this.exportButton.UseVisualStyleBackColor = true;
			this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(179, 140);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(28, 15);
			this.label6.TabIndex = 16;
			this.label6.Text = "Rot:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 140);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 15);
			this.label5.TabIndex = 12;
			this.label5.Text = "Pos:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 116);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 15);
			this.label4.TabIndex = 10;
			this.label4.Text = "MeshMode:";
			// 
			// backMeshMode
			// 
			this.backMeshMode.AutoSize = true;
			this.backMeshMode.Checked = true;
			this.backMeshMode.Location = new System.Drawing.Point(140, 114);
			this.backMeshMode.Name = "backMeshMode";
			this.backMeshMode.Size = new System.Drawing.Size(50, 19);
			this.backMeshMode.TabIndex = 9;
			this.backMeshMode.TabStop = true;
			this.backMeshMode.Text = "Back";
			this.backMeshMode.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 15);
			this.label3.TabIndex = 7;
			this.label3.Text = "Size:";
			// 
			// frontMeshMode
			// 
			this.frontMeshMode.AutoSize = true;
			this.frontMeshMode.Location = new System.Drawing.Point(81, 114);
			this.frontMeshMode.Name = "frontMeshMode";
			this.frontMeshMode.Size = new System.Drawing.Size(53, 19);
			this.frontMeshMode.TabIndex = 6;
			this.frontMeshMode.Text = "Front";
			this.frontMeshMode.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "Export Path:";
			// 
			// exportBrowseBtn
			// 
			this.exportBrowseBtn.Location = new System.Drawing.Point(277, 54);
			this.exportBrowseBtn.Name = "exportBrowseBtn";
			this.exportBrowseBtn.Size = new System.Drawing.Size(57, 23);
			this.exportBrowseBtn.TabIndex = 4;
			this.exportBrowseBtn.Text = "Browse";
			this.exportBrowseBtn.UseVisualStyleBackColor = true;
			this.exportBrowseBtn.Click += new System.EventHandler(this.exportBrowseBtn_Click);
			// 
			// exportPathTextInput
			// 
			this.exportPathTextInput.Location = new System.Drawing.Point(81, 54);
			this.exportPathTextInput.Name = "exportPathTextInput";
			this.exportPathTextInput.Size = new System.Drawing.Size(190, 23);
			this.exportPathTextInput.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Obj Path:";
			// 
			// objBrowseBtn
			// 
			this.objBrowseBtn.Location = new System.Drawing.Point(277, 22);
			this.objBrowseBtn.Name = "objBrowseBtn";
			this.objBrowseBtn.Size = new System.Drawing.Size(57, 23);
			this.objBrowseBtn.TabIndex = 1;
			this.objBrowseBtn.Text = "Browse";
			this.objBrowseBtn.UseVisualStyleBackColor = true;
			this.objBrowseBtn.Click += new System.EventHandler(this.objBrowseBtn_Click);
			// 
			// objPathTextInput
			// 
			this.objPathTextInput.Location = new System.Drawing.Point(81, 22);
			this.objPathTextInput.Name = "objPathTextInput";
			this.objPathTextInput.Size = new System.Drawing.Size(190, 23);
			this.objPathTextInput.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.clearButton);
			this.groupBox2.Controls.Add(this.recentListBox);
			this.groupBox2.Location = new System.Drawing.Point(365, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(198, 235);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Recent Files";
			// 
			// clearButton
			// 
			this.clearButton.Location = new System.Drawing.Point(6, 199);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(186, 23);
			this.clearButton.TabIndex = 6;
			this.clearButton.Text = "Clear";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// recentListBox
			// 
			this.recentListBox.FormattingEnabled = true;
			this.recentListBox.ItemHeight = 15;
			this.recentListBox.Items.AddRange(new object[] {
            "Box.obj",
            "Sphere.obj",
            "Box.obj",
            "Sphere.obj",
            "Box.obj",
            "Sphere.obj",
            "Box.obj",
            "Sphere.obj",
            "Box.obj",
            "Sphere.obj",
            "Box.obj",
            "Sphere.obj",
            "Box.obj",
            "Sphere.obj",
            "Box.obj",
            "Sphere.obj",
            "Box.obj",
            "Sphere.obj",
            "Box.obj",
            "Sphere.obj"});
			this.recentListBox.Location = new System.Drawing.Point(6, 24);
			this.recentListBox.Name = "recentListBox";
			this.recentListBox.Size = new System.Drawing.Size(186, 169);
			this.recentListBox.TabIndex = 0;
			this.recentListBox.SelectedIndexChanged += new System.EventHandler(this.recentListBox_SelectedIndexChanged);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(535, 237);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(28, 15);
			this.label7.TabIndex = 28;
			this.label7.Text = "v0.1";
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(577, 259);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(593, 298);
			this.MinimumSize = new System.Drawing.Size(593, 298);
			this.Name = "Form1";
			this.Text = "Obj2PicoCAD";
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.rotZ)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rotY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rotX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sizeInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.posZ)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.posY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.posX)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private Label label2;
		private Button exportBrowseBtn;
		private TextBox exportPathTextInput;
		private Label label1;
		private Button objBrowseBtn;
		private TextBox objPathTextInput;
		private ListBox recentListBox;
		private Button clearButton;
		private Label label4;
		private RadioButton backMeshMode;
		private Label label3;
		private RadioButton frontMeshMode;
		private Button exportButton;
		private Label label6;
		private Label label5;
		private NumericUpDown posX;
		private ContextMenuStrip contextMenuStrip1;
		private NumericUpDown posZ;
		private NumericUpDown posY;
		private NumericUpDown sizeInput;
		private NumericUpDown rotZ;
		private NumericUpDown rotY;
		private NumericUpDown rotX;
		private Label label7;
	}
}