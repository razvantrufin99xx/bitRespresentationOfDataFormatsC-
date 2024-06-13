/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 6/13/2024
 * Time: 12:49 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace datarepresentinginbinary
{
	partial class bytes256bits
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public datarepresentinginbinary.bytes128bits bytes128bits1;
		public datarepresentinginbinary.bytes128bits bytes128bits2;
		
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
			this.bytes128bits1 = new datarepresentinginbinary.bytes128bits();
			this.bytes128bits2 = new datarepresentinginbinary.bytes128bits();
			this.SuspendLayout();
			// 
			// bytes128bits1
			// 
			this.bytes128bits1.Location = new System.Drawing.Point(15, 4);
			this.bytes128bits1.Name = "bytes128bits1";
			this.bytes128bits1.Size = new System.Drawing.Size(892, 464);
			this.bytes128bits1.TabIndex = 0;
			// 
			// bytes128bits2
			// 
			this.bytes128bits2.Location = new System.Drawing.Point(15, 423);
			this.bytes128bits2.Name = "bytes128bits2";
			this.bytes128bits2.Size = new System.Drawing.Size(892, 464);
			this.bytes128bits2.TabIndex = 1;
			// 
			// bytes256bits
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.bytes128bits2);
			this.Controls.Add(this.bytes128bits1);
			this.Name = "bytes256bits";
			this.Size = new System.Drawing.Size(894, 914);
			this.ResumeLayout(false);

		}
	}
}
