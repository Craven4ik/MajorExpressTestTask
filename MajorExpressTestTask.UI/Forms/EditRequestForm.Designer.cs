namespace MajorExpressTestTask.UI.Forms
{
    partial class EditRequestForm
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
            buttonSave = new Button();
            buttonCancel = new Button();
            textBoxDeliveryAddress = new TextBox();
            textBoxDescription = new TextBox();
            textBoxName = new TextBox();
            labelHeader = new Label();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 14F);
            buttonSave.Location = new Point(405, 363);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(145, 41);
            buttonSave.TabIndex = 11;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 14F);
            buttonCancel.Location = new Point(250, 363);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(145, 41);
            buttonCancel.TabIndex = 10;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxDeliveryAddress
            // 
            textBoxDeliveryAddress.Font = new Font("Segoe UI", 14F);
            textBoxDeliveryAddress.Location = new Point(250, 271);
            textBoxDeliveryAddress.Name = "textBoxDeliveryAddress";
            textBoxDeliveryAddress.PlaceholderText = "Введите адрес доставки";
            textBoxDeliveryAddress.Size = new Size(300, 39);
            textBoxDeliveryAddress.TabIndex = 9;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Font = new Font("Segoe UI", 14F);
            textBoxDescription.Location = new Point(250, 200);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.PlaceholderText = "Введите описание заявки";
            textBoxDescription.Size = new Size(300, 39);
            textBoxDescription.TabIndex = 8;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 14F);
            textBoxName.Location = new Point(250, 127);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Введите название заявки";
            textBoxName.Size = new Size(300, 39);
            textBoxName.TabIndex = 7;
            // 
            // labelHeader
            // 
            labelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelHeader.Location = new Point(295, 50);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(217, 32);
            labelHeader.TabIndex = 6;
            labelHeader.Text = "Изменить заявку";
            labelHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EditRequestForm
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
            Name = "EditRequestForm";
            Text = "Форма изменения заявки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Button buttonCancel;
        private TextBox textBoxDeliveryAddress;
        private TextBox textBoxDescription;
        private TextBox textBoxName;
        private Label labelHeader;
    }
}