using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasmSkillsHosted.Shared.Entities
{
    public class Skill
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string SkillName { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string SkillDescription { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string SkillCategory { get; set; }
        public int SkillLevel { get; set; }

    }
}
