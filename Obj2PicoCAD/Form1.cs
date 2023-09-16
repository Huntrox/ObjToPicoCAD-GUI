using Obj2PicoCAD.Models;
using Obj2PicoCAD.Utils;
using System;
using System.Diagnostics;

namespace Obj2PicoCAD
{

	public partial class Form1 : Form
	{

		private ObjReader _objReader = new ObjReader();

		private int _meshMode = 0;
		private int _alphaColorIndex = 0;
		private int _bgColorIndex = 0;
		
		public Form1()
		{
			InitializeComponent();
			recentListBox.Items.Clear();

			RecentFilesHandler.LoadRecentFiles();
			foreach (var recent in RecentFilesHandler.RecentFiles)
			{
				AddRecentFileToList(recent);
			}
		}

		private void AddRecentFileToList(RecentFile recent)
		{
			var outputName = Path.GetFileNameWithoutExtension(recent.OutputPath);
			recentListBox.Items.Add($"[{outputName}] ({recent.Date})");
		}

		private void Form1_DragDrop(object sender, DragEventArgs e)
		{
			//Console.WriteLine(sender.ToString());
			//Console.WriteLine(e.Data.GetData(DataFormats.FileDrop));
		}

		
		private void exportButton_Click(object sender, EventArgs e)
		{
			_objReader.Pos = new Vector3((float)posX.Value, (float)posY.Value, (float)posZ.Value);
			_objReader.Rot = new Vector3((float)rotX.Value, (float)rotY.Value, (float)rotZ.Value);

			_objReader.AlphaColorIndex = _alphaColorIndex;
			_objReader.BgColorIndex = _bgColorIndex;

			_objReader.Zoom = (float)zoomLevel.Value;


			_meshMode = frontMeshMode.Checked ? 0 : 1;
			
			var size = (float)sizeInput.Value;
			var objPath = objPathTextInput.Text;
			var exportPath = exportPathTextInput.Text;
			var fileName = Path.GetFileNameWithoutExtension(objPath);
			


			_objReader.ObjToPicoCAD(objPath, exportPath, size, _meshMode);
			

			var recent = new RecentFile()
			{
				Path = objPath,
				OutputPath = exportPath,
				Name = fileName,
				Size = size,
				Zoom = _objReader.Zoom,
				BackgroundColor = _bgColorIndex,
				AlphaColor = _alphaColorIndex,
				Date = DateTime.Now.ToString(),
				MeshMode = _meshMode,
				Pos = new Vector3(_objReader.Pos.x, _objReader.Pos.y, _objReader.Pos.z),
				Rot = new Vector3(_objReader.Rot.x, _objReader.Rot.y, _objReader.Rot.z),
			};

			RecentFilesHandler.AddRecentFile(recent);
			AddRecentFileToList(recent);

			
			//check if file directory is opend if not open directory and select the file
			
			var directory = Path.GetDirectoryName(exportPath);
			Utilities.ShowInExplorer(exportPath);

		}

		private void objBrowseBtn_Click(object sender, EventArgs e)
		{
			//open file dialoge and select obj file 
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Obj files (*.obj)|*.obj";
			openFileDialog.RestoreDirectory = true;
			openFileDialog.Multiselect = false;

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				objPathTextInput.Text = openFileDialog.FileName;
				objPathTextInput.SelectionStart = objPathTextInput.Text.Length;
			}
		}

		private void exportBrowseBtn_Click(object sender, EventArgs e)
		{
			//open save file dialoge and select path to save txt file 
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Txt files (*.txt)|*.txt";
			saveFileDialog.RestoreDirectory = true;
			saveFileDialog.FileName = Path.GetFileNameWithoutExtension(objPathTextInput.Text) + ".txt";
				

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				exportPathTextInput.Text = saveFileDialog.FileName;
				exportPathTextInput.SelectionStart = exportPathTextInput.Text.Length;
			}

		}

		private void recentListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var index = recentListBox.SelectedIndex;
			if (index == -1 || RecentFilesHandler.RecentFiles.IsNullOrEmpty() || index > RecentFilesHandler.RecentFiles.Count - 1)
			{
				return;
			}
			
			var recent = RecentFilesHandler.RecentFiles[index];
			objPathTextInput.Text = recent.Path;
			exportPathTextInput.Text = recent.OutputPath;

			posX.Value = (decimal)recent.Pos.x;
			posY.Value = (decimal)recent.Pos.y;
			posZ.Value = (decimal)recent.Pos.z;
			rotX.Value = (decimal)recent.Rot.x;
			rotY.Value = (decimal)recent.Rot.y;
			rotZ.Value = (decimal)recent.Rot.z;
			zoomLevel.Value = (decimal)recent.Zoom;

			_bgColorIndex = recent.BackgroundColor;
			_alphaColorIndex = recent.AlphaColor;

			
			bgBtn.BackColor = Utilities.rgbColors[_bgColorIndex];
			alphaBtn.BackColor = Utilities.rgbColors[_alphaColorIndex];
			
			sizeInput.Value = (decimal)recent.Size;
			



			frontMeshMode.Checked = recent.MeshMode == 0;
			backMeshMode.Checked = recent.MeshMode == 1;
				
		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			RecentFilesHandler.ClearRecentFiles();
			recentListBox.Items.Clear();
			
		}

		private void OnAlphaColorBtn_Click(object sender, EventArgs e)
		{
			ShowColorPicker((index) =>
			{
				alphaBtn.BackColor = Utilities.rgbColors[index];
				_alphaColorIndex = index;
			});
		}

		private void BgBtn_Click(object sender, EventArgs e)
		{
			ShowColorPicker((index) =>
			{
				bgBtn.BackColor = Utilities.rgbColors[index];
				_bgColorIndex = index;
			});
		}
		private void ShowColorPicker(Action<int> onColorSelectCallback)
		{

			var modal = new ColorPicker();
			modal.OnColorSelected = onColorSelectCallback;
			//show in the center of this form 
			modal.StartPosition = FormStartPosition.CenterParent;
			modal.ShowDialog();
		}


	}

}