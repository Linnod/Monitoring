using System;

namespace Monitoring.Helpers
{
    /// <summary>
    /// Вспомогательный класс для конвертации строк
    /// </summary>
    public static class StringParseExtensions
    {
        /// <summary>
        /// Сконвертировать в <see cref="int?"/>
        /// </summary>
        /// <param name="source">Исходная строка</param>
        /// <returns>Число или null</returns>
        public static int? ParseAsNullableInt(this string source)
        {
            if (!int.TryParse(source, out int result))
            {
                return null;
            }

            return result;
        }

        /// <summary>
        /// Сконвертировать в <see cref="int"/>
        /// </summary>
        /// <param name="source">Исходная строка</param>
        /// <returns>Число</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если строку не удалось превратить в число</exception>
        public static int ParseAsInt(this string source)
        {
            var result = ParseAsNullableInt(source);

            if (!result.HasValue)
            {
                throw new ArgumentException("Исходная строка не является числом");
            }

            return result.Value;
        }
    }
}
