using BlazorWasmSkillsHosted.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmSkillsHosted.Client.Helpers
{
    public class RepositoryInMemory : IRepository
    {
        public List<Category> GetCategories()
        {
        return new List<Category>()
    {
                    new Category()
                    {
                        Id=2,
                        CategoryName="Shopfloor",

                    },
                    new Category()
                    {
                        Id=3,
                        CategoryName="Programming"
                    },
                    new Category()
                    {
                        Id=4,
                        CategoryName="Database"
                    },
                    new Category()
                    {
                        Id=1,
                        CategoryName="Administration"
                    }

                };
        }
    }
}
