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
	partial class Form3
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private datarepresentinginbinary.bytes256bits bytes256bits1;
		
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
			this.bytes256bits1 = new datarepresentinginbinary.bytes256bits();
			this.SuspendLayout();
			// 
			// bytes256bits1
			// 
			this.bytes256bits1.Location = new System.Drawing.Point(67, 45);
			this.bytes256bits1.Name = "bytes256bits1";
			this.bytes256bits1.Size = new System.Drawing.Size(894, 914);
			this.bytes256bits1.TabIndex = 0;
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1444, 891);
			this.Controls.Add(this.bytes256bits1);
			this.Name = "Form3";
			this.Text = "256biti";
			this.Load += new System.EventHandler(this.Form3Load);
			this.ResumeLayout(false);

		}
	}
}
