using System.ComponentModel.DataAnnotations;

namespace TesteProjetoFront.Models
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class YearRangeAttribute : RangeAttribute
    {
        public YearRangeAttribute(int date) : base(DateTime.Now.Year, date)
        {
        }
    }
}
