using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Mini_Market_Management_System
{
    public partial class BarCodeScanner : Form
    {
        //Creating a collection for product
        DBConnect dBCon = new DBConnect();
        public BarCodeScanner()
        {
            InitializeComponent();
        }


        FilterInfoCollection filter;
        VideoCaptureDevice captureDevice;
        private void Form1_Load(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filter)
            comboBox_camera.Items.Add(filterInfo.Name);
            comboBox_camera.SelectedIndex = 0;
        }

        private void Display_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void barcode_exit_Click(object sender, EventArgs e)
        {
            if (captureDevice == null)
            {
                SellingForm selling = new SellingForm();
                selling.Show();
                this.Hide();
            }
            else if (captureDevice.IsRunning)
            {
                captureDevice.Stop();
                SellingForm selling = new SellingForm();
                selling.Show();
                this.Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox != null)
            {
                BarcodeReader barcode = new BarcodeReader();
                Result result = barcode.Decode((Bitmap)pictureBox.Image);
                if (result != null)
                {
                    textBox_display.Text = result.ToString();
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();

                }
            }
        }

        private void button_scan_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filter[comboBox_camera.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();

        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            pictureBox.Image = (Bitmap) eventArgs.Frame.Clone();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox_display.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string insertQuery = "INSERT INTO BarCode VALUES(" + textBox_display.Text + " )";
                    SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBCon.CloseCon();
                    captureDevice.Stop();
                    SellingForm selling = new SellingForm();
                    selling.Show();
                    this.Hide();
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
