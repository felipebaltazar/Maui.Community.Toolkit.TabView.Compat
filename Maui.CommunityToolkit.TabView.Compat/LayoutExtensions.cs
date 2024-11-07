namespace Maui.CommunityToolkit.TabView.Compat;

public static class LayoutExtensions
{
    public static IReadOnlyList<Element> GetChildren(this ILayoutController source)
    {
        _ = source ?? throw new ArgumentNullException(nameof(source));

        return source.Children;
    }
}