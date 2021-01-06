using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls.Primitives;
using Syncfusion.UI.Xaml.Core;
using Syncfusion.UI.Xaml.Editors;
using System;

namespace ViewAndItemCustomization
{
    public class TimePickerViewModel : NotificationObject
    {
        private int minItemWidth = 0;
        private int maxItemWidth = 300;
        private int itemWidth = 80;
        private int itemHeight = 40;
        private int dropDownHeight = 350;
        private string dropDownHeader = "Choose the time";
        private bool showDropDownButton = true;
        private bool showDropDownHeader = true;
        private bool showColumnHeaders = true;
        private bool showSubmitButtons = true;
        private FlowDirection flowDirection = FlowDirection.LeftToRight;
        private FlyoutPlacementMode dropDownPlacement = FlyoutPlacementMode.BottomEdgeAlignedRight;
        private DateTimeOffsetCollection blackoutTimes;
        private DateTimeOffset? selectedTime = DateTimeOffset.Now.Date;

        public DateTimeOffset? SelectedTime
        {
            get
            {
                return selectedTime;
            }
            set
            {
                if (selectedTime != value)
                {
                    selectedTime = value;
                    this.RaisePropertyChanged(nameof(this.SelectedTime));
                }
            }
        }

        public DateTimeOffsetCollection BlackoutTimes
        {
            get
            {
                return blackoutTimes;
            }
            set
            {
                if (blackoutTimes != value)
                {
                    blackoutTimes = value;
                    this.RaisePropertyChanged(nameof(this.BlackoutTimes));
                }
            }
        }
        public FlyoutPlacementMode DropDownPlacement
        {
            get
            {
                return dropDownPlacement;
            }
            set
            {
                if (dropDownPlacement != value)
                {
                    dropDownPlacement = value;
                    this.RaisePropertyChanged(nameof(this.DropDownPlacement));
                }
            }
        }

        public FlowDirection FlowDirection
        {
            get
            {
                return flowDirection;
            }
            set
            {
                if (flowDirection != value)
                {
                    flowDirection = value;
                    this.RaisePropertyChanged(nameof(this.FlowDirection));
                }
            }
        }

        public string DropDownHeader
        {
            get
            {
                return dropDownHeader;
            }
            set
            {
                if (dropDownHeader != value)
                {
                    dropDownHeader = value;
                    this.RaisePropertyChanged(nameof(this.DropDownHeader));
                }
            }
        }

        public bool ShowDropDownButton
        {
            get
            {
                return showDropDownButton;
            }
            set
            {
                if (showDropDownButton != value)
                {
                    showDropDownButton = value;
                    this.RaisePropertyChanged(nameof(this.ShowDropDownButton));
                }
            }
        }
        public bool ShowDropDownHeader
        {
            get
            {
                return showDropDownHeader;
            }
            set
            {
                if (showDropDownHeader != value)
                {
                    showDropDownHeader = value;
                    this.RaisePropertyChanged(nameof(this.ShowDropDownHeader));
                }
            }
        }
        public bool ShowColumnHeaders
        {
            get
            {
                return showColumnHeaders;
            }
            set
            {
                if (showColumnHeaders != value)
                {
                    showColumnHeaders = value;
                    this.RaisePropertyChanged(nameof(this.ShowColumnHeaders));
                }
            }
        }

        public bool ShowSubmitButtons
        {
            get
            {
                return showSubmitButtons;
            }
            set
            {
                if (showSubmitButtons != value)
                {
                    showSubmitButtons = value;
                    this.RaisePropertyChanged(nameof(this.ShowSubmitButtons));
                }
            }
        }

        public int MinItemWidth
        {
            get
            {
                return minItemWidth;
            }
            set
            {
                if (minItemWidth != value)
                {
                    minItemWidth = value;
                    this.RaisePropertyChanged(nameof(this.MinItemWidth));
                }
            }
        }

        public int MaxItemWidth
        {
            get
            {
                return maxItemWidth;
            }
            set
            {
                if (maxItemWidth != value)
                {
                    maxItemWidth = value;
                    this.RaisePropertyChanged(nameof(this.MaxItemWidth));
                }
            }
        }

        public int ItemWidth
        {
            get
            {
                return itemWidth;
            }
            set
            {
                if (itemWidth != value)
                {
                    itemWidth = value;
                    this.RaisePropertyChanged(nameof(this.ItemWidth));
                }
            }
        }

        public int ItemHeight
        {
            get
            {
                return itemHeight;
            }
            set
            {
                if (itemHeight != value)
                {
                    itemHeight = value;
                    this.RaisePropertyChanged(nameof(this.ItemHeight));
                }
            }
        }

        public int DropDownHeight
        {
            get
            {
                return dropDownHeight;
            }
            set
            {
                if (dropDownHeight != value)
                {
                    dropDownHeight = value;
                    this.RaisePropertyChanged(nameof(this.DropDownHeight));
                }
            }
        }

        public TimePickerViewModel()
        {
            BlackoutTimes = new DateTimeOffsetCollection();
            BlackoutTimes.Add(new DateTimeOffset(DateTimeOffset.Now.Year, DateTimeOffset.Now.Month, DateTimeOffset.Now.Day, 0, 3, 0, DateTimeOffset.Now.Offset));
            BlackoutTimes.Add(new DateTimeOffset(DateTimeOffset.Now.Year, DateTimeOffset.Now.Month, DateTimeOffset.Now.Day, 0, 58, 0, DateTimeOffset.Now.Offset));
            BlackoutTimes.Add(new DateTimeOffset(DateTimeOffset.Now.Year, DateTimeOffset.Now.Month, DateTimeOffset.Now.Day, 1, 0, 0, DateTimeOffset.Now.Offset));
            BlackoutTimes.Add(new DateTimeOffset(DateTimeOffset.Now.Year, DateTimeOffset.Now.Month, DateTimeOffset.Now.Day, 3, 0, 0, DateTimeOffset.Now.Offset));
            BlackoutTimes.Add(new DateTimeOffset(DateTimeOffset.Now.Year, DateTimeOffset.Now.Month, DateTimeOffset.Now.Day, 9, 0, 0, DateTimeOffset.Now.Offset));
            BlackoutTimes.Add(new DateTimeOffset(DateTimeOffset.Now.Year, DateTimeOffset.Now.Month, DateTimeOffset.Now.Day, 10, 0, 0, DateTimeOffset.Now.Offset));
        }
    }
}
