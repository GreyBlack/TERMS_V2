using System;
using System.Collections.Generic;
using TERMS_V2.Domain.Entity;
using TERMS_V2.Domain.Interface;

namespace TERMS_V2.Application
{
    public class UserAppService
    {
        public IBdUiUserRepository UserInfoRepository { get; set; }

        public bool Add()
        {
            return UserInfoRepository.Add(new BdUiUser() { }) > 0;
        }
    }
}
