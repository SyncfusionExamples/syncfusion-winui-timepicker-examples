using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Syncfusion.UI.Xaml.Editors;
using System.Globalization;
using System.Collections.ObjectModel;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace TimeFieldPrepared
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Get the ItemsSource for minute or second column.
        /// </summary>
        /// <returns>Return the ItemsSource for minute or second column.</returns>
        private static ObservableCollection<string> GetMinutesOrSeconds(string pattern)
        {
            ObservableCollection<string> minutes = new ObservableCollection<string>();
            NumberFormatInfo provider = new NumberFormatInfo();
            for (int i = 0; i < 60; i = i + 5)
            {
                if (i > 9 || pattern == "%s" || pattern == "{second.integer}" || pattern == "%m" || pattern == "{minute.integer}")
                {
                    minutes.Add(i.ToString(provider));
                }
                else
                {
                    minutes.Add("0" + i.ToString(provider));
                }
            }

            return minutes;
        }

        private void sfTimePicker_TimeFieldPrepared(object sender, DateTimeFieldPreparedEventArgs e)
        {
            if (e.Column != null)
            {
                //Minutes interval changed as 5.
                if (e.Column.Field == DateTimeField.Minute || e.Column.Field == DateTimeField.Second)
                {
                    e.Column.ItemsSource = GetMinutesOrSeconds(e.Column.Format);
                }
                if (e.Column.Field == DateTimeField.Hour12)
                {
                    e.Column.Header = "Hr";
                    e.Column.ItemHeight = 60;
                    e.Column.ItemWidth = 100;
                }
                else if (e.Column.Field == DateTimeField.Minute)
                {
                    e.Column.Header = "Min";
                    e.Column.ItemHeight = 40;
                    e.Column.ItemWidth = 100;
                }
                else if (e.Column.Field == DateTimeField.Meridiem)
                {
                    e.Column.Header = "AM/PM";
                    e.Column.ItemHeight = 60;
                    e.Column.ItemWidth = 100;
                }
                e.Column.ShowHeader = true;

            }
        }
    }
}
