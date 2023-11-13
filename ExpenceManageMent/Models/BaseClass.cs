using System.ComponentModel.DataAnnotations;

namespace ExpenceManageMent.Models
{
    public class BaseClass
    {
        public string?  CreateBy { get; set; }
        public string?  UpdateBy { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{dd/MM/yyyy}")]
        public DateTime?  CreateDate { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{dd/MM/yyyy}")]
        public DateTime?  UpdateDate { get; set; }
    }
}
