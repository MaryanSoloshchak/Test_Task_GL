using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTask_GL.models;

namespace TestTask_GL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_serialize_Click(object sender, EventArgs e)
        { 
            folderBrowserDialog.Description = "Select folder to serialize";
            folderBrowserDialog.ShowDialog();
            DirectoryInfo directoryInfo = new DirectoryInfo(folderBrowserDialog.SelectedPath);
            saveFileDialog.InitialDirectory = folderBrowserDialog.SelectedPath;
            saveFileDialog.Title = "Choose file to serialize your directory";
            saveFileDialog.Filter = "Bin files (*.bin)|*.bin";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                label_notifications.Text = "Serializing directory. Please wait...";
                DirectorySerializer serializer = new DirectorySerializer();
                serializer.Serialize(folderBrowserDialog.SelectedPath, saveFileDialog.FileName);
                label_notifications.Text = string.Empty;
            }
        }

        private void button_desirialize_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Choose file to deserialize your directory";
            openFileDialog.Filter = "Bin files (*.bin)|*.bin";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    label_notifications.Text = "Deserializing directory. Please wait...";
                    DirectorySerializer serializer = new DirectorySerializer();
                    serializer.Deserialize(openFileDialog.FileName, folderBrowserDialog.SelectedPath);
                    label_notifications.Text = string.Empty;
                }
            }
        }

    }
}
