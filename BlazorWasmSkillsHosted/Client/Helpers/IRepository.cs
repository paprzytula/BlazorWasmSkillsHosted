using BlazorWasmSkillsHosted.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmSkillsHosted.Client.Helpers
{
    public interface IRepository
    {
        List<Category> GetCategories();
    }
}
