﻿using System;
using System.Collections.Generic;
using System.Text;
using DLaB.Xrm.LocalCrm.Entities;
using Microsoft.Xrm.Sdk;

namespace DLaB.Xrm.LocalCrm
{
    internal class AssociationInfo
    {
        public Type AssociationType { get; set; }
        public string OneLogicalName { get; set; }
        public string TwoLogicalName { get; set; }

        private AssociationInfo(){}

        public static AssociationInfo Create<TOne, TTwo>(Type associationType, N2NAssociation<TOne, TTwo> association)
            where TOne : Entity
            where TTwo : Entity
        {
            return new AssociationInfo
            {
                AssociationType = associationType,
                OneLogicalName = association.One.LogicalName,
                TwoLogicalName = association.Two.LogicalName,
            };
        }
    }
}
