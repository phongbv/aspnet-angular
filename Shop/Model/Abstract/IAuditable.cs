
using System;

namespace Shop.Model
{
    public interface IAuditable
    {
        DateTime? CreatedDate { get; set; }

        string  CreatedBy { get; set; }

        DateTime? UpdatedDate { get; set; }

        string UpdatedBy { get; set; }
    }
}