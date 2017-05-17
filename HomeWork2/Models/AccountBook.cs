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
        [Display(Name = "���O")]
        public int Categoryyy { get; set; }

        [Required]
        [Range(0, int.MaxValue,ErrorMessage ="���B������J�����")]
        [Display(Name = "���B")]
        public int Amounttt { get; set; }

        [Required]
        [Remote("OverToday", "OverToday",ErrorMessage ="������o�j�󤵤�")]
        [Display(Name = "���")]
        public DateTime Dateee { get; set; }

        [Required]
        [StringLength(100,ErrorMessage ="�r�Ƥ��o�j��100�r")]
        [Display(Name = "�Ƶ�")]
        public string Remarkkk { get; set; }
    }
}
