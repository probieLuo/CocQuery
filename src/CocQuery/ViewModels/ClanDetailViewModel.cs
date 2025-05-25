using CocQuery.Models.Coc;
using System.ComponentModel;

namespace CocQuery.ViewModels
{
    public class ClanDetailViewModel: ViewModelBase
    {
        public ClanDetailViewModel(Clan clan)
        {
            Clan = clan;
        }

        private Clan _clan;
        public Clan Clan
        {
            get
            {
                return _clan;
            }
            set
            {
                if (_clan != value)
                {
                    _clan = value;
                    OnPropertyChanged(nameof(Clan));
                }
            }
        }
        internal async Task OnItemClicked(ClanMember clanMember)
        {
            try
            {
                ActivityIndicatorIsRunning = true;
                ActivityIndicatorIsVisible = true;
                if (clanMember != null)
                {
                    Services.Coc.PlayersService playersService = new Services.Coc.PlayersService();

                    var responseResult = await playersService.GetPlayerAsync(clanMember.Tag);
                    Player player1 = responseResult.Data;
                    // 跳转到详细页面
                    await Application.Current.MainPage.Navigation.PushAsync(new Views.PlayerDetailPage(player1));
                }
            }
            catch (Exception e)
            {
#if DEBUG
                throw e;
#endif
            }
            finally
            {
                ActivityIndicatorIsRunning = false;
                ActivityIndicatorIsVisible = false;

            }
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
    }
}
