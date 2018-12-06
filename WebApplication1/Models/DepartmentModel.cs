
using System;

using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;

using System.Linq;

using System.Web;



namespace WebApplication1.Models

{

    public class DepartmentModel

    {
      

        public int Pk_ID { get; set; }

        [Required]

        [StringLength(50, ErrorMessage="Only 50 characters allowed!" )]

        public string DeptName { get; set; }        

        [Required]

	    public string Description{ get; set; }

        
    }

}
