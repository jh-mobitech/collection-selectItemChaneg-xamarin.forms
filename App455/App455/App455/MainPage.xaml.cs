using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App455
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
    }

    public class MainPageModel : FreshBasePageModel
    {
        public override void Init(object initData)
        {
            Tags = new ObservableCollection<string>() { "A", "B", "C" };

            base.Init(initData);
        }

        public ObservableCollection<string> Tags { get; set; }

        public string SelectedTag { get; set; }

        public Command SelectedTagChangedCommand
        {
            get
            {
                return new Command(() =>
                {

                    Console.WriteLine("1231231");
                });
            }
        }
    }
}
