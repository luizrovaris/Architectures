using CustomerRelationship.Application.Common.Interfaces;
using System;

namespace CustomerRelationship.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
