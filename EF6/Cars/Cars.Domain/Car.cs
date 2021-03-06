﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Domain
{
	public class Car
	{
		public int Id { get; set; }
		[Required]
		[StringLength(50)]
		public string Make { get; set; }

		public CarCategory Category { get; set; }
	}
}
