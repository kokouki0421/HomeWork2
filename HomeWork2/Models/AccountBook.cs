namespace HomeWork2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    [Table("AccountBook")]
    public partial class AccountBook
    {
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "類別")]
        public int Categoryyy { get; set; }

        [Required]
        [Range(0, int.MaxValue,ErrorMessage ="金額必須輸入正整數")]
        [Display(Name = "金額")]
        public int Amounttt { get; set; }

        [Required]
        [Remote("OverToday", "OverToday",ErrorMessage ="日期不得大於今天")]
        [Display(Name = "日期")]
        public DateTime Dateee { get; set; }

        [Required]
        [StringLength(100,ErrorMessage ="字數不得大於100字")]
        [Display(Name = "備註")]
        public string Remarkkk { get; set; }
    }
}
