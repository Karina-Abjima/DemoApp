
  using Microsoft.Maui.Controls;
using MauiApp2.Models;
//using MauiApp2.Services;
using System;
using System.Collections.Generic;
namespace MauiApp2
{
            public partial class UserListPage : ContentPage
            {
                private ListView listView;

                public UserListPage()
                {
                    InitializeComponent();

                    // Create the ListView
                    listView = new ListView
                    {
                        ItemTemplate = new DataTemplate(typeof(UserDataCell)),
                     //   ItemsSource = DatabaseService.GetUserData() // Retrieve the user data from the database
                    };

                    Content = new StackLayout
                    {
                        Children = { listView }
                    };
                }
            }

            public class UserDataCell : ViewCell
            {
                public UserDataCell()
                {
                    var nameLabel = new Label();
                    nameLabel.SetBinding(Label.TextProperty, "Name");

                    var rollNumberLabel = new Label();
                    rollNumberLabel.SetBinding(Label.TextProperty, "RollNumber");

                    var dobLabel = new Label();
                    dobLabel.SetBinding(Label.TextProperty, "DOB", stringFormat: "{0:dd/MM/yyyy}");

                    View = new StackLayout
                    {
                        Children = { nameLabel, rollNumberLabel, dobLabel }
                    };
                }
            }
        }

    }