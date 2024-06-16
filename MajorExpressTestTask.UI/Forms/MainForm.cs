using MajorExpressTestTask.Domain.Enums;
using MajorExpressTestTask.Domain.Interfaces.Services;
using MajorExpressTestTask.Domain.Models;

namespace MajorExpressTestTask.UI.Forms;

public partial class MainForm : Form
{
    private readonly IRequestService _requestService;
    private readonly ICourierService _courierService;
    private BindingSource _requestsBindingSource;

    public MainForm(IRequestService requestService, ICourierService courierService)
    {
        InitializeComponent();
        _requestService = requestService;
        _courierService = courierService;
        _requestsBindingSource = new BindingSource();
    }

    private async void MainForm_Load(object sender, EventArgs e)
    {
        InitializeDataGridView();
        await LoadRequestsAsync();
    }

    private async Task LoadRequestsAsync()
    {
        var requests = await _requestService.GetRequestsAsync();

        var requestsWithCourierNames = requests.Select(request => new
        {
            Id = request.Id,
            Name = request.Name,
            Description = request.Description,
            DeliveryAddress = request.DeliveryAddress,
            Status = request.Status,
            CreatedDate = request.CreatedDate,
            CancellingReason = request.CancellingReason,
            CourierName = request.Delivery?.Courier?.Name ?? string.Empty
        }).ToList();

        _requestsBindingSource.DataSource = requestsWithCourierNames;
        dataGridViewRequests.DataSource = _requestsBindingSource;
    }

    private void InitializeDataGridView()
    {
        dataGridViewRequests.AutoGenerateColumns = false;
        dataGridViewRequests.Columns.AddRange(
        [
            new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Название", ReadOnly = true },
            new DataGridViewTextBoxColumn { DataPropertyName = "Description", HeaderText = "Описание", ReadOnly = true },
            new DataGridViewTextBoxColumn { DataPropertyName = "DeliveryAddress", HeaderText = "Адрес доставки", ReadOnly = true },
            new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Статус", ReadOnly = true },
            new DataGridViewTextBoxColumn { DataPropertyName = "CreatedDate", HeaderText = "Дата создания", ReadOnly = true },
            new DataGridViewTextBoxColumn { DataPropertyName = "CourierName", HeaderText = "Курьер", ReadOnly = true },
            new DataGridViewTextBoxColumn { DataPropertyName = "CancellingReason", HeaderText = "Причина отмены", ReadOnly = true }
        ]);
    }

    private async void buttonSearch_Click(object sender, EventArgs e)
    {
        string searchText = textBoxSearchText.Text;

        if (!string.IsNullOrEmpty(searchText))
        {
            var requests = await _requestService.FindRequestsAsync(searchText);

            var requestsWithCourierNames = requests.Select(request => new
            {
                Id = request.Id,
                Name = request.Name,
                Description = request.Description,
                DeliveryAddress = request.DeliveryAddress,
                Status = request.Status,
                CreatedDate = request.CreatedDate,
                CancellingReason = request.CancellingReason,
                CourierName = request.Delivery?.Courier?.Name ?? string.Empty
            }).ToList();

            _requestsBindingSource.DataSource = requestsWithCourierNames;
            dataGridViewRequests.DataSource = _requestsBindingSource;
        }
        else
            await LoadRequestsAsync();
    }

    private async void buttonAddRequest_Click(object sender, EventArgs e)
    {
        var addRequestForm = new AddRequestForm();

        if (addRequestForm.ShowDialog() == DialogResult.OK)
        {
            var requestInfo = addRequestForm.GetRequestInfo();

            await _requestService.CreateRequestAsync(requestInfo);

            await LoadRequestsAsync();
        }
    }

