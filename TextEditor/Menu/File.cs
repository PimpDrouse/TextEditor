namespace TextEditor;

public class File
{
    private string Location;

    public File() {}

    public string Create()
    {
        Console.Write("Введите путь до файла: ");
        Location = Console.ReadLine();
        Console.WriteLine("Создается файл и отдается Текстовому редактору");
        return "";
    }

    public string Open()
    {
        Console.Write("Введите путь до файла: ");
        Location = Console.ReadLine();
        Console.WriteLine("Открывается файл и отдается Текстовому редактору");
        return "";
    }

    public void Delete() => Console.WriteLine(Location != "" ? "Удаляется файл" : "Вы еще не выбрали файл");
    public void Save() => Console.WriteLine(Location != "" ? "Сохраняем файл" : "Вы еще не выбрали файл");
    public void SaveAs()
    {
        Console.Write("Введите путь для сохранения: ");
        Location = Console.ReadLine();
        Console.WriteLine("Сохраняем файл");
    }
}