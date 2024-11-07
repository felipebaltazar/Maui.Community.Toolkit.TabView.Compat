namespace Maui.CommunityToolkit.TabView.Compat;

public class TabSelectionChangedEventArgs : EventArgs
{
    public int NewPosition { get; set; }

    public int OldPosition { get; set; }
}