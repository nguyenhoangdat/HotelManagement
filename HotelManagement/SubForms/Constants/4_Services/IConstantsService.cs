﻿using HotelManagement.Shared.Models.Objects;
using HotelManagement.SubForms.Constants._3_Models.Req;
using HotelManagement.SubForms.Constants._3_Models.Res;
using System.Collections.Generic;

namespace HotelManagement.SubForms.Constants._4_Services
{
    public interface IConstantsService
    {
        List<Constant> GetConstants(GetConstants req);
        Constant GetConstant(int constantId);
        ReturnStatus SetConstant(SetConstant req);
    }
}
