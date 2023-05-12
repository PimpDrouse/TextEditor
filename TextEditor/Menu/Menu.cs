namespace TextEditor;

public class Menu
{
    private File FileMenu;
    private Setting SettingMenu;

    public Menu()
    {
        FileMenu = new File();
        SettingMenu = new Setting();
    }

    public void CreateFile() => FileMenu.Create();
    public void OpenFile() => FileMenu.Open();
    public void DeleteFile() => FileMenu.Delete();
    public void SaveFile() => FileMenu.Save();
    public void SaveFileAs() => FileMenu.SaveAs();
    public void HightLightText() => SettingMenu.HightLight();
    public void SetColor(Colors color) => SettingMenu.SetColor(color);
}