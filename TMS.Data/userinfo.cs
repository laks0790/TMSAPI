
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


public partial class userinfo
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public userinfo()
    {

        this.useractivities = new HashSet<useractivity>();

        this.companies = new HashSet<company>();

    }


    public System.Guid userkey { get; set; }

    public string userid { get; set; }

    public string password { get; set; }

    public Nullable<System.DateTime> passwordexpirydate { get; set; }

    public string firstname { get; set; }

    public string lastname { get; set; }

    public System.Guid addrkey { get; set; }

    public short status { get; set; }

    public System.DateTime statusdate { get; set; }

    public System.Guid approvedby { get; set; }

    public System.DateTime approvedtimestamp { get; set; }

    public System.DateTime createdate { get; set; }

    public Nullable<System.DateTime> lastlogindate { get; set; }

    public Nullable<short> loginattempts { get; set; }

    public string passwordtemp { get; set; }



    public virtual address address { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<useractivity> useractivities { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<company> companies { get; set; }

}
