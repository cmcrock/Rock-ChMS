//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//

using System;
using System.Linq;

using Rock.Data;

namespace Rock.Model
{
    /// <summary>
    /// ServiceLog Service class
    /// </summary>
    public partial class ServiceLogService : Service<ServiceLog, ServiceLogDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceLogService"/> class
        /// </summary>
        public ServiceLogService()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceLogService"/> class
        /// </summary>
        public ServiceLogService(IRepository<ServiceLog> repository) : base(repository)
        {
        }

        /// <summary>
        /// Creates a new model
        /// </summary>
        public override ServiceLog CreateNew()
        {
            return new ServiceLog();
        }

        /// <summary>
        /// Query DTO objects
        /// </summary>
        /// <returns>A queryable list of DTO objects</returns>
        public override IQueryable<ServiceLogDto> QueryableDto( )
        {
            return QueryableDto( this.Queryable() );
        }

        /// <summary>
        /// Query DTO objects
        /// </summary>
        /// <returns>A queryable list of DTO objects</returns>
        public IQueryable<ServiceLogDto> QueryableDto( IQueryable<ServiceLog> items )
        {
            return items.Select( m => new ServiceLogDto()
                {
                    Time = m.Time,
                    Input = m.Input,
                    Type = m.Type,
                    Name = m.Name,
                    Result = m.Result,
                    Success = m.Success,
                    Id = m.Id,
                    Guid = m.Guid,
                });
        }

        /// <summary>
        /// Determines whether this instance can delete the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <returns>
        ///   <c>true</c> if this instance can delete the specified item; otherwise, <c>false</c>.
        /// </returns>
        public bool CanDelete( ServiceLog item, out string errorMessage )
        {
            errorMessage = string.Empty;
            return true;
        }
    }
}