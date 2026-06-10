namespace MauiPt2L15;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        Person student = new Person();
        student.Name = "Gabit";
        student.City = "Atyrau";

        BindingContext = student;
    }
}