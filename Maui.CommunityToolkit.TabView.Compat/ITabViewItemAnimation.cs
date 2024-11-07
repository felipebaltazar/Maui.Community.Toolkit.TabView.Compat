namespace Maui.CommunityToolkit.TabView.Compat;

public interface ITabViewItemAnimation
{
    Task OnSelected(View tabViewItem);

    Task OnDeSelected(View tabViewItem);
}