﻿using System;
using Microsoft.Xrm.Sdk;

namespace DLaB.Xrm.Test
{
    public class FakeExecutionContext : IExecutionContext
    {
        public int Mode { get; set; }
        public int IsolationMode { get; set; }
        public int Depth { get; set; }
        public string MessageName { get; set; }
        public string PrimaryEntityName { get; set; }
        public Guid? RequestId { get; set; }
        public string SecondaryEntityName { get; set; }
        public ParameterCollection InputParameters { get; set; }
        public ParameterCollection OutputParameters { get; set; }
        public ParameterCollection SharedVariables { get; set; }
        public Guid UserId { get; set; }
        public Guid InitiatingUserId { get; set; }
        public Guid BusinessUnitId { get; set; }
        public Guid OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public Guid PrimaryEntityId { get; set; }
        public EntityImageCollection PreEntityImages { get; set; }
        public EntityImageCollection PostEntityImages { get; set; }
        public EntityReference OwningExtension { get; set; }
        public Guid CorrelationId { get; set; }
        public bool IsExecutingOffline { get; set; }
        public bool IsOfflinePlayback { get; set; }
        public bool IsInTransaction { get; set; }
        public Guid OperationId { get; set; }
        public DateTime OperationCreatedOn { get; set; }

        public FakeExecutionContext()
        {
            InputParameters = new ParameterCollection();
            OutputParameters = new ParameterCollection();
            SharedVariables = new ParameterCollection();
            PreEntityImages = new EntityImageCollection();
            PostEntityImages = new EntityImageCollection();
            UserId = new Guid("eb96c0b5-93cc-4a82-bf9d-f8f5880f4772");
        }
    }
}