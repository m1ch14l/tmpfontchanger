using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMPFontChanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkFolder(txt_TMPlocation.Text);
            LoadFonts();
        }

        private void LoadFonts()
        {
            InstalledFontCollection installedFonts = new InstalledFontCollection();
            foreach (FontFamily fontFamily in installedFonts.Families)
            {
                cb_InstalledFonts.Items.Add(fontFamily.Name);
            }

            cb_InstalledFonts.SelectedIndex = 0;
        }

        private void cb_InstalledFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lbl_preview.Font = new Font(cb_InstalledFonts.SelectedItem.ToString(), this.lbl_preview.Font.Size);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string destinationFolder = txt_TMPlocation.Text + @"\data\shared\fonts";

            if (File.Exists(destinationFolder + "\\OpenSans.ttf"))
            {
                if (File.Exists(destinationFolder + "\\ORIGINAL_OpenSans.ttf"))
                {
                    File.Delete(destinationFolder + "\\OpenSans.ttf");
                }
                else
                {
                    File.Move(destinationFolder + "\\OpenSans.ttf", destinationFolder + "\\ORIGINAL_OpenSans.ttf");
                }
            }

            string font = GetSystemFontFileName(new Font(cb_InstalledFonts.SelectedItem.ToString(), this.lbl_preview.Font.Size));
            string source = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), font);
            string destination = Path.Combine(destinationFolder, font);

            File.Copy(source, destination);
            File.Move(destinationFolder + "\\" + font, destinationFolder + "\\OpenSans.ttf");
        }

        public static string GetSystemFontFileName(Font font)
        {
            RegistryKey fonts = null;
            try
            {
                fonts = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows NT\CurrentVersion\Fonts", false);
                if (fonts == null)
                {
                    fonts = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Fonts", false);
                    if (fonts == null)
                    {
                        throw new Exception("Can't find font registry database.");
                    }
                }
                string[] names = fonts.GetValueNames();
                StringBuilder nameb = new StringBuilder(font.Name);
                if (font.Bold)
                    nameb.Append(" Bold");
                if (font.Italic)
                    nameb.Append(" Italic");
                nameb.Append(" (TrueType)");
                string fullname = nameb.ToString();
                string basename = font.Name + " (TrueType)";
                object file = fonts.GetValue(fullname);
                if (file == null && fullname != basename)
                {
                    file = fonts.GetValue(basename);
                }
                if (file != null) return file.ToString();
                return null;
            }
            finally
            {
                if (fonts != null)
                {
                    fonts.Dispose();
                }
            }
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                checkFolder(folderBrowserDialog1.SelectedPath);
            }
        }

        private void checkFolder(string location)
        {
            if (!Directory.Exists(location + "\\data"))
            {
                txt_TMPlocation.Text = "WRONG FOLDER, CHECK AGAIN!";
                txt_TMPlocation.ForeColor = Color.Red;

                btn_copy.Enabled = false;
            }
            else
            {
                txt_TMPlocation.Text = location;
                txt_TMPlocation.ForeColor = Color.Black;
                btn_copy.Enabled = true;
            }
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            string destinationFolder = txt_TMPlocation.Text + @"\data\shared\fonts";
            if(File.Exists(destinationFolder + "\\OpenSans.ttf"))
            {
                File.Delete(destinationFolder + "\\OpenSans.ttf");
                if(File.Exists(destinationFolder + "\\ORIGINAL_OpenSans.ttf"))
                {
                    File.Move(destinationFolder + "\\ORIGINAL_OpenSans.ttf", destinationFolder + "\\OpenSans.ttf");
                }
            }
        }
    }
}
