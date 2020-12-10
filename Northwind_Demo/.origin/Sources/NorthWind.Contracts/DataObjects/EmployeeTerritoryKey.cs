using System;
using System.ComponentModel;
using BusinessFramework.Contracts;
using BusinessFramework.Contracts.Utils;


namespace NorthWind.Contracts.DataObjects
{
    [Serializable]
    [TypeConverter(typeof (JsonUriConverter<EmployeeTerritoryKey, EmployeeTerritoryKeyData>))]
    public struct EmployeeTerritoryKey : IEquatable<EmployeeTerritoryKey>, IJsonUri
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        /// </summary>
        public EmployeeTerritoryKey(int employeeID, int territoryID)
            : this()
        {
            this.EmployeeID = employeeID;        
            this.TerritoryID = territoryID;        
        }

        public int EmployeeID { get; private set; }
        public int TerritoryID { get; private set; }

        /// <summary>
        ///     Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <returns>
        ///     true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        public bool Equals(EmployeeTerritoryKey other)
        {
            return Equals(EmployeeID, other.EmployeeID) && Equals(TerritoryID, other.TerritoryID);
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
            return obj is EmployeeTerritoryKey && Equals((EmployeeTerritoryKey) obj);
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
                hashCode = (hashCode*397) ^ EmployeeID.GetHashCode();
                hashCode = (hashCode*397) ^ TerritoryID.GetHashCode();
                return hashCode;
            }
        }

		public static bool operator ==(EmployeeTerritoryKey left, EmployeeTerritoryKey right)
        {
            return Equals(left, right);
        }
        public static bool operator !=(EmployeeTerritoryKey left, EmployeeTerritoryKey right)
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
		    return string.Format("EmployeeID:{0}, TerritoryID:{0}", EmployeeID, TerritoryID);
        }

        /// <summary>
        ///     Serialization data
        /// </summary>
        object IJsonUri.Data
        {
            get { return new EmployeeTerritoryKeyData(EmployeeID, TerritoryID); }
        }
    }

    [Serializable]
    public struct EmployeeTerritoryKeyData : IConvertable<EmployeeTerritoryKey>
    {
        public EmployeeTerritoryKeyData(int employeeID, int territoryID)
            : this()
        {
            EmployeeID = employeeID;        
            TerritoryID = territoryID;        
        }

        public int EmployeeID { get; private set; }
        public int TerritoryID { get; private set; }

        public EmployeeTerritoryKey Convert()
        {
            return new EmployeeTerritoryKey(EmployeeID, TerritoryID);
        }
    }
}