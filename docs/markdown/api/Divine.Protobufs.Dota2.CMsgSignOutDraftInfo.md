# <a id="Divine_Protobufs_Dota2_CMsgSignOutDraftInfo"></a> Class CMsgSignOutDraftInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSignOutDraftInfo : IMessage<CMsgSignOutDraftInfo>, IEquatable<CMsgSignOutDraftInfo>, IDeepCloneable<CMsgSignOutDraftInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSignOutDraftInfo](Divine.Protobufs.Dota2.CMsgSignOutDraftInfo.md)

#### Implements

IMessage<CMsgSignOutDraftInfo\>, 
[IEquatable<CMsgSignOutDraftInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSignOutDraftInfo\>, 
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
[EnumerableExtensions.In<CMsgSignOutDraftInfo\>\(CMsgSignOutDraftInfo, params CMsgSignOutDraftInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSignOutDraftInfo__ctor"></a> CMsgSignOutDraftInfo\(\)

```csharp
public CMsgSignOutDraftInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutDraftInfo__ctor_Divine_Protobufs_Dota2_CMsgSignOutDraftInfo_"></a> CMsgSignOutDraftInfo\(CMsgSignOutDraftInfo\)

```csharp
public CMsgSignOutDraftInfo(CMsgSignOutDraftInfo other)
```

#### Parameters

`other` [CMsgSignOutDraftInfo](Divine.Protobufs.Dota2.CMsgSignOutDraftInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSignOutDraftInfo_DireCaptainAccountIdFieldNumber"></a> DireCaptainAccountIdFieldNumber

```csharp
public const int DireCaptainAccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutDraftInfo_PicksBansFieldNumber"></a> PicksBansFieldNumber

```csharp
public const int PicksBansFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutDraftInfo_RadiantCaptainAccountIdFieldNumber"></a> RadiantCaptainAccountIdFieldNumber

```csharp
public const int RadiantCaptainAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSignOutDraftInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSignOutDraftInfo_DireCaptainAccountId"></a> DireCaptainAccountId

```csharp
public uint DireCaptainAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutDraftInfo_HasDireCaptainAccountId"></a> HasDireCaptainAccountId

```csharp
public bool HasDireCaptainAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutDraftInfo_HasRadiantCaptainAccountId"></a> HasRadiantCaptainAccountId

```csharp
public bool HasRadiantCaptainAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutDraftInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSignOutDraftInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSignOutDraftInfo](Divine.Protobufs.Dota2.CMsgSignOutDraftInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutDraftInfo_PicksBans"></a> PicksBans

```csharp
public RepeatedField<CMatchHeroSelectEvent> PicksBans { get; }
```

#### Property Value

 RepeatedField<[CMatchHeroSelectEvent](Divine.Protobufs.Dota2.CMatchHeroSelectEvent.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutDraftInfo_RadiantCaptainAccountId"></a> RadiantCaptainAccountId

```csharp
public uint RadiantCaptainAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSignOutDraftInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutDraftInfo_ClearDireCaptainAccountId"></a> ClearDireCaptainAccountId\(\)

```csharp
public void ClearDireCaptainAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutDraftInfo_ClearRadiantCaptainAccountId"></a> ClearRadiantCaptainAccountId\(\)

```csharp
public void ClearRadiantCaptainAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutDraftInfo_Clone"></a> Clone\(\)

```csharp
public CMsgSignOutDraftInfo Clone()
```

#### Returns

 [CMsgSignOutDraftInfo](Divine.Protobufs.Dota2.CMsgSignOutDraftInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutDraftInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutDraftInfo_Equals_Divine_Protobufs_Dota2_CMsgSignOutDraftInfo_"></a> Equals\(CMsgSignOutDraftInfo\)

```csharp
public bool Equals(CMsgSignOutDraftInfo other)
```

#### Parameters

`other` [CMsgSignOutDraftInfo](Divine.Protobufs.Dota2.CMsgSignOutDraftInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutDraftInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutDraftInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgSignOutDraftInfo_"></a> MergeFrom\(CMsgSignOutDraftInfo\)

```csharp
public void MergeFrom(CMsgSignOutDraftInfo other)
```

#### Parameters

`other` [CMsgSignOutDraftInfo](Divine.Protobufs.Dota2.CMsgSignOutDraftInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutDraftInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSignOutDraftInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutDraftInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

