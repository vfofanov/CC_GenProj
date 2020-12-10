﻿using System;
using System.ComponentModel;
using BusinessFramework.Contracts;
using BusinessFramework.Contracts.Utils;


namespace NorthWind.Contracts.DataObjects
{
    [Serializable]
    [TypeConverter(typeof (JsonUriConverter<CustomerCustomerDemoKey, CustomerCustomerDemoKeyData>))]
    public struct CustomerCustomerDemoKey : IEquatable<CustomerCustomerDemoKey>, IJsonUri
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        /// </summary>
        public CustomerCustomerDemoKey(int customerID, int customerTypeID)
            : this()
        {
            this.CustomerID = customerID;        
            this.CustomerTypeID = customerTypeID;        
        }

        public int CustomerID { get; private set; }
        public int CustomerTypeID { get; private set; }

        /// <summary>
        ///     Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <returns>
        ///     true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        public bool Equals(CustomerCustomerDemoKey other)
        {
            return Equals(CustomerID, other.CustomerID) && Equals(CustomerTypeID, other.CustomerTypeID);
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
            return obj is CustomerCustomerDemoKey && Equals((CustomerCustomerDemoKey) obj);
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
                hashCode = (hashCode*397) ^ CustomerID.GetHashCode();
                hashCode = (hashCode*397) ^ CustomerTypeID.GetHashCode();
                return hashCode;
            }
        }

		public static bool operator ==(CustomerCustomerDemoKey left, CustomerCustomerDemoKey right)
        {
            return Equals(left, right);
        }
        public static bool operator !=(CustomerCustomerDemoKey left, CustomerCustomerDemoKey right)
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
		    return string.Format("CustomerID:{0}, CustomerTypeID:{0}", CustomerID, CustomerTypeID);
        }

        /// <summary>
        ///     Serialization data
        /// </summary>
        object IJsonUri.Data
        {
            get { return new CustomerCustomerDemoKeyData(CustomerID, CustomerTypeID); }
        }
    }

    [Serializable]
    public struct CustomerCustomerDemoKeyData : IConvertable<CustomerCustomerDemoKey>
    {
        public CustomerCustomerDemoKeyData(int customerID, int customerTypeID)
            : this()
        {
            CustomerID = customerID;        
            CustomerTypeID = customerTypeID;        
        }

        public int CustomerID { get; private set; }
        public int CustomerTypeID { get; private set; }

        public CustomerCustomerDemoKey Convert()
        {
            return new CustomerCustomerDemoKey(CustomerID, CustomerTypeID);
        }
    }
}