using System;
using System.Linq;
using System.Reflection;

namespace CustomLabel.Support
{
    public static class ObjectExtension
    {
        /// <summary>
        /// Tries to type cast the object to the specified target type. The return value specifies whether the type casting succeeded.
        /// </summary>
        /// <typeparam name="TTargetType">The target type this value is required to be type casted</typeparam>
        /// <param name="source">The source object to be type casted</param>
        /// <param name="target">The target.</param>
        /// <returns><c>true</c> if type casting was succeeded, <c>false</c> otherwise.</returns>
        public static bool TryCastAs<TTargetType>(this object source, out TTargetType target)
        {
            bool success = true;
            target = default(TTargetType);
            try
            {
                target = (TTargetType)source;
            }
            catch (InvalidCastException)
            {
                success = false;
            }
            return success;
        }

        public static bool TryGetPropertyValue(this object obj, string propertyName, out object value)
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj));
            if (propertyName == null)
            {
                propertyName = string.Empty;
            }
            value = null;
            try
            {
                foreach (var prop in propertyName.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => obj.GetType().GetRuntimeProperty(s)))
                {
                    obj = prop.GetValue(obj, null);
                }
            }
            catch
            {
                return false;
            }
            value = obj;
            return true;
        }
    }
}
