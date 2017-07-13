using ACME.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMBL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public Decimal? CurrentPrice { get; set; }

        public int ProductId { get; private set; }

        public string ProductDescription { get; set; }

        private String _ProductName;

        public String ProductName
        {
            get
            {
                //Making insert spaces an extenstion method makes this possible
                return _ProductName.InsertSpaces();

                //Normal Static Method
                //return StringHandler.InsertSpaces(_ProductName);
            }
            set { _ProductName = value; }
        }

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            return ProductName;
        }

        public string Log()
        {
            var logString = this.ProductId + ": " +
                            this.ProductName + " " +
                            "Email: " + this.ProductDescription + " " +
                            "Status: " + this.EntityState.ToString();
            return logString;
        }
    }
}
