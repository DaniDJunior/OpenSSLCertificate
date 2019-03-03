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

namespace OpenSSLCertificate
{
    public partial class frmMain : Form
    {

        private string StartFolder = string.Empty;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txt_folder.Text = System.Reflection.Assembly.GetExecutingAssembly().Location.Replace(@"\OpenSSLCertificate.exe",string.Empty);
            folder_browser_dialog.SelectedPath = txt_folder.Text;
            StartFolder = txt_folder.Text;
        }

        private void btn_folder_Click(object sender, EventArgs e)
        {
            if(folder_browser_dialog.ShowDialog() == DialogResult.OK)
            {
                txt_folder.Text = folder_browser_dialog.SelectedPath;
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (File.Exists(StartFolder + "\\temp.rsa.key.pem"))
            {
                File.Delete(StartFolder + "\\temp.rsa.key.pem");
            }
            if (File.Exists(StartFolder + "\\temp.key.pem"))
            {
                File.Delete(StartFolder + "\\temp.key.pem");
            }
            if (File.Exists(StartFolder + "\\temp.cert.pem"))
            {
                File.Delete(StartFolder + "\\temp.cert.pem");
            }
            if (string.IsNullOrEmpty(txt_service_account_name.Text))
            {
                MessageBox.Show("service_account_name is not empty");
                return;
            }
            if (string.IsNullOrEmpty(txt_tenant_id.Text))
            {
                MessageBox.Show("tenant_id is not empty");
                return;
            }
            if (string.IsNullOrEmpty(txt_days.Text))
            {
                MessageBox.Show("days is not empty");
                return;
            }
            int days = 0;
            if (!int.TryParse(txt_days.Text, out days))
            {
                MessageBox.Show("days is a number");
                return;
            }
            string parameters = "req -x509 -new -nodes -sha1 -days " + txt_days.Text + " -newkey rsa:2048 -subj \"/CN=" + txt_service_account_name.Text + "@" + txt_tenant_id.Text + ".acesso.io\" -keyout \"" + StartFolder + "\\temp.rsa.key.pem\" -out \"" + StartFolder + "\\temp.cert.pem\" -config \"" + StartFolder + "\\openssl_idp.cnf\"";
            System.Diagnostics.Process.Start(StartFolder + @"\openssl.exe", parameters);
            System.Threading.Thread.Sleep(6000);
            parameters = "pkcs8 -topk8 -inform pem -in \"" + StartFolder + "\\temp.rsa.key.pem\" -outform pem -nocrypt -out \"" + StartFolder + "\\temp.key.pem\"";
            System.Diagnostics.Process.Start(StartFolder + "\\openssl.exe", parameters);
            System.Threading.Thread.Sleep(5000);
            if (File.Exists(StartFolder + "\\temp.rsa.key.pem"))
            {
                StreamReader sr = new StreamReader(StartFolder + "\\temp.rsa.key.pem");
                txt_private_token_rsa.Text = sr.ReadToEnd().Replace("-----BEGIN RSA PRIVATE KEY-----", string.Empty).Replace("-----END RSA PRIVATE KEY-----", string.Empty);
                sr.Close();
                File.Copy(StartFolder + "\\temp.rsa.key.pem", txt_folder.Text + "\\" + txt_service_account_name.Text + ".rsa.key.pem");
                File.Delete(StartFolder + "\\temp.rsa.key.pem");
            }
            if (File.Exists(StartFolder + "\\temp.key.pem"))
            {
                StreamReader sr = new StreamReader(StartFolder + "\\temp.key.pem");
                txt_private_token.Text = sr.ReadToEnd().Replace("-----BEGIN PRIVATE KEY-----", string.Empty).Replace("-----END PRIVATE KEY-----", string.Empty);
                sr.Close();
                File.Copy(StartFolder + "\\temp.key.pem", txt_folder.Text + "\\" + txt_service_account_name.Text + ".key.pem");
                File.Delete(StartFolder + "\\temp.key.pem");
            }
            if (File.Exists(StartFolder + "\\temp.cert.pem"))
            {
                StreamReader sr = new StreamReader(StartFolder + "\\temp.cert.pem");
                txt_public_token.Text = sr.ReadToEnd().Replace("-----BEGIN CERTIFICATE-----", string.Empty).Replace("-----END CERTIFICATE-----", string.Empty);
                sr.Close();
                File.Copy(StartFolder + "\\temp.cert.pem", txt_folder.Text + "\\" + txt_service_account_name.Text + ".cert.pem");
                File.Delete(StartFolder + "\\temp.cert.pem");
            }
        }

        private void btn_tenant_id_Click(object sender, EventArgs e)
        {
            txt_tenant_id.Text = Guid.NewGuid().ToString();

        }
    }
}
