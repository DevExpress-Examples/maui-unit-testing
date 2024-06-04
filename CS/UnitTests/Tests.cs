using DXMauiApp;
using Xunit;

namespace UnitTests;

public class UnitTests {
    [Fact]
    public void MainViewModelTest() {
        var vm = new MainViewModel();
        Assert.Equal(3, vm.Items.Count);
    }
    [Fact]
    public void MainPageTest() {
        var mainPage = new MainPage();
        var vm = (MainViewModel)mainPage.BindingContext;
        Assert.Equal(vm.Items, mainPage.DXCollectionView.ItemsSource);
    }
}
