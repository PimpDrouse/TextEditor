namespace TextEditor;

public class Setting
{
    private bool isHightLight;
    private Colors Color;

    public Setting()
    {
        isHightLight = false;
        Color = Colors.Black;
    }

    public void HightLight() => Console.WriteLine(isHightLight ? "Выключить подсветку" : "Включить подсветку");
    public void SetColor(Colors color) => Color = color;
}