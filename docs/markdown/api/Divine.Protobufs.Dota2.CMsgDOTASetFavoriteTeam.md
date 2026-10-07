# <a id="Divine_Protobufs_Dota2_CMsgDOTASetFavoriteTeam"></a> Class CMsgDOTASetFavoriteTeam

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTASetFavoriteTeam : IMessage<CMsgDOTASetFavoriteTeam>, IEquatable<CMsgDOTASetFavoriteTeam>, IDeepCloneable<CMsgDOTASetFavoriteTeam>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTASetFavoriteTeam](Divine.Protobufs.Dota2.CMsgDOTASetFavoriteTeam.md)

#### Implements

IMessage<CMsgDOTASetFavoriteTeam\>, 
[IEquatable<CMsgDOTASetFavoriteTeam\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTASetFavoriteTeam\>, 
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
[EnumerableExtensions.In<CMsgDOTASetFavoriteTeam\>\(CMsgDOTASetFavoriteTeam, params CMsgDOTASetFavoriteTeam\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetFavoriteTeam__ctor"></a> CMsgDOTASetFavoriteTeam\(\)

```csharp
public CMsgDOTASetFavoriteTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetFavoriteTeam__ctor_Divine_Protobufs_Dota2_CMsgDOTASetFavoriteTeam_"></a> CMsgDOTASetFavoriteTeam\(CMsgDOTASetFavoriteTeam\)

```csharp
public CMsgDOTASetFavoriteTeam(CMsgDOTASetFavoriteTeam other)
```

#### Parameters

`other` [CMsgDOTASetFavoriteTeam](Divine.Protobufs.Dota2.CMsgDOTASetFavoriteTeam.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetFavoriteTeam_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetFavoriteTeam_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetFavoriteTeam_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetFavoriteTeam_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetFavoriteTeam_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetFavoriteTeam_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetFavoriteTeam_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTASetFavoriteTeam> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTASetFavoriteTeam](Divine.Protobufs.Dota2.CMsgDOTASetFavoriteTeam.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetFavoriteTeam_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetFavoriteTeam_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetFavoriteTeam_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetFavoriteTeam_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetFavoriteTeam_Clone"></a> Clone\(\)

```csharp
public CMsgDOTASetFavoriteTeam Clone()
```

#### Returns

 [CMsgDOTASetFavoriteTeam](Divine.Protobufs.Dota2.CMsgDOTASetFavoriteTeam.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetFavoriteTeam_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetFavoriteTeam_Equals_Divine_Protobufs_Dota2_CMsgDOTASetFavoriteTeam_"></a> Equals\(CMsgDOTASetFavoriteTeam\)

```csharp
public bool Equals(CMsgDOTASetFavoriteTeam other)
```

#### Parameters

`other` [CMsgDOTASetFavoriteTeam](Divine.Protobufs.Dota2.CMsgDOTASetFavoriteTeam.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetFavoriteTeam_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetFavoriteTeam_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTASetFavoriteTeam_"></a> MergeFrom\(CMsgDOTASetFavoriteTeam\)

```csharp
public void MergeFrom(CMsgDOTASetFavoriteTeam other)
```

#### Parameters

`other` [CMsgDOTASetFavoriteTeam](Divine.Protobufs.Dota2.CMsgDOTASetFavoriteTeam.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetFavoriteTeam_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetFavoriteTeam_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetFavoriteTeam_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

