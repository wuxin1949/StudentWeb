using System.ComponentModel.DataAnnotations;

namespace StudentWeb.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Display(Name = "姓名")]//这个代码只能放在修饰Name代码的前面，不能放在后面，否者就是改的出生日期的名字。
        [Required]
        [StringLength(300)]
        public string? Name { get; set; }

        [Display(Name = "性别")]
        [Required]
        [StringLength(1)]
        public string? Sex { get; set; }

        [Range(1, 200)]
        [Display(Name = "年龄")]
        public decimal? age { get; set; }

        [DataType(DataType.Date)]//有这行代码后程序就不会显示时间，只显示年月日！
        [Display(Name = "出生日期")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "手机号")]
        [Required]
        [StringLength(13)]
        public string? Phone { get; set; }

        [Range(30, 50)]
        [Display(Name = "体温")]
        public decimal? Tempeture { get; set; }

        [Display(Name = "填表日期")]
        public DateTime ReleaseDate { get; set; }
    }
}
