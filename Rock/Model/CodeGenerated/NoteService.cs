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
    /// Note Service class
    /// </summary>
    public partial class NoteService : Service<Note>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoteService"/> class
        /// </summary>
        public NoteService()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoteService"/> class
        /// </summary>
        public NoteService(IRepository<Note> repository) : base(repository)
        {
        }

        /// <summary>
        /// Determines whether this instance can delete the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <returns>
        ///   <c>true</c> if this instance can delete the specified item; otherwise, <c>false</c>.
        /// </returns>
        public bool CanDelete( Note item, out string errorMessage )
        {
            errorMessage = string.Empty;
            return true;
        }
    }

    /// <summary>
    /// Generated Extension Methods
    /// </summary>
    public static class NoteExtensionMethods
    {
        /// <summary>
        /// Copies all the entity properties from another Note entity
        /// </summary>
        public static void CopyPropertiesFrom( this Note target, Note source )
        {
            target.IsSystem = source.IsSystem;
            target.NoteTypeId = source.NoteTypeId;
            target.EntityId = source.EntityId;
            target.SourceTypeValueId = source.SourceTypeValueId;
            target.Caption = source.Caption;
            target.Date = source.Date;
            target.IsAlert = source.IsAlert;
            target.Text = source.Text;
            target.Id = source.Id;
            target.Guid = source.Guid;

        }
    }
}