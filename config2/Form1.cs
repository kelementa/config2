using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace config2
{
    public partial class Form1 : Form
    {

       

        // OK
        private string openDialog()
        {
            DialogResult res = folderBrowserDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                return folderBrowserDialog1.SelectedPath;
            }
            else
            {
                return "";
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            txtPath.Clear();
            cbIniList.Items.Clear();
            cbIniList.Text = "";
            lblSerial.Text = "-";
            lblType.Text = "-";
            folderBrowserDialog1.SelectedPath = @"C:\ProgramData\3DHISTECH\SlideScanner\";
            String pathOfConfigFiles = openDialog();
            if (!string.IsNullOrEmpty(pathOfConfigFiles))
            {
                if ( renameFiles(Directory.GetFiles(@pathOfConfigFiles, "MicroscopeConfiguration*")) == 0)
                {
                    // if the renaming was successful
                    txtPath.Text = pathOfConfigFiles;
                    cbIniList.Items.Clear();
                    cbIniList.Items.AddRange(listOfIniFiles(pathOfConfigFiles));
                    btnActivate.Enabled = true;
                }
                //richTextBox1.AppendText("rename: " + renameFiles(Directory.GetFiles(@pathOfConfigFiles, "MicroscopeConfiguration*")) + "\n");
               
            }
        }

        /* OK
         
            usage: 
            
        */ 
        public int renameFiles(String[] pathOfDirectoryWithIni)
        {
            int result = -1;
            if (pathOfDirectoryWithIni.Length > 0)
            {
                for (int i = 0; i < pathOfDirectoryWithIni.Length; i++)
                {
                    try
                    {
                        INIFile ini = new INIFile(pathOfDirectoryWithIni[i]);
                        string serial = ini.IniReadValue("Microscope", "SerialNumber");
                        string type = ini.IniReadValue("Microscope", "MicroscopeType");
                        File.Move(pathOfDirectoryWithIni[i], Path.GetDirectoryName(pathOfDirectoryWithIni[i]) + "\\MicroscopeConfiguration-" + serial + ".ini");
                        //richTextBox1.AppendText("Rename " + pathOfDirectoryWithIni[i] + 
                        //    " to: " + Path.GetDirectoryName(pathOfDirectoryWithIni[i]) + "\\MicroscopeConfiguration-" + serial + ".ini\n");
                        result = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            return result;
        }

        public String[] listOfIniFiles(String path)
        {
            String[] list = new string[] { };
            try
            {
                list = Directory.GetFiles(@path, "MicroscopeConfiguration*");
                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return list;
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (cbIniList.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an INI file to activate!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // rename to...
                try
                {
                    //richTextBox1.AppendText("from: " + cbIniList.Text + " to: " + @Path.GetDirectoryName(cbIniList.Text) + @"\MicroscopeConfiguration.ini" + "\n");
                    File.Move(cbIniList.Text, @Path.GetDirectoryName(cbIniList.Text) + @"\MicroscopeConfiguration.ini");
                    MessageBox.Show("Renaming the selected config file\n was successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnActivate.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //richTextBox1.AppendText("renameing to: " + @Path.GetDirectoryName(cbIniList.Text) + @"\MicroscopeConfiguration.ini" + "\n");
            }
        }

        private void cbIniList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                INIFile ini = new INIFile(cbIniList.Text);
                string serial = ini.IniReadValue("Microscope", "SerialNumber");
                string type = ini.IniReadValue("Microscope", "MicroscopeType");
                lblSerial.Text = serial;
                lblType.Text = type;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //richTextBox1.AppendText(cbIniList.Text + "\n");
        }
    }
}
