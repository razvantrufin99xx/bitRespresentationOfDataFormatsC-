/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 6/13/2024
 * Time: 12:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace datarepresentinginbinary
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private datarepresentinginbinary.bit1 bit11;
		private datarepresentinginbinary.bytes16 bytes161;
		private datarepresentinginbinary.bit2 bit21;
		private datarepresentinginbinary.bit3 bit31;
		private datarepresentinginbinary.bit4 bit41;
		private datarepresentinginbinary.byte8bits byte8bits1;
		private datarepresentinginbinary.bytes32bits bytes32bits1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Button button9;
		
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
			this.bit11 = new datarepresentinginbinary.bit1();
			this.bytes161 = new datarepresentinginbinary.bytes16();
			this.bit21 = new datarepresentinginbinary.bit2();
			this.bit31 = new datarepresentinginbinary.bit3();
			this.bit41 = new datarepresentinginbinary.bit4();
			this.byte8bits1 = new datarepresentinginbinary.byte8bits();
			this.bytes32bits1 = new datarepresentinginbinary.bytes32bits();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button5 = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.button6 = new System.Windows.Forms.Button();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.button7 = new System.Windows.Forms.Button();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.button8 = new System.Windows.Forms.Button();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.button9 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// bit11
			// 
			this.bit11.BackColor = System.Drawing.Color.Red;
			this.bit11.Location = new System.Drawing.Point(179, 28);
			this.bit11.Name = "bit11";
			this.bit11.Size = new System.Drawing.Size(38, 32);
			this.bit11.TabIndex = 0;
			// 
			// bytes161
			// 
			this.bytes161.Location = new System.Drawing.Point(163, 439);
			this.bytes161.Name = "bytes161";
			this.bytes161.Size = new System.Drawing.Size(802, 58);
			this.bytes161.TabIndex = 1;
			// 
			// bit21
			// 
			this.bit21.Location = new System.Drawing.Point(179, 104);
			this.bit21.Name = "bit21";
			this.bit21.Size = new System.Drawing.Size(88, 32);
			this.bit21.TabIndex = 2;
			// 
			// bit31
			// 
			this.bit31.Location = new System.Drawing.Point(179, 184);
			this.bit31.Name = "bit31";
			this.bit31.Size = new System.Drawing.Size(142, 38);
			this.bit31.TabIndex = 3;
			// 
			// bit41
			// 
			this.bit41.Location = new System.Drawing.Point(179, 260);
			this.bit41.Name = "bit41";
			this.bit41.Size = new System.Drawing.Size(184, 44);
			this.bit41.TabIndex = 4;
			// 
			// byte8bits1
			// 
			this.byte8bits1.Location = new System.Drawing.Point(179, 343);
			this.byte8bits1.Name = "byte8bits1";
			this.byte8bits1.Size = new System.Drawing.Size(374, 44);
			this.byte8bits1.TabIndex = 5;
			// 
			// bytes32bits1
			// 
			this.bytes32bits1.Location = new System.Drawing.Point(163, 517);
			this.bytes32bits1.Name = "bytes32bits1";
			this.bytes32bits1.Size = new System.Drawing.Size(946, 101);
			this.bytes32bits1.TabIndex = 6;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1297, 28);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "load form2";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(1297, 57);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 8;
			this.button2.Text = "load form3";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(423, 25);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 9;
			this.button3.Text = "1bit";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(375, 28);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(42, 20);
			this.textBox1.TabIndex = 10;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(461, 110);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 11;
			this.button4.Text = "2bits";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(411, 113);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(44, 20);
			this.textBox2.TabIndex = 12;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(447, 202);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(72, 20);
			this.textBox3.TabIndex = 14;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(525, 202);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 13;
			this.button5.Text = "3bits";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(492, 281);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(108, 20);
			this.textBox4.TabIndex = 16;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(606, 281);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(129, 23);
			this.button6.TabIndex = 15;
			this.button6.Text = "quadbits 4bits";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(632, 361);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(230, 20);
			this.textBox5.TabIndex = 18;
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(787, 332);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 23);
			this.button7.TabIndex = 17;
			this.button7.Text = "word 8bits";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(1021, 455);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(402, 20);
			this.textBox6.TabIndex = 20;
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(1248, 426);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(175, 23);
			this.button8.TabIndex = 19;
			this.button8.Text = "doublword 16bits";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(1021, 579);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(402, 20);
			this.textBox7.TabIndex = 22;
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(1248, 550);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(175, 23);
			this.button9.TabIndex = 21;
			this.button9.Text = "quad word 32 bits";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.Button9Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1823, 1061);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.bytes32bits1);
			this.Controls.Add(this.byte8bits1);
			this.Controls.Add(this.bit41);
			this.Controls.Add(this.bit31);
			this.Controls.Add(this.bit21);
			this.Controls.Add(this.bytes161);
			this.Controls.Add(this.bit11);
			this.Name = "MainForm";
			this.Text = "datarepresentinginbinary 1 2 3 4 8 16 32 biti";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
