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
	partial class bytes64bits
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private datarepresentinginbinary.bytes32bits bytes32bits1;
		private datarepresentinginbinary.bytes32bits bytes32bits2;
		
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
			this.bytes32bits1 = new datarepresentinginbinary.bytes32bits();
			this.bytes32bits2 = new datarepresentinginbinary.bytes32bits();
			this.SuspendLayout();
			// 
			// bytes32bits1
			// 
			this.bytes32bits1.Location = new System.Drawing.Point(4, 13);
			this.bytes32bits1.Name = "bytes32bits1";
			this.bytes32bits1.Size = new System.Drawing.Size(946, 101);
			this.bytes32bits1.TabIndex = 0;
			// 
			// bytes32bits2
			// 
			this.bytes32bits2.Location = new System.Drawing.Point(4, 107);
			this.bytes32bits2.Name = "bytes32bits2";
			this.bytes32bits2.Size = new System.Drawing.Size(946, 101);
			this.bytes32bits2.TabIndex = 1;
			// 
			// bytes64bits
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.bytes32bits2);
			this.Controls.Add(this.bytes32bits1);
			this.Name = "bytes64bits";
			this.Size = new System.Drawing.Size(826, 220);
			this.Load += new System.EventHandler(this.Bytes64bitsLoad);
			this.ResumeLayout(false);

		}
	}
}
