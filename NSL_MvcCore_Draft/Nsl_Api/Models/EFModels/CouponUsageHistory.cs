﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Nsl_Api.Models.EFModels
{
    public partial class CouponUsageHistory
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int CouponId { get; set; }

        public virtual Coupons Coupon { get; set; }
        public virtual Members Member { get; set; }
    }
}