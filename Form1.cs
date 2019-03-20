using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace XoaTepTinTheoSoDong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                DirectoryInfo dinfo = new DirectoryInfo(folderDlg.SelectedPath);
                FileInfo[] Files = dinfo.GetFiles("*");
                Environment.SpecialFolder root = folderDlg.RootFolder;
                foreach (FileInfo file in Files)
                {
                    //  var path = new TestPath(file);
                    listBox1.Items.Add(file);
                    Soluongview1.Text = listBox1.Items.Count.ToString();
                }
                btnDeleteLine.Enabled = true;
            }
            else
                btnDeleteLine.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            FileInfo file = listBox1.SelectedItem as FileInfo;
           
            if (file != null)
            {
                string entry = file.FullName;
                string[] items = File.ReadAllLines(entry);
                foreach (string item in items)
                {
                    listBox3.Items.Add(item);

                }
            }
            else
            {
                for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);
                }
            }
            soluongview3.Text = listBox3.Items.Count.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //listBox1.SelectionMode = SelectionMode.MultiExtended;
        }
        public class TestPath
        {
            public FileInfo Original { get; private set; }

            public TestPath(FileInfo original)
            {
                Original = original;
            }

            public override string ToString()
            {
                return Path.GetFileNameWithoutExtension(Original.Name);
            }
        }

        private void btnDeleteLine_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = "";
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                   
                    listBox1.SetSelected(i, true);
                    FileInfo file = listBox1.SelectedItem as FileInfo;
                    string entry = file.FullName;
                    int dongmuonxoa = TotalLines(txtValue.Text.Trim(), entry);
                    List<string> lines = File.ReadAllLines(entry).ToList();
                    List<string> new1 = new List<string>();

                    for (int a = dongmuonxoa; a < lines.Count; a++)
                    {
                        string newlines = lines[a];
                        new1.Add(newlines);
                    }
                    if(checkBox1.Checked==true)
                    {
                        if(file.Extension==".T3"|| file.Extension == ".B3")
                        {
                            int vitribatdau = GetT82(new1);
                            int vitriden = GetT00(new1);

                          for(int c = vitriden-1;c>=vitribatdau;c--)
                            {
                                new1.RemoveAt(c);
                            }
                        }
                       
                    }
                    //listBox2.DataSource = new1;
                    //Du lieu la new1---------------->luu vao filePath

                    filePath = folderDlg.SelectedPath + @"\" + listBox1.SelectedItem.ToString();
                    StreamWriter objWriter = new StreamWriter(filePath);
                    for (int b = 0; b < new1.Count; b++)
                    {
                        objWriter.WriteLine(new1[b]);
                    }
                    objWriter.Close();

                    listBox1.SetSelected(i, false);
                }
                DirectoryInfo dinfo = new DirectoryInfo(folderDlg.SelectedPath);
                FileInfo[] Files = dinfo.GetFiles("*");
                Environment.SpecialFolder root = folderDlg.RootFolder;
                foreach (FileInfo file in Files)
                {
                    listBox2.Items.Add(file);
                    Soluongview2.Text = listBox1.Items.Count.ToString();
                }
                listBox2.SetSelected(0, true);
                MessageBox.Show("Finished!");
            }
        }
        int TotalLines(string valueline,string filePath)
        {
            int count =0;
            string[] lines = File.ReadAllLines(filePath);
            int linescounttotal = lines.Count();
            for (int i =0; i < linescounttotal; i++)
            {
                
                if (lines[i].Contains(valueline))
                {
                    count = i;
                    break;
                }
            }
            return count;
        }
        int GetT82(List<string> getT82)
        {
            int count = 0;
            for (int i = getT82.Count-1; i > 0; i--)
            {
                if (getT82[i].ToString()==txtVitrixoa.Text.ToUpper())
                {
                    count = i;
                    break;
                }
            }
            return count;
        }
        int GetT00(List<string> getT00)
        {
            int count = 0;
            for (int i = getT00.Count-1; i > 0; i--)
            {
                if (getT00[i].ToString() == txtDenvitri.Text.ToUpper())
                {
                    count = i;
                    break;
                }
            }
            return count;
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            listBox4.Items.Clear();
            listBox1.SetSelected(listBox2.SelectedIndex, true);
            if (listBox2.SelectedIndex >= 1)
            {
                listBox1.SetSelected(listBox2.SelectedIndex - 1, false);
                listBox1.SetSelected(listBox2.SelectedIndex, true);

            }
            FileInfo file = listBox2.SelectedItem as FileInfo;
            
            if (file != null)
            {
                string entry = file.FullName;
                string[] items = File.ReadAllLines(entry);
                foreach (string item in items)
                {
                    listBox4.Items.Add(item);
                    soluongview4.Text = listBox4.Items.Count.ToString();
                }
                soluongdelete.Text = (Convert.ToInt32(soluongview3.Text) - Convert.ToInt32(soluongview4.Text)).ToString();
            }
            else
            {
                for (int i = listBox2.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    listBox2.Items.RemoveAt(listBox2.SelectedIndices[i]);
                }
            }
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.SetSelected(listBox4.SelectedIndex + Convert.ToInt32(soluongdelete.Text), true);
            if (listBox4.SelectedIndex >= 1)
            {
                listBox3.SetSelected(listBox4.SelectedIndex + Convert.ToInt32(soluongdelete.Text) - 1, false);
                listBox3.SetSelected(listBox4.SelectedIndex + Convert.ToInt32(soluongdelete.Text), true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            soluongdelete.Text = null;
            Soluongview1.Text = null;
            Soluongview2.Text = null;
            soluongview3.Text = null;
            soluongview4.Text = null;
            btnDeleteLine.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
              checkBox1.Checked = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                if (string.IsNullOrEmpty(txtVitrixoa.Text) || string.IsNullOrEmpty(txtDenvitri.Text))
                {
                    MessageBox.Show("Chưa nhập vị trí cần xóa!");
                    checkBox1.Checked = false;
                }
            }
               
        }

        private void txtVitrixoa_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Checked = false;
            }
        }
    }
}
