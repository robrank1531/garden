﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone.Web.Dal;
using System.Data.SqlClient;
using System.Configuration;
using System.ComponentModel.DataAnnotations;

namespace Capstone.Web.Models
{
    public class User
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public DateTime PlantDate { get; set; }
        public DateTime MaturityDate { get; set; }
    }
}
//{
//    public class Survey
//    {        
//        //Survey Results data
//        public int Votes { get; set; }
//        public string Name { get; set; }

//        //Survey fields/data

//        [Required]
//        [DataType(DataType.EmailAddress)]
//        [EmailAddress]
//        public string Email { get; set; }

//        public string ParkCode { get; set; }
//        public string State { get; set; }
//        public string ActivityLevel { get; set; }

//        //Properties for <SelectList> text/values
//        public string Text { get; set; }
//        public string Value { get; set; }

//        //Survey dropdown lists
//        public SelectList DropDownList { get; set; }

//        public static List<SelectListItem> ChooseState { get; } = new List<SelectListItem>()
//        {
//        new SelectListItem() {Text = "Alabama" },
//        new SelectListItem() {Text = "Alaska"},
//        new SelectListItem() {Text = "Arizona"},
//        new SelectListItem() {Text = "Arkansas"},
//        new SelectListItem() {Text = "California"},
//        new SelectListItem() {Text = "Colorado"},
//        new SelectListItem() {Text = "Connecticut"},
//        new SelectListItem() {Text = "District of Columbia"},
//        new SelectListItem() {Text = "Delaware"},
//        new SelectListItem() {Text = "Florida"},
//        new SelectListItem() {Text = "Georgia"},
//        new SelectListItem() {Text = "Hawaii"},
//        new SelectListItem() {Text = "Idaho"},
//        new SelectListItem() {Text = "Illinois"},
//        new SelectListItem() {Text = "Indiana"},
//        new SelectListItem() {Text = "Iowa"},
//        new SelectListItem() {Text = "Kansas"},
//        new SelectListItem() {Text = "Kentucky"},
//        new SelectListItem() {Text = "Louisiana"},
//        new SelectListItem() {Text = "Maine"},
//        new SelectListItem() {Text = "Maryland"},
//        new SelectListItem() {Text = "Massachusetts"},
//        new SelectListItem() {Text = "Michigan"},
//        new SelectListItem() {Text = "Minnesota"},
//        new SelectListItem() {Text = "Mississippi"},
//        new SelectListItem() {Text = "Missouri"},
//        new SelectListItem() {Text = "Montana"},
//        new SelectListItem() {Text = "Nebraska"},
//        new SelectListItem() {Text = "Nevada"},
//        new SelectListItem() {Text = "New Hampshire"},
//        new SelectListItem() {Text = "New Jersey"},
//        new SelectListItem() {Text = "New Mexico"},
//        new SelectListItem() {Text = "New York"},
//        new SelectListItem() {Text = "North Carolina"},
//        new SelectListItem() {Text = "North Dakota"},
//        new SelectListItem() {Text = "Ohio"},
//        new SelectListItem() {Text = "Oklahoma"},
//        new SelectListItem() {Text = "Oregon"},
//        new SelectListItem() {Text = "Pennsylvania"},
//        new SelectListItem() {Text = "Rhode Island"},
//        new SelectListItem() {Text = "South Carolina"},
//        new SelectListItem() {Text = "South Dakota"},
//        new SelectListItem() {Text = "Tennessee"},
//        new SelectListItem() {Text = "Texas"},
//        new SelectListItem() {Text = "Utah"},
//        new SelectListItem() {Text = "Vermont"},
//        new SelectListItem() {Text = "Virginia"},
//        new SelectListItem() {Text = "Washington"},
//        new SelectListItem() {Text = "West Virginia"},
//        new SelectListItem() {Text = "Wisconsin"},
//        new SelectListItem() {Text = "Wyoming"}
//        };

//        public static List<SelectListItem> ActivityLevels { get; } = new List<SelectListItem>()
//        {
//            new SelectListItem() { Text = "inactive", Value = "inactive"},
//            new SelectListItem() { Text = "sedentary", Value = "sedentary"},
//            new SelectListItem() { Text = "active", Value = "active"},
//            new SelectListItem() { Text = "extremely active", Value = "extremely active"}
//        };
//<<<<<<< HEAD


//=======
//>>>>>>> f8ade6b01088c083160acf6d6d8693270fd7c070
//    }
//}