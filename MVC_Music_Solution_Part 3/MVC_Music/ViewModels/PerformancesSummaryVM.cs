using System.ComponentModel.DataAnnotations;

namespace MVC_Music.ViewModels
{
    public class PerformancesSummaryVM
    {
        public int Id { get; set; }

        [Display(Name ="Musician")]
        public string summary
        {
            get
            {
                return First_Name
                        + (string.IsNullOrEmpty(Middle_Name)
                            ? " "
                            : " " + ((char)Middle_Name[0]).ToString().ToUpper() + ". ")
                        + Last_Name;
            }
        }
        public string First_Name { get; set; } = "";
        public string Last_Name { get; set; } = "";
        public string Middle_Name { get; set; } = "";

        [Display(Name = "Average fee paid")]
        [DataType(DataType.Currency)]
        public double Average_Fee { get; set; }

        [Display(Name = "Highest fee paid")]
        [DataType(DataType.Currency)]
        public double Highest_Fee { get; set; }

        [Display(Name ="Fewes fee paid")]
        [DataType(DataType.Currency)]
        public double Fewest_Fee { get; set; }

        [Display(Name = "Number of Performances")]
        public int? Total_Of_Performances { get; set; }
    }
}
