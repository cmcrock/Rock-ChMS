/* List each Entity's Attributes' Values and which Entity ID it is associated with */
SELECT 
    [p].[Name] [Page.Name],    
    [b].[Name] [Block.Name],
    [bt].[Name] [BlockType.Name],
    [a].[Key] [Attribute.Key],
    --[a].[EntityTypeQualifierColumn],
    --[a].[EntityTypeQualifierValue],
    --isnull(cast([v].[EntityId] as nvarchar(100)), 'n/a') [Entity's Id Value],
    [v].[Value] [Value],
    [b].[Guid] [Block.Guid],
    [v].[Guid] [AttributeValue.Guid]
  FROM [AttributeValue] [v]
    join [Attribute] [a] on [a].[Id] = [v].[AttributeId]
    join [EntityType] [e] on [e].[Id] = [a].[EntityTypeId]
    join [Block] [b] on b.Id = [v].[EntityId]
    join [BlockType] bt on b.BlockTypeId = bt.Id
    join [Page] p on b.PageId = p.Id
    where [e].[Name] = 'Rock.Model.Block'
order by 1, 2, 3, [a].[Order]
  

