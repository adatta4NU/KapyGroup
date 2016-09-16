
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace IdentityTest2.Models
{

using System;
    using System.Collections.Generic;
    
public partial class AspNetUser
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public AspNetUser()
    {

        this.ActionRecords = new HashSet<ActionRecord>();

        this.ActionRecords1 = new HashSet<ActionRecord>();

        this.AspNetUserClaims = new HashSet<AspNetUserClaim>();

        this.AspNetUserLogins = new HashSet<AspNetUserLogin>();

        this.User_Category = new HashSet<User_Category>();

        this.User_Source = new HashSet<User_Source>();

        this.AspNetRoles = new HashSet<AspNetRole>();

        this.Comment1 = new HashSet<Comment1>();

        this.AspNetUser_Category = new HashSet<AspNetUser_Category>();

        this.AspNetUser_Source = new HashSet<AspNetUser_Source>();

        this.ResetPasswordRequests = new HashSet<ResetPasswordRequest>();

    }


    public int Id { get; set; }

    public string Email { get; set; }

    public bool EmailConfirmed { get; set; }

    public string PasswordHash { get; set; }

    public string SecurityStamp { get; set; }

    public string PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public Nullable<System.DateTime> LockoutEndDateUtc { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public string UserName { get; set; }

    public Nullable<int> ReceiveNewsLetters { get; set; }

    public byte[] UserPhoto { get; set; }

    public int isNotified { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ActionRecord> ActionRecords { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ActionRecord> ActionRecords1 { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<User_Category> User_Category { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<User_Source> User_Source { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<AspNetRole> AspNetRoles { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Comment1> Comment1 { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<AspNetUser_Category> AspNetUser_Category { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<AspNetUser_Source> AspNetUser_Source { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ResetPasswordRequest> ResetPasswordRequests { get; set; }

}

}
