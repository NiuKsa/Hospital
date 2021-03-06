﻿using Hospital.Operation.OperationDomain;

namespace Hospital.Operation.OperationFacadeService
{
    interface ISurgeonRepository
    {
        ISurgeon GetSurgeon(int id);
        void DeleteSurgeon(int id);
        int SaveSurgeon(ISurgeon surgeon);
    }
}
