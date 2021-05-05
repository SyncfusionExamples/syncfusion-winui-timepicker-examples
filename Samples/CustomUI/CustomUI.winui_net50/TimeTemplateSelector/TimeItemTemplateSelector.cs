using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Syncfusion.UI.Xaml.Editors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomUI
{
    public class TimeItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DefaultTemplate { get; set; }
        public DataTemplate AlarmTemplate { get; set; }
        public DataTemplate SleepTemplate { get; set; }
        public DataTemplate GroupMeetingTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            DateTimeFieldItemInfo dateTimeField = item as DateTimeFieldItemInfo;
            if (dateTimeField.Field == DateTimeField.Hour12)
            {
                switch (dateTimeField.DateTime.Value.Hour)
                {
                    case 2:
                        return SleepTemplate as DataTemplate;
                    case 5:
                        return AlarmTemplate as DataTemplate;
                    case 10:
                        return GroupMeetingTemplate as DataTemplate;
                    case 14:
                        return GroupMeetingTemplate as DataTemplate;
                    case 17:
                        return AlarmTemplate as DataTemplate;
                    case 22:
                        return SleepTemplate as DataTemplate;
                }
            }

            return base.SelectTemplateCore(item, container);
        }
    }
}
