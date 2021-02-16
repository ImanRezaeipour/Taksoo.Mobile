using System;
using System.Collections.ObjectModel;
using System.Linq;
using Taksoo.TestData;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Taksoo.Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoriesTabbedPage : TabbedPage
    {
        public CategoriesTabbedPage()
        {
            InitializeComponent();
            Product _product = new Product();

            ObservableCollection<Category> category = _product.Categorie();



            foreach (var mainCategory in category.Where(x => x.ParentId == null))
            {
                ContentPage contentPage = new ContentPage()
                {
                    Title = mainCategory.Name
                };

                StackLayout stack = new StackLayout();
                ScrollView scroll = new ScrollView { Content = stack };
                foreach (var item in category.Where(x => x.ParentId == mainCategory.Id))
                {
                    var grid = new Grid()
                    {
                        Padding = 5,
                        RowSpacing = 0.5,

                    };
                    grid.ColumnDefinitions.Add(new ColumnDefinition()
                    {
                        Width = new GridLength(5, GridUnitType.Star)
                    });
                    grid.ColumnDefinitions.Add(new ColumnDefinition()
                    {
                        Width = new GridLength(5, GridUnitType.Star)
                    });
                    Label label = new Label()
                    {
                        HorizontalOptions = LayoutOptions.EndAndExpand,
                        VerticalTextAlignment = TextAlignment.Center,
                        Text = item.Name,
                        FontFamily = "IranSans",
                        FontSize = 12,
                        TextColor = Color.Black
                    };
                    var img = new Image()
                    {
                        BackgroundColor = Color.Transparent,
                        HorizontalOptions = LayoutOptions.StartAndExpand,
                        Source = item.Image,
                        Aspect = Aspect.AspectFill,

                    };
                    grid.Children.Add(label, 1, 0);
                    grid.Children.Add(img, 0, 0);
                    var tapped = new TapGestureRecognizer();

                    tapped.Tapped += TappedOnTapped;

                    stack.Children.Add(new BoxView()
                    {
                        VerticalOptions = LayoutOptions.StartAndExpand,
                        Color = Color.Black,
                        Opacity = 0.8,
                        HeightRequest = 0.5,
                        HorizontalOptions = LayoutOptions.FillAndExpand
                    });
                    img.GestureRecognizers.Add(tapped);
                    label.GestureRecognizers.Add(tapped);
                    stack.Children.Add(grid);
                }

                contentPage.Content = scroll;
                this.Children.Add(contentPage);
            }
        }

        private void TappedOnTapped(object sender, EventArgs eventArgs)
        {
            App.Current.MainPage = new ProductDetails();
        }
    }


}