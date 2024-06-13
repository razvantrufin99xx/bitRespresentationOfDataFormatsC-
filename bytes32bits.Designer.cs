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
	partial class bytes32bits
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private datarepresentinginbinary.bytes16 bytes161;
		private datarepresentinginbinary.bytes16 bytes162;
		
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
			this.bytes161 = new datarepresentinginbinary.bytes16();
			this.bytes162 = new datarepresentinginbinary.bytes16();
			this.SuspendLayout();
			// 
			// bytes161
			// 
			this.bytes161.Location = new System.Drawing.Point(3, 0);
			this.bytes161.Name = "bytes161";
			this.bytes161.Size = new System.Drawing.Size(802, 58);
			this.bytes161.TabIndex = 0;
			// 
			// bytes162
			// 
			this.bytes162.Location = new System.Drawing.Point(3, 43);
			this.bytes162.Name = "bytes162";
			this.bytes162.Size = new System.Drawing.Size(802, 58);
			this.bytes162.TabIndex = 1;
			// 
			// bytes32bits
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.bytes162);
			this.Controls.Add(this.bytes161);
			this.Name = "bytes32bits";
			this.Size = new System.Drawing.Size(946, 101);
			this.Load += new System.EventHandler(this.Bytes32bitsLoad);
			this.ResumeLayout(false);

		}
	}
}