    private async void buttonDeleteRequest_Click(object sender, EventArgs e)
    {
        if (dataGridViewRequests.SelectedRows.Count > 0)
        {
            var selectedRow = dataGridViewRequests.SelectedRows[0];
            var request = (dynamic)selectedRow.DataBoundItem;

            if (MessageBox.Show($"Вы действительно хотите удалить заявку '{request.Name}'?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await _requestService.DeleteRequestAsync(request.Id);
                await LoadRequestsAsync();
            }
        }
        else
            MessageBox.Show("Выберите заявку для удаления");
    }

    private async Task<List<Courier>> LoadCouriersAsync()
    {
        var couriers = await _courierService.GetCouriersAsync();
        return couriers;
    }

    private async void buttonAssignPerformer_Click(object sender, EventArgs e)
    {
        if (dataGridViewRequests.SelectedRows.Count == 0)
        {
            MessageBox.Show("Выберите заявку для назначения исполнителя");
            return;
        }

        var selectedRow = dataGridViewRequests.SelectedRows[0];
        var selectedRequest = (dynamic)selectedRow.DataBoundItem;

        if (selectedRequest.Status != Status.New)
        {
            MessageBox.Show("Назначение исполнителя доступно только для новых заявок");
            return;
        }

        var couriers = await LoadCouriersAsync();

        var selectCourierForm = new SelectCourierForm(couriers);

        if (selectCourierForm.ShowDialog() == DialogResult.OK)
        {
            var selectedCourier = selectCourierForm.SelectedCourier;
            await _requestService.AssignCourierAsync(selectedRequest.Id, selectedCourier.Id);
            await LoadRequestsAsync();
        }
    }

    private async void buttonEditRequest_Click(object sender, EventArgs e)
    {
        if (dataGridViewRequests.SelectedRows.Count == 0)
        {
            MessageBox.Show("Выберите заявку для редактирования");
            return;
        }

        var selectedRow = dataGridViewRequests.SelectedRows[0];
        var selectedRequest = (dynamic)selectedRow.DataBoundItem;

        if (selectedRequest.Status != Status.New)
        {
            MessageBox.Show("Редактирование доступно только для новых заявок");
            return;
        }

        var request = new Request()
        {
            Name = selectedRequest.Name,
            Description = selectedRequest.Description,
            DeliveryAddress = selectedRequest.DeliveryAddress
        };

        var editRequestForm = new EditRequestForm(request);

        if (editRequestForm.ShowDialog() == DialogResult.OK)
        {
            var requestInfo = editRequestForm.GetRequestInfo();
            await _requestService.UpdateRequestAsync(selectedRequest.Id, requestInfo);
            await LoadRequestsAsync();
        }
    }

    private async void buttonExecuteRequest_Click(object sender, EventArgs e)
    {
        if (dataGridViewRequests.SelectedRows.Count == 0)
        {
            MessageBox.Show("Выберите заявку для перевода в статус 'Выполнено'");
            return;
        }

        var selectedRow = dataGridViewRequests.SelectedRows[0];
        var selectedRequest = (dynamic)selectedRow.DataBoundItem;

        if (selectedRequest.Status != Status.InProgress)
        {
            MessageBox.Show("Перевод в статус 'Выполнено' доступен только для заявок со статусом 'Передано на выполнение'");
            return;
        }

        if (MessageBox.Show($"Вы действительно хотите перевести заявку '{selectedRequest.Name}' в статус 'Выполнено'?", "Подтверждение перевода", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            await _requestService.ExecuteRequestAsync(selectedRequest.Id);
            await LoadRequestsAsync();
        }
    }

    private async void buttonCancelRequest_Click(object sender, EventArgs e)
    {
        if (dataGridViewRequests.SelectedRows.Count == 0)
        {
            MessageBox.Show("Выберите заявку для отмены");
            return;
        }

        var selectedRow = dataGridViewRequests.SelectedRows[0];
        var selectedRequest = (dynamic)selectedRow.DataBoundItem;

        if (selectedRequest.Status == Status.Cancelled)
        {
            MessageBox.Show("Эта заявка уже отменена");
            return;
        }

        var cancelRequestForm = new CancelRequestForm();

        if (cancelRequestForm.ShowDialog() == DialogResult.OK)
        {
            await _requestService.CancelRequestAsync(selectedRequest.Id, cancelRequestForm.GetCancellingReason());
            await LoadRequestsAsync();
        }
    }
}
