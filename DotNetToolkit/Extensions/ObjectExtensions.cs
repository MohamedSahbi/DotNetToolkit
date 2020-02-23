
namespace DotNetToolkit.Extensions
{
	public static class ObjectExtensions
    {
		public static bool IsNull(this object obj)
		{
			return obj == null;
		}

		public static bool IsNotNull(this object obj)
		{
			return !IsNull(obj);
		}

		public static bool TryCast<T>(this object obj, out T result)
		{
			if (obj is T)
			{
				result = (T)obj;
				return true;
			}

			result = default;
			return false;
		}
	}
}
