/*
 * Created by SharpDevelop.
 * User: Salman-pc
 * Date: 11/09/2020
 * Time: 17:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Temperature_converter
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
	
		public MainForm()
		{
			InitializeComponent();
			comboBox1.SelectedIndex = 0;
			comboBox2.SelectedIndex = 1;
			Count();
		}
	
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			try{
				Count();
			}catch(Exception f){
				textBox1.Text = "0";
			}
		}
		
		void ButtonClick(object sender, EventArgs e)
		{
			Button button = sender as Button;
			if(textBox1.Text == "0"){
				textBox1.Text = button.Text;
			}else{
				textBox1.Text = textBox1.Text + button.Text;
			}
		}
		
		//count method
		/**
		 * this method, is where all count process is processed
		 */
		private void Count()
		{
			Double result;
			Double temperature =  Convert.ToDouble(textBox1.Text);
			//Celcius to fahrenheit
			if(comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
			{
				result = temperature*1.8 + 32; //(0 °C × 9/5) + 32
				label1.Text =  result.ToString();
			}
			//celcius to kelvin
			else if(comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 2)
			{
				result = temperature + 273.15; //0 °C + 273,15 = 273,15 K
				label1.Text = result.ToString();
			}
			
			//fahrenhiet to celcius
			else if(comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
			{
				result = (temperature - 32) * 5/ 9 + 273.15; //(0 °F − 32) × 5/9 + 273,15
				label1.Text = result.ToString();
			}
			
			//fahrenheit to celcius
			else if(comboBox1.SelectedIndex ==  1 && comboBox2.SelectedIndex == 0)
			{
				result = (temperature - 32) * 5 / 9; //(24 °F − 32) × 5/9
				label1.Text =  result.ToString();
			}
			
			//kelvin to fahrenheit
			else if(comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 1)
			{
				result = temperature - 273.15 * 1.8 + 32; //(0 K − 273,15) × 9/5 + 32
				label1.Text = result.ToString();
			}
			
			//kelvin to celcius
			else if(comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 0)
			{
				result = temperature - 273.15;
				label1.Text = result.ToString();
			}
			
			//celius to reamur
			else if(comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 3)
			{
				result =  temperature * 0.8;
				label1.Text =  result.ToString();
			}
			//fahrenheit to reamur
			else if(comboBox1.SelectedIndex ==  1 && comboBox2.SelectedIndex == 3)
			{
				result = (temperature - 32)/2.25;
				label1.Text = result.ToString();
			}
			//kelvin to reamur
			else if(comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 3)
			{
				result = (temperature - 273.15) * 0.8;
				label1.Text = result.ToString();
			}
			//reamur to celcius
			else if(comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 0)
			{
				result = temperature * 1.25;
				label1.Text = result.ToString();
			}
			//reamur to fahrenheit
			else if(comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 1)
			{
				result = temperature * 2.25 + 32;
				label1.Text = result.ToString();
			}
			//reamur to kelvin
			else if(comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 2)
			{
				result =  temperature * 1.25 + 273.15;
				label1.Text = result.ToString();
			}
			else{
				label1.Text = textBox1.Text;
			}
		}
		void Button11Click(object sender, EventArgs e)
		{
			if (!textBox1.Text.Contains(".")){
				if(textBox1.Text == string.Empty){
        			textBox1.Text = "0.";
				}else{
        			textBox1.Text += ".";
				}
			}

		}
		void Button10Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
		}
		void ComboBox2SelectedIndexChanged(object sender, EventArgs e)
		{
			Count();
		}
	}
}
