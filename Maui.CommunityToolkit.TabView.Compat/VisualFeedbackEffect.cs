﻿namespace Maui.CommunityToolkit.TabView.Compat;

public class VisualFeedbackEffect : RoutingEffect
{
	public VisualFeedbackEffect()
		: base(EffectIds.VisualFeedback)
	{
	}

	public static readonly BindableProperty FeedbackColorProperty =
		BindableProperty.CreateAttached("FeedbackColor", typeof(Color), typeof(VisualFeedbackEffect), KnownColor.Default);

	public static Color GetFeedbackColor(BindableObject view) => (Color)view.GetValue(FeedbackColorProperty);

	public static void SetFeedbackColor(BindableObject view, Color value) => view.SetValue(FeedbackColorProperty, value);

	public static bool IsFeedbackColorSet(BindableObject element) => GetFeedbackColor(element) != KnownColor.Default;
}