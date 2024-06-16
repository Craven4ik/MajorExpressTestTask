using MajorExpressTestTask.Domain.Models;

namespace MajorExpressTestTask.UI.Forms;

public partial class SelectCourierForm : Form
{
    public SelectCourierForm(List<Courier> couriers)
    {
        InitializeComponent();

        comboBoxCouriers.DataSource = couriers;
        comboBoxCouriers.DisplayMember = "Name";
    }

    public Courier SelectedCourier => (Courier)comboBoxCouriers.SelectedItem;

    private void buttonCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    private void buttonApprove_Click(object sender, EventArgs e)
    {
        if (comboBoxCouriers.SelectedItem != null)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        else
        {
            MessageBox.Show("Выберите курьера.");
        }
    }
}
