using System.Xml.Linq;
using Microsoft.Data.SqlClient;
using Microsoft.Maui.Controls;
using Dapper;


namespace MauiApp2

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

        private async void OnSaveClicked(object sender, EventArgs e)
        { 
            name = nameEntry.Text;
            rollNumber = rollNumberEntry.Text;
            dob = dobPicker.Date;
            // Create a new UserData instance
            var userData = new Models.UserData
            {
                Name = name,
                RollNumber = rollNumber,
                DOB = dob
            };

            // Retrieve the connection string from the configuration
            string connectionString = "Db";

            // Insert the user data into the database using Dapper
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO UserData (Name, RollNumber, DOB) VALUES (@Name, @RollNumber, @DOB)";
                  connection.Execute(query, userData);
            }
            //await Navigation.PushAsync(new SuccessPage());
        }
    }

}