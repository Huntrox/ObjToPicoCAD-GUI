using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obj2PicoCAD
{
	public partial class ColorPicker : Form
	{

		public Action<int> OnColorSelected { get; set; }

		
		
		public ColorPicker()
		{
			InitializeComponent();
			//get all 16 button

			var buttons = new Button[]
			{
				b1, b2, b3, b4, b5, b6, b7, b8, b9,
				b10, b11, b12, b13, b14, b15, b16
			};
			
			for (int i = 0; i < buttons.Count(); i++)
			{
				var index = i;
				buttons[index].Click += (sender, e) 
					=> OnColorButtonSelected(index);
			}

		}

		private void OnColorButtonSelected(int indx)
		{
			OnColorSelected?.Invoke(indx);
			this.Close();
		}

	}
}
