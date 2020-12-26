using System;

namespace PaymentService.Domain.BaseEntity
{
    public abstract class  Base
    {
        public Guid Id { get; set; }
        public DateTime Created { get;  set; }
        public DateTime? ModifyDate { get;  set; } 
    }
}
