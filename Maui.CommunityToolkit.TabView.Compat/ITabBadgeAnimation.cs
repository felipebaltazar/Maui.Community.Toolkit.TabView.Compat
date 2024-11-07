namespace Maui.CommunityToolkit.TabView.Compat;

public interface ITabBadgeAnimation
{
    Task OnAppearing(TabBadgeView badgeView);

    Task OnDisappering(TabBadgeView badgeView);
}