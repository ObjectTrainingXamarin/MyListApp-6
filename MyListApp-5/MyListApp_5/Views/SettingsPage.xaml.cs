﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyListApp;
namespace MyListApp_5
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
            //BindingContext = new ContentPageViewModel();
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            // TODO Validate
            User user = new User();
            user.FirstName = firstNameEntry.Text;
            user.Surname = surnameNameEntry.Text;
            user.UserName = userNameEntry.Text;
            user.Password = passwordEntry.Text;
            user.ServerURL = serverURLEntry.Text;
            Model.Users.Clear();
            Model.Users.Add(user);
            Database.SaveModel();
        }

        //	Use to load saved user
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (Model.Users.Count > 0)
            {
                firstNameEntry.Text = Model.Users[0].FirstName;
                surnameNameEntry.Text = Model.Users[0].Surname;
                userNameEntry.Text = Model.Users[0].UserName;
                passwordEntry.Text = Model.Users[0].Password;
                serverURLEntry.Text = Model.Users[0].ServerURL;
            }

        }

    }

    
    
}
