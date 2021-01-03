using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasmSkillsHosted.Shared.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Image { get; set; }
        public List<Skill> Skills { get; set; }
        public List<CategoriesSkills> CategoriesSkills { get; set; } = new List<CategoriesSkills>();
    }
}
