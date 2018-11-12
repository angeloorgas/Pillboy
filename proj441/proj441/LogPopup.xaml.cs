﻿using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace proj441
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LogPopup
	{
        public Prescription pre = new Prescription();
		public LogPopup ()
		{
			InitializeComponent ();
		}

        public LogPopup(Prescription p)
        {
            InitializeComponent();
            pre.CopyPrescription(p);
            DosageStepper.Value = pre.PrescribedDosage;
        }

        private void DosageStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            AmountLabel.Text = ((int)DosageStepper.Value).ToString();  //converting from double to int to string
        }

        private async Task AddToHistory_Clicked(object sender, EventArgs e)
        {
            App.MyHistory.Add(pre);
            await PopupNavigation.Instance.PopAsync(true);
        }

        private async void CancelToHistory_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync(true);
        }
    }
}