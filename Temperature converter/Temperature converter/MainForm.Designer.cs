/*
 * Created by SharpDevelop.
 * User: Salman-pc
 * Date: 11/09/2020
 * Time: 17:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Temperature_converter
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(13, 26);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(144, 24);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "0";
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "0";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"C",
			"F",
			"K",
			"R"});
			this.comboBox1.Location = new System.Drawing.Point(184, 28);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(52, 21);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox2SelectedIndexChanged);
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
			"C",
			"F",
			"K",
			"R"});
			this.comboBox2.Location = new System.Drawing.Point(184, 68);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(52, 21);
			this.comboBox2.TabIndex = 3;
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 112);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(56, 49);
			this.button1.TabIndex = 4;
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.ButtonClick);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(74, 112);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(56, 49);
			this.button2.TabIndex = 5;
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.ButtonClick);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(136, 112);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(56, 49);
			this.button3.TabIndex = 6;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.ButtonClick);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(12, 167);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(56, 49);
			this.button4.TabIndex = 7;
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.ButtonClick);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(12, 219);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(56, 49);
			this.button5.TabIndex = 8;
			this.button5.Text = "7";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.ButtonClick);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(74, 167);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(56, 49);
			this.button6.TabIndex = 9;
			this.button6.Text = "5";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.ButtonClick);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(136, 167);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(56, 49);
			this.button7.TabIndex = 10;
			this.button7.Text = "6";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.ButtonClick);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(74, 219);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(56, 49);
			this.button8.TabIndex = 11;
			this.button8.Text = "8";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.ButtonClick);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(136, 219);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(56, 49);
			this.button9.TabIndex = 12;
			this.button9.Text = "9";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.ButtonClick);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(198, 112);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(72, 30);
			this.button10.TabIndex = 13;
			this.button10.Text = "<-";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.Button10Click);
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(198, 148);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(72, 30);
			this.button11.TabIndex = 14;
			this.button11.Text = ".";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.Button11Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(282, 272);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Name = "MainForm";
			this.Text = "Temperature converter";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
