using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace DXMauiApp {
    public partial class MainViewModel : ObservableObject {
        public ObservableCollection<Item> Items { get; }
        public MainViewModel()
        {
            Items = new ObservableCollection<Item>();
            Items.Add(new Item() { Text = "A" });
            Items.Add(new Item() { Text = "B" });
            Items.Add(new Item() { Text = "C" });
        }
    }
    public class Item {
        public string? Text { get; set; }
    }
}

