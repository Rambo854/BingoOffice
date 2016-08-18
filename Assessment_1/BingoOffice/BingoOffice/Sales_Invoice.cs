using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoOffice
{
    class Sales_Invoice
    {
        //Attributes
        private int sales_Invoice_Number;
        private string product_Name;
        private decimal product_Selling_Mark;
        private int quantity_Purchased;
        private double value_of_Sale;

        //Constructor with Parameters
        public Sales_Invoice(int Number, string Name, decimal Mark, int Quantity, double Sale)
        {
            Sales_Invoice_Number = Number;
            Product_Name = Name;
            Product_Selling_Mark = Mark;
            Quantity_Purchased = Quantity;
            Value_of_Sale = Sale;
        }

        //Null Constructor, Meant to store nothing, but to create space for it
        public Sales_Invoice()
        {
            //No Initialisations
        }


        //Get/Set Methods for the attributes
        public int Sales_Invoice_Number
        {
            get
            {
                return sales_Invoice_Number;
            }

            set
            {
                sales_Invoice_Number = value;
            }
        }

        public string Product_Name
        {
            get
            {
                return product_Name;
            }

            set
            {
                product_Name = value;
            }
        }

        public decimal Product_Selling_Mark
        {
            get
            {
                return product_Selling_Mark;
            }

            set
            {
                product_Selling_Mark = value;
            }
        }

        public int Quantity_Purchased
        {
            get
            {
                return quantity_Purchased;
            }

            set
            {
                quantity_Purchased = value;
            }
        }

        public double Value_of_Sale
        {
            get
            {
                return value_of_Sale;
            }

            set
            {
                value_of_Sale = value;
            }
        }



    }
}
