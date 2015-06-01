﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ng.NET.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }
        
        public string Notes { get; set; }

        [Required]
        [MinLength(3)]
        public string FavoriteHobby { get; set; }
        public int Happiness { get; set; }
        public bool IsContractor { get; set; }
        public string ContractingCompany { get; set; }
        public string Department { get; set; }
        public DateTime DateHired { get; set; }
        public DateTime BreakTime { get; set; }
        public bool PerkCar { get; set; }
        public bool PerkStock { get; set; }
        public bool PerkSixWeeks { get; set; }
        public string PayrollType { get; set; }
    }
}