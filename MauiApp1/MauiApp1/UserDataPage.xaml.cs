using System.Xml.Linq;
using Microsoft.Maui.Controls;


namespace MauiApp1

{
public partial class UserDataPage : ContentPage
{
     private string name;
    private string rollNumber;
    private DateTime dob;

    public UserDataPage()
    {
        InitializeComponent();
    }

    private void OnDateSelected(object sender, DateChangedEventArgs e)
    {
        dob = e.NewDate;
    }

    private void OnSaveClicked(object sender, EventArgs e)
    {
        name = nameEntry.Text;
        rollNumber = rollNumberEntry.Text;

    }
}
}