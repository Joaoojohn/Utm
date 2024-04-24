using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects
{
    public class Url : ValueObjects
    {
        /// <summary>
        /// Create a new URL
        /// </summary>
        /// <param name="address">Address of URL (Website link)</param>

        public Url(string address)
        {
            Address = address;

            InvalidUrlException.ThrowIfInvalid(address);
        }
        
        /// <summary>
        /// Address of URL
        /// </summary>
        public string Address { get; }

    }
}
