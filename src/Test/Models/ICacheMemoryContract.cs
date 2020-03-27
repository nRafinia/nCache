﻿using System.Collections.Generic;
using System.ServiceModel;

namespace Test.Models
{
    [ServiceContract(Name = "CacheMemory")]
    public interface ICacheMemoryContract
    {
        void AddOrUpdate(AddOrUpdateModel model);
        BaseServiceResponse Get(BaseModel model);
        BaseServiceResponse GetAll(BaseModel model);
        void Remove(BaseModel model);
        void RemoveAllWithKey(BaseModel model);
        void RemoveAll(StructModel<int> provider);
        StructModel<bool> Exists(BaseModel model);
        Dictionary<string, string> GetStatus();
        //bool SaveCacheMemoryToDisk();
    }
}