namespace Monitoring.Helpers
{
    /// <summary>
    /// Вспомогательный класс для работы со строками
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Вернуть пустую строку, если исходная - null, либо - исходную
        /// </summary>
        /// <param name="source">Исходная строка</param>
        /// <returns>Пустая строка или исходная</returns>
        public static string GetEmptyIfNull(this string source)
        {
            if (source == null)
                return string.Empty;

            return source;
        }
    }
}
