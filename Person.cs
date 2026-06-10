using System.ComponentModel;

namespace MauiPt2L15;

public class Person : INotifyPropertyChanged
{
    private string name;
    private string city;

    public event PropertyChangedEventHandler? PropertyChanged;

    public Person()
    {
        name = "Gabit";
        city = "Atyrau";
    }

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
        }
    }

    public string City
    {
        get
        {
            return city;
        }
        set
        {
            city = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(City)));
        }
    }
}