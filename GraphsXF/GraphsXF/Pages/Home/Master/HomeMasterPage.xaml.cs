using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GraphsXF
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeMasterPage : MasterDetailPage
    {
        public HomeMasterPage()
        {
            InitializeComponent();

            Master = ViewContainer.Current.CreatePage(new MasterViewModel(this));
        }
    }
}