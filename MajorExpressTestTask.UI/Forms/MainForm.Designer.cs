namespace MajorExpressTestTask.UI.Forms
{
    partial class MainForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dataGridViewRequests = new DataGridView();
            labelHeader = new Label();
            textBoxSearchText = new TextBox();
            buttonSearch = new Button();
            buttonAddRequest = new Button();
            buttonDeleteRequest = new Button();
            buttonAssignPerformer = new Button();
            buttonEditRequest = new Button();
            buttonCancelRequest = new Button();
            buttonExecuteRequest = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRequests
            // 
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewRequests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewRequests.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRequests.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewRequests.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewRequests.Location = new Point(12, 181);
            dataGridViewRequests.Name = "dataGridViewRequests";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewRequests.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewRequests.RowHeadersWidth = 51;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewRequests.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewRequests.Size = new Size(1238, 691);
            dataGridViewRequests.TabIndex = 0;
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelHeader.Location = new Point(18, 20);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(348, 62);
            labelHeader.TabIndex = 1;
            labelHeader.Text = "Реестр заявок";
            // 
            // textBoxSearchText
            // 
            textBoxSearchText.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxSearchText.Location = new Point(18, 109);
            textBoxSearchText.Name = "textBoxSearchText";
            textBoxSearchText.PlaceholderText = "Введите текст для поиска";
            textBoxSearchText.Size = new Size(315, 39);
            textBoxSearchText.TabIndex = 2;
            // 
            // buttonSearch
            // 
            buttonSearch.AutoSize = true;
            buttonSearch.Font = new Font("Segoe UI", 14F);
            buttonSearch.Location = new Point(357, 106);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 42);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Найти";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonAddRequest
            // 
            buttonAddRequest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAddRequest.Font = new Font("Segoe UI", 14F);
            buttonAddRequest.Location = new Point(581, 26);
            buttonAddRequest.Name = "buttonAddRequest";
            buttonAddRequest.Size = new Size(320, 40);
            buttonAddRequest.TabIndex = 4;
            buttonAddRequest.Text = "Добавить заявку";
            buttonAddRequest.UseVisualStyleBackColor = true;
            buttonAddRequest.Click += buttonAddRequest_Click;
            // 
            // buttonDeleteRequest
            // 
            buttonDeleteRequest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDeleteRequest.Font = new Font("Segoe UI", 14F);
            buttonDeleteRequest.Location = new Point(581, 118);
            buttonDeleteRequest.Name = "buttonDeleteRequest";
            buttonDeleteRequest.Size = new Size(320, 40);
            buttonDeleteRequest.TabIndex = 5;
            buttonDeleteRequest.Text = "Удалить заявку";
            buttonDeleteRequest.UseVisualStyleBackColor = true;
            buttonDeleteRequest.Click += buttonDeleteRequest_Click;
            // 
            // buttonAssignPerformer
            // 
            buttonAssignPerformer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAssignPerformer.Font = new Font("Segoe UI", 14F);
            buttonAssignPerformer.Location = new Point(913, 26);
            buttonAssignPerformer.Name = "buttonAssignPerformer";
            buttonAssignPerformer.Size = new Size(320, 40);
            buttonAssignPerformer.TabIndex = 6;
            buttonAssignPerformer.Text = "Назначить исполнителя";
            buttonAssignPerformer.UseVisualStyleBackColor = true;
            buttonAssignPerformer.Click += buttonAssignPerformer_Click;
            // 
            // buttonEditRequest
            // 
            buttonEditRequest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEditRequest.Font = new Font("Segoe UI", 14F);
            buttonEditRequest.Location = new Point(581, 72);
            buttonEditRequest.Name = "buttonEditRequest";
            buttonEditRequest.Size = new Size(320, 40);
            buttonEditRequest.TabIndex = 7;
            buttonEditRequest.Text = "Редактировать заявку";
            buttonEditRequest.UseVisualStyleBackColor = true;
            buttonEditRequest.Click += buttonEditRequest_Click;
            // 
            // buttonCancelRequest
            // 
            buttonCancelRequest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCancelRequest.Font = new Font("Segoe UI", 14F);
            buttonCancelRequest.Location = new Point(913, 118);
            buttonCancelRequest.Name = "buttonCancelRequest";
            buttonCancelRequest.Size = new Size(320, 40);
            buttonCancelRequest.TabIndex = 8;
            buttonCancelRequest.Text = "Отменить заявку";
            buttonCancelRequest.UseVisualStyleBackColor = true;
            buttonCancelRequest.Click += buttonCancelRequest_Click;
            // 
            // buttonExecuteRequest
            // 
            buttonExecuteRequest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonExecuteRequest.Font = new Font("Segoe UI", 14F);
            buttonExecuteRequest.Location = new Point(913, 72);
            buttonExecuteRequest.Name = "buttonExecuteRequest";
            buttonExecuteRequest.Size = new Size(320, 40);
            buttonExecuteRequest.TabIndex = 9;
            buttonExecuteRequest.Text = "Отметить как выполенная";
            buttonExecuteRequest.UseVisualStyleBackColor = true;
            buttonExecuteRequest.Click += buttonExecuteRequest_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 977);
            Controls.Add(buttonExecuteRequest);
            Controls.Add(buttonCancelRequest);
            Controls.Add(buttonEditRequest);
            Controls.Add(buttonAssignPerformer);
            Controls.Add(buttonDeleteRequest);
            Controls.Add(buttonAddRequest);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearchText);
            Controls.Add(labelHeader);
            Controls.Add(dataGridViewRequests);
            Name = "MainForm";
            Text = "Реестр заявок";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewRequests;
        private Label labelHeader;
        private TextBox textBoxSearchText;
        private Button buttonSearch;
        private Button buttonAddRequest;
        private Button buttonDeleteRequest;
        private Button buttonAssignPerformer;
        private Button buttonEditRequest;
        private Button buttonCancelRequest;
        private Button buttonExecuteRequest;
    }
}