using Lecture26.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Lecture26
{

	[Author("John", Version = 2.0)]
	[Author("Sxva", Version = 2.1)]
	[Author("kide sxva", Version = 2.2)]
	internal class Product
	{
		[JsonPropertyName("product-name")]
		public string Name { get; set; }

		[JsonIgnore]
		public decimal Price { get; set; }
	}
}


//fluent validation