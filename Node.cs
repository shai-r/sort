﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort
{
    internal class Node<T>
    {
        public Node<T>? next {  get; set; }
        public T? data {  get; set; }
    }
}
