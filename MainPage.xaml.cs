namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnSubmitClicked (object sender, EventArgs e)
        {
            //navigate to createacc
            await Navigation.PushAsync(new CreateAccountPage());
        }
      

    }

}
