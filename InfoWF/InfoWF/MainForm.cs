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
using System.Runtime.Serialization.Formatters.Binary;

namespace InfoWF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(this, "Exit?", "Закрытие программы", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //string writePath = @"C:\Users\Aqua\source\repos\InfoWF\ath.txt";                        
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog1.FileName);
                writer.Write(label1.Text+": ");
                writer.WriteLine(txbSurname.Text);
                writer.Write(label2.Text + ": ");
                writer.WriteLine(txbFirstname.Text);
                writer.Write(label3.Text + ": ");
                writer.WriteLine(txbPatronymic.Text);
                writer.Write(label4.Text + ": ");
                writer.WriteLine(txbGender.Text);
                writer.Write(label5.Text + ": ");
                writer.WriteLine(maskedtxbDate.Text);
                writer.Write(label6.Text + ": ");
                writer.WriteLine(cbFamily.Text);
                writer.Write(label7.Text + ": ");
                writer.WriteLine(txbInfo.Text);
                writer.Close();
            }
            //using (StreamWriter sw = new StreamWriter(filename))
            //    {                    
            //        sw.WriteLine(txbSurname.Text);
            //        sw.WriteLine(txbFirstname.Text);
            //        sw.WriteLine(txbPatronymic.Text);
            //        sw.WriteLine(txbGender.Text);
            //        sw.WriteLine(maskedtxbDate.Text);
            //        sw.WriteLine(cbFamily.Text);
            //        sw.WriteLine(txbInfo.Text);
            //    }

                //using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                //{
                //    sw.WriteLine("Дозапись");
                //    sw.Write(4.5);
                //}
           

            //if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            //    return;
            //получаем выбранный файл
            // string filename = saveFileDialog1.FileName;
            //сохраняем текст в файл
            //System.IO.File.WriteAllText(filename, textBox1.Text);
            //System.IO.File.WriteAllText(filename, textBox2.Text);
            //System.IO.File.WriteAllText(filename, textBox3.Text);
            //System.IO.File.WriteAllText(filename, textBox4.Text);
            //System.IO.File.WriteAllText(filename, maskedTextBox1.Text);
            //System.IO.File.WriteAllText(filename, comboBox1.SelectedText);
            //System.IO.File.WriteAllText(filename, textBox5.Text);
            MessageBox.Show(this,"Файл сохранен","Сохранение файла",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Очистить форму?", "Очистка формы", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
            {
                foreach (Control c in this.Controls)
                {
                    if (c.GetType() == typeof(TextBox))
                        c.Text = string.Empty;
                }
                maskedtxbDate.Text = string.Empty;
            }
            
        }
    }
}
