using System;
using System.Collections.Generic;
using System.Reflection;
using AutoMapper;

namespace AspNetCoreOOPRepoP.Helpers.AutoMapper
{
    public class AutoMapperUtility
    {
        public IMapper Mapper;

        public AutoMapperUtility(IMapper mapper)
        {
            Mapper = mapper;
        }

        public static MapperConfiguration MapperConfiguration(params KeyValuePair<Type, Type>[] mappingExpression)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfiles(Assembly.GetExecutingAssembly());

                if (mappingExpression == null)
                {
                    return;
                }
                foreach (var item in mappingExpression)
                {
                    cfg.CreateMap(item.Key, item.Value);
                }
            });

            return config;
        }

        public virtual TDto GetModelFromData<TDto, TEntity>(TEntity entity)
            where TDto : class, new() where TEntity : class
        {
            return entity != null ? Mapper.Map<TEntity, TDto>(entity) : null;
        }

        public virtual void CopyDataFromModel<TDto, TEntity>(TDto fromDto, TEntity toEntity)
            where TDto : class, new() where TEntity : class
        {
            if (fromDto == null)
            {
                return;
            }
            if (toEntity == null)
            {
                toEntity = Activator.CreateInstance<TEntity>();
            }
            Mapper.Map(fromDto, toEntity);
        }
    }
}