﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Dto
{
    public class IngredientDto
    {
        public string Name { get; set; }
        public List<AmountDto> Amounts { get; set; }
    }
}
