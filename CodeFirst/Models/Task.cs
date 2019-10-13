using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Task
    {
        [Key]
        [JsonProperty(PropertyName = "id")]
        public int Task_Id { get; set; }

        [JsonProperty(PropertyName = "parentId")]
        public int ParentTaskParent_Id { get; set; }

        [JsonProperty(PropertyName ="taskName")]
        public string TaskName { get; set; }

        [JsonProperty(PropertyName = "startDate")]
        public string Start_Date { get; set; }

        [JsonProperty(PropertyName = "endDate")]
        public string End_Date { get; set; }

        [JsonProperty(PropertyName = "priority")]
        public int Priority { get; set; }

        [JsonProperty(PropertyName = "parentTask")]
        public ParentTask ParentTask { get; set; }
    }
}