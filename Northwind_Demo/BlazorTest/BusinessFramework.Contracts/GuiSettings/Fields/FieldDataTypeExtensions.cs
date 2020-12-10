using System;

namespace BusinessFramework.Contracts.GuiSettings.Fields
{
    public static class FieldDataTypeExtensions
    {
        public static Type ToType(this FieldDataType type)
        {
            switch (type)
            {
                case FieldDataType.None:
                    return null;
                case FieldDataType.Bool:
                    return typeof(bool);
                case FieldDataType.String:
                    return typeof(string);
                case FieldDataType.Integer:
                    return typeof(int);
                case FieldDataType.Float:
                    return typeof(double);
                case FieldDataType.Decimal:
                    return typeof(decimal);
                case FieldDataType.DateTime:
                    return typeof(DateTime);
                case FieldDataType.DateTimeOffset:
                    return typeof(DateTimeOffset);
                case FieldDataType.Guid:
                    return typeof(Guid);
                case FieldDataType.Image:
                    return typeof(byte[]);
                default:
                    throw new ArgumentOutOfRangeException("type", type, null);
            }
        }
    }
}