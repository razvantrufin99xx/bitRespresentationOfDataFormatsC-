/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 6/13/2024
 * Time: 12:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace datarepresentinginbinary
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			Form2 f2= new Form2();
			f2.Show();
		}
		void Button2Click(object sender, EventArgs e)
		{
			Form3 f3= new Form3();
			f3.Show();
		}
		void Button3Click(object sender, EventArgs e)
		{
			if(this.bit11.BackColor==Color.Red){this.textBox1.Text = "0";}
			else {this.textBox1.Text ="1";}
		}
		void Button4Click(object sender, EventArgs e)
		{
			
			if(this.bit21.bit11.getC()==Color.Red){this.textBox2.Text = "0";}
			else {this.textBox2.Text ="1";}
			if(this.bit21.bit12.getC()==Color.Red){this.textBox2.Text += "0";}
			else {this.textBox2.Text +="1";}
			
		}
		void Button5Click(object sender, EventArgs e)
		{
			if(this.bit31.bit11.getC()==Color.Red){this.textBox3.Text = "0";}
			else {this.textBox3.Text ="1";}
			if(this.bit31.bit12.getC()==Color.Red){this.textBox3.Text += "0";}
			else {this.textBox3.Text +="1";}
			if(this.bit31.bit13.getC()==Color.Red){this.textBox3.Text += "0";}
			else {this.textBox3.Text +="1";}
		}
		void Button6Click(object sender, EventArgs e)
		{
			if(this.bit41.bit11.getC()==Color.Red){this.textBox4.Text = "0";}
			else {this.textBox4.Text ="1";}
			if(this.bit41.bit12.getC()==Color.Red){this.textBox4.Text += "0";}
			else {this.textBox4.Text +="1";}
			if(this.bit41.bit13.getC()==Color.Red){this.textBox4.Text += "0";}
			else {this.textBox4.Text +="1";}
			if(this.bit41.bit14.getC()==Color.Red){this.textBox4.Text += "0";}
			else {this.textBox4.Text +="1";}
		}
		void Button7Click(object sender, EventArgs e)
		{
			if(this.byte8bits1.bit41.bit11.getC()==Color.Red){this.textBox5.Text = "0";}
			else {this.textBox5.Text ="1";}
			if(this.byte8bits1.bit41.bit12.getC()==Color.Red){this.textBox5.Text += "0";}
			else {this.textBox5.Text +="1";}
			if(this.byte8bits1.bit41.bit13.getC()==Color.Red){this.textBox5.Text += "0";}
			else {this.textBox5.Text +="1";}
			if(this.byte8bits1.bit41.bit14.getC()==Color.Red){this.textBox5.Text += "0";}
			else {this.textBox5.Text +="1";}
			if(this.byte8bits1.bit42.bit11.getC()==Color.Red){this.textBox5.Text += "0";}
			else {this.textBox5.Text +="1";}
			if(this.byte8bits1.bit42.bit12.getC()==Color.Red){this.textBox5.Text += "0";}
			else {this.textBox5.Text +="1";}
			if(this.byte8bits1.bit42.bit13.getC()==Color.Red){this.textBox5.Text += "0";}
			else {this.textBox5.Text +="1";}
			if(this.byte8bits1.bit42.bit14.getC()==Color.Red){this.textBox5.Text += "0";}
			else {this.textBox5.Text +="1";}
		}
		void Button8Click(object sender, EventArgs e)
		{
			if(this.bytes161.byte8bits1.bit41.bit11.getC()==Color.Red){this.textBox6.Text = "0";}
			else {this.textBox6.Text ="1";}
			if(this.bytes161.byte8bits1.bit41.bit12.getC()==Color.Red){this.textBox6.Text += "0";}
			else {this.textBox6.Text +="1";}
			if(this.bytes161.byte8bits1.bit41.bit13.getC()==Color.Red){this.textBox6.Text += "0";}
			else {this.textBox6.Text +="1";}
			if(this.bytes161.byte8bits1.bit41.bit14.getC()==Color.Red){this.textBox6.Text += "0";}
			else {this.textBox6.Text +="1";}
			if(this.bytes161.byte8bits1.bit42.bit11.getC()==Color.Red){this.textBox6.Text += "0";}
			else {this.textBox6.Text +="1";}
			if(this.bytes161.byte8bits1.bit42.bit12.getC()==Color.Red){this.textBox6.Text += "0";}
			else {this.textBox6.Text +="1";}
			if(this.bytes161.byte8bits1.bit42.bit13.getC()==Color.Red){this.textBox6.Text += "0";}
			else {this.textBox6.Text +="1";}
			if(this.bytes161.byte8bits1.bit42.bit14.getC()==Color.Red){this.textBox6.Text += "0";}
			else {this.textBox6.Text +="1";}
			
			if(this.bytes161.byte8bits2.bit41.bit11.getC()==Color.Red){this.textBox6.Text += "0";}
			else {this.textBox6.Text +="1";}
			if(this.bytes161.byte8bits2.bit41.bit12.getC()==Color.Red){this.textBox6.Text += "0";}
			else {this.textBox6.Text +="1";}
			if(this.bytes161.byte8bits2.bit41.bit13.getC()==Color.Red){this.textBox6.Text += "0";}
			else {this.textBox6.Text +="1";}
			if(this.bytes161.byte8bits2.bit41.bit14.getC()==Color.Red){this.textBox6.Text += "0";}
			else {this.textBox6.Text +="1";}
			if(this.bytes161.byte8bits2.bit42.bit11.getC()==Color.Red){this.textBox6.Text += "0";}
			else {this.textBox6.Text +="1";}
			if(this.bytes161.byte8bits2.bit42.bit12.getC()==Color.Red){this.textBox6.Text += "0";}
			else {this.textBox6.Text +="1";}
			if(this.bytes161.byte8bits2.bit42.bit13.getC()==Color.Red){this.textBox6.Text += "0";}
			else {this.textBox6.Text +="1";}
			if(this.bytes161.byte8bits2.bit42.bit14.getC()==Color.Red){this.textBox6.Text += "0";}
			else {this.textBox6.Text +="1";}
			
			
		}
		void Button9Click(object sender, EventArgs e)
		{
			//bytes32bits1
	
			if(this.bytes32bits1.bytes161.byte8bits1.bit41.bit11.getC()==Color.Red){this.textBox7.Text = "0";}
			else {this.textBox7.Text ="1";}
			if(this.bytes32bits1.bytes161.byte8bits1.bit41.bit12.getC()==Color.Red){this.textBox7.Text += "0";}
			else {this.textBox7.Text +="1";}
			if(this.bytes32bits1.bytes161.byte8bits1.bit41.bit13.getC()==Color.Red){this.textBox7.Text += "0";}
			else {this.textBox7.Text +="1";}
			if(this.bytes32bits1.bytes161.byte8bits1.bit41.bit14.getC()==Color.Red){this.textBox7.Text += "0";}
			else {this.textBox7.Text +="1";}
			if(this.bytes32bits1.bytes161.byte8bits1.bit42.bit11.getC()==Color.Red){this.textBox7.Text += "0";}
			else {this.textBox7.Text +="1";}
			if(this.bytes32bits1.bytes161.byte8bits1.bit42.bit12.getC()==Color.Red){this.textBox7.Text += "0";}
			else {this.textBox7.Text +="1";}
			if(this.bytes32bits1.bytes161.byte8bits1.bit42.bit13.getC()==Color.Red){this.textBox7.Text += "0";}
			else {this.textBox7.Text +="1";}
			if(this.bytes32bits1.bytes161.byte8bits1.bit42.bit14.getC()==Color.Red){this.textBox7.Text += "0";}
			else {this.textBox7.Text +="1";}
			
			if(this.bytes32bits1.bytes161.byte8bits2.bit41.bit11.getC()==Color.Red){this.textBox7.Text += "0";}
			else {this.textBox7.Text +="1";}
			if(this.bytes32bits1.bytes161.byte8bits2.bit41.bit12.getC()==Color.Red){this.textBox7.Text += "0";}
			else {this.textBox7.Text +="1";}
			if(this.bytes32bits1.bytes161.byte8bits2.bit41.bit13.getC()==Color.Red){this.textBox7.Text += "0";}
			else {this.textBox7.Text +="1";}
			if(this.bytes32bits1.bytes161.byte8bits2.bit41.bit14.getC()==Color.Red){this.textBox7.Text += "0";}
			else {this.textBox7.Text +="1";}
			if(this.bytes32bits1.bytes161.byte8bits2.bit42.bit11.getC()==Color.Red){this.textBox7.Text += "0";}
			else {this.textBox7.Text +="1";}
			if(this.bytes32bits1.bytes161.byte8bits2.bit42.bit12.getC()==Color.Red){this.textBox7.Text += "0";}
			else {this.textBox7.Text +="1";}
			if(this.bytes32bits1.bytes161.byte8bits2.bit42.bit13.getC()==Color.Red){this.textBox7.Text += "0";}
			else {this.textBox7.Text +="1";}
			if(this.bytes32bits1.bytes161.byte8bits2.bit42.bit14.getC()==Color.Red){this.textBox7.Text += "0";}
			else {this.textBox7.Text +="1";}
			
			
			if(this.bytes32bits1.bytes162.byte8bits1.bit41.bit11.getC()==Color.Red){this.textBox7.Text += "0";}
			else {this.textBox7.Text +="1";}
			if(this.bytes32bits1.bytes162.byte8bits1.bit41.bit12.getC()==Color.Red){this.textBox7.Text += "0";}
			else {this.textBox7.Text +="1";}
			if(this.bytes32bits1.bytes162.byte8bits1.bit41.bit13.getC()==Color.Red){this.textBox7.Text += "0";}
			else {this.textBox7.Text +="1";}
			if(this.bytes32bits1.bytes162.byte8bits1.bit41.bit14.getC()==Color.Red){this.textBox7.Text += "0";}
			else {this.textBox7.Text +="1";}
			if(this.bytes32bits1.bytes162.byte8bits1.bit42.bit11.getC()==Color.Red){this.textBox7.Text += "0";}
			else {this.textBox7.Text +="1";}
			if(this.bytes32bits1.bytes162.byte8bits1.bit42.bit12.getC()==Color.Red){this.textBox7.Text += "0";}
			else {this.textBox7.Text +="1";}
			if(this.bytes32bits1.bytes162.byte8bits1.bit42.bit13.getC()==Color.Red){this.textBox7.Text += "0";}
			else {this.textBox7.Text +="1";}
			if(this.bytes32bits1.bytes162.byte8bits1.bit42.bit14.getC()==Color.Red){this.textBox7.Text += "0";}
			else {this.textBox7.Text +="1";}
			
			if(this.bytes32bits1.bytes162.byte8bits2.bit41.bit11.getC()==Color.Red){this.textBox7.Text += "0";}
			else {this.textBox7.Text +="1";}
			if(this.bytes32bits1.bytes162.byte8bits2.bit41.bit12.getC()==Color.Red){this.textBox7.Text += "0";}
			else {this.textBox7.Text +="1";}
			if(this.bytes32bits1.bytes162.byte8bits2.bit41.bit13.getC()==Color.Red){this.textBox7.Text += "0";}
			else {this.textBox7.Text +="1";}
			if(this.bytes32bits1.bytes162.byte8bits2.bit41.bit14.getC()==Color.Red){this.textBox7.Text += "0";}
			else {this.textBox7.Text +="1";}
			if(this.bytes32bits1.bytes162.byte8bits2.bit42.bit11.getC()==Color.Red){this.textBox7.Text += "0";}
			else {this.textBox7.Text +="1";}
			if(this.bytes32bits1.bytes162.byte8bits2.bit42.bit12.getC()==Color.Red){this.textBox7.Text += "0";}
			else {this.textBox7.Text +="1";}
			if(this.bytes32bits1.bytes162.byte8bits2.bit42.bit13.getC()==Color.Red){this.textBox7.Text += "0";}
			else {this.textBox7.Text +="1";}
			if(this.bytes32bits1.bytes162.byte8bits2.bit42.bit14.getC()==Color.Red){this.textBox7.Text += "0";}
			else {this.textBox7.Text +="1";}
			
		}
	}
}
