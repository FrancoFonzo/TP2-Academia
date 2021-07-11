﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class BusinessEntity
    {
        public int ID { get; set; } 
        public States State { get; set; }

        public BusinessEntity()
        {
            this.State = States.New;
        }
        public enum States
        {
            Deleted,
            New,
            Modified,
            Unmodified
        }
    }
}
