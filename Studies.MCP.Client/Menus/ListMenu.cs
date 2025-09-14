
using System.Collections.ObjectModel;

internal abstract class ListMenu : Menu
{
    private readonly List<string> _selectedList = [];

    internal ReadOnlyCollection<string> SelectedList { get => _selectedList.AsReadOnly(); }

    protected abstract List<string> GetMenuList();

    protected override bool HasContent() => HasList();

    protected override string GetInvalidInputMessage() => "Entrada inválida. Tente novamente.";

    internal bool HasList() => GetMenuList().Count > 0;

    protected override async Task ReadMenuContentAsync()
    {
        foreach (var item in GetMenuList())
        {
            Console.Write($"- {item}: ");
            base.ReadInput();

            while (!base.IsInputValid())
            {
                Console.WriteLine(GetInvalidInputMessage());
                await Task.Delay(1000);
                WriteLine();
                Console.Write($"- {item}: ");
                base.ReadInput();
            }

            _selectedList.Add(_input!);
        }
    }
}