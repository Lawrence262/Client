using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF_Client
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        static List<Customer> custlist = new List<Customer>();
        //public Customer GetDataUsingDataContract()
        //{
        //    Customer c = new Customer();
        //    c.CustName = "Manoj";
        //    return c;
        //   // throw new NotImplementedException();
        //}

        public List<Customer> GetDataUsingDataContractXML()
        {
            //Customer c = new Customer();

            return custlist;
            //throw new NotImplementedException();
        }

        public void PostDataUsingDataContract(Customer c)
        {
            Customer c1 = new Customer();
            c1.CustName = c.CustName;
            custlist.Add(c1);
            //throw new NotImplementedException();
        }
    }
}
