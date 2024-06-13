/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 6/13/2024
 * Time: 1:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace datarepresentinginbinary
{
	partial class Form2
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private datarepresentinginbinary.bytes64bits bytes64bits1;
		private datarepresentinginbinary.bytes128bits bytes128bits1;
		private datarepresentinginbinary.bytes80bits bytes80bits1;
		
		/// <summary>
		/// Disposes resources used by the form.
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
			this.bytes128bits1 = new datarepresentinginbinary.bytes128bits();
			this.bytes80bits1 = new datarepresentinginbinary.bytes80bits();
			this.SuspendLayout();
			// 
			// bytes64bits1
			// 
			this.bytes64bits1.Location = new System.Drawing.Point(27, 13);
			this.bytes64bits1.Name = "bytes64bits1";
			this.bytes64bits1.Size = new System.Drawing.Size(826, 220);
			this.bytes64bits1.TabIndex = 0;
			// 
			// bytes128bits1
			// 
			this.bytes128bits1.Location = new System.Drawing.Point(27, 251);
			this.bytes128bits1.Name = "bytes128bits1";
			this.bytes128bits1.Size = new System.Drawing.Size(892, 464);
			this.bytes128bits1.TabIndex = 1;
			// 
			// bytes80bits1
			// 
			this.bytes80bits1.Location = new System.Drawing.Point(950, 120);
			this.bytes80bits1.Name = "bytes80bits1";
			this.bytes80bits1.Size = new System.Drawing.Size(412, 512);
			this.bytes80bits1.TabIndex = 2;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1460, 917);
			this.Controls.Add(this.bytes80bits1);
			this.Controls.Add(this.bytes128bits1);
			this.Controls.Add(this.bytes64bits1);
			this.Name = "Form2";
			this.Text = "64 , 80 and 128";
			this.Load += new System.EventHandler(this.Form2Load);
			this.ResumeLayout(false);

		}
	}
}
