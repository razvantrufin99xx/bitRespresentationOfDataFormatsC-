/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 6/13/2024
 * Time: 12:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace datarepresentinginbinary
{
	partial class bytes128bits
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private datarepresentinginbinary.bytes64bits bytes64bits1;
		private datarepresentinginbinary.bytes64bits bytes64bits2;
		
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
			this.bytes64bits1 = new datarepresentinginbinary.bytes64bits();
			this.bytes64bits2 = new datarepresentinginbinary.bytes64bits();
			this.SuspendLayout();
			// 
			// bytes64bits1
			// 
			this.bytes64bits1.Location = new System.Drawing.Point(4, 4);
			this.bytes64bits1.Name = "bytes64bits1";
			this.bytes64bits1.Size = new System.Drawing.Size(826, 220);
			this.bytes64bits1.TabIndex = 0;
			// 
			// bytes64bits2
			// 
			this.bytes64bits2.Location = new System.Drawing.Point(4, 209);
			this.bytes64bits2.Name = "bytes64bits2";
			this.bytes64bits2.Size = new System.Drawing.Size(826, 220);
			this.bytes64bits2.TabIndex = 1;
			// 
			// bytes128bits
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.bytes64bits2);
			this.Controls.Add(this.bytes64bits1);
			this.Name = "bytes128bits";
			this.Size = new System.Drawing.Size(892, 464);
			this.ResumeLayout(false);

		}
	}
}
