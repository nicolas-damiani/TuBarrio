﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuBarrio.Entities
{
    public class ImageTag
    {
        public int Id { get; set; }
        public String Text { get; set; }

        public ImageTag() { }
        public ImageTag(String text)
        {
            Text = text;
        }
    }
}
