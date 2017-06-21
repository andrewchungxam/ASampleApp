using System;
using System.ComponentModel;
using SQLite;
//using Newtonsoft.Json;

namespace ASampleApp
{
    [Table("dog")]
	public class Dog
	{
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
		//[JsonProperty(PropertyName = "id")]
		//public string Id { get; set; }

		//[JsonProperty(PropertyName = "name")]
        [MaxLength(250), Unique]
		public string Name { get; set; }

		//[JsonProperty(PropertyName = "furColor")]
        [MaxLength(250)]
		public string FurColor { get; set; }
	}
}