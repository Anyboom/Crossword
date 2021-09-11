namespace Crossword
{
	class FieldHelper
	{
		public static bool IsNullCellTop(char?[,] field, int x, int y) => field[x, y - 1] == null;

		public static bool IsNullCellLeft(char?[,] field, int x, int y) => field[x - 1, y] == null;

		public static bool IsNullCellRigth(char?[,] field, int x, int y) => field[x + 1, y] == null;

		public static bool IsNullCellBottom(char?[,] field, int x, int y) => field[x, y + 1] == null;

		public static bool IsNullCell(char?[,] field, int x, int y) => field[x, y] == null;

		public static bool IsNotNullCell(char?[,] field, int x, int y) => !(IsNullCell(field, x, y));

		public static bool IsNotNullTop(char?[,] field, int x, int y) => !(IsNullCellTop(field, x, y));

		public static bool IsNotNullLeft(char?[,] field, int x, int y) => !(IsNullCellLeft(field, x, y));

		public static bool IsNotNullRigth(char?[,] field, int x, int y) => !(IsNullCellRigth(field, x, y));

		public static bool IsNotNullBottom(char?[,] field, int x, int y) => !(IsNullCellBottom(field, x, y));
	}
}