namespace MajorExpressTestTask.UI.Forms
{
    partial class AddRequestForm
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
            labelHeader = new Label();
            textBoxName = new TextBox();
            textBoxDescription = new TextBox();
            textBoxDeliveryAddress = new TextBox();
            buttonCancel = new Button();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // labelHeader
            // 
            labelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelHeader.Location = new Point(255, 27);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(300, 32);
            labelHeader.TabIndex = 0;
            labelHeader.Text = "Добавить новую заявку";
            labelHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 14F);
            textBoxName.Location = new Point(255, 107);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Введите название заявки";
            textBoxName.Size = new Size(300, 39);
            textBoxName.TabIndex = 1;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Font = new Font("Segoe UI", 14F);
            textBoxDescription.Location = new Point(255, 180);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.PlaceholderText = "Введите описание заявки";
            textBoxDescription.Size = new Size(300, 39);
            textBoxDescription.TabIndex = 2;
            // 
            // textBoxDeliveryAddress
            // 
            textBoxDeliveryAddress.Font = new Font("Segoe UI", 14F);
            textBoxDeliveryAddress.Location = new Point(255, 251);
            textBoxDeliveryAddress.Name = "textBoxDeliveryAddress";
            textBoxDeliveryAddress.PlaceholderText = "Введите адрес доставки";
            textBoxDeliveryAddress.Size = new Size(300, 39);
            textBoxDeliveryAddress.TabIndex = 3;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 14F);
            buttonCancel.Location = new Point(255, 343);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(145, 41);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 14F);
            buttonSave.Location = new Point(410, 343);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(145, 41);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // AddRequestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Controls.Add(textBoxDeliveryAddress);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxName);
            Controls.Add(labelHeader);
            Name = "AddRequestForm";
            Text = "Форма добавления заявки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeader;
        private TextBox textBoxName;
        private TextBox textBoxDescription;
        private TextBox textBoxDeliveryAddress;
        private Button buttonCancel;
        private Button buttonSave;
    }
}