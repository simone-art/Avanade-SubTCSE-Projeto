﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain
{
    //<Tid> permite definir o tipo
    public class BaseEntity<Tid>
    {
        public Tid Id { get; set; }
    }
}
