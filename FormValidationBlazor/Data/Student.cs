using System.ComponentModel.DataAnnotations;

namespace FormValidationBlazor.Data
{
    public class Student
    {
        public int StudentId { get; set; } = 0;

        [Required (ErrorMessage ="Give the student Name")]
        public string Name { get; set; } = "";

        [Required (ErrorMessage ="Give ROLL NUMBER")]
        public string Roll { get; set; } = "";
    }
}
