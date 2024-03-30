using System.Collections.ObjectModel;
using _Cytrikov_Var3.Entities;
using Avalonia.Controls;

namespace _21._102_Cytrikov_Var3;

public partial class MainWindow : Window
{
    public ObservableCollection<Discipline> _discipline = new ObservableCollection<Discipline>
    {
        new Discipline{ IdDiscipline=1, Title = "Математика"},
        new Discipline{ IdDiscipline=2, Title = "Русский язык"},
        new Discipline{ IdDiscipline=3, Title = "Музыка"},
        new Discipline{ IdDiscipline=4, Title = "Труд"},
        new Discipline{ IdDiscipline=5, Title = "Физика"},
    };
    public ObservableCollection<string> a = new ObservableCollection<string>
    {
        "по возрастанию",
        "по убыванию"
    };
    public MainWindow()
    {
        InitializeComponent();
        Table.ItemsSource = _discipline;
        Box.ItemsSource = a;
    }
}
