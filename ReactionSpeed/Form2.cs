using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ReactionSpeed
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string meanTimesVal)
        {
            InitializeComponent();
            txtMeanTime.Text = meanTimesVal;
        }

        bool fileExists = false;
        private void txtMeanTime_TextChanged(object sender, EventArgs e)
        {
            
        }

        public string createFile()
        {
            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string subFolder = System.IO.Path.Combine(path, "React");

            if (!Directory.Exists(subFolder))
            {
                System.IO.Directory.CreateDirectory(subFolder);
            }         
                string fileName = Path.Combine(subFolder, "ReactionSpeed.txt");

                if (!File.Exists(fileName))
                {
                    StreamWriter file = new StreamWriter(fileName);
                    file.WriteLine("Name ## Mean Speed ## Min/Max");
                    file.Close();  
                }
            MessageBox.Show("File created in Location: " + pathLocate());
            fileExists = true;
            return path + subFolder + fileName;                
        }

        public string pathLocate()
        {
            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string subFolder = System.IO.Path.Combine(path, "React");
            string fullPath = Path.Combine(subFolder, "ReactionSpeed.txt");
            return fullPath;
        }
        private void bttnSave_Click(object sender, EventArgs e)
        {
            if (fileExists != true)
            {
                createFile();
            }

            else
            {
                if (chkMax.Checked != true)
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(pathLocate(), true))
                    {
                        file.WriteLine(txtName.Text + " ## " + txtMeanTime.Text + " ## Minimized");
                    }
                }
                else
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(pathLocate(), true))
                    {
                        file.WriteLine(txtName.Text + " ## " + txtMeanTime.Text + " ## Maximized");
                    }
                }

            }
        }

        private void bttnOpen_Click(object sender, EventArgs e)
        {
            
            if (!File.Exists(pathLocate()))
            {
                createFile();
            }
            // Process.Start("notepad.exe", pathLocate());
            var fs = new FileStream(pathLocate(), FileMode.Open, FileAccess.Read);
            using (var sr = new StreamReader(fs))
            {
                Process.Start("notepad.exe", pathLocate());
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
