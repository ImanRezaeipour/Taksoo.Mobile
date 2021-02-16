using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Taksoo.Mobile.Service.Parameter;
using Taksoo.Mobile.Service.Service;
using Taksoo.Mobile.Service.Service.Interface;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Taksoo.Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : ContentPage
    {

        private readonly IProductService _productService;
        private readonly List<Products> _products = new List<Products>()
        {
            new Products()
        {
            ProductId = 1,
                Name = "چای سبز",
                Price = "2000",

            },
            new Products()
        {
            ProductId = 2,
                Name = "خمیر دندان ذغالی",
                Price = "2000",

            },
            new Products()
        {
            ProductId = 3,
                Name = "ادکلن",
                Price = "2000",

            },
            new Products()
        {
            ProductId = 7,
                Name = "عسل",
                Price = "2000",

            },
            new Products()
        {
            ProductId = 8,
                Name = "عطر بک افغان",
                Price = "2000",

            },
            new Products()
        {
            ProductId = 9,
                Name = "عسل",
                Price = "2000",

            }
    };
      
        public FirstPage()
        {
            ObservableCollection<Products> product = new ObservableCollection<Products>();
            product.Add(new Products
            {
                ProductId = 9,
                Name = "عسل",
                Price = "2000",
            });
            product.Add(new Products
            {
                ProductId = 9,
                Name = "عسل",
                Price = "2000",
            });
            product.Add(new Products
            {
                ProductId = 9,
                Name = "عسل",
                Price = "2000",
            });
            product.Add(new Products
            {
                ProductId = 9,
                Name = "عسل",
                Price = "2000",
            });
            product.Add(new Products
            {
                ProductId = 9,
                Name = "عسل",
                Price = "2000",
            });
            product.Add(new Products
            {
                ProductId = 9,
                Name = "عسل",
                Price = "2000",
            });
            product.Add(new Products
            {
                ProductId = 9,
                Name = "عسل",
                Price = "2000",
            });
            product.Add(new Products
            {
                ProductId = 9,
                Name = "عسل",
                Price = "2000",
            }); product.Add(new Products
            {
                ProductId = 9,
                Name = "عسل",
                Price = "2000",
            }); product.Add(new Products
            {
                ProductId = 9,
                Name = "عسل",
                Price = "2000",
            });
            product.Add(new Products
            {
                ProductId = 9,
                Name = "عسل",
                Price = "2000",
            });


            InitializeComponent();

            _productService = new ProductService();


            //_products = _productService.GetOfferProduct().Result.ToList();
            CategoryScroll();

            ProductsOfferScroll();

            //CategoryScrolls();

            ProductsOfferScrolls();
        }



        private void ProductsOfferScrolls()
        {
            StackLayout stackLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };
            foreach (var product in _products)
            {
                var toman = new Label()
                {
                    Text = "تومان",
                    TextColor = Color.Green,
                    FontSize = 14,
                    VerticalTextAlignment = TextAlignment.Start,
                    FontFamily = "IRANSansWeb.ttf#IRANSansWeb",
                    Margin = new Thickness(0, 5, 0, 0)


                };
                var price = new Label
                {
                    Text = product.Price,
                    TextColor = Color.Green,
                    FontSize = 14,
                    VerticalTextAlignment = TextAlignment.Start,
                    FontFamily = "IRANSansWeb.ttf#IRANSansWeb",
                    Margin = new Thickness(0, 5, 0, 0)
                };
                var boxView = new BoxView()
                {
                    HeightRequest = 0.5,
                    Color = Color.Black,
                    Opacity = 0.6,
                    VerticalOptions = LayoutOptions.End,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                };
                var labelProducName = new Label()
                {
                    Text = product.Name,
                    TextColor = Color.Black,
                    FontSize = 13,
                    FontFamily = "IRANSansWeb.ttf#IRANSansWeb",
                    HorizontalTextAlignment = TextAlignment.End,
                    VerticalTextAlignment = TextAlignment.Center,
                    FontAttributes = FontAttributes.Bold,
                    Margin = new Thickness(0, 0, 0, 5)
                };

                var grid = new Grid()
                {
                    Padding = 5,
                    RowSpacing = 0.5,
                };
                grid.RowDefinitions.Add(new RowDefinition()
                {
                    Height = new GridLength(6, GridUnitType.Star)
                });
                grid.RowDefinitions.Add(new RowDefinition()
                {
                    Height = new GridLength(2, GridUnitType.Star)
                });
                grid.RowDefinitions.Add(new RowDefinition()
                {
                    Height = new GridLength(2, GridUnitType.Star)
                });

                grid.Children.Add(boxView, 0, 1);
                grid.Children.Add(labelProducName, 0, 1);
                var tapped = new TapGestureRecognizer();
                tapped.Tapped += TappedOnTapped;
                Frame fr = new Frame()
                {
                    HasShadow = true,
                    Padding = new Thickness(1, 1, 1, 1),
                    BackgroundColor = Color.White,
                    Opacity = 0.5,
                    Margin = 5,
                    WidthRequest = 150,
                    HeightRequest = 210
                };
               
                fr.Content = grid;
              grid.GestureRecognizers.Add(tapped);
                //grid.Children.Add(toman,0,2);

                var priceStackLayout = new StackLayout()
                {
                    Orientation = StackOrientation.Horizontal,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    HorizontalOptions = LayoutOptions.FillAndExpand
                };
                grid.Children.Add(priceStackLayout, 0, 2);
                priceStackLayout.Children.Add(toman);
                priceStackLayout.Children.Add(price);

                grid.Children.Add(new Image()
                {
                    Source = "A.png",
                    BackgroundColor = Color.White,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.FillAndExpand,


                }, 0, 0);

                stackLayout.Children.Add(fr);

            }
            ScrlProducts.Content = stackLayout;
        }
        private void CategoryScrolls()
        {

            StackLayout stackLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            foreach (var color in Categories)
            {
                Frame fr = new Frame()
                {
                    HasShadow = true,
                    Padding = new Thickness(3, 3, 3, 3),
                    BackgroundColor = Color.White,
                    Margin = 5,


                };
                fr.Content =
                (
                    new Label
                    {
                        Text = color.Name,
                        TextColor = Color.White,
                        Opacity = 0.9,
                        FontSize = 14,
                        Margin = new Thickness(3, 3, 3, 3),
                        VerticalTextAlignment = TextAlignment.Center,
                        FontFamily = "IRANSansWeb.ttf#IRANSansWeb",

                    }
                );
                stackLayout.Children.Add(fr);

            }

            //ScrlCat.Content = stackLayout;
        }

        private void CategorygestureRecognizerOnTapped(object sender, EventArgs eventArgs)
        {
            Navigation.PushAsync(new CategoriesTabbedPage());
        }

        private void ProductsOfferScroll()
        {
            StackLayout stackLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };
            foreach (var product in _products)
            {
                var toman = new Label()
                {
                    Text = "تومان",
                    TextColor = Color.Green,
                    FontSize = 14,
                    VerticalTextAlignment = TextAlignment.Start,
                    FontFamily = "IRANSansWeb.ttf#IRANSansWeb",
                    Margin = new Thickness(0, 5, 0, 0)


                };
                var price = new Label
                {
                    Text = product.Price,
                    TextColor = Color.Green,
                    FontSize = 14,
                    VerticalTextAlignment = TextAlignment.Start,
                    FontFamily = "IRANSansWeb.ttf#IRANSansWeb",
                    Margin = new Thickness(0, 5, 0, 0)
                };
                var boxView = new BoxView()
                {
                    HeightRequest = 0.5,
                    Color = Color.Black,
                    Opacity = 0.6,
                    VerticalOptions = LayoutOptions.End,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                };
                var labelProducName = new Label()
                {
                    Text = product.Name,
                    TextColor = Color.Black,
                    FontSize = 13,
                    FontFamily = "IRANSansWeb.ttf#IRANSansWeb",
                    HorizontalTextAlignment = TextAlignment.End,
                    VerticalTextAlignment = TextAlignment.Center,
                    FontAttributes = FontAttributes.Bold,
                    Margin = new Thickness(0, 0, 0, 5)
                };

                var grid = new Grid()
                {
                    Padding = 5,
                    RowSpacing = 0.5,
                };
                grid.RowDefinitions.Add(new RowDefinition()
                {
                    Height = new GridLength(6, GridUnitType.Star)
                });
                grid.RowDefinitions.Add(new RowDefinition()
                {
                    Height = new GridLength(2, GridUnitType.Star)
                });
                grid.RowDefinitions.Add(new RowDefinition()
                {
                    Height = new GridLength(2, GridUnitType.Star)
                });

                grid.Children.Add(boxView, 0, 1);
                grid.Children.Add(labelProducName, 0, 1);

                Frame fr = new Frame()
                {
                    HasShadow = true,
                    Padding = new Thickness(1, 1, 1, 1),
                    BackgroundColor = Color.White,
                    Opacity = 0.5,
                    Margin = 5,
                    WidthRequest = 150,
                    HeightRequest = 210
                };
                fr.Content = grid;

                //grid.Children.Add(toman,0,2);

                var priceStackLayout = new StackLayout()
                {
                    Orientation = StackOrientation.Horizontal,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    HorizontalOptions = LayoutOptions.FillAndExpand
                };
                grid.Children.Add(priceStackLayout, 0, 2);
                priceStackLayout.Children.Add(toman);
                priceStackLayout.Children.Add(price);

                grid.Children.Add(new Image()
                {
                    Source = "A.png",
                    BackgroundColor = Color.White,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.FillAndExpand,


                }, 0, 0);
                var tapped = new TapGestureRecognizer();
                tapped.Tapped += TappedOnTapped;
                fr.GestureRecognizers.Add(tapped);
                stackLayout.Children.Add(fr);

            }
            ScrlProduct.Content = stackLayout;
        }

        private void TappedOnTapped(object o, EventArgs eventArgs)
        {
           App.Current.MainPage = new ProductDetails();
        }

        private void CategoryScroll()
        {
            var categorygestureRecognizer = new TapGestureRecognizer();

            categorygestureRecognizer.Tapped += CategorygestureRecognizerOnTapped;

            StackLayout stackLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            foreach (var color in Categories)
            {
                Frame fr = new Frame()
                {
                    HasShadow = true,
                    Padding = new Thickness(3, 3, 3, 3),
                    BackgroundColor = Color.White,
                    Margin = 5,


                };
                fr.GestureRecognizers.Add(categorygestureRecognizer);
                fr.Content =
                (
                    new Label
                    {
                        Text = color.Name,
                        TextColor = Color.White,
                        Opacity = 0.9,
                        FontSize = 14,
                        Margin = new Thickness(3, 3, 3, 3),
                        VerticalTextAlignment = TextAlignment.Center,
                        FontFamily = "IRANSansWeb.ttf#IRANSansWeb",

                    }
                );
                stackLayout.Children.Add(fr);

            }

            //ScrlCat.Content = stackLayout;
        }

        public class Category
        {
            public string Name { get; set; }

        }

        private ObservableCollection<Category> _categories = new ObservableCollection<Category>()
        {
            new Category()
            {
                Name = "کالای دیجیتال"
            },
            new Category()
            {
                Name = "لوازم خانگی"
            },
            new Category()
            {
                Name = "فرهنگ و هنر"
            },
            new Category()
            {
                Name = "دمنوش"
            },
            new Category()
            {
                Name = "لوازم آرایشی"
            },
            new Category()
            {
                Name = "aaaaaa"
            },
            new Category()
            {
                Name = "aaaaaa"
            },

        };


        public ObservableCollection<Category> Categories
        {
            get { return _categories; }
        }

        private void Offer1_OnTapped(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}