# Xamarin.Forms: Using Commands Demo

To make things easier for beginners getting used to MVVM in Xamarin, this is a demo on using commands. The set-up comes as an out-of-the-box PCL.

### Button in page xaml class
```xml
<Button x:Name="TestButton"        
        Command="{Binding ButtonCommand}" 
        Text="Click"  
        VerticalOptions="Center" 
        HorizontalOptions="Center" />
```

### Set the binding context in the page xaml.cs
```csharp
    ViewModel viewModel;

    public CommandDemoPage()
    {
        InitializeComponent();
        viewModel = new ViewModel();
        BindingContext = viewModel;
    }
```

### Set up the command and the method to execute in the ViewModel
```csharp
    public ICommand ButtonCommand { get; private set; }
    public ViewModel()
    {
        ButtonCommand = new Command(ButtonCommandMethod);
    }

    public void ButtonCommandMethod() 
    {
        App.Current.MainPage.DisplayAlert("Alert", "This is an alert", "Ok");
    } 
```