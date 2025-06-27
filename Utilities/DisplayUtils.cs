using Spectre.Console;

namespace DrinksInfo.Utilities
{
    public static class DisplayUtils
    {
        public static void ShowTable(string[] columns, string[] rows)
        {
            var table = new Table();

            table.AddColumns(columns);
            table.AddRow(rows);

            AnsiConsole.Write(table);
        }

        public static int PromptUserForIndexSelection(string promptText, Dictionary<string, int> choices)
        {
            var selection = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title(promptText)
                .PageSize(10)
                .MoreChoicesText("[grey](Move up and down to see additional options)[/]")
                .AddChoices(choices.Keys.ToArray()));

            return choices[selection];
        }
    }
}
