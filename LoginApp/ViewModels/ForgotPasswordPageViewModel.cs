﻿using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using LoginApp.Services;
using Xamarin.Forms;

namespace LoginApp.ViewModels
{
    public class ForgotPasswordPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private IPageService _pageService;
        public ICommand SubmitButton { get; private set; }
        public ICommand BackToLoginButton { get; private set; }
        private string _email;
        

        public ForgotPasswordPageViewModel(IPageService pageService)
        {
            _pageService = pageService;

            BackToLoginButton = new Command(async () => await PopModalForgotPasswordPage());
        }

        public string EmailField
        {
            get { return _email; }
            set {
                _email = value;
                PropertyChanged(this, new PropertyChangedEventArgs(EmailField));
                    }
        }

        private async Task PopModalForgotPasswordPage()
        {
            await _pageService.PopModalAsync();
        }

        //private async Task Submit()
        //{
            
        //}

    }
}
