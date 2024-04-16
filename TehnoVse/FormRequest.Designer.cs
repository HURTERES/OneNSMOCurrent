namespace TehnoVse
{
    partial class FormRequest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.requestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tehnoVseDataSet = new TehnoVse.TehnoVseDataSet();
            this.requestTableAdapter = new TehnoVse.TehnoVseDataSetTableAdapters.RequestTableAdapter();
            this.DgvRequest = new System.Windows.Forms.DataGridView();
            this.idRequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeRequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tehnoVseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // requestBindingSource
            // 
            this.requestBindingSource.DataMember = "Request";
            this.requestBindingSource.DataSource = this.tehnoVseDataSet;
            // 
            // tehnoVseDataSet
            // 
            this.tehnoVseDataSet.DataSetName = "TehnoVseDataSet";
            this.tehnoVseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requestTableAdapter
            // 
            this.requestTableAdapter.ClearBeforeFill = true;
            // 
            // DgvRequest
            // 
            this.DgvRequest.AllowUserToAddRows = false;
            this.DgvRequest.AllowUserToDeleteRows = false;
            this.DgvRequest.AllowUserToResizeColumns = false;
            this.DgvRequest.AllowUserToResizeRows = false;
            this.DgvRequest.AutoGenerateColumns = false;
            this.DgvRequest.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvRequest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvRequest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvRequest.ColumnHeadersHeight = 30;
            this.DgvRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRequestDataGridViewTextBoxColumn,
            this.timeRequestDataGridViewTextBoxColumn,
            this.numPhoneDataGridViewTextBoxColumn,
            this.deviceDataGridViewTextBoxColumn,
            this.descDataGridViewTextBoxColumn});
            this.DgvRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvRequest.DataSource = this.requestBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvRequest.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvRequest.EnableHeadersVisualStyles = false;
            this.DgvRequest.GridColor = System.Drawing.Color.White;
            this.DgvRequest.Location = new System.Drawing.Point(0, 0);
            this.DgvRequest.Name = "DgvRequest";
            this.DgvRequest.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvRequest.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvRequest.RowHeadersVisible = false;
            this.DgvRequest.RowTemplate.Height = 32;
            this.DgvRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvRequest.Size = new System.Drawing.Size(1417, 511);
            this.DgvRequest.TabIndex = 39;
            // 
            // idRequestDataGridViewTextBoxColumn
            // 
            this.idRequestDataGridViewTextBoxColumn.DataPropertyName = "IdRequest";
            this.idRequestDataGridViewTextBoxColumn.HeaderText = "№ Заявки";
            this.idRequestDataGridViewTextBoxColumn.Name = "idRequestDataGridViewTextBoxColumn";
            this.idRequestDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeRequestDataGridViewTextBoxColumn
            // 
            this.timeRequestDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.timeRequestDataGridViewTextBoxColumn.DataPropertyName = "TimeRequest";
            this.timeRequestDataGridViewTextBoxColumn.HeaderText = "Время заявки";
            this.timeRequestDataGridViewTextBoxColumn.Name = "timeRequestDataGridViewTextBoxColumn";
            this.timeRequestDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeRequestDataGridViewTextBoxColumn.Width = 158;
            // 
            // numPhoneDataGridViewTextBoxColumn
            // 
            this.numPhoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numPhoneDataGridViewTextBoxColumn.DataPropertyName = "NumPhone";
            this.numPhoneDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.numPhoneDataGridViewTextBoxColumn.Name = "numPhoneDataGridViewTextBoxColumn";
            this.numPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.numPhoneDataGridViewTextBoxColumn.Width = 191;
            // 
            // deviceDataGridViewTextBoxColumn
            // 
            this.deviceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.deviceDataGridViewTextBoxColumn.DataPropertyName = "Device";
            this.deviceDataGridViewTextBoxColumn.HeaderText = "Устройство";
            this.deviceDataGridViewTextBoxColumn.Name = "deviceDataGridViewTextBoxColumn";
            this.deviceDataGridViewTextBoxColumn.ReadOnly = true;
            this.deviceDataGridViewTextBoxColumn.Width = 141;
            // 
            // descDataGridViewTextBoxColumn
            // 
            this.descDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descDataGridViewTextBoxColumn.DataPropertyName = "Desc";
            this.descDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descDataGridViewTextBoxColumn.Name = "descDataGridViewTextBoxColumn";
            this.descDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 511);
            this.Controls.Add(this.DgvRequest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ТехноВсё Новозыбков";
            this.Load += new System.EventHandler(this.FormRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tehnoVseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRequest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.BindingSource requestBindingSource;
        public TehnoVseDataSet tehnoVseDataSet;
        public TehnoVseDataSetTableAdapters.RequestTableAdapter requestTableAdapter;
        public System.Windows.Forms.DataGridView DgvRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRequestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeRequestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descDataGridViewTextBoxColumn;
    }
}