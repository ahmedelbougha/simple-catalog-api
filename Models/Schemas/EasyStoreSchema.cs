using System;
using GraphQL.Types;

namespace aspnetcoregraphql.Models.Schemas
{
    public class EasyStoreSchema : Schema
    {
        public EasyStoreSchema(Func<Type, GraphType> resolveType)
            :base(resolveType)
        {
            Query = (EasyStoreQuery)resolveType(typeof(EasyStoreQuery));
        }

        // public EasyStoreSchema(IDependencyResolver resolver)
        //     :base(resolver)
        // {
        //     Query = resolver.Resolve<EasyStoreQuery>();
        // }        
    }
}