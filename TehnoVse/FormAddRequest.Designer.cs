namespace TehnoVse
{
    partial class FormAddRequest
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.LblNow = new System.Windows.Forms.Label();
            this.TbxPhone = new System.Windows.Forms.RichTextBox();
            this.TbxDevice = new System.Windows.Forms.RichTextBox();
            this.TbxDesc = new System.Windows.Forms.RichTextBox();
            this.BtnAddRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добавление заявки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer
            // 
            this.Timer.Interval = 60000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // LblNow
            // 
            this.LblNow.BackColor = System.Drawing.Color.White;
            this.LblNow.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.LblNow.Location = new System.Drawing.Point(12, 65);
            this.LblNow.Name = "LblNow";
            this.LblNow.Size = new System.Drawing.Size(451, 41);
            this.LblNow.TabIndex = 3;
            this.LblNow.Text = "Текущее время:";
            this.LblNow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbxPhone
            // 
            this.TbxPhone.BackColor = System.Drawing.Color.White;
            this.TbxPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxPhone.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxPhone.ForeColor = System.Drawing.Color.Black;
            this.TbxPhone.Location = new System.Drawing.Point(42, 122);
            this.TbxPhone.Name = "TbxPhone";
            this.TbxPhone.Size = new System.Drawing.Size(421, 38);
            this.TbxPhone.TabIndex = 67;
            this.TbxPhone.Text = "Введите номер телефона";
            this.TbxPhone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TbxAddress_MouseEnter);
            this.TbxPhone.MouseLeave += new System.EventHandler(this.TbxPhone_MouseLeave);
            // 
            // TbxDevice
            // 
            this.TbxDevice.BackColor = System.Drawing.Color.White;
            this.TbxDevice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxDevice.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxDevice.ForeColor = System.Drawing.Color.Black;
            this.TbxDevice.Location = new System.Drawing.Point(42, 176);
            this.TbxDevice.Name = "TbxDevice";
            this.TbxDevice.Size = new System.Drawing.Size(421, 38);
            this.TbxDevice.TabIndex = 68;
            this.TbxDevice.Text = "Введите неисправное устройство";
            this.TbxDevice.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TbxDevice_MouseDown);
            this.TbxDevice.MouseLeave += new System.EventHandler(this.TbxDevice_MouseLeave);
            // 
            // TbxDesc
            // 
            this.TbxDesc.BackColor = System.Drawing.Color.White;
            this.TbxDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxDesc.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxDesc.ForeColor = System.Drawing.Color.Black;
            this.TbxDesc.Location = new System.Drawing.Point(42, 233);
            this.TbxDesc.Name = "TbxDesc";
            this.TbxDesc.Size = new System.Drawing.Size(421, 227);
            this.TbxDesc.TabIndex = 69;
            this.TbxDesc.Text = "Введите описание поломки";
            this.TbxDesc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TbxDesc_MouseDown);
            this.TbxDesc.MouseLeave += new System.EventHandler(this.TbxDesc_MouseLeave);
            // 
            // BtnAddRequest
            // 
            this.BtnAddRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.BtnAddRequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAddRequest.ForeColor = System.Drawing.Color.White;
            this.BtnAddRequest.Location = new System.Drawing.Point(42, 478);
            this.BtnAddRequest.Name = "BtnAddRequest";
            this.BtnAddRequest.Size = new System.Drawing.Size(421, 35);
            this.BtnAddRequest.TabIndex = 70;
            this.BtnAddRequest.Text = "Создать заявку";
            this.BtnAddRequest.UseVisualStyleBackColor = false;
            this.BtnAddRequest.Click += new System.EventHandler(this.BtnAddRequest_Click);
            // 
            // FormAddRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(501, 525);
            this.Controls.Add(this.BtnAddRequest);
            this.Controls.Add(this.TbxDesc);
            this.Controls.Add(this.TbxDevice);
            this.Controls.Add(this.TbxPhone);
            this.Controls.Add(this.LblNow);
            this.Controls.Add(this.label1);
            this.Name = "FormAddRequest";
            this.ShowIcon = false;
            this.Text = "ТехноВсё Новозыбков";
            this.Load += new System.EventHandler(this.FormAddRequest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label LblNow;
        private System.Windows.Forms.RichTextBox TbxPhone;
        private System.Windows.Forms.RichTextBox TbxDevice;
        private System.Windows.Forms.RichTextBox TbxDesc;
        private System.Windows.Forms.Button BtnAddRequest;
    }
}