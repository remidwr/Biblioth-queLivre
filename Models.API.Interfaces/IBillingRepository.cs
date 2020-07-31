using Models.API.Global.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.API.Interfaces
{
    public interface IBillingRepository
    {
        IEnumerable<Billing> Get();
        Billing Get(int id);
        void Insert(Billing billing);
    }
}