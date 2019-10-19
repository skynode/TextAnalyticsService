namespace TextAnalyticsService.Utilities
{
    using System;

    internal static class Comparers
    {
        internal static bool IsNumber<T>(this T @object)
        {
            if (@object is uint) return true;
            if (@object is int) return true;
            if (@object is float) return true;
            if (@object is long) return true;
            if (@object is decimal) return true;
            if (@object is double) return true;

            return false;
        }

        internal static bool IsEqualTo<T>(this T firstObject, T secondObject)
            where T : IComparable<T> => firstObject.Equals(secondObject);
        

        internal static bool IsGreaterThan<T>(this T firstObject, T secondObject)
            where T : IComparable<T> => firstObject.CompareTo(secondObject) > 0;
        

        internal static bool IsLessThan<T>(this T firstObject, T secondObject)
            where T : IComparable<T> => firstObject.CompareTo(secondObject) < 0;
    }
}
