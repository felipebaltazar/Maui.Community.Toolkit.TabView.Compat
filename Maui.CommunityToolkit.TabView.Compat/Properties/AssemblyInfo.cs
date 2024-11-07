using XmlnsPrefixAttribute = Microsoft.Maui.Controls.XmlnsPrefixAttribute;

//Custom xaml schema <see href="https://docs.microsoft.com/pt-br/xamarin/xamarin-forms/xaml/custom-namespace-schemas#defining-a-custom-namespace-schema"/>
[assembly: XmlnsDefinition("http://schemas.microsoft.com/dotnet/2021/maui", "Maui.CommunityToolkit.TabView.Compat")]
[assembly: XmlnsDefinition("http://mauicommunitytoolkitcompat.com/schemas/xaml", "Maui.CommunityToolkit.TabView.Compat")]

//Recommended prefix <see href="https://docs.microsoft.com/pt-br/xamarin/xamarin-forms/xaml/custom-prefix"/>
[assembly: XmlnsPrefix("http://Maui.CommunityToolkit.TabView.Compat.com/schemas/xaml", "xctcompat")]