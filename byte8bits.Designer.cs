/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 6/13/2024
 * Time: 12:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace datarepresentinginbinary
{
	partial class byte8bits
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public datarepresentinginbinary.bit4 bit41;
		public datarepresentinginbinary.bit4 bit42;
		
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
			this.bit41 = new datarepresentinginbinary.bit4();
			this.bit42 = new datarepresentinginbinary.bit4();
			this.SuspendLayout();
			// 
			// bit41
			// 
			this.bit41.Location = new System.Drawing.Point(0, 4);
			this.bit41.Name = "bit41";
			this.bit41.Size = new System.Drawing.Size(184, 44);
			this.bit41.TabIndex = 0;
			// 
			// bit42
			// 
			this.bit42.Location = new System.Drawing.Point(191, 4);
			this.bit42.Name = "bit42";
			this.bit42.Size = new System.Drawing.Size(184, 44);
			this.bit42.TabIndex = 1;
			// 
			// byte8bits
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.bit42);
			this.Controls.Add(this.bit41);
			this.Name = "byte8bits";
			this.Size = new System.Drawing.Size(374, 44);
			this.Load += new System.EventHandler(this.Byte8bitsLoad);
			this.ResumeLayout(false);

		}
	}
}
