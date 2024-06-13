/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 6/13/2024
 * Time: 12:46 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace datarepresentinginbinary
{
	partial class bytes16
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public datarepresentinginbinary.byte8bits byte8bits1;
		public datarepresentinginbinary.byte8bits byte8bits2;
		
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
			this.byte8bits1 = new datarepresentinginbinary.byte8bits();
			this.byte8bits2 = new datarepresentinginbinary.byte8bits();
			this.SuspendLayout();
			// 
			// byte8bits1
			// 
			this.byte8bits1.Location = new System.Drawing.Point(18, 4);
			this.byte8bits1.Name = "byte8bits1";
			this.byte8bits1.Size = new System.Drawing.Size(374, 44);
			this.byte8bits1.TabIndex = 0;
			// 
			// byte8bits2
			// 
			this.byte8bits2.Location = new System.Drawing.Point(408, 4);
			this.byte8bits2.Name = "byte8bits2";
			this.byte8bits2.Size = new System.Drawing.Size(374, 44);
			this.byte8bits2.TabIndex = 1;
			// 
			// bytes16
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.byte8bits2);
			this.Controls.Add(this.byte8bits1);
			this.Name = "bytes16";
			this.Size = new System.Drawing.Size(802, 58);
			this.Load += new System.EventHandler(this.Bytes16Load);
			this.ResumeLayout(false);

		}
	}
}
