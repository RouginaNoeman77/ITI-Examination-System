//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sql_project
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inst_Course
    {
        public int Ins_ID { get; set; }
        public int Course_ID { get; set; }
    
        public virtual Course Course { get; set; }
    }
}
