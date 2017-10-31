using System.ComponentModel.DataAnnotations;

namespace Dekart.LazyNet
{
    public enum DeviceStateEnum
    {
        [Display(Name = @"���������������")]
        Operated = 0,
        [Display(Name = @"�����������")]
        Idle = 1,
        [Display(Name = @"����������")]
        Broken = 2,
        [Display(Name = @"�������������")]
        Repairing = 3,
    }
}