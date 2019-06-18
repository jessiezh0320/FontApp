using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyFontApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public ObservableCollection<VeggieViewModel> veggies { get; set; }

        public MainPage()
        {
            InitializeComponent();

            veggies = new ObservableCollection<VeggieViewModel>();
            veggies.Add(new VeggieViewModel { Name = "Tomato", Type = "Fruit", Image = "tomato.png" });
            veggies.Add(new VeggieViewModel { Name = "Romaine Lettuce", Type = "Vegetable", Image = "lettuce.png" });
            veggies.Add(new VeggieViewModel { Name = "Zucchini", Type = "Vegetable", Image = "zucchini.png" });
            veggies.Add(new VeggieViewModel { Name = "Tomato", Type = "Fruit", Image = "tomato.png" });
            veggies.Add(new VeggieViewModel { Name = "Romaine Lettuce", Type = "Vegetable", Image = "lettuce.png" });
            veggies.Add(new VeggieViewModel { Name = "Zucchini", Type = "Vegetable", Image = "zucchini.png" });
            veggies.Add(new VeggieViewModel { Name = "Tomato", Type = "Fruit", Image = "tomato.png" });
            veggies.Add(new VeggieViewModel { Name = "Romaine Lettuce", Type = "Vegetable", Image = "lettuce.png" });
            veggies.Add(new VeggieViewModel { Name = "Zucchini", Type = "Vegetable", Image = "zucchini.png" });
            veggies.Add(new VeggieViewModel { Name = "Tomato", Type = "Fruit", Image = "tomato.png" });
            veggies.Add(new VeggieViewModel { Name = "Romaine Lettuce", Type = "Vegetable", Image = "lettuce.png" });
            veggies.Add(new VeggieViewModel { Name = "Zucchini", Type = "Vegetable", Image = "zucchini.png" });
            veggies.Add(new VeggieViewModel { Name = "Tomato", Type = "Fruit", Image = "tomato.png" });
            veggies.Add(new VeggieViewModel { Name = "Romaine Lettuce", Type = "Vegetable", Image = "lettuce.png" });
            veggies.Add(new VeggieViewModel { Name = "Zucchini", Type = "Vegetable", Image = "zucchini.png" });
            veggies.Add(new VeggieViewModel { Name = "Tomato", Type = "Fruit", Image = "tomato.png" });
            veggies.Add(new VeggieViewModel { Name = "Romaine Lettuce", Type = "Vegetable", Image = "lettuce.png" });
            veggies.Add(new VeggieViewModel { Name = "Zucchini", Type = "Vegetable", Image = "zucchini.png" });
            veggies.Add(new VeggieViewModel { Name = "Tomato", Type = "Fruit", Image = "tomato.png" });
            veggies.Add(new VeggieViewModel { Name = "Romaine Lettuce", Type = "Vegetable", Image = "lettuce.png" });
            veggies.Add(new VeggieViewModel { Name = "Zucchini", Type = "Vegetable", Image = "zucchini.png" });
            veggies.Add(new VeggieViewModel { Name = "Tomato", Type = "Fruit", Image = "tomato.png" });
            veggies.Add(new VeggieViewModel { Name = "Romaine Lettuce", Type = "Vegetable", Image = "lettuce.png" });
            veggies.Add(new VeggieViewModel { Name = "Zucchini", Type = "Vegetable", Image = "zucchini.png" });

            veggies.Add(new VeggieViewModel { Name = "Tomato", Type = "Fruit", Image = "tomato.png" });
            veggies.Add(new VeggieViewModel { Name = "Romaine Lettuce", Type = "Vegetable", Image = "lettuce.png" });
            veggies.Add(new VeggieViewModel { Name = "Zucchini", Type = "Vegetable", Image = "zucchini.png" });
            lstView.ItemsSource = veggies;
        }
    }
}
