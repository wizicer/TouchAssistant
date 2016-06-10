namespace TouchAssistant
{
    using System;
    using System.Linq;

    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    public sealed class AutoGenAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoGenAttribute"/> class.
        /// if the type is not string, the default value will remove the " on the begin and end
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="fieldType">Type of the field. only support typeof() method here</param>
        /// <param name="defaultValue">The default value.</param>
        public AutoGenAttribute(string fieldName, Type fieldType, object defaultValue)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoGenAttribute"/> class.
        /// if the type is not string, the default value will remove the " on the begin and end
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="fieldType">Type of the field. only support typeof() method here. Wrap in string when type is generic type.</param>
        /// <param name="defaultValue">The default value.</param>
        public AutoGenAttribute(string fieldName, string fieldType, object defaultValue)
        {
        }
    }
}