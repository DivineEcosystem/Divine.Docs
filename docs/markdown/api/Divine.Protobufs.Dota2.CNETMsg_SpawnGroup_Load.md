# <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load"></a> Class CNETMsg\_SpawnGroup\_Load

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CNETMsg_SpawnGroup_Load : IMessage<CNETMsg_SpawnGroup_Load>, IEquatable<CNETMsg_SpawnGroup_Load>, IDeepCloneable<CNETMsg_SpawnGroup_Load>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CNETMsg\_SpawnGroup\_Load](Divine.Protobufs.Dota2.CNETMsg\_SpawnGroup\_Load.md)

#### Implements

IMessage<CNETMsg\_SpawnGroup\_Load\>, 
[IEquatable<CNETMsg\_SpawnGroup\_Load\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CNETMsg\_SpawnGroup\_Load\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<CNETMsg\_SpawnGroup\_Load\>\(CNETMsg\_SpawnGroup\_Load, params CNETMsg\_SpawnGroup\_Load\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load__ctor"></a> CNETMsg\_SpawnGroup\_Load\(\)

```csharp
public CNETMsg_SpawnGroup_Load()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load__ctor_Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_"></a> CNETMsg\_SpawnGroup\_Load\(CNETMsg\_SpawnGroup\_Load\)

```csharp
public CNETMsg_SpawnGroup_Load(CNETMsg_SpawnGroup_Load other)
```

#### Parameters

`other` [CNETMsg\_SpawnGroup\_Load](Divine.Protobufs.Dota2.CNETMsg\_SpawnGroup\_Load.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_CreationsequenceFieldNumber"></a> CreationsequenceFieldNumber

```csharp
public const int CreationsequenceFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_EntityfilternameFieldNumber"></a> EntityfilternameFieldNumber

```csharp
public const int EntityfilternameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_EntitylumpnameFieldNumber"></a> EntitylumpnameFieldNumber

```csharp
public const int EntitylumpnameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_FlagsFieldNumber"></a> FlagsFieldNumber

```csharp
public const int FlagsFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_LeveltransitionFieldNumber"></a> LeveltransitionFieldNumber

```csharp
public const int LeveltransitionFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_LocalnamefixupFieldNumber"></a> LocalnamefixupFieldNumber

```csharp
public const int LocalnamefixupFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_ManifestincompleteFieldNumber"></a> ManifestincompleteFieldNumber

```csharp
public const int ManifestincompleteFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_ManifestloadpriorityFieldNumber"></a> ManifestloadpriorityFieldNumber

```csharp
public const int ManifestloadpriorityFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_ParentnamefixupFieldNumber"></a> ParentnamefixupFieldNumber

```csharp
public const int ParentnamefixupFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_SavegamefilenameFieldNumber"></a> SavegamefilenameFieldNumber

```csharp
public const int SavegamefilenameFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_SpawngrouphandleFieldNumber"></a> SpawngrouphandleFieldNumber

```csharp
public const int SpawngrouphandleFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_SpawngroupmanifestFieldNumber"></a> SpawngroupmanifestFieldNumber

```csharp
public const int SpawngroupmanifestFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_SpawngroupownerhandleFieldNumber"></a> SpawngroupownerhandleFieldNumber

```csharp
public const int SpawngroupownerhandleFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_SpawngroupparenthandleFieldNumber"></a> SpawngroupparenthandleFieldNumber

```csharp
public const int SpawngroupparenthandleFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_TickcountFieldNumber"></a> TickcountFieldNumber

```csharp
public const int TickcountFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_WorldgroupidFieldNumber"></a> WorldgroupidFieldNumber

```csharp
public const int WorldgroupidFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_WorldgroupnameFieldNumber"></a> WorldgroupnameFieldNumber

```csharp
public const int WorldgroupnameFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_WorldnameFieldNumber"></a> WorldnameFieldNumber

```csharp
public const int WorldnameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_WorldOffsetAngleFieldNumber"></a> WorldOffsetAngleFieldNumber

```csharp
public const int WorldOffsetAngleFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_WorldOffsetPosFieldNumber"></a> WorldOffsetPosFieldNumber

```csharp
public const int WorldOffsetPosFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_Creationsequence"></a> Creationsequence

```csharp
public uint Creationsequence { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_Entityfiltername"></a> Entityfiltername

```csharp
public string Entityfiltername { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_Entitylumpname"></a> Entitylumpname

```csharp
public string Entitylumpname { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_Flags"></a> Flags

```csharp
public uint Flags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_HasCreationsequence"></a> HasCreationsequence

```csharp
public bool HasCreationsequence { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_HasEntityfiltername"></a> HasEntityfiltername

```csharp
public bool HasEntityfiltername { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_HasEntitylumpname"></a> HasEntitylumpname

```csharp
public bool HasEntitylumpname { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_HasFlags"></a> HasFlags

```csharp
public bool HasFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_HasLeveltransition"></a> HasLeveltransition

```csharp
public bool HasLeveltransition { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_HasLocalnamefixup"></a> HasLocalnamefixup

```csharp
public bool HasLocalnamefixup { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_HasManifestincomplete"></a> HasManifestincomplete

```csharp
public bool HasManifestincomplete { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_HasManifestloadpriority"></a> HasManifestloadpriority

```csharp
public bool HasManifestloadpriority { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_HasParentnamefixup"></a> HasParentnamefixup

```csharp
public bool HasParentnamefixup { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_HasSavegamefilename"></a> HasSavegamefilename

```csharp
public bool HasSavegamefilename { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_HasSpawngrouphandle"></a> HasSpawngrouphandle

```csharp
public bool HasSpawngrouphandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_HasSpawngroupmanifest"></a> HasSpawngroupmanifest

```csharp
public bool HasSpawngroupmanifest { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_HasSpawngroupownerhandle"></a> HasSpawngroupownerhandle

```csharp
public bool HasSpawngroupownerhandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_HasSpawngroupparenthandle"></a> HasSpawngroupparenthandle

```csharp
public bool HasSpawngroupparenthandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_HasTickcount"></a> HasTickcount

```csharp
public bool HasTickcount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_HasWorldgroupid"></a> HasWorldgroupid

```csharp
public bool HasWorldgroupid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_HasWorldgroupname"></a> HasWorldgroupname

```csharp
public bool HasWorldgroupname { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_HasWorldname"></a> HasWorldname

```csharp
public bool HasWorldname { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_Leveltransition"></a> Leveltransition

```csharp
public bool Leveltransition { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_Localnamefixup"></a> Localnamefixup

```csharp
public string Localnamefixup { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_Manifestincomplete"></a> Manifestincomplete

```csharp
public bool Manifestincomplete { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_Manifestloadpriority"></a> Manifestloadpriority

```csharp
public int Manifestloadpriority { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_Parentnamefixup"></a> Parentnamefixup

```csharp
public string Parentnamefixup { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_Parser"></a> Parser

```csharp
public static MessageParser<CNETMsg_SpawnGroup_Load> Parser { get; }
```

#### Property Value

 MessageParser<[CNETMsg\_SpawnGroup\_Load](Divine.Protobufs.Dota2.CNETMsg\_SpawnGroup\_Load.md)\>

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_Savegamefilename"></a> Savegamefilename

```csharp
public string Savegamefilename { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_Spawngrouphandle"></a> Spawngrouphandle

```csharp
public uint Spawngrouphandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_Spawngroupmanifest"></a> Spawngroupmanifest

```csharp
public ByteString Spawngroupmanifest { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_Spawngroupownerhandle"></a> Spawngroupownerhandle

```csharp
public uint Spawngroupownerhandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_Spawngroupparenthandle"></a> Spawngroupparenthandle

```csharp
public uint Spawngroupparenthandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_Tickcount"></a> Tickcount

```csharp
public int Tickcount { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_Worldgroupid"></a> Worldgroupid

```csharp
public uint Worldgroupid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_Worldgroupname"></a> Worldgroupname

```csharp
public string Worldgroupname { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_Worldname"></a> Worldname

```csharp
public string Worldname { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_WorldOffsetAngle"></a> WorldOffsetAngle

```csharp
public CMsgQAngle WorldOffsetAngle { get; set; }
```

#### Property Value

 [CMsgQAngle](Divine.Protobufs.Dota2.CMsgQAngle.md)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_WorldOffsetPos"></a> WorldOffsetPos

```csharp
public CMsgVector WorldOffsetPos { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_ClearCreationsequence"></a> ClearCreationsequence\(\)

```csharp
public void ClearCreationsequence()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_ClearEntityfiltername"></a> ClearEntityfiltername\(\)

```csharp
public void ClearEntityfiltername()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_ClearEntitylumpname"></a> ClearEntitylumpname\(\)

```csharp
public void ClearEntitylumpname()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_ClearFlags"></a> ClearFlags\(\)

```csharp
public void ClearFlags()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_ClearLeveltransition"></a> ClearLeveltransition\(\)

```csharp
public void ClearLeveltransition()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_ClearLocalnamefixup"></a> ClearLocalnamefixup\(\)

```csharp
public void ClearLocalnamefixup()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_ClearManifestincomplete"></a> ClearManifestincomplete\(\)

```csharp
public void ClearManifestincomplete()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_ClearManifestloadpriority"></a> ClearManifestloadpriority\(\)

```csharp
public void ClearManifestloadpriority()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_ClearParentnamefixup"></a> ClearParentnamefixup\(\)

```csharp
public void ClearParentnamefixup()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_ClearSavegamefilename"></a> ClearSavegamefilename\(\)

```csharp
public void ClearSavegamefilename()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_ClearSpawngrouphandle"></a> ClearSpawngrouphandle\(\)

```csharp
public void ClearSpawngrouphandle()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_ClearSpawngroupmanifest"></a> ClearSpawngroupmanifest\(\)

```csharp
public void ClearSpawngroupmanifest()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_ClearSpawngroupownerhandle"></a> ClearSpawngroupownerhandle\(\)

```csharp
public void ClearSpawngroupownerhandle()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_ClearSpawngroupparenthandle"></a> ClearSpawngroupparenthandle\(\)

```csharp
public void ClearSpawngroupparenthandle()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_ClearTickcount"></a> ClearTickcount\(\)

```csharp
public void ClearTickcount()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_ClearWorldgroupid"></a> ClearWorldgroupid\(\)

```csharp
public void ClearWorldgroupid()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_ClearWorldgroupname"></a> ClearWorldgroupname\(\)

```csharp
public void ClearWorldgroupname()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_ClearWorldname"></a> ClearWorldname\(\)

```csharp
public void ClearWorldname()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_Clone"></a> Clone\(\)

```csharp
public CNETMsg_SpawnGroup_Load Clone()
```

#### Returns

 [CNETMsg\_SpawnGroup\_Load](Divine.Protobufs.Dota2.CNETMsg\_SpawnGroup\_Load.md)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_Equals_Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_"></a> Equals\(CNETMsg\_SpawnGroup\_Load\)

```csharp
public bool Equals(CNETMsg_SpawnGroup_Load other)
```

#### Parameters

`other` [CNETMsg\_SpawnGroup\_Load](Divine.Protobufs.Dota2.CNETMsg\_SpawnGroup\_Load.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_MergeFrom_Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_"></a> MergeFrom\(CNETMsg\_SpawnGroup\_Load\)

```csharp
public void MergeFrom(CNETMsg_SpawnGroup_Load other)
```

#### Parameters

`other` [CNETMsg\_SpawnGroup\_Load](Divine.Protobufs.Dota2.CNETMsg\_SpawnGroup\_Load.md)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SpawnGroup_Load_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

