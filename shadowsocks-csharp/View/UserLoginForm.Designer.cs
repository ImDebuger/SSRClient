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
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.userEmailInput = new CCWin.SkinControl.SkinTextBox();
            this.bu_login = new System.Windows.Forms.Button();
            this.skinPictureBox3 = new CCWin.SkinControl.SkinPictureBox();
            this.userKeyInput = new CCWin.SkinControl.SkinTextBox();
            this.ck_remeberme = new CCWin.SkinControl.SkinCheckBox();
            this.bt_forget = new CCWin.SkinControl.SkinButton();
            this.skinPictureBox4 = new CCWin.SkinControl.SkinPictureBox();
            this.bg_logo = new CCWin.SkinControl.SkinPanel();
            this.image_logo = new CCWin.SkinControl.SkinPictureBox();
            this.bg_wight = new CCWin.SkinControl.SkinPanel();
            this.freelogin = new System.Windows.Forms.Button();
            this.bg_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            this.userEmailInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox3)).BeginInit();
            this.userKeyInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox4)).BeginInit();
            this.bg_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_logo)).BeginInit();
            this.bg_wight.SuspendLayout();
            this.SuspendLayout();
            // 
            // bg_login
            // 
            this.bg_login.BackColor = System.Drawing.Color.Transparent;
            this.bg_login.Controls.Add(this.skinPictureBox1);
            this.bg_login.Controls.Add(this.userEmailInput);
            this.bg_login.Controls.Add(this.bu_login);
            this.bg_login.Controls.Add(this.skinPictureBox3);
            this.bg_login.Controls.Add(this.userKeyInput);
            this.bg_login.Controls.Add(this.ck_remeberme);
            this.bg_login.Controls.Add(this.bt_forget);
            this.bg_login.Controls.Add(this.skinPictureBox4);
            this.bg_login.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.bg_login.DownBack = null;
            this.bg_login.Location = new System.Drawing.Point(307, 105);
            this.bg_login.MouseBack = null;
            this.bg_login.Name = "bg_login";
            this.bg_login.NormlBack = null;
            this.bg_login.Size = new System.Drawing.Size(324, 225);
            this.bg_login.TabIndex = 1;
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox1.Image = global::Shadowsocks.Properties.Resources.用户;
            this.skinPictureBox1.Location = new System.Drawing.Point(37, 11);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(40, 40);
            this.skinPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skinPictureBox1.TabIndex = 9;
            this.skinPictureBox1.TabStop = false;
            // 
            // userEmailInput
            // 
            this.userEmailInput.BackColor = System.Drawing.Color.Transparent;
            this.userEmailInput.Icon = null;
            this.userEmailInput.IconIsButton = false;
            this.userEmailInput.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.userEmailInput.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.userEmailInput.Location = new System.Drawing.Point(34, 8);
            this.userEmailInput.Margin = new System.Windows.Forms.Padding(0);
            this.userEmailInput.MinimumSize = new System.Drawing.Size(28, 28);
            this.userEmailInput.MouseBack = null;
            this.userEmailInput.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.userEmailInput.Name = "userEmailInput";
            this.userEmailInput.NormlBack = null;
            this.userEmailInput.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.userEmailInput.Size = new System.Drawing.Size(278, 46);
            // 
            // userEmailInput.BaseText
            // 
            this.userEmailInput.SkinTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.userEmailInput.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userEmailInput.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.userEmailInput.SkinTxt.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.userEmailInput.SkinTxt.Location = new System.Drawing.Point(55, 14);
            this.userEmailInput.SkinTxt.Name = "BaseText";
            this.userEmailInput.SkinTxt.Size = new System.Drawing.Size(211, 22);
            this.userEmailInput.SkinTxt.TabIndex = 0;
            this.userEmailInput.SkinTxt.TabStop = false;
            this.userEmailInput.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.userEmailInput.SkinTxt.WaterText = "请输入用户名";
            this.userEmailInput.SkinTxt.WordWrap = false;
            this.userEmailInput.TabIndex = 0;
            // 
            // bu_login
            // 
            this.bu_login.BackgroundImage = global::Shadowsocks.Properties.Resources.button;
            this.bu_login.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bu_login.Location = new System.Drawing.Point(45, 166);
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
            this.skinPictureBox3.Location = new System.Drawing.Point(37, 75);
            this.skinPictureBox3.Name = "skinPictureBox3";
            this.skinPictureBox3.Size = new System.Drawing.Size(40, 40);
            this.skinPictureBox3.TabIndex = 11;
            this.skinPictureBox3.TabStop = false;
            // 
            // userKeyInput
            // 
            this.userKeyInput.BackColor = System.Drawing.Color.Transparent;
            this.userKeyInput.Icon = null;
            this.userKeyInput.IconIsButton = false;
            this.userKeyInput.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.userKeyInput.Location = new System.Drawing.Point(34, 72);
            this.userKeyInput.Margin = new System.Windows.Forms.Padding(0);
            this.userKeyInput.MinimumSize = new System.Drawing.Size(28, 28);
            this.userKeyInput.MouseBack = null;
            this.userKeyInput.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.userKeyInput.Name = "userKeyInput";
            this.userKeyInput.NormlBack = null;
            this.userKeyInput.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.userKeyInput.Size = new System.Drawing.Size(278, 46);
            // 
            // userKeyInput.BaseText
            // 
            this.userKeyInput.SkinTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.userKeyInput.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userKeyInput.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.userKeyInput.SkinTxt.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.userKeyInput.SkinTxt.Location = new System.Drawing.Point(55, 14);
            this.userKeyInput.SkinTxt.Name = "BaseText";
            this.userKeyInput.SkinTxt.Size = new System.Drawing.Size(212, 22);
            this.userKeyInput.SkinTxt.TabIndex = 7;
            this.userKeyInput.SkinTxt.TabStop = false;
            this.userKeyInput.SkinTxt.UseSystemPasswordChar = true;
            this.userKeyInput.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.userKeyInput.SkinTxt.WaterText = "请输入密码";
            this.userKeyInput.TabIndex = 1;
            // 
            // ck_remeberme
            // 
            this.ck_remeberme.AutoSize = true;
            this.ck_remeberme.BackColor = System.Drawing.Color.Transparent;
            this.ck_remeberme.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ck_remeberme.DownBack = null;
            this.ck_remeberme.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ck_remeberme.Location = new System.Drawing.Point(58, 138);
            this.ck_remeberme.MouseBack = null;
            this.ck_remeberme.Name = "ck_remeberme";
            this.ck_remeberme.NormlBack = null;
            this.ck_remeberme.SelectedDownBack = null;
            this.ck_remeberme.SelectedMouseBack = null;
            this.ck_remeberme.SelectedNormlBack = null;
            this.ck_remeberme.Size = new System.Drawing.Size(75, 21);
            this.ck_remeberme.TabIndex = 2;
            this.ck_remeberme.Text = "记住密码";
            this.ck_remeberme.UseVisualStyleBackColor = false;
            // 
            // bt_forget
            // 
            this.bt_forget.BackColor = System.Drawing.Color.Transparent;
            this.bt_forget.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.bt_forget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_forget.DownBack = null;
            this.bt_forget.Location = new System.Drawing.Point(210, 136);
            this.bt_forget.MouseBack = null;
            this.bt_forget.Name = "bt_forget";
            this.bt_forget.NormlBack = null;
            this.bt_forget.Size = new System.Drawing.Size(75, 23);
            this.bt_forget.TabIndex = 7;
            this.bt_forget.TabStop = false;
            this.bt_forget.Text = "忘记密码";
            this.bt_forget.UseVisualStyleBackColor = false;
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
            // bg_logo
            // 
            this.bg_logo.BackColor = System.Drawing.Color.Transparent;
            this.bg_logo.Controls.Add(this.image_logo);
            this.bg_logo.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.bg_logo.DownBack = null;
            this.bg_logo.Location = new System.Drawing.Point(307, 3);
            this.bg_logo.MouseBack = null;
            this.bg_logo.Name = "bg_logo";
            this.bg_logo.NormlBack = null;
            this.bg_logo.Size = new System.Drawing.Size(324, 105);
            this.bg_logo.TabIndex = 3;
            // 
            // image_logo
            // 
            this.image_logo.BackColor = System.Drawing.Color.Transparent;
            this.image_logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.image_logo.Image = global::Shadowsocks.Properties.Resources.logoText;
            this.image_logo.Location = new System.Drawing.Point(22, 22);
            this.image_logo.Name = "image_logo";
            this.image_logo.Size = new System.Drawing.Size(263, 74);
            this.image_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image_logo.TabIndex = 0;
            this.image_logo.TabStop = false;
            this.image_logo.Click += new System.EventHandler(this.image_logo_Click);
            // 
            // bg_wight
            // 
            this.bg_wight.BackColor = System.Drawing.Color.White;
            this.bg_wight.BackgroundImage = global::Shadowsocks.Properties.Resources.bg;
            this.bg_wight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bg_wight.Controls.Add(this.freelogin);
            this.bg_wight.Controls.Add(this.bg_login);
            this.bg_wight.Controls.Add(this.bg_logo);
            this.bg_wight.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.bg_wight.DownBack = null;
            this.bg_wight.Location = new System.Drawing.Point(-1, 39);
            this.bg_wight.MouseBack = null;
            this.bg_wight.Name = "bg_wight";
            this.bg_wight.NormlBack = null;
            this.bg_wight.Size = new System.Drawing.Size(640, 420);
            this.bg_wight.TabIndex = 9;
            // 
            // freelogin
            // 
            this.freelogin.BackgroundImage = global::Shadowsocks.Properties.Resources.button_2;
            this.freelogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.freelogin.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.freelogin.Location = new System.Drawing.Point(503, 368);
            this.freelogin.Name = "freelogin";
            this.freelogin.Size = new System.Drawing.Size(122, 35);
            this.freelogin.TabIndex = 4;
            this.freelogin.Text = "免费试用";
            this.freelogin.UseVisualStyleBackColor = true;
            this.freelogin.Click += new System.EventHandler(this.freelogin_Click);
            // 
            // UserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(637, 460);
            this.CloseBoxSize = new System.Drawing.Size(40, 36);
            this.CloseDownBack = global::Shadowsocks.Properties.Resources.sysbtn_close_down;
            this.CloseMouseBack = global::Shadowsocks.Properties.Resources.sysbtn_close_hover;
            this.CloseNormlBack = global::Shadowsocks.Properties.Resources.sysbtn_close_normal;
            this.Controls.Add(this.bg_wight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.TitleSuitColor = true;
            this.bg_login.ResumeLayout(false);
            this.bg_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            this.userEmailInput.ResumeLayout(false);
            this.userEmailInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox3)).EndInit();
            this.userKeyInput.ResumeLayout(false);
            this.userKeyInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox4)).EndInit();
            this.bg_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image_logo)).EndInit();
            this.bg_wight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel bg_login;
        private CCWin.SkinControl.SkinTextBox userEmailInput;
        private System.Windows.Forms.Button bu_login;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox3;
        private CCWin.SkinControl.SkinTextBox userKeyInput;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
        private CCWin.SkinControl.SkinCheckBox ck_remeberme;
        private CCWin.SkinControl.SkinButton bt_forget;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox4;
        private CCWin.SkinControl.SkinPanel bg_logo;
        private CCWin.SkinControl.SkinPictureBox image_logo;
        private CCWin.SkinControl.SkinPanel bg_wight;
        private System.Windows.Forms.Button freelogin;
    }
}