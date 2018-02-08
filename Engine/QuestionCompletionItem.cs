﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class QuestionCompletionItem
    {
        public Item Details { get; set; }
        public int Quantity { get; set; }

        public QuestionCompletionItem(Item details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }
    }
}
