using System;
using System.Collections.Generic;
using System.Reflection;

namespace DotNetToolkit.Helpers
{
    public static class ObjectComparer<T> where T : class
    {

        public static bool HasChanged(T originalObject, T changedObject)
        {
            bool result = false;

            foreach (PropertyInfo property in originalObject.GetType().GetProperties())
            {

                object originalPropertyValue =
                    property.GetValue(originalObject, null);
                object newPropertyValue =
                    property.GetValue(changedObject, null);

                if (!Equals(originalPropertyValue, newPropertyValue))
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public static bool HasChanged(T originalObject, T changedObject, List<Type> typesToIgnore)
        {
            bool result = false;

            foreach (PropertyInfo property in originalObject.GetType().GetProperties())
            {

                object originalPropertyValue =
                    property.GetValue(originalObject, null);
                object newPropertyValue =
                    property.GetValue(changedObject, null);
                if (originalPropertyValue != null && typesToIgnore.Contains(originalPropertyValue.GetType()))
                {
                    continue;
                }
                
                if (!Equals(originalPropertyValue, newPropertyValue))
                {
                    result = true;
                    break;
                }
            }

            return result;
        }
    }
}
