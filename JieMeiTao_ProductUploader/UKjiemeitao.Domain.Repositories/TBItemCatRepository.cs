﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKjiemeitao.Domain.Model;
using UKjiemeitao.Domain.Repositories.EntityFramework;
using UKjiemeitao.Domain.Repositories.Specifications;
using UKjiemeitao.Domain.Specifications;

namespace UKjiemeitao.Domain.Repositories
{
    public class TBItemCatRepository : EntityFrameworkRepository<TB_ItemCat>, ITBItemCatRepository
    {
        public TBItemCatRepository(IRepositoryContext context)
            : base(context)
        { }

       
    }
}
