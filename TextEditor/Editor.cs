namespace TextEditor;

public class Editor
{
    private static Editor instance;
    private TextProcessor TextProcessor;
    private Menu Menu;

    private Editor()
    {
        Menu = new Menu();
        TextProcessor = new TextProcessor();
    }

    public static Editor GetInstance() => instance is null ? instance = new Editor() : instance = null;

    public void Start()
    {
        
    }
}