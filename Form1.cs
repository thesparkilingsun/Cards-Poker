using System;

using System.Drawing;

using System.Windows.Forms;
using IronBarCode;

namespace BarCodeDesigner2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            errorLabel.Visible = false; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConvertImageToBarCode();
            textBox.Text = "";
        }

        private void ConvertImageToBarCode()
        {
            string data = textBox.Text.ToString();
            if(data.Length > 0)
            {
                errorLabel.Visible = false;
                var BarCode = BarcodeWriter.CreateBarcode(data, BarcodeEncoding.Code128);
                BarCode.SaveAsPng("BarCode.png");
                displayImage.ImageLocation = "G:/C#/BarCodeDesigner2/bin/Debug/BarCode.png";
            }
            else
            {
                errorLabel.Text = "Enter Input to convert";
                errorLabel.ForeColor = Color.Red;
                errorLabel.Visible = true;
            }
            
        }
    }
}
