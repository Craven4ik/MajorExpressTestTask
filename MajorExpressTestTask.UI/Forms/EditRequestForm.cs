using MajorExpressTestTask.Domain.Models;
using MajorExpressTestTask.UI.Contracts;

namespace MajorExpressTestTask.UI.Forms;

public partial class EditRequestForm : Form
{
    public EditRequestForm(Request request)
    {
        InitializeComponent();

        textBoxName.Text = request.Name;
        textBoxDescription.Text = request.Description;
        textBoxDeliveryAddress.Text = request.DeliveryAddress;
    }

    public RequestInfo GetRequestInfo() => new RequestInfo(
        textBoxName.Text,
        textBoxDescription.Text,
        textBoxDeliveryAddress.Text
        );

    private void buttonCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
            string.IsNullOrWhiteSpace(textBoxDescription.Text) ||
            string.IsNullOrWhiteSpace(textBoxDeliveryAddress.Text))
        {
            MessageBox.Show("Заполните все поля.");
            return;
        }

        DialogResult = DialogResult.OK;
        Close();
    }
}
