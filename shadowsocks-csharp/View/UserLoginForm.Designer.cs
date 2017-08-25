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
            this.bu_login = new System.Windows.Forms.Button();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.skinPanel2 = new CCWin.SkinControl.SkinPanel();
            this.skinPictureBox2 = new CCWin.SkinControl.SkinPictureBox();
            this.userEmailInput = new CCWin.SkinControl.SkinTextBox();
            this.skinPanel3 = new CCWin.SkinControl.SkinPanel();
            this.skinCheckBox1 = new CCWin.SkinControl.SkinCheckBox();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.userKeyInput = new CCWin.SkinControl.SkinTextBox();
            this.bt_freetest = new System.Windows.Forms.Button();
            this.skinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            this.skinPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox2)).BeginInit();
            this.userEmailInput.SuspendLayout();
            this.skinPanel3.SuspendLayout();
            this.userKeyInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // bu_login
            // 
            this.bu_login.Location = new System.Drawing.Point(86, 169);
            this.bu_login.Name = "bu_login";
            this.bu_login.Size = new System.Drawing.Size(153, 47);
            this.bu_login.TabIndex = 0;
            this.bu_login.Text = "button1";
            this.bu_login.UseVisualStyleBackColor = true;
            this.bu_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.skinPictureBox1);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(12, 12);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(426, 437);
            this.skinPanel1.TabIndex = 2;
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox1.Location = new System.Drawing.Point(3, 3);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(420, 431);
            this.skinPictureBox1.TabIndex = 0;
            this.skinPictureBox1.TabStop = false;
            // 
            // skinPanel2
            // 
            this.skinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel2.Controls.Add(this.skinPictureBox2);
            this.skinPanel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel2.DownBack = null;
            this.skinPanel2.Location = new System.Drawing.Point(444, 31);
            this.skinPanel2.MouseBack = null;
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.NormlBack = null;
            this.skinPanel2.Size = new System.Drawing.Size(329, 106);
            this.skinPanel2.TabIndex = 3;
            // 
            // skinPictureBox2
            // 
            this.skinPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox2.Image = global::Shadowsocks.Properties.Resources.logoText;
            this.skinPictureBox2.Location = new System.Drawing.Point(47, 20);
            this.skinPictureBox2.Name = "skinPictureBox2";
            this.skinPictureBox2.Size = new System.Drawing.Size(228, 82);
            this.skinPictureBox2.TabIndex = 0;
            this.skinPictureBox2.TabStop = false;
            // 
            // userEmailInput
            // 
            this.userEmailInput.BackColor = System.Drawing.Color.Transparent;
            this.userEmailInput.Icon = null;
            this.userEmailInput.IconIsButton = false;
            this.userEmailInput.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.userEmailInput.Location = new System.Drawing.Point(21, 17);
            this.userEmailInput.Margin = new System.Windows.Forms.Padding(0);
            this.userEmailInput.MinimumSize = new System.Drawing.Size(28, 28);
            this.userEmailInput.MouseBack = null;
            this.userEmailInput.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.userEmailInput.Name = "userEmailInput";
            this.userEmailInput.NormlBack = null;
            this.userEmailInput.Padding = new System.Windows.Forms.Padding(5);
            this.userEmailInput.Size = new System.Drawing.Size(278, 48);
            // 
            // userEmailInput.BaseText
            // 
            this.userEmailInput.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userEmailInput.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userEmailInput.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.userEmailInput.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.userEmailInput.SkinTxt.Name = "BaseText";
            this.userEmailInput.SkinTxt.Size = new System.Drawing.Size(268, 18);
            this.userEmailInput.SkinTxt.TabIndex = 0;
            this.userEmailInput.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.userEmailInput.SkinTxt.WaterText = "";
            this.userEmailInput.TabIndex = 4;
            // 
            // skinPanel3
            // 
            this.skinPanel3.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel3.Controls.Add(this.skinCheckBox1);
            this.skinPanel3.Controls.Add(this.skinButton1);
            this.skinPanel3.Controls.Add(this.userKeyInput);
            this.skinPanel3.Controls.Add(this.bu_login);
            this.skinPanel3.Controls.Add(this.userEmailInput);
            this.skinPanel3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel3.DownBack = null;
            this.skinPanel3.Location = new System.Drawing.Point(447, 143);
            this.skinPanel3.MouseBack = null;
            this.skinPanel3.Name = "skinPanel3";
            this.skinPanel3.NormlBack = null;
            this.skinPanel3.Size = new System.Drawing.Size(316, 227);
            this.skinPanel3.TabIndex = 5;
            // 
            // skinCheckBox1
            // 
            this.skinCheckBox1.AutoSize = true;
            this.skinCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBox1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBox1.DownBack = null;
            this.skinCheckBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBox1.Location = new System.Drawing.Point(34, 142);
            this.skinCheckBox1.MouseBack = null;
            this.skinCheckBox1.Name = "skinCheckBox1";
            this.skinCheckBox1.NormlBack = null;
            this.skinCheckBox1.SelectedDownBack = null;
            this.skinCheckBox1.SelectedMouseBack = null;
            this.skinCheckBox1.SelectedNormlBack = null;
            this.skinCheckBox1.Size = new System.Drawing.Size(114, 21);
            this.skinCheckBox1.TabIndex = 8;
            this.skinCheckBox1.Text = "skinCheckBox1";
            this.skinCheckBox1.UseVisualStyleBackColor = false;
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(210, 142);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(75, 23);
            this.skinButton1.TabIndex = 7;
            this.skinButton1.Text = "skinButton1";
            this.skinButton1.UseVisualStyleBackColor = false;
            // 
            // userKeyInput
            // 
            this.userKeyInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userKeyInput.BackColor = System.Drawing.Color.Transparent;
            this.userKeyInput.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userKeyInput.Icon = global::Shadowsocks.Properties.Resources.ssw128;
            this.userKeyInput.IconIsButton = false;
            this.userKeyInput.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.userKeyInput.Location = new System.Drawing.Point(19, 82);
            this.userKeyInput.Margin = new System.Windows.Forms.Padding(0);
            this.userKeyInput.MinimumSize = new System.Drawing.Size(28, 28);
            this.userKeyInput.MouseBack = null;
            this.userKeyInput.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.userKeyInput.Name = "userKeyInput";
            this.userKeyInput.NormlBack = null;
            this.userKeyInput.Padding = new System.Windows.Forms.Padding(5, 5, 28, 5);
            this.userKeyInput.Size = new System.Drawing.Size(278, 48);
            // 
            // userKeyInput.BaseText
            // 
            this.userKeyInput.SkinTxt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.userKeyInput.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userKeyInput.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userKeyInput.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.userKeyInput.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.userKeyInput.SkinTxt.Name = "BaseText";
            this.userKeyInput.SkinTxt.Size = new System.Drawing.Size(245, 18);
            this.userKeyInput.SkinTxt.TabIndex = 0;
            this.userKeyInput.SkinTxt.Text = "请输入密码";
            this.userKeyInput.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.userKeyInput.SkinTxt.WaterText = "";
            this.userKeyInput.TabIndex = 5;
            // 
            // bt_freetest
            // 
            this.bt_freetest.Location = new System.Drawing.Point(533, 399);
            this.bt_freetest.Name = "bt_freetest";
            this.bt_freetest.Size = new System.Drawing.Size(153, 47);
            this.bt_freetest.TabIndex = 8;
            this.bt_freetest.Text = "button2";
            this.bt_freetest.UseVisualStyleBackColor = true;
            this.bt_freetest.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(785, 461);
            this.Controls.Add(this.bt_freetest);
            this.Controls.Add(this.skinPanel3);
            this.Controls.Add(this.skinPanel2);
            this.Controls.Add(this.skinPanel1);
            this.Name = "UserLoginForm";
            this.Text = "91智云登录";
            this.skinPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            this.skinPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox2)).EndInit();
            this.userEmailInput.ResumeLayout(false);
            this.userEmailInput.PerformLayout();
            this.skinPanel3.ResumeLayout(false);
            this.skinPanel3.PerformLayout();
            this.userKeyInput.ResumeLayout(false);
            this.userKeyInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bu_login;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
        private CCWin.SkinControl.SkinPanel skinPanel2;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox2;
        private CCWin.SkinControl.SkinTextBox userEmailInput;
        private CCWin.SkinControl.SkinPanel skinPanel3;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinTextBox userKeyInput;
        private System.Windows.Forms.Button bt_freetest;
        private CCWin.SkinControl.SkinCheckBox skinCheckBox1;
    }
}