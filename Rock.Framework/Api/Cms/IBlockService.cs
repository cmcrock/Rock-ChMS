//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the T4\Model.tt template.
//
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//
using System.ServiceModel;

namespace Rock.Api.Cms
{
	[ServiceContract]
    public partial interface IBlockService
    {
		[OperationContract]
        Rock.Models.Cms.Block Get( string id );

        [OperationContract]
        void UpdateBlock( string id, Rock.Models.Cms.Block Block );

        [OperationContract]
        void CreateBlock( Rock.Models.Cms.Block Block );

        [OperationContract]
        void DeleteBlock( string id );
    }
}