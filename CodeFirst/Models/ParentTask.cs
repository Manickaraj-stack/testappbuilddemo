using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class ParentTask
    {
        [Key]
        [JsonProperty(PropertyName = "parentId")]
        public int Parent_Id { get; set; }

        [JsonProperty(PropertyName = "parentTaskName")]
        public string Parent_Task { get; set; }
    }
}