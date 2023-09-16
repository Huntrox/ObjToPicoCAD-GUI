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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.bgBtn = new System.Windows.Forms.Button();
			this.alphaBtn = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.zoomLevel = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
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
			this.label7 = new System.Windows.Forms.Label();
			this.clearButton = new System.Windows.Forms.Button();
			this.recentListBox = new System.Windows.Forms.ListBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.zoomLevel)).BeginInit();
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
			this.groupBox1.Controls.Add(this.bgBtn);
			this.groupBox1.Controls.Add(this.alphaBtn);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.zoomLevel);
			this.groupBox1.Controls.Add(this.label8);
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
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(12, 11);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.groupBox1.Size = new System.Drawing.Size(346, 271);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "File Settings";
			// 
			// bgBtn
			// 
			this.bgBtn.BackColor = System.Drawing.Color.Black;
			this.bgBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.bgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bgBtn.Location = new System.Drawing.Point(88, 141);
			this.bgBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.bgBtn.Name = "bgBtn";
			this.bgBtn.Size = new System.Drawing.Size(31, 28);
			this.bgBtn.TabIndex = 33;
			this.bgBtn.UseVisualStyleBackColor = false;
			this.bgBtn.Click += new System.EventHandler(this.BgBtn_Click);
			// 
			// alphaBtn
			// 
			this.alphaBtn.BackColor = System.Drawing.Color.Black;
			this.alphaBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.alphaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.alphaBtn.Location = new System.Drawing.Point(267, 141);
			this.alphaBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.alphaBtn.Name = "alphaBtn";
			this.alphaBtn.Size = new System.Drawing.Size(31, 28);
			this.alphaBtn.TabIndex = 32;
			this.alphaBtn.UseVisualStyleBackColor = false;
			this.alphaBtn.Click += new System.EventHandler(this.OnAlphaColorBtn_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(186, 150);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(40, 13);
			this.label10.TabIndex = 31;
			this.label10.Text = "Alpha:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(6, 150);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(75, 13);
			this.label9.TabIndex = 30;
			this.label9.Text = "Background:";
			// 
			// zoomLevel
			// 
			this.zoomLevel.BackColor = System.Drawing.Color.Silver;
			this.zoomLevel.DecimalPlaces = 1;
			this.zoomLevel.Location = new System.Drawing.Point(270, 75);
			this.zoomLevel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.zoomLevel.Name = "zoomLevel";
			this.zoomLevel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.zoomLevel.Size = new System.Drawing.Size(71, 20);
			this.zoomLevel.TabIndex = 29;
			this.zoomLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.zoomLevel.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(192, 76);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(75, 13);
			this.label8.TabIndex = 28;
			this.label8.Text = "Zoom Level:";
			// 
			// rotZ
			// 
			this.rotZ.BackColor = System.Drawing.Color.Silver;
			this.rotZ.DecimalPlaces = 1;
			this.rotZ.Location = new System.Drawing.Point(293, 202);
			this.rotZ.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.rotZ.Name = "rotZ";
			this.rotZ.Size = new System.Drawing.Size(48, 20);
			this.rotZ.TabIndex = 27;
			this.rotZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// rotY
			// 
			this.rotY.BackColor = System.Drawing.Color.Silver;
			this.rotY.DecimalPlaces = 1;
			this.rotY.Location = new System.Drawing.Point(239, 202);
			this.rotY.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.rotY.Name = "rotY";
			this.rotY.Size = new System.Drawing.Size(48, 20);
			this.rotY.TabIndex = 26;
			this.rotY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// rotX
			// 
			this.rotX.BackColor = System.Drawing.Color.Silver;
			this.rotX.DecimalPlaces = 1;
			this.rotX.Location = new System.Drawing.Point(186, 202);
			this.rotX.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.rotX.Name = "rotX";
			this.rotX.Size = new System.Drawing.Size(48, 20);
			this.rotX.TabIndex = 25;
			this.rotX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// sizeInput
			// 
			this.sizeInput.BackColor = System.Drawing.Color.Silver;
			this.sizeInput.DecimalPlaces = 1;
			this.sizeInput.Location = new System.Drawing.Point(88, 72);
			this.sizeInput.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.sizeInput.Name = "sizeInput";
			this.sizeInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.sizeInput.Size = new System.Drawing.Size(71, 20);
			this.sizeInput.TabIndex = 24;
			this.sizeInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.sizeInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// posZ
			// 
			this.posZ.BackColor = System.Drawing.Color.Silver;
			this.posZ.DecimalPlaces = 1;
			this.posZ.Location = new System.Drawing.Point(114, 202);
			this.posZ.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.posZ.Name = "posZ";
			this.posZ.Size = new System.Drawing.Size(48, 20);
			this.posZ.TabIndex = 23;
			this.posZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// posY
			// 
			this.posY.BackColor = System.Drawing.Color.Silver;
			this.posY.DecimalPlaces = 1;
			this.posY.Location = new System.Drawing.Point(59, 202);
			this.posY.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.posY.Name = "posY";
			this.posY.Size = new System.Drawing.Size(48, 20);
			this.posY.TabIndex = 22;
			this.posY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// posX
			// 
			this.posX.BackColor = System.Drawing.Color.Silver;
			this.posX.DecimalPlaces = 1;
			this.posX.Location = new System.Drawing.Point(6, 202);
			this.posX.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.posX.Name = "posX";
			this.posX.Size = new System.Drawing.Size(48, 20);
			this.posX.TabIndex = 21;
			this.posX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// exportButton
			// 
			this.exportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
			this.exportButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exportButton.ForeColor = System.Drawing.Color.White;
			this.exportButton.Location = new System.Drawing.Point(6, 228);
			this.exportButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.exportButton.Name = "exportButton";
			this.exportButton.Size = new System.Drawing.Size(335, 32);
			this.exportButton.TabIndex = 20;
			this.exportButton.Text = "Convert";
			this.exportButton.UseVisualStyleBackColor = false;
			this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(186, 187);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(94, 13);
			this.label6.TabIndex = 16;
			this.label6.Text = "Light Direction:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(6, 187);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Offset:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(6, 110);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Flip Normals:";
			// 
			// backMeshMode
			// 
			this.backMeshMode.AutoSize = true;
			this.backMeshMode.Checked = true;
			this.backMeshMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.backMeshMode.Location = new System.Drawing.Point(154, 110);
			this.backMeshMode.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.backMeshMode.Name = "backMeshMode";
			this.backMeshMode.Size = new System.Drawing.Size(53, 17);
			this.backMeshMode.TabIndex = 9;
			this.backMeshMode.TabStop = true;
			this.backMeshMode.Text = "False";
			this.backMeshMode.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(6, 76);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Size:";
			// 
			// frontMeshMode
			// 
			this.frontMeshMode.AutoSize = true;
			this.frontMeshMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.frontMeshMode.Location = new System.Drawing.Point(94, 110);
			this.frontMeshMode.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.frontMeshMode.Name = "frontMeshMode";
			this.frontMeshMode.Size = new System.Drawing.Size(51, 17);
			this.frontMeshMode.TabIndex = 6;
			this.frontMeshMode.Text = "True";
			this.frontMeshMode.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(6, 50);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Export Path:";
			// 
			// exportBrowseBtn
			// 
			this.exportBrowseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
			this.exportBrowseBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.exportBrowseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exportBrowseBtn.Font = new System.Drawing.Font("MS PGothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.exportBrowseBtn.Location = new System.Drawing.Point(284, 46);
			this.exportBrowseBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.exportBrowseBtn.Name = "exportBrowseBtn";
			this.exportBrowseBtn.Size = new System.Drawing.Size(57, 20);
			this.exportBrowseBtn.TabIndex = 4;
			this.exportBrowseBtn.Text = "Browse";
			this.exportBrowseBtn.UseVisualStyleBackColor = false;
			this.exportBrowseBtn.Click += new System.EventHandler(this.exportBrowseBtn_Click);
			// 
			// exportPathTextInput
			// 
			this.exportPathTextInput.BackColor = System.Drawing.Color.Silver;
			this.exportPathTextInput.Font = new System.Drawing.Font("Microsoft Uighur", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.exportPathTextInput.Location = new System.Drawing.Point(88, 46);
			this.exportPathTextInput.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.exportPathTextInput.Name = "exportPathTextInput";
			this.exportPathTextInput.Size = new System.Drawing.Size(190, 22);
			this.exportPathTextInput.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(6, 26);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Obj Path:";
			// 
			// objBrowseBtn
			// 
			this.objBrowseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
			this.objBrowseBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.objBrowseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.objBrowseBtn.Font = new System.Drawing.Font("MS PGothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.objBrowseBtn.Location = new System.Drawing.Point(284, 20);
			this.objBrowseBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.objBrowseBtn.Name = "objBrowseBtn";
			this.objBrowseBtn.Size = new System.Drawing.Size(57, 19);
			this.objBrowseBtn.TabIndex = 1;
			this.objBrowseBtn.Text = "Browse";
			this.objBrowseBtn.UseVisualStyleBackColor = false;
			this.objBrowseBtn.Click += new System.EventHandler(this.objBrowseBtn_Click);
			// 
			// objPathTextInput
			// 
			this.objPathTextInput.BackColor = System.Drawing.Color.Silver;
			this.objPathTextInput.Font = new System.Drawing.Font("Microsoft Uighur", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.objPathTextInput.Location = new System.Drawing.Point(88, 20);
			this.objPathTextInput.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.objPathTextInput.Name = "objPathTextInput";
			this.objPathTextInput.Size = new System.Drawing.Size(190, 22);
			this.objPathTextInput.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.clearButton);
			this.groupBox2.Controls.Add(this.recentListBox);
			this.groupBox2.ForeColor = System.Drawing.Color.White;
			this.groupBox2.Location = new System.Drawing.Point(365, 11);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.groupBox2.Size = new System.Drawing.Size(202, 271);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Recent Files";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(170, 256);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(30, 13);
			this.label7.TabIndex = 28;
			this.label7.Text = "v0.1";
			// 
			// clearButton
			// 
			this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
			this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clearButton.ForeColor = System.Drawing.Color.White;
			this.clearButton.Location = new System.Drawing.Point(6, 236);
			this.clearButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(186, 21);
			this.clearButton.TabIndex = 6;
			this.clearButton.Text = "Clear";
			this.clearButton.UseVisualStyleBackColor = false;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// recentListBox
			// 
			this.recentListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
			this.recentListBox.ForeColor = System.Drawing.Color.Ivory;
			this.recentListBox.FormattingEnabled = true;
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
			this.recentListBox.Location = new System.Drawing.Point(6, 20);
			this.recentListBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.recentListBox.Name = "recentListBox";
			this.recentListBox.Size = new System.Drawing.Size(186, 212);
			this.recentListBox.TabIndex = 0;
			this.recentListBox.SelectedIndexChanged += new System.EventHandler(this.recentListBox_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
			this.ClientSize = new System.Drawing.Size(578, 292);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(594, 331);
			this.MinimumSize = new System.Drawing.Size(594, 331);
			this.Name = "Form1";
			this.Text = "ObjToPicoCAD";
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.zoomLevel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rotZ)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rotY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rotX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sizeInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.posZ)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.posY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.posX)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

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
		private NumericUpDown posZ;
		private NumericUpDown posY;
		private NumericUpDown sizeInput;
		private NumericUpDown rotZ;
		private NumericUpDown rotY;
		private NumericUpDown rotX;
		private Label label7;
		private Label label10;
		private Label label9;
		private NumericUpDown zoomLevel;
		private Label label8;
		private Button alphaBtn;
		private Button bgBtn;
	}
}