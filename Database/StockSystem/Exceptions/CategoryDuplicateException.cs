using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StockSystem.Exceptions
{
    public class CategoryDuplicateException : Exception
    {
        public CategoryDuplicateException()
        {
        }

        public CategoryDuplicateException(string? message) : base(message)
        {
        }
    }
}
