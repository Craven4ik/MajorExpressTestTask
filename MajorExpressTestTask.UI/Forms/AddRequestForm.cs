using MajorExpressTestTask.UI.Contracts;

namespace MajorExpressTestTask.UI.Forms;

public partial class AddRequestForm : Form
{
    public AddRequestForm()
    {
        InitializeComponent();
    }

    public RequestInfo GetRequestInfo()
    {
        return new RequestInfo
        (
            textBoxName.Text,
            textBoxDescription.Text,
            textBoxDeliveryAddress.Text
        );
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxName.Text))
        {
            MessageBox.Show("Введите название заявки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBoxName.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(textBoxDescription.Text))
        {
            MessageBox.Show("Введите описание заявки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBoxDescription.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(textBoxDeliveryAddress.Text))
        {
            MessageBox.Show("Введите адрес доставки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBoxDeliveryAddress.Focus();
            return;
        }

        DialogResult = DialogResult.OK;

        Close();
    }
}
