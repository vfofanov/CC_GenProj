using System;
using System.ComponentModel;
using BusinessFramework.Contracts;
using BusinessFramework.Contracts.Utils;


namespace NorthWind.Contracts.DataObjects
{
    [Serializable]
    [TypeConverter(typeof (JsonUriConverter<OrderDetailsKey, OrderDetailsKeyData>))]
    public struct OrderDetailsKey : IEquatable<OrderDetailsKey>, IJsonUri
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        /// </summary>
        public OrderDetailsKey(int orderID, int productID)
            : this()
        {
            this.OrderID = orderID;        
            this.ProductID = productID;        
        }

        public int OrderID { get; private set; }
        public int ProductID { get; private set; }

        /// <summary>
        ///     Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <returns>
        ///     true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        public bool Equals(OrderDetailsKey other)
        {
            return Equals(OrderID, other.OrderID) && Equals(ProductID, other.ProductID);
        }
        /// <summary>
        ///     Indicates whether this instance and a specified object are equal.
        /// </summary>
        /// <returns>
        ///     true if <paramref name="obj" /> and this instance are the same type and represent the same value; otherwise, false.
        /// </returns>
        /// <param name="obj">Another object to compare to. </param>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            return obj is OrderDetailsKey && Equals((OrderDetailsKey) obj);
        }
        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>
        ///     A 32-bit signed integer that is the hash code for this instance.
        /// </returns>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = 0;
                hashCode = (hashCode*397) ^ OrderID.GetHashCode();
                hashCode = (hashCode*397) ^ ProductID.GetHashCode();
                return hashCode;
            }
        }

		public static bool operator ==(OrderDetailsKey left, OrderDetailsKey right)
        {
            return Equals(left, right);
        }
        public static bool operator !=(OrderDetailsKey left, OrderDetailsKey right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Returns the fully qualified type name of this instance.
        /// </summary>
        /// <returns>
        ///     A <see cref="T:System.String" /> containing a fully qualified type name.
        /// </returns>
        public override string ToString()
        {
		    return string.Format("OrderID:{0}, ProductID:{0}", OrderID, ProductID);
        }

        /// <summary>
        ///     Serialization data
        /// </summary>
        object IJsonUri.Data
        {
            get { return new OrderDetailsKeyData(OrderID, ProductID); }
        }
    }

    [Serializable]
    public struct OrderDetailsKeyData : IConvertable<OrderDetailsKey>
    {
        public OrderDetailsKeyData(int orderID, int productID)
            : this()
        {
            OrderID = orderID;        
            ProductID = productID;        
        }

        public int OrderID { get; private set; }
        public int ProductID { get; private set; }

        public OrderDetailsKey Convert()
        {
            return new OrderDetailsKey(OrderID, ProductID);
        }
    }
}