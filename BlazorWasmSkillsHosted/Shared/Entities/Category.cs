using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasmSkillsHosted.Shared.Entities
{
    public class Category
    {
        public int Id { get; set; } = 1;
        public string CategoryName { get; set; }
        public string Image { get; set; }
        public List<Skill> Skill { get; set; }
    }
}
