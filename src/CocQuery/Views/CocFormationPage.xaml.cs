using CocQuery.ViewModels;

namespace CocQuery.Views;

public partial class CocFormationPage : ContentPage
{
	public CocFormationPage()
	{
		InitializeComponent();
	}

    private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (/*e.CurrentSelection.FirstOrDefault() is Models.Coc.ClanRanking clanRanking &&*/ BindingContext is CocFormationViewModel viewModel)
        {
            await viewModel.OnItemClicked(viewModel);
        }
    }
}