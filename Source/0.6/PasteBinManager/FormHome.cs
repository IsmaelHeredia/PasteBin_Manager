// Pastebin Manager 0.6
// © Ismael Heredia , Argentina , 2017

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Text.RegularExpressions;
using System.Net;

namespace PasteBinManager
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        public void get_files()
        {

            lvFilesDownloaded.Items.Clear();
            lbFilesDownloaded.Items.Clear();

            string[] archivos = Directory.GetFiles(Directory.GetCurrentDirectory());
            foreach (string archivo in archivos)
            {
                if (Path.GetExtension(archivo) == ".txt")
                {
                    lbFilesDownloaded.Items.Add(archivo);
                    FileInfo basename = new FileInfo(archivo);
                    string nombre = basename.Name;

                    ListViewItem agregar = new ListViewItem();
                    agregar.Text = nombre;
                    FileInfo info = new FileInfo(nombre);
                    DateTime cuando = info.CreationTime;
                    agregar.SubItems.Add(Convert.ToString(cuando));

                    lvFilesDownloaded.Items.Add(agregar);
                }
            }

            gbFilesDownloaded.Text = "Files found [" + lbFilesDownloaded.Items.Count + "]";

        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            cmbType.SelectedIndex = 0;

            if (!Directory.Exists("downloads"))
            {
                System.IO.Directory.CreateDirectory("downloads");
                Directory.SetCurrentDirectory("downloads");
            }
            else
            {
                Directory.SetCurrentDirectory("downloads");
            }

            get_files();

            SoundPlayer sound1 = new SoundPlayer(PasteBinManager.Properties.Resources.formcreate);
            sound1.Play();
        }

        public void crear_archivo(string nombre, string contenido)
        {
            try
            {
                System.IO.StreamWriter archivo = new System.IO.StreamWriter(nombre, true);
                archivo.Write(contenido);
                archivo.Close();
            }
            catch
            {
                //
            }
        }

        private void txtEnterFile_DragDrop(object sender, DragEventArgs e)
        {
            List<string> archivos = new List<string>((string[])e.Data.GetData(DataFormats.FileDrop));
            txtEnterFile.Lines = archivos.ToArray();
        }

        private void txtEnterFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(PasteBinManager.Properties.Resources.click);
            sound1.Play();

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            DialogResult archivo = openFileDialog1.ShowDialog();
            if (archivo == DialogResult.OK)
            {
                txtEnterFile.Text = openFileDialog1.FileName;
            }
        }

        private void btnCopyResult_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(PasteBinManager.Properties.Resources.click);
            sound1.Play();
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(txtResult.Text);
            }
            catch
            {
                //
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(PasteBinManager.Properties.Resources.click);
            sound1.Play();
            string link = "http://pastebin.com/api/api_post.php";
            string ruta_archivo = txtEnterFile.Text;
            string nombre_archivo = Path.GetFileName(ruta_archivo);
            nombre_archivo = nombre_archivo.Replace(Path.GetExtension(nombre_archivo), "");
            string paste_code = System.IO.File.ReadAllText(ruta_archivo);
            string paste_name = nombre_archivo;
            string api_key = "f88f9b3578203ac7a2585ee7bdf61dc5";
            string paste_format = "";

            if (rbUseThis1.Checked)
            {
                paste_format = cmbType.Text;
            }
            else
            {
                paste_format = txtUseThis.Text;
            }

            string parametros = "api_dev_key=" + api_key + "&api_option=paste&api_paste_name=" + paste_name + "&api_paste_code=" + paste_code + "&api_paste_private=0&api_paste_expire_date=N";
            string resultado = "";

            HttpWebRequest request_post = (HttpWebRequest)
            WebRequest.Create(link);

            request_post.UserAgent = "Opera/9.80 (Windows NT 6.0) Presto/2.12.388 Version/12.14";
            request_post.Method = "POST";
            request_post.ContentType = "application/x-www-form-urlencoded";

            Stream notengoidea = request_post.GetRequestStream();

            notengoidea.Write(Encoding.ASCII.GetBytes(parametros), 0, Encoding.ASCII.GetBytes(parametros).Length);
            notengoidea.Close();

            StreamReader notengoidea2 = new StreamReader(request_post.GetResponse().GetResponseStream());
            resultado = notengoidea2.ReadToEnd();

            SoundPlayer sound2 = new SoundPlayer(PasteBinManager.Properties.Resources.scanfin);
            sound2.Play();

            if (resultado.StartsWith("http"))
            {
                txtResult.Text = resultado;
                MessageBox.Show("File uploaded");
            }
            else
            {
                MessageBox.Show("Error in the uploader");
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(PasteBinManager.Properties.Resources.click);
            sound1.Play();
            WebClient web = new WebClient();
            web.Headers["User-Agent"] = "Opera/9.80 (Windows NT 6.0) Presto/2.12.388 Version/12.14";
            string codigofuente = web.DownloadString(txtEnterPage.Text + "/" + txtPages.Text);

            List<string> ids = new List<string> { };
            List<string> titulos = new List<string> { };
            List<string> links = new List<string> { };

            Match search = Regex.Match(codigofuente, "class=(.*) title=(.*) alt=(.*) /> <a href=\"/(.*)\">(.*)</a></td>", RegexOptions.IgnoreCase);
            while (search.Success)
            {
                string id = search.Groups[4].Value;
                string titulo = search.Groups[5].Value;
                titulo = titulo.Replace("[", "-");
                titulo = titulo.Replace("]", "-");
                string link = "http://pastebin.com/raw.php?i=" + id;
                ids.Add(id);
                titulos.Add(titulo);
                links.Add(link);
                search = search.NextMatch();
            }

            for (int i = 0; i < ids.Count; i++)
            {
                status.Text = "[+] Downloading : " + titulos[i];
                this.Refresh();
                mmOutput.AppendText("[+] Downloaded : " + ids[i] + "\n");
                crear_archivo(titulos[i] + ".txt", web.DownloadString(links[i]));
            }

            status.Text = "[+] Done";
            this.Refresh();

            SoundPlayer sound2 = new SoundPlayer(PasteBinManager.Properties.Resources.scanfin);
            sound2.Play();
        }

        private void LoadFileDownloaded_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(PasteBinManager.Properties.Resources.click);
            sound1.Play();
            if (lbFilesDownloaded.Items.Count == 0)
            {
                MessageBox.Show("Error");
            }
            else
            {
                string ponecarajo = lbFilesDownloaded.Items[lvFilesDownloaded.FocusedItem.Index].ToString();
                System.Diagnostics.Process.Start(ponecarajo);
            }
        }

        private void OpenFolderDownloaded_Click(object sender, EventArgs e)
        {
            string ponecarajo = Directory.GetCurrentDirectory();
            System.Diagnostics.Process.Start(ponecarajo);
        }

        private void lblCopyRight_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://ismaelheredia123.wordpress.com");
        }

    }
}
