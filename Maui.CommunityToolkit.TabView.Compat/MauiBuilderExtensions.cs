namespace Maui.CommunityToolkit.TabView.Compat;

public static class MauiBuilderExtensions
{
    public static MauiAppBuilder UseCompatTabView(this MauiAppBuilder builder)
    {
        builder.ConfigureEffects(e =>
        {
            e.Add<VisualFeedbackEffect, VisualFeedbackEffectRouter>();
        });

        return builder;
    }
}
