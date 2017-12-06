using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PsdLayersNameCorrector
{
    public partial class MainForm : Form
    {

        private string dirName = "";

        public string DirName
        {
            get { return dirName; }
            private set { dirName = value; }
        }
        

        public MainForm()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources._1;
        }

        private void b_select_dir_Click(object sender, EventArgs e)
        {
            tb_logs.Clear();
            if (fbd_open_dir.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dirName = fbd_open_dir.SelectedPath;
                l_dir_name.Text = dirName;
                tb_logs.Text += "Папка выбрана\n\n";
            }
        }

        private void b_start_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(dirName))
            {
                pictureBox1.Image = Properties.Resources._3;
                Regex regex = new Regex(@"^_\d*_");
                Directory.CreateDirectory(dirName + "\\new");
                string newDir = fbd_open_dir.SelectedPath + "\\new";
                string[] filePaths = Directory.GetFiles(dirName);
                StringBuilder sb = new StringBuilder();
                sb.Clear();
                sb.Append("Переименованные файлы:");
                sb.Append(Environment.NewLine);
                sb.Append(Environment.NewLine);
                foreach (string fp in filePaths)
                {
                    string shortName = Path.GetFileName(fp);
                    Match newMatch = regex.Match(shortName);
                    StringBuilder sbNew = new StringBuilder();
                    if (newMatch.Success)
                    {
                        string newName = shortName.Replace(newMatch.Value, "");
                        sbNew.Append(newDir);
                        sbNew.Append("\\");
                        sbNew.Append(newName);
                        sb.Append(shortName.PadRight(33, ' '));
                        sb.Append(" => ");
                        sb.Append(newName);
                        sb.Append(Environment.NewLine);
                        File.Copy(fp, sbNew.ToString(), true);
                    }
                }
                sb.Append(Environment.NewLine);
                sb.Append("Переименование завершено!");
                tb_logs.Text += sb.ToString();
            }
            else
            {
                pictureBox1.Image = Properties.Resources._3;
                //MessageBox.Show("Файл не выбран! Выберите файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
