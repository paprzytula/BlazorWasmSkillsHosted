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
                        Image= "https://www.mi-gb.com/wp-content/uploads/2012/04/CategoryManagementDiagram.png",
                        Skills = new List<Skill>() { new Skill() { Id = 1, SkillName = "Paper jamming" }, {new Skill(){Id=2, SkillName="Repairing stuff"} } }
                    },
                    new Category()
                    {
                        Id=3,
                        CategoryName="Programming",
                        Image= "https://www.mi-gb.com/wp-content/uploads/2012/04/CategoryManagementDiagram.png",
                        Skills = new List<Skill>() { new Skill() { Id = 1, SkillName = "C#" }, {new Skill(){Id=2, SkillName="JavaScript"} } }
                    },
                    new Category()
                    {
                        Id=4,
                        CategoryName="Database",
                        Image= "https://www.mi-gb.com/wp-content/uploads/2012/04/CategoryManagementDiagram.png",
                        Skills = new List<Skill>() { new Skill() { Id = 1, SkillName = "SQL" }, {new Skill(){Id=2, SkillName="T-SQL"} } }
                    },
                    new Category()
                    {
                        Id=1,
                        CategoryName="Administration",
                        Image= "https://www.mi-gb.com/wp-content/uploads/2012/04/CategoryManagementDiagram.png",
                        Skills = new List<Skill>() { new Skill() { Id = 1, SkillName = "GDPR" }, {new Skill(){Id=2, SkillName= "Work Safety Regulations" } } }
                    }

                };
        }

        public List<Department> GetDepartments()
        {
            return  new List<Department>() { new Department() { Id = 1, DepartmentName = "HR", Employees = GetEmployees()}, new Department() { Id = 2, DepartmentName = "Scada" } };
    }

        public List<Employee> GetEmployees()
        {
           return new List<Employee>() { new Employee() { Id = 1, FirstName = "John", LastName = "Travolta" }, new Employee() { Id = 2, FirstName = "Keanu", LastName = "Reeves" } };
        }

        public List<Skill> GetSkills()
        {
            return new List<Skill>() { new Skill() { Id = 1, SkillName = "GDPR" }, { new Skill() { Id = 2, SkillName = "Work Safety Regulations" } } };
        }

       
    }
}
