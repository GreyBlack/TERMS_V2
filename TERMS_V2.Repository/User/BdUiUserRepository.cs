using System;
using System.Collections.Generic;
using System.Text;
using TERMS_V2.Domain.Entity;
using TERMS_V2.Domain.Interface;

namespace TERMS_V2.Repository
{
    public class BdUiUserRepository : BaseRepository<BdUiUser>, IBdUiUserRepository
    {
        public BdUiUserRepository(IDbContext context) : base(context) { }
    }
}
