using System;
using System.ComponentModel;
using BusinessFramework.Contracts;
using BusinessFramework.Contracts.Utils;


namespace NorthWind.Contracts.DataObjects
{
    [Serializable]
    [TypeConverter(typeof (JsonUriConverter<OrderProductQueryKey, OrderProductQueryKeyData>))]
    public struct OrderProductQueryKey : IEquatable<OrderProductQueryKey>, IJsonUri
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        /// </summary>
        public OrderProductQueryKey(int id, int orderID, int productID)
            : this()
        {
            this.Id = id;        
            this.OrderID = orderID;        
            this.ProductID = productID;        
        }

        public int Id { get; private set; }
        public int OrderID { get; private set; }
        public int ProductID { get; private set; }

        /// <summary>
        ///     Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <returns>
        ///     true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        public bool Equals(OrderProductQueryKey other)
        {
            return Equals(Id, other.Id) && Equals(OrderID, other.OrderID) && Equals(ProductID, other.ProductID);
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
            return obj is OrderProductQueryKey && Equals((OrderProductQueryKey) obj);
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
                hashCode = (hashCode*397) ^ Id.GetHashCode();
                hashCode = (hashCode*397) ^ OrderID.GetHashCode();
                hashCode = (hashCode*397) ^ ProductID.GetHashCode();
                return hashCode;
            }
        }

		public static bool operator ==(OrderProductQueryKey left, OrderProductQueryKey right)
        {
            return Equals(left, right);
        }
        public static bool operator !=(OrderProductQueryKey left, OrderProductQueryKey right)
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
		    return string.Format("Id:{0}, OrderID:{0}, ProductID:{0}", Id, OrderID, ProductID);
        }

        /// <summary>
        ///     Serialization data
        /// </summary>
        object IJsonUri.Data
        {
            get { return new OrderProductQueryKeyData(Id, OrderID, ProductID); }
        }
    }

    [Serializable]
    public struct OrderProductQueryKeyData : IConvertable<OrderProductQueryKey>
    {
        public OrderProductQueryKeyData(int id, int orderID, int productID)
            : this()
        {
            Id = id;        
            OrderID = orderID;        
            ProductID = productID;        
        }

        public int Id { get; private set; }
        public int OrderID { get; private set; }
        public int ProductID { get; private set; }

        public OrderProductQueryKey Convert()
        {
            return new OrderProductQueryKey(Id, OrderID, ProductID);
        }
    }
}