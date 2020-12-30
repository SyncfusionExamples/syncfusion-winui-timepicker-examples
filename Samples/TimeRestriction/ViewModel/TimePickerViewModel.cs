using Syncfusion.UI.Xaml.Core;
using Syncfusion.UI.Xaml.Editors;
using System;
namespace TimeRestriction
{
    public class TimePickerViewModel : NotificationObject
    {
        private int visibleItemsCount = 7;
        private bool allowNullValue = true;
        private DateTimeOffset minTime = new DateTimeOffset(DateTimeOffset.Now.Year, DateTimeOffset.Now.Month, DateTimeOffset.Now.Day, 9, 0, 0, DateTimeOffset.Now.Offset);
        private DateTimeOffset maxTime = new DateTimeOffset(DateTimeOffset.Now.Year, DateTimeOffset.Now.Month, DateTimeOffset.Now.Day, 18, 30, 0, DateTimeOffset.Now.Offset);
        private DateTimeEditMode editMode =  DateTimeEditMode.Mask;
        private string placeHolderText= "No Time is Selected";
        private string formatString="f";

        public TimePickerViewModel()
        {
            
        }

        public int VisibleItemsCount
        {
            get
            {
                return visibleItemsCount;
            }
            set
            {
                if (visibleItemsCount != value)
                {
                    visibleItemsCount = value;
                    this.RaisePropertyChanged(nameof(this.VisibleItemsCount));
                }
            }
        }
        public bool AllowNullValue
        {
            get
            {
                return allowNullValue;
            }
            set
            {
                if (allowNullValue != value)
                {
                    allowNullValue = value;
                    this.RaisePropertyChanged(nameof(this.AllowNullValue));
                }
            }
        }

        public string PlaceHolderText
        {
            get
            {
                return placeHolderText;
            }
            set
            {
                if (placeHolderText != value)
                {
                    placeHolderText = value;
                    this.RaisePropertyChanged(nameof(this.PlaceHolderText));
                }
            }
        }

        public DateTimeEditMode EditMode
        {
            get
            {
                return editMode;
            }
            set
            {
                if (editMode != value)
                {
                    editMode = value;
                    this.RaisePropertyChanged(nameof(this.EditMode));
                }
            }
        }

        public DateTimeOffset MinTime
        {
            get
            {
                return minTime;
            }
            set
            {
                if (minTime != value)
                {
                    minTime = value;
                    this.RaisePropertyChanged(nameof(this.MinTime));
                }
            }
        }

        public DateTimeOffset MaxTime
        {
            get
            {
                return maxTime;
            }
            set
            {
                if (maxTime != value)
                {
                    maxTime = value;
                    this.RaisePropertyChanged(nameof(this.MaxTime));
                }
            }
        }
    }
}
