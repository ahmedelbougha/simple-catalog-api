using System;
using GraphQL;
using GraphQL.Types;
using aspnetcoregraphql.Models.Operations;

namespace aspnetcoregraphql.Models.Schemas
{
    public class EasyStoreSchema : Schema
    {
        // public EasyStoreSchema(Func<Type, GraphType> resolveType)
        //     :base(resolveType)
        // {
        //     Query = (EasyStoreQuery)resolveType(typeof(EasyStoreQuery));
        // }

        public EasyStoreSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<EasyStoreQuery>();
            Mutation = resolver.Resolve<EasyStoreMutation>();            
        }        
    }
}