namespace OpenSSLCertificate
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_create = new System.Windows.Forms.Button();
            this.lbl_service_account_name = new System.Windows.Forms.Label();
            this.txt_service_account_name = new System.Windows.Forms.TextBox();
            this.txt_tenant_id = new System.Windows.Forms.TextBox();
            this.lbl_tenant_id = new System.Windows.Forms.Label();
            this.txt_folder = new System.Windows.Forms.TextBox();
            this.lbl_folder = new System.Windows.Forms.Label();
            this.btn_folder = new System.Windows.Forms.Button();
            this.folder_browser_dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_tenant_id = new System.Windows.Forms.Button();
            this.txt_days = new System.Windows.Forms.TextBox();
            this.lbl_days = new System.Windows.Forms.Label();
            this.lbl_private_token_rsa = new System.Windows.Forms.Label();
            this.txt_private_token_rsa = new System.Windows.Forms.TextBox();
            this.txt_public_token = new System.Windows.Forms.TextBox();
            this.lbl_public_token = new System.Windows.Forms.Label();
            this.txt_private_token = new System.Windows.Forms.TextBox();
            this.lbl_private_token = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_create
            // 
            this.btn_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.Location = new System.Drawing.Point(488, 135);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(97, 36);
            this.btn_create.TabIndex = 0;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // lbl_service_account_name
            // 
            this.lbl_service_account_name.AutoSize = true;
            this.lbl_service_account_name.Location = new System.Drawing.Point(12, 9);
            this.lbl_service_account_name.Name = "lbl_service_account_name";
            this.lbl_service_account_name.Size = new System.Drawing.Size(118, 13);
            this.lbl_service_account_name.TabIndex = 1;
            this.lbl_service_account_name.Text = "service_account_name";
            // 
            // txt_service_account_name
            // 
            this.txt_service_account_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_service_account_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_service_account_name.Location = new System.Drawing.Point(15, 25);
            this.txt_service_account_name.Name = "txt_service_account_name";
            this.txt_service_account_name.Size = new System.Drawing.Size(484, 22);
            this.txt_service_account_name.TabIndex = 2;
            // 
            // txt_tenant_id
            // 
            this.txt_tenant_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tenant_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenant_id.Location = new System.Drawing.Point(15, 66);
            this.txt_tenant_id.Name = "txt_tenant_id";
            this.txt_tenant_id.Size = new System.Drawing.Size(511, 22);
            this.txt_tenant_id.TabIndex = 4;
            // 
            // lbl_tenant_id
            // 
            this.lbl_tenant_id.AutoSize = true;
            this.lbl_tenant_id.Location = new System.Drawing.Point(12, 50);
            this.lbl_tenant_id.Name = "lbl_tenant_id";
            this.lbl_tenant_id.Size = new System.Drawing.Size(51, 13);
            this.lbl_tenant_id.TabIndex = 3;
            this.lbl_tenant_id.Text = "tenant_id";
            // 
            // txt_folder
            // 
            this.txt_folder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_folder.Location = new System.Drawing.Point(15, 107);
            this.txt_folder.Name = "txt_folder";
            this.txt_folder.Size = new System.Drawing.Size(511, 22);
            this.txt_folder.TabIndex = 6;
            // 
            // lbl_folder
            // 
            this.lbl_folder.AutoSize = true;
            this.lbl_folder.Location = new System.Drawing.Point(12, 91);
            this.lbl_folder.Name = "lbl_folder";
            this.lbl_folder.Size = new System.Drawing.Size(68, 13);
            this.lbl_folder.TabIndex = 5;
            this.lbl_folder.Text = "Output folder";
            // 
            // btn_folder
            // 
            this.btn_folder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_folder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_folder.Location = new System.Drawing.Point(525, 107);
            this.btn_folder.Name = "btn_folder";
            this.btn_folder.Size = new System.Drawing.Size(60, 22);
            this.btn_folder.TabIndex = 7;
            this.btn_folder.Text = "folder";
            this.btn_folder.UseVisualStyleBackColor = true;
            this.btn_folder.Click += new System.EventHandler(this.btn_folder_Click);
            // 
            // btn_tenant_id
            // 
            this.btn_tenant_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_tenant_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tenant_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tenant_id.Location = new System.Drawing.Point(525, 66);
            this.btn_tenant_id.Name = "btn_tenant_id";
            this.btn_tenant_id.Size = new System.Drawing.Size(60, 22);
            this.btn_tenant_id.TabIndex = 8;
            this.btn_tenant_id.Text = "new";
            this.btn_tenant_id.UseVisualStyleBackColor = true;
            this.btn_tenant_id.Click += new System.EventHandler(this.btn_tenant_id_Click);
            // 
            // txt_days
            // 
            this.txt_days.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_days.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_days.Location = new System.Drawing.Point(505, 25);
            this.txt_days.Name = "txt_days";
            this.txt_days.Size = new System.Drawing.Size(80, 22);
            this.txt_days.TabIndex = 10;
            this.txt_days.Text = "730";
            // 
            // lbl_days
            // 
            this.lbl_days.AutoSize = true;
            this.lbl_days.Location = new System.Drawing.Point(502, 9);
            this.lbl_days.Name = "lbl_days";
            this.lbl_days.Size = new System.Drawing.Size(29, 13);
            this.lbl_days.TabIndex = 9;
            this.lbl_days.Text = "days";
            // 
            // lbl_private_token_rsa
            // 
            this.lbl_private_token_rsa.AutoSize = true;
            this.lbl_private_token_rsa.Location = new System.Drawing.Point(12, 174);
            this.lbl_private_token_rsa.Name = "lbl_private_token_rsa";
            this.lbl_private_token_rsa.Size = new System.Drawing.Size(99, 13);
            this.lbl_private_token_rsa.TabIndex = 11;
            this.lbl_private_token_rsa.Text = "Private Token RSA";
            // 
            // txt_private_token_rsa
            // 
            this.txt_private_token_rsa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_private_token_rsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_private_token_rsa.Location = new System.Drawing.Point(12, 190);
            this.txt_private_token_rsa.Name = "txt_private_token_rsa";
            this.txt_private_token_rsa.Size = new System.Drawing.Size(573, 22);
            this.txt_private_token_rsa.TabIndex = 12;
            // 
            // txt_public_token
            // 
            this.txt_public_token.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_public_token.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_public_token.Location = new System.Drawing.Point(12, 272);
            this.txt_public_token.Name = "txt_public_token";
            this.txt_public_token.Size = new System.Drawing.Size(573, 22);
            this.txt_public_token.TabIndex = 14;
            // 
            // lbl_public_token
            // 
            this.lbl_public_token.AutoSize = true;
            this.lbl_public_token.Location = new System.Drawing.Point(12, 256);
            this.lbl_public_token.Name = "lbl_public_token";
            this.lbl_public_token.Size = new System.Drawing.Size(70, 13);
            this.lbl_public_token.TabIndex = 13;
            this.lbl_public_token.Text = "Public Token";
            // 
            // txt_private_token
            // 
            this.txt_private_token.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_private_token.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_private_token.Location = new System.Drawing.Point(12, 231);
            this.txt_private_token.Name = "txt_private_token";
            this.txt_private_token.Size = new System.Drawing.Size(573, 22);
            this.txt_private_token.TabIndex = 16;
            // 
            // lbl_private_token
            // 
            this.lbl_private_token.AutoSize = true;
            this.lbl_private_token.Location = new System.Drawing.Point(12, 215);
            this.lbl_private_token.Name = "lbl_private_token";
            this.lbl_private_token.Size = new System.Drawing.Size(74, 13);
            this.lbl_private_token.TabIndex = 15;
            this.lbl_private_token.Text = "Private Token";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 310);
            this.Controls.Add(this.txt_private_token);
            this.Controls.Add(this.lbl_private_token);
            this.Controls.Add(this.txt_public_token);
            this.Controls.Add(this.lbl_public_token);
            this.Controls.Add(this.txt_private_token_rsa);
            this.Controls.Add(this.lbl_private_token_rsa);
            this.Controls.Add(this.txt_days);
            this.Controls.Add(this.lbl_days);
            this.Controls.Add(this.btn_tenant_id);
            this.Controls.Add(this.btn_folder);
            this.Controls.Add(this.txt_folder);
            this.Controls.Add(this.lbl_folder);
            this.Controls.Add(this.txt_tenant_id);
            this.Controls.Add(this.lbl_tenant_id);
            this.Controls.Add(this.txt_service_account_name);
            this.Controls.Add(this.lbl_service_account_name);
            this.Controls.Add(this.btn_create);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "OpenSSL";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label lbl_service_account_name;
        private System.Windows.Forms.TextBox txt_service_account_name;
        private System.Windows.Forms.TextBox txt_tenant_id;
        private System.Windows.Forms.Label lbl_tenant_id;
        private System.Windows.Forms.TextBox txt_folder;
        private System.Windows.Forms.Label lbl_folder;
        private System.Windows.Forms.Button btn_folder;
        private System.Windows.Forms.FolderBrowserDialog folder_browser_dialog;
        private System.Windows.Forms.Button btn_tenant_id;
        private System.Windows.Forms.TextBox txt_days;
        private System.Windows.Forms.Label lbl_days;
        private System.Windows.Forms.Label lbl_private_token_rsa;
        private System.Windows.Forms.TextBox txt_private_token_rsa;
        private System.Windows.Forms.TextBox txt_public_token;
        private System.Windows.Forms.Label lbl_public_token;
        private System.Windows.Forms.TextBox txt_private_token;
        private System.Windows.Forms.Label lbl_private_token;
    }
}

