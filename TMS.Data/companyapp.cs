
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;


public partial class companyapp
{

    public System.Guid companykey { get; set; }

    public System.Guid appkey { get; set; }

    public short status { get; set; }

    public System.DateTime statusdatetime { get; set; }

    public string registrationstring { get; set; }

    public Nullable<System.DateTime> registrationdate { get; set; }

    public string connectionstring { get; set; }



    public virtual app app { get; set; }

    public virtual company company { get; set; }

}
