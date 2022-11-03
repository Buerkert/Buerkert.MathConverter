using System.Reflection;

namespace HexInnovation
{
    internal static class CompatibilityExtensions
    {
        public static IEnumerable<object> MyToArray(this IEnumerable<object> objects)
        {
            return objects;
        }

        public static IEnumerable<string> MyToArray(this IEnumerable<string> strings)
        {
            return strings;
        }

        public static IEnumerable<TAttribute> GetCustomAttributes<TAttribute>(this Type self)
            where TAttribute : Attribute
        {
            return
                Attribute.GetCustomAttributes(self)
                    .OfType<TAttribute>();
        }

        public static bool IsIConvertible(object self)
        {
            return self is IConvertible;
        }

        public static IEnumerable<MethodInfo> GetPublicStaticMethods(this Type self)
        {
            return self.GetRuntimeMethods().Where(method => method.IsPublic && method.IsStatic);
        }


        public static Type GetTypeInfo(this Type self)
        {
            return self;
        }
    }
}