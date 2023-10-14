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

namespace FileIODemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreatDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\TestFolder";
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Directory already exists");

                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Directory Created");


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }

            //try
            //{
            //    string path = @"D:\TestFolder2";
            //    DirectoryInfo info = new DirectoryInfo(path);
            //    if (info.Exists)
            //    {
            //        MessageBox.Show("Directory already exists");

            //    }
            //    else
            //    {
            //        info.Create();
            //        MessageBox.Show("Created");

            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}


        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\TestFolder\Employee.dta";
                if (File.Exists(path))
                {
                    MessageBox.Show("File already Exists");


                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("File created");

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }

            //try
            //{
            //    string path = @"D:\TestFolder\Employee2.dta";
            //    FileInfo file = new FileInfo(path);
            //    if (file.Exists)
            //    {
            //        MessageBox.Show("File already exists");
            //    }
            //    else
            //    {
            //        file.Create();
            //        MessageBox.Show("File created");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}




        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\TestFolder\Employee.dta", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(txtId.Text));
                bw.Write(txtName.Text);
                bw.Write(Convert.ToDouble(txtSalary.Text));
                bw.Close();
                fs.Close();
                MessageBox.Show("Done");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\TestFolder\Employee.dta", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtId.Text = br.ReadInt32().ToString();
                txtName.Text = br.ReadString();
                txtSalary.Text = br.ReadDouble().ToString();
                br.Close();
                fs.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }

        }

        private void btnStreamWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\TestFolder\Employee.dta", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(richTextBox1.Text);
                sw.Close();
                fs.Close();
                MessageBox.Show("done");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }

        }

        private void btnStreamRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\TestFolder\Employee.dta", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
                fs.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }

        }
    }


        
    }

