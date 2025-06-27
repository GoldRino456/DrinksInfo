using Spectre.Console;

namespace DrinksInfo
{
    internal static class DrinksDisplayEngine
    {
        /*public static void ShowListAsTable(List list)
        {

        }*/

        public static void ShowTable(string[] columns, string[] rows)
        {
            var table = new Table();

            table.AddColumns(columns);
            table.AddRow(rows);

            AnsiConsole.Write(table);
        }
    }
}
