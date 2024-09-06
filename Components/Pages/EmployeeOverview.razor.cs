using BethanysPieShopHRM.Services;
using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopHRM.Components.Pages;

public partial class EmployeeOverview
{
    private Employee? _selectedEmployee;
    public List<Employee>? Employees { get; set; }

    private string Title = "Employee overview";

    protected override async Task OnInitializedAsync()
    {
        await Task.Delay(2000);
        Employees = MockDataService.Employees!;
    }

    public void ShowQuickViewPopup(Employee selectedEmployee)
    {
        _selectedEmployee = selectedEmployee;
    }
}