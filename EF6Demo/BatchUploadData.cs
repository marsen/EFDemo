//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF6Demo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class BatchUploadData
    {
        public long BatchUploadData_Id { get; set; }
        public long BatchUploadData_BatchUploadId { get; set; }
        public int BatchUploadData_SupplierId { get; set; }
        public string BatchUploadData_TypeDef { get; set; }
        public string BatchUploadData_StatusDef { get; set; }
        public string BatchUploadData_Title { get; set; }
        public string BatchUploadData_Data { get; set; }

        [Column(TypeName = "datetime2")]
        public System.DateTime BatchUploadData_CreatedDateTime { get; set; }
        public string BatchUploadData_CreatedUser { get; set; }
        public byte BatchUploadData_UpdatedTimes { get; set; }
        public string BatchUploadData_UpdatedUser { get; set; }
        public System.DateTime BatchUploadData_UpdatedDateTime { get; set; }
        public bool BatchUploadData_ValidFlag { get; set; }
        public byte[] BatchUploadData_Rowversion { get; set; }
    }
}