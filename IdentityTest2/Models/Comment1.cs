//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IdentityTest2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment1
    {
        public int commentId { get; set; }
        public int userId { get; set; }
        public int newsId { get; set; }
        public byte[] postTime { get; set; }
        public string commentContent { get; set; }
        public bool isDisplayed { get; set; }
        public Nullable<int> numOfComentLikes { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.DateTime> Datetime { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual News1 News1 { get; set; }
    }
}
