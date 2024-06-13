/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 6/13/2024
 * Time: 12:41 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace datarepresentinginbinary
{
	/// <summary>
	/// Description of bit1.
	/// </summary>
	public partial class bit1 : UserControl
	{
		public bit1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Bit1Load(object sender, EventArgs e)
		{
	
		}
		public Color getC()
		{
			return this.BackColor;
		}
		public bool changeText()
		{
			if(this.label1.Text=="1")
			{
			
				this.label1.Text = "0";
				this.BackColor = Color.Red;
			
				return false;
			}
			if(this.label1.Text =="0")
			{
			
				this.label1.Text = "1";
				this.BackColor = Color.Green;
				
				return true;
			}
			return false;
		}
		void Bit1MouseClick(object sender, MouseEventArgs e)
		{
	changeText();
		}
		
		
	}
}
