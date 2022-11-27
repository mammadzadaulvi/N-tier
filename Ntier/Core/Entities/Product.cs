﻿using Core.Constants;
using Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string Weight { get; set; }
        public string MainPhotoName { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ProductStatus Status { get; set; }
        public DateTime CreateAt { get; set; }

        public ICollection<ProductPhoto> ProductPhotos { get; set; }
    }
}
