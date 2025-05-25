using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CocQuery.ViewModels
{
    public class CocFormationListViewModel : ViewModelBase
    {
        public CocFormationListViewModel()
        {
            RefreshCommand = new AsyncRelayCommand(Refresh);
            Formations = new ObservableCollection<CocFormation>()
            {
                new CocFormation
                {
                    ImageUrl = "https://clashofclans-layouts.com/pics/th13_plans/war/preview/th13_war_255.jpg?u=1738927026",
                    PublishDate = DateTime.Now,
                    Publisher = "Publisher 1"
                },
                new CocFormation
                {
                    ImageUrl = "https://clashofclans-layouts.com/pics/th13_plans/war/preview/th13_war_255.jpg?u=1738927026",
                    PublishDate = DateTime.Now.AddDays(-1),
                    Publisher = "Publisher 2"
                },
                new CocFormation
                {
                    ImageUrl = "https://clashofclans-layouts.com/pics/th13_plans/war/preview/th13_war_255.jpg?u=1738927026",
                    PublishDate = DateTime.Now.AddDays(-2),
                    Publisher = "Publisher 3"
                },new CocFormation
                {
                    ImageUrl = "https://clashofclans-layouts.com/pics/th13_plans/war/preview/th13_war_255.jpg?u=1738927026",
                    PublishDate = DateTime.Now.AddDays(-1),
                    Publisher = "Publisher 2"
                },new CocFormation
                {
                    ImageUrl = "https://clashofclans-layouts.com/pics/th13_plans/war/preview/th13_war_255.jpg?u=1738927026",
                    PublishDate = DateTime.Now.AddDays(-1),
                    Publisher = "Publisher 2"
                },new CocFormation
                {
                    ImageUrl = "https://clashofclans-layouts.com/pics/th13_plans/war/preview/th13_war_255.jpg?u=1738927026",
                    PublishDate = DateTime.Now.AddDays(-1),
                    Publisher = "Publisher 2"
                },new CocFormation
                {
                    ImageUrl = "https://clashofclans-layouts.com/pics/th13_plans/war/preview/th13_war_255.jpg?u=1738927026",
                    PublishDate = DateTime.Now.AddDays(-1),
                    Publisher = "Publisher 2"
                },new CocFormation
                {
                    ImageUrl = "https://clashofclans-layouts.com/pics/th13_plans/war/preview/th13_war_255.jpg?u=1738927026",
                    PublishDate = DateTime.Now.AddDays(-1),
                    Publisher = "Publisher 2"
                },new CocFormation
                {
                    ImageUrl = "https://clashofclans-layouts.com/pics/th13_plans/war/preview/th13_war_255.jpg?u=1738927026",
                    PublishDate = DateTime.Now.AddDays(-1),
                    Publisher = "Publisher 2"
                },new CocFormation
                {
                    ImageUrl = "https://clashofclans-layouts.com/pics/th13_plans/war/preview/th13_war_255.jpg?u=1738927026",
                    PublishDate = DateTime.Now.AddDays(-1),
                    Publisher = "Publisher 2"
                },new CocFormation
                {
                    ImageUrl = "https://clashofclans-layouts.com/pics/th13_plans/war/preview/th13_war_255.jpg?u=1738927026",
                    PublishDate = DateTime.Now.AddDays(-1),
                    Publisher = "Publisher 2"
                },new CocFormation
                {
                    ImageUrl = "https://clashofclans-layouts.com/pics/th13_plans/war/preview/th13_war_255.jpg?u=1738927026",
                    PublishDate = DateTime.Now.AddDays(-1),
                    Publisher = "Publisher 2"
                },new CocFormation
                {
                    ImageUrl = "https://clashofclans-layouts.com/pics/th13_plans/war/preview/th13_war_255.jpg?u=1738927026",
                    PublishDate = DateTime.Now.AddDays(-1),
                    Publisher = "Publisher 2"
                },new CocFormation
                {
                    ImageUrl = "https://clashofclans-layouts.com/pics/th13_plans/war/preview/th13_war_255.jpg?u=1738927026",
                    PublishDate = DateTime.Now.AddDays(-1),
                    Publisher = "Publisher 2"
                },new CocFormation
                {
                    ImageUrl = "https://clashofclans-layouts.com/pics/th13_plans/war/preview/th13_war_255.jpg?u=1738927026",
                    PublishDate = DateTime.Now.AddDays(-1),
                    Publisher = "Publisher 2"
                },new CocFormation
                {
                    ImageUrl = "https://clashofclans-layouts.com/pics/th13_plans/war/preview/th13_war_255.jpg?u=1738927026",
                    PublishDate = DateTime.Now.AddDays(-1),
                    Publisher = "Publisher 2"
                },new CocFormation
                {
                    ImageUrl = "https://clashofclans-layouts.com/pics/th13_plans/war/preview/th13_war_255.jpg?u=1738927026",
                    PublishDate = DateTime.Now.AddDays(-1),
                    Publisher = "Publisher 2"
                },new CocFormation
                {
                    ImageUrl = "https://clashofclans-layouts.com/pics/th13_plans/war/preview/th13_war_255.jpg?u=1738927026",
                    PublishDate = DateTime.Now.AddDays(-1),
                    Publisher = "Publisher 2"
                },new CocFormation
                {
                    ImageUrl = "https://clashofclans-layouts.com/pics/th13_plans/war/preview/th13_war_255.jpg?u=1738927026",
                    PublishDate = DateTime.Now.AddDays(-1),
                    Publisher = "Publisher 2"
                },new CocFormation
                {
                    ImageUrl = "https://clashofclans-layouts.com/pics/th13_plans/war/preview/th13_war_255.jpg?u=1738927026",
                    PublishDate = DateTime.Now.AddDays(-1),
                    Publisher = "Publisher 2"
                },new CocFormation
                {
                    ImageUrl = "https://clashofclans-layouts.com/pics/th13_plans/war/preview/th13_war_255.jpg?u=1738927026",
                    PublishDate = DateTime.Now.AddDays(-1),
                    Publisher = "Publisher 2"
                },new CocFormation
                {
                    ImageUrl = "https://clashofclans-layouts.com/pics/th13_plans/war/preview/th13_war_255.jpg?u=1738927026",
                    PublishDate = DateTime.Now.AddDays(-1),
                    Publisher = "Publisher 2"
                },
            };
            _ = Refresh(null);

        }

        private async Task Refresh(object arg)
        {

        }

        
        #region 处理活动指示器的显示和隐藏
        private bool activityIndicatorIsRunning = false;
        public bool ActivityIndicatorIsRunning
        {
            get { return activityIndicatorIsRunning; }
            set
            {
                activityIndicatorIsRunning = value;
                OnPropertyChanged(nameof(ActivityIndicatorIsRunning));
            }
        }
        private bool activityIndicatorIsVisible = false;
        public bool ActivityIndicatorIsVisible
        {
            get { return activityIndicatorIsVisible; }
            set
            {
                activityIndicatorIsVisible = value;
                OnPropertyChanged(nameof(ActivityIndicatorIsVisible));
            }
        }
        #endregion
        private bool _isRefreshing;
        public bool IsRefreshing
        {
            get
            {
                return _isRefreshing;
            }
            set
            {
                _isRefreshing = value;
                OnPropertyChanged(nameof(IsRefreshing));
            }
        }

        private ObservableCollection<CocFormation> _formations;
        public ObservableCollection<CocFormation> Formations
        {
            get { return _formations; }
            set
            {
                _formations = value;
                OnPropertyChanged(nameof(Formations));
            }
        }
        public ICommand RefreshCommand { get; private set; }
    }

    public class CocFormation
    {
        public string ImageUrl { get; set; }
        public DateTime PublishDate { get; set; }
        public string Publisher { get; set; }
        public string ThLevel { get; set; }
    }
}
