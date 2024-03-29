﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfPunch
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Punch" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Punch.svc or Punch.svc.cs at the Solution Explorer and start debugging.
    public class Punch : IPunch
    {
        public string GetData(int value)
        {
            return string.Format("Entre une valeur: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
