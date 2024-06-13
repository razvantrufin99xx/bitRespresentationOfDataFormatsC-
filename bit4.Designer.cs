/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 6/13/2024
 * Time: 12:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace datarepresentinginbinary
{
	partial class bit4
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public datarepresentinginbinary.bit1 bit11;
		public datarepresentinginbinary.bit1 bit12;
		public datarepresentinginbinary.bit1 bit13;
		public datarepresentinginbinary.bit1 bit14;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.bit11 = new datarepresentinginbinary.bit1();
			this.bit12 = new datarepresentinginbinary.bit1();
			this.bit13 = new datarepresentinginbinary.bit1();
			this.bit14 = new datarepresentinginbinary.bit1();
			this.SuspendLayout();
			// 
			// bit11
			// 
			this.bit11.Location = new System.Drawing.Point(0, 4);
			this.bit11.Name = "bit11";
			this.bit11.Size = new System.Drawing.Size(38, 32);
			this.bit11.TabIndex = 0;
			// 
			// bit12
			// 
			this.bit12.Location = new System.Drawing.Point(45, 4);
			this.bit12.Name = "bit12";
			this.bit12.Size = new System.Drawing.Size(38, 32);
			this.bit12.TabIndex = 1;
			// 
			// bit13
			// 
			this.bit13.Location = new System.Drawing.Point(90, 4);
			this.bit13.Name = "bit13";
			this.bit13.Size = new System.Drawing.Size(38, 32);
			this.bit13.TabIndex = 2;
			// 
			// bit14
			// 
			this.bit14.Location = new System.Drawing.Point(135, 4);
			this.bit14.Name = "bit14";
			this.bit14.Size = new System.Drawing.Size(38, 32);
			this.bit14.TabIndex = 3;
			// 
			// bit4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.bit14);
			this.Controls.Add(this.bit13);
			this.Controls.Add(this.bit12);
			this.Controls.Add(this.bit11);
			this.Name = "bit4";
			this.Size = new System.Drawing.Size(184, 44);
			this.Load += new System.EventHandler(this.Bit4Load);
			this.ResumeLayout(false);

		}
	}
}
