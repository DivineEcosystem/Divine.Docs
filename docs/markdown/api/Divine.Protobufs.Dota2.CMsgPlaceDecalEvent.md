# <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent"></a> Class CMsgPlaceDecalEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPlaceDecalEvent : IMessage<CMsgPlaceDecalEvent>, IEquatable<CMsgPlaceDecalEvent>, IDeepCloneable<CMsgPlaceDecalEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPlaceDecalEvent](Divine.Protobufs.Dota2.CMsgPlaceDecalEvent.md)

#### Implements

IMessage<CMsgPlaceDecalEvent\>, 
[IEquatable<CMsgPlaceDecalEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPlaceDecalEvent\>, 
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
[EnumerableExtensions.In<CMsgPlaceDecalEvent\>\(CMsgPlaceDecalEvent, params CMsgPlaceDecalEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent__ctor"></a> CMsgPlaceDecalEvent\(\)

```csharp
public CMsgPlaceDecalEvent()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent__ctor_Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_"></a> CMsgPlaceDecalEvent\(CMsgPlaceDecalEvent\)

```csharp
public CMsgPlaceDecalEvent(CMsgPlaceDecalEvent other)
```

#### Parameters

`other` [CMsgPlaceDecalEvent](Divine.Protobufs.Dota2.CMsgPlaceDecalEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_BoneindexFieldNumber"></a> BoneindexFieldNumber

```csharp
public const int BoneindexFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_ColorFieldNumber"></a> ColorFieldNumber

```csharp
public const int ColorFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_DecalGroupNameFieldNumber"></a> DecalGroupNameFieldNumber

```csharp
public const int DecalGroupNameFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_EntityhandleFieldNumber"></a> EntityhandleFieldNumber

```csharp
public const int EntityhandleFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_FlagsFieldNumber"></a> FlagsFieldNumber

```csharp
public const int FlagsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_MaterialIdFieldNumber"></a> MaterialIdFieldNumber

```csharp
public const int MaterialIdFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_NormalFieldNumber"></a> NormalFieldNumber

```csharp
public const int NormalFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_NormalObjectspaceFieldNumber"></a> NormalObjectspaceFieldNumber

```csharp
public const int NormalObjectspaceFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_PositionFieldNumber"></a> PositionFieldNumber

```csharp
public const int PositionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_PositionObjectspaceFieldNumber"></a> PositionObjectspaceFieldNumber

```csharp
public const int PositionObjectspaceFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_RandomSeedFieldNumber"></a> RandomSeedFieldNumber

```csharp
public const int RandomSeedFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_SaxisFieldNumber"></a> SaxisFieldNumber

```csharp
public const int SaxisFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_SequenceNameFieldNumber"></a> SequenceNameFieldNumber

```csharp
public const int SequenceNameFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_SizeOverrideFieldNumber"></a> SizeOverrideFieldNumber

```csharp
public const int SizeOverrideFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_TriangleindexFieldNumber"></a> TriangleindexFieldNumber

```csharp
public const int TriangleindexFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_Boneindex"></a> Boneindex

```csharp
public int Boneindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_Color"></a> Color

```csharp
public uint Color { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_DecalGroupName"></a> DecalGroupName

```csharp
public uint DecalGroupName { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_Entityhandle"></a> Entityhandle

```csharp
public uint Entityhandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_Flags"></a> Flags

```csharp
public uint Flags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_HasBoneindex"></a> HasBoneindex

```csharp
public bool HasBoneindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_HasColor"></a> HasColor

```csharp
public bool HasColor { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_HasDecalGroupName"></a> HasDecalGroupName

```csharp
public bool HasDecalGroupName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_HasEntityhandle"></a> HasEntityhandle

```csharp
public bool HasEntityhandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_HasFlags"></a> HasFlags

```csharp
public bool HasFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_HasMaterialId"></a> HasMaterialId

```csharp
public bool HasMaterialId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_HasRandomSeed"></a> HasRandomSeed

```csharp
public bool HasRandomSeed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_HasSequenceName"></a> HasSequenceName

```csharp
public bool HasSequenceName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_HasSizeOverride"></a> HasSizeOverride

```csharp
public bool HasSizeOverride { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_HasTriangleindex"></a> HasTriangleindex

```csharp
public bool HasTriangleindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_MaterialId"></a> MaterialId

```csharp
public ulong MaterialId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_Normal"></a> Normal

```csharp
public CMsgVector Normal { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_NormalObjectspace"></a> NormalObjectspace

```csharp
public CMsgVector NormalObjectspace { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPlaceDecalEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPlaceDecalEvent](Divine.Protobufs.Dota2.CMsgPlaceDecalEvent.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_Position"></a> Position

```csharp
public CMsgVector Position { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_PositionObjectspace"></a> PositionObjectspace

```csharp
public CMsgVector PositionObjectspace { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_RandomSeed"></a> RandomSeed

```csharp
public int RandomSeed { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_Saxis"></a> Saxis

```csharp
public CMsgVector Saxis { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_SequenceName"></a> SequenceName

```csharp
public uint SequenceName { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_SizeOverride"></a> SizeOverride

```csharp
public float SizeOverride { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_Triangleindex"></a> Triangleindex

```csharp
public int Triangleindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_ClearBoneindex"></a> ClearBoneindex\(\)

```csharp
public void ClearBoneindex()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_ClearColor"></a> ClearColor\(\)

```csharp
public void ClearColor()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_ClearDecalGroupName"></a> ClearDecalGroupName\(\)

```csharp
public void ClearDecalGroupName()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_ClearEntityhandle"></a> ClearEntityhandle\(\)

```csharp
public void ClearEntityhandle()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_ClearFlags"></a> ClearFlags\(\)

```csharp
public void ClearFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_ClearMaterialId"></a> ClearMaterialId\(\)

```csharp
public void ClearMaterialId()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_ClearRandomSeed"></a> ClearRandomSeed\(\)

```csharp
public void ClearRandomSeed()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_ClearSequenceName"></a> ClearSequenceName\(\)

```csharp
public void ClearSequenceName()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_ClearSizeOverride"></a> ClearSizeOverride\(\)

```csharp
public void ClearSizeOverride()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_ClearTriangleindex"></a> ClearTriangleindex\(\)

```csharp
public void ClearTriangleindex()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_Clone"></a> Clone\(\)

```csharp
public CMsgPlaceDecalEvent Clone()
```

#### Returns

 [CMsgPlaceDecalEvent](Divine.Protobufs.Dota2.CMsgPlaceDecalEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_Equals_Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_"></a> Equals\(CMsgPlaceDecalEvent\)

```csharp
public bool Equals(CMsgPlaceDecalEvent other)
```

#### Parameters

`other` [CMsgPlaceDecalEvent](Divine.Protobufs.Dota2.CMsgPlaceDecalEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_MergeFrom_Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_"></a> MergeFrom\(CMsgPlaceDecalEvent\)

```csharp
public void MergeFrom(CMsgPlaceDecalEvent other)
```

#### Parameters

`other` [CMsgPlaceDecalEvent](Divine.Protobufs.Dota2.CMsgPlaceDecalEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPlaceDecalEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

