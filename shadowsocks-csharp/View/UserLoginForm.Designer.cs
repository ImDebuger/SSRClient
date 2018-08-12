namespace Shadowsocks.View
{
    partial class UserLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLoginForm));
            this.bg_login = new CCWin.SkinControl.SkinPanel();
            this.userKeyCodeInput = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.bu_login = new System.Windows.Forms.Button();
            this.skinPictureBox3 = new CCWin.SkinControl.SkinPictureBox();
            this.userKeyInput = new CCWin.SkinControl.SkinTextBox();
            this.ck_remeberme = new CCWin.SkinControl.SkinCheckBox();
            this.skinPictureBox4 = new CCWin.SkinControl.SkinPictureBox();
            this.skinTextBox1 = new CCWin.SkinControl.SkinTextBox();
            this.userMailInput = new CCWin.SkinControl.SkinWaterTextBox();
            this.bg_logo = new CCWin.SkinControl.SkinPanel();
            this.image_logo = new CCWin.SkinControl.SkinPictureBox();
            this.bg_wight = new CCWin.SkinControl.SkinPanel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.freelogin = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bg_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox4)).BeginInit();
            this.skinTextBox1.SuspendLayout();
            this.bg_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_logo)).BeginInit();
            this.bg_wight.SuspendLayout();
            this.SuspendLayout();
            // 
            // bg_login
            // 
            this.bg_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bg_login.BackColor = System.Drawing.Color.Transparent;
            this.bg_login.Controls.Add(this.userKeyCodeInput);
            this.bg_login.Controls.Add(this.skinPictureBox1);
            this.bg_login.Controls.Add(this.bu_login);
            this.bg_login.Controls.Add(this.skinPictureBox3);
            this.bg_login.Controls.Add(this.userKeyInput);
            this.bg_login.Controls.Add(this.ck_remeberme);
            this.bg_login.Controls.Add(this.skinPictureBox4);
            this.bg_login.Controls.Add(this.skinTextBox1);
            this.bg_login.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.bg_login.DownBack = null;
            this.bg_login.Location = new System.Drawing.Point(307, 105);
            this.bg_login.MouseBack = null;
            this.bg_login.Name = "bg_login";
            this.bg_login.NormlBack = null;
            this.bg_login.Size = new System.Drawing.Size(391, 283);
            this.bg_login.TabIndex = 1;
            // 
            // userKeyCodeInput
            // 
            this.userKeyCodeInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.userKeyCodeInput.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userKeyCodeInput.Location = new System.Drawing.Point(103, 122);
            this.userKeyCodeInput.Name = "userKeyCodeInput";
            this.userKeyCodeInput.PasswordChar = '*';
            this.userKeyCodeInput.Size = new System.Drawing.Size(259, 37);
            this.userKeyCodeInput.TabIndex = 12;
            this.userKeyCodeInput.UseSystemPasswordChar = true;
            this.userKeyCodeInput.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.userKeyCodeInput.WaterText = "请输入密码";
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox1.Image = global::Shadowsocks.Properties.Resources.用户;
            this.skinPictureBox1.Location = new System.Drawing.Point(40, 16);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(57, 54);
            this.skinPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skinPictureBox1.TabIndex = 9;
            this.skinPictureBox1.TabStop = false;
            // 
            // bu_login
            // 
            this.bu_login.BackgroundImage = global::Shadowsocks.Properties.Resources.button;
            this.bu_login.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bu_login.Location = new System.Drawing.Point(58, 212);
            this.bu_login.Name = "bu_login";
            this.bu_login.Size = new System.Drawing.Size(240, 53);
            this.bu_login.TabIndex = 3;
            this.bu_login.Text = "登录";
            this.bu_login.UseVisualStyleBackColor = true;
            this.bu_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // skinPictureBox3
            // 
            this.skinPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox3.Image = global::Shadowsocks.Properties.Resources.密码;
            this.skinPictureBox3.Location = new System.Drawing.Point(40, 105);
            this.skinPictureBox3.Name = "skinPictureBox3";
            this.skinPictureBox3.Size = new System.Drawing.Size(57, 58);
            this.skinPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skinPictureBox3.TabIndex = 11;
            this.skinPictureBox3.TabStop = false;
            // 
            // userKeyInput
            // 
            this.userKeyInput.BackColor = System.Drawing.Color.Transparent;
            this.userKeyInput.CausesValidation = false;
            this.userKeyInput.DownBack = null;
            this.userKeyInput.Icon = null;
            this.userKeyInput.IconIsButton = false;
            this.userKeyInput.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.userKeyInput.IsPasswordChat = '\0';
            this.userKeyInput.IsSystemPasswordChar = true;
            this.userKeyInput.Lines = new string[0];
            this.userKeyInput.Location = new System.Drawing.Point(37, 102);
            this.userKeyInput.Margin = new System.Windows.Forms.Padding(0);
            this.userKeyInput.MaxLength = 32767;
            this.userKeyInput.MinimumSize = new System.Drawing.Size(28, 28);
            this.userKeyInput.MouseBack = null;
            this.userKeyInput.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.userKeyInput.Multiline = true;
            this.userKeyInput.Name = "userKeyInput";
            this.userKeyInput.NormlBack = null;
            this.userKeyInput.Padding = new System.Windows.Forms.Padding(5);
            this.userKeyInput.ReadOnly = false;
            this.userKeyInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userKeyInput.Size = new System.Drawing.Size(333, 65);
            // 
            // 
            // 
            this.userKeyInput.SkinTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.userKeyInput.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userKeyInput.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.userKeyInput.SkinTxt.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.userKeyInput.SkinTxt.Location = new System.Drawing.Point(89, 89);
            this.userKeyInput.SkinTxt.Multiline = true;
            this.userKeyInput.SkinTxt.Name = "BaseText";
            this.userKeyInput.SkinTxt.Size = new System.Drawing.Size(266, 32);
            this.userKeyInput.SkinTxt.TabIndex = 2;
            this.userKeyInput.SkinTxt.UseSystemPasswordChar = true;
            this.userKeyInput.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.userKeyInput.SkinTxt.WaterText = "请输入密码";
            this.userKeyInput.TabIndex = 1;
            this.userKeyInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userKeyInput.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.userKeyInput.WaterText = "请输入密码";
            this.userKeyInput.WordWrap = true;
            // 
            // ck_remeberme
            // 
            this.ck_remeberme.AutoSize = true;
            this.ck_remeberme.BackColor = System.Drawing.Color.Transparent;
            this.ck_remeberme.Checked = true;
            this.ck_remeberme.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ck_remeberme.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ck_remeberme.DownBack = null;
            this.ck_remeberme.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ck_remeberme.Location = new System.Drawing.Point(67, 170);
            this.ck_remeberme.MouseBack = null;
            this.ck_remeberme.Name = "ck_remeberme";
            this.ck_remeberme.NormlBack = null;
            this.ck_remeberme.SelectedDownBack = null;
            this.ck_remeberme.SelectedMouseBack = null;
            this.ck_remeberme.SelectedNormlBack = null;
            this.ck_remeberme.Size = new System.Drawing.Size(108, 28);
            this.ck_remeberme.TabIndex = 2;
            this.ck_remeberme.TabStop = false;
            this.ck_remeberme.Text = "自动登录";
            this.ck_remeberme.UseVisualStyleBackColor = false;
            // 
            // skinPictureBox4
            // 
            this.skinPictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox4.Image = global::Shadowsocks.Properties.Resources.bg;
            this.skinPictureBox4.Location = new System.Drawing.Point(-226, -75);
            this.skinPictureBox4.Name = "skinPictureBox4";
            this.skinPictureBox4.Size = new System.Drawing.Size(206, 398);
            this.skinPictureBox4.TabIndex = 9;
            this.skinPictureBox4.TabStop = false;
            // 
            // skinTextBox1
            // 
            this.skinTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox1.CausesValidation = false;
            this.skinTextBox1.Controls.Add(this.userMailInput);
            this.skinTextBox1.DownBack = null;
            this.skinTextBox1.Icon = null;
            this.skinTextBox1.IconIsButton = false;
            this.skinTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.IsPasswordChat = '\0';
            this.skinTextBox1.IsSystemPasswordChar = true;
            this.skinTextBox1.Lines = new string[0];
            this.skinTextBox1.Location = new System.Drawing.Point(37, 13);
            this.skinTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox1.MaxLength = 32767;
            this.skinTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox1.MouseBack = null;
            this.skinTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.Multiline = true;
            this.skinTextBox1.Name = "skinTextBox1";
            this.skinTextBox1.NormlBack = null;
            this.skinTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox1.ReadOnly = false;
            this.skinTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox1.Size = new System.Drawing.Size(333, 65);
            // 
            // 
            // 
            this.skinTextBox1.SkinTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.skinTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.skinTextBox1.SkinTxt.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.skinTextBox1.SkinTxt.Location = new System.Drawing.Point(89, 89);
            this.skinTextBox1.SkinTxt.Multiline = true;
            this.skinTextBox1.SkinTxt.Name = "BaseText";
            this.skinTextBox1.SkinTxt.Size = new System.Drawing.Size(266, 32);
            this.skinTextBox1.SkinTxt.TabIndex = 2;
            this.skinTextBox1.SkinTxt.UseSystemPasswordChar = true;
            this.skinTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.SkinTxt.WaterText = "请输入密码";
            this.skinTextBox1.TabIndex = 3;
            this.skinTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.WaterText = "请输入密码";
            this.skinTextBox1.WordWrap = true;
            // 
            // userMailInput
            // 
            this.userMailInput.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userMailInput.Location = new System.Drawing.Point(66, 18);
            this.userMailInput.Name = "userMailInput";
            this.userMailInput.Size = new System.Drawing.Size(259, 37);
            this.userMailInput.TabIndex = 13;
            this.userMailInput.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.userMailInput.WaterText = "请输入邮箱";
            this.userMailInput.TextChanged += new System.EventHandler(this.skinWaterTextBox2_TextChanged);
            // 
            // bg_logo
            // 
            this.bg_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bg_logo.BackColor = System.Drawing.Color.Transparent;
            this.bg_logo.Controls.Add(this.image_logo);
            this.bg_logo.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.bg_logo.DownBack = null;
            this.bg_logo.Location = new System.Drawing.Point(307, 3);
            this.bg_logo.MouseBack = null;
            this.bg_logo.Name = "bg_logo";
            this.bg_logo.NormlBack = null;
            this.bg_logo.Size = new System.Drawing.Size(388, 105);
            this.bg_logo.TabIndex = 3;
            // 
            // image_logo
            // 
            this.image_logo.BackColor = System.Drawing.Color.Transparent;
            this.image_logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.image_logo.Image = global::Shadowsocks.Properties.Resources.logoText1;
            this.image_logo.Location = new System.Drawing.Point(66, 20);
            this.image_logo.Name = "image_logo";
            this.image_logo.Size = new System.Drawing.Size(263, 74);
            this.image_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image_logo.TabIndex = 0;
            this.image_logo.TabStop = false;
            this.image_logo.Click += new System.EventHandler(this.image_logo_Click);
            // 
            // bg_wight
            // 
            this.bg_wight.AutoSize = true;
            this.bg_wight.BackColor = System.Drawing.Color.White;
            this.bg_wight.BackgroundImage = global::Shadowsocks.Properties.Resources.bg;
            this.bg_wight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bg_wight.Controls.Add(this.skinLabel1);
            this.bg_wight.Controls.Add(this.freelogin);
            this.bg_wight.Controls.Add(this.bg_login);
            this.bg_wight.Controls.Add(this.bg_logo);
            this.bg_wight.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.bg_wight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bg_wight.DownBack = null;
            this.bg_wight.Location = new System.Drawing.Point(4, 28);
            this.bg_wight.MinimumSize = new System.Drawing.Size(696, 451);
            this.bg_wight.MouseBack = null;
            this.bg_wight.Name = "bg_wight";
            this.bg_wight.NormlBack = null;
            this.bg_wight.Size = new System.Drawing.Size(696, 451);
            this.bg_wight.TabIndex = 9;
            this.bg_wight.Paint += new System.Windows.Forms.PaintEventHandler(this.bg_wight_Paint);
            // 
            // skinLabel1
            // 
            this.skinLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(3, 434);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(125, 16);
            this.skinLabel1.TabIndex = 5;
            this.skinLabel1.Text = "SSR 4.7.0 & QZ 1.0.0 ";
            this.skinLabel1.Click += new System.EventHandler(this.skinLabel1_Click);
            // 
            // freelogin
            // 
            this.freelogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.freelogin.BackgroundImage = global::Shadowsocks.Properties.Resources.button_2;
            this.freelogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.freelogin.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.freelogin.Location = new System.Drawing.Point(563, 407);
            this.freelogin.Name = "freelogin";
            this.freelogin.Size = new System.Drawing.Size(128, 39);
            this.freelogin.TabIndex = 4;
            this.freelogin.TabStop = false;
            this.freelogin.Text = "免费试用";
            this.freelogin.UseVisualStyleBackColor = true;
            this.freelogin.Click += new System.EventHandler(this.freelogin_Click);
            // 
            // UserLoginForm
            // 
            this.AcceptButton = this.bu_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(704, 483);
            this.CloseBoxSize = new System.Drawing.Size(40, 36);
            this.CloseDownBack = global::Shadowsocks.Properties.Resources.sysbtn_close_down;
            this.CloseMouseBack = global::Shadowsocks.Properties.Resources.sysbtn_close_hover;
            this.CloseNormlBack = global::Shadowsocks.Properties.Resources.sysbtn_close_normal;
            this.Controls.Add(this.bg_wight);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(704, 483);
            this.Name = "UserLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "轻纸云 ";
            this.TitleSuitColor = true;
            this.Load += new System.EventHandler(this.UserLoginForm_Load);
            this.bg_login.ResumeLayout(false);
            this.bg_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox4)).EndInit();
            this.skinTextBox1.ResumeLayout(false);
            this.skinTextBox1.PerformLayout();
            this.bg_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image_logo)).EndInit();
            this.bg_wight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinPanel bg_login;
        private System.Windows.Forms.Button bu_login;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox3;
        private CCWin.SkinControl.SkinTextBox userKeyInput;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
        private CCWin.SkinControl.SkinCheckBox ck_remeberme;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox4;
        private CCWin.SkinControl.SkinPanel bg_logo;
        private CCWin.SkinControl.SkinPictureBox image_logo;
        private CCWin.SkinControl.SkinPanel bg_wight;
        private System.Windows.Forms.Button freelogin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CCWin.SkinControl.SkinWaterTextBox userKeyCodeInput;
        private CCWin.SkinControl.SkinTextBox skinTextBox1;
        private CCWin.SkinControl.SkinWaterTextBox userMailInput;
        private CCWin.SkinControl.SkinLabel skinLabel1;
    }
}