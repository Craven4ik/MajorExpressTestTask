namespace MajorExpressTestTask.UI.Forms;

public partial class CancelRequestForm : Form
{
    public CancelRequestForm()
    {
        InitializeComponent();
    }

    public string GetCancellingReason() => textBoxCancellingReason.Text;

    private void buttonCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxCancellingReason.Text))
        {
            MessageBox.Show("Укажите причину отмены");
            return;
        }

        DialogResult = DialogResult.OK;
        Close();
    }
}
