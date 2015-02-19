namespace Problem01_Customer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Customer : IComparable<Customer>, ICloneable
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int id;
        private string address;
        private string phone;
        private string email;
        private List<Payment> Payments { get; set; }
        public CustomerType Type { get; set; }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name can't be null or empty");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Middle name can't be null or empty");
                }
                else
                {
                    this.middleName = value;
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name can't be null or empty");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Customer id can't negative");
                }
                else
                {
                    this.id = value;
                }
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Address can't be null or empty");
                }
                else
                {
                    this.address= value;
                }
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Phone can't be null or empty");
                }
                else
                {
                    this.phone = value;
                }
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Email can't be null or empty");
                }
                else
                {
                    this.email = value;
                }
            }
        }

        public Customer(string fname, string mname, string lname, int id, string address, string phone,
            string email, CustomerType type)
        {
            this.FirstName = fname;
            this.MiddleName = mname;
            this.LastName = lname;
            this.Id = id;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.Type = type;
            this.Payments = new List<Payment>();
        }

        public void AddPayment(Payment payment)
        {
            this.Payments.Add(payment);
        }


        public int CompareTo(Customer cust)
        {
            int compare = this.FullName().CompareTo(cust.FullName());
            return compare == 0 ? this.Id.CompareTo(cust.Id) : compare;
        }

        public string FullName()
        {
            return this.FirstName + this.MiddleName + this.LastName;
        }

        public object Clone()
        {
            Customer clone = new Customer(this.FirstName, this.MiddleName, this.LastName,
            this.Id, this.Address, this.Phone, this.Email, this.Type);

            clone.Payments = this.Payments.Select(payment => (Payment)payment.Clone()).ToList();
            return clone;
        }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }

            Customer cust = obj as Customer;
            if ((System.Object)cust == null)
            {
                return false;
            }

            if(this.FullName().Equals(cust.FullName()) &&
                this.Id == cust.Id)
            {
                return true;
            }
            return false;
        }

        public bool Equals(Customer cust)
        {
            if ((object)cust == null)
            {
                return false;
            }

            if (this.FullName().Equals(cust.FullName()) &&
                this.Id == cust.Id)
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(Customer a, Customer b)
        {
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }

            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            if (a.FullName().Equals(b.FullName()) &&
                a.Id == b.Id)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Customer a, Customer b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (this.FullName() + this.Id).GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(String.Format("First name: {0}, Last name: {1}, Id: {2}",
                this.FirstName, this.LastName, this.Id));
            foreach(var payment in this.Payments)
            {
                result.Append("\n\t" + payment.ToString());
            }
            return result.ToString();
        }
    }
}
