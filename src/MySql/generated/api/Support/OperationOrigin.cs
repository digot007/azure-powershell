// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Support
{

    /// <summary>The intended executor of the operation.</summary>
    public partial struct OperationOrigin :
        System.IEquatable<OperationOrigin>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.OperationOrigin NotSpecified = @"NotSpecified";

        public static Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.OperationOrigin System1 = @"system";

        public static Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.OperationOrigin User = @"user";

        /// <summary>the value for an instance of the <see cref="OperationOrigin" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to OperationOrigin</summary>
        /// <param name="value">the value to convert to an instance of <see cref="OperationOrigin" />.</param>
        internal static object CreateFrom(object value)
        {
            return new OperationOrigin(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type OperationOrigin</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.OperationOrigin e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type OperationOrigin (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is OperationOrigin && Equals((OperationOrigin)obj);
        }

        /// <summary>Returns hashCode for enum OperationOrigin</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="OperationOrigin" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private OperationOrigin(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for OperationOrigin</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to OperationOrigin</summary>
        /// <param name="value">the value to convert to an instance of <see cref="OperationOrigin" />.</param>

        public static implicit operator OperationOrigin(string value)
        {
            return new OperationOrigin(value);
        }

        /// <summary>Implicit operator to convert OperationOrigin to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="OperationOrigin" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.OperationOrigin e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum OperationOrigin</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.OperationOrigin e1, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.OperationOrigin e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum OperationOrigin</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.OperationOrigin e1, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.OperationOrigin e2)
        {
            return e2.Equals(e1);
        }
    }
}