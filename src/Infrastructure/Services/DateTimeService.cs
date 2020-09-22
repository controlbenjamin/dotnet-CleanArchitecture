using sample_ca.Application.Common.Interfaces;
using System;

namespace sample_ca.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
