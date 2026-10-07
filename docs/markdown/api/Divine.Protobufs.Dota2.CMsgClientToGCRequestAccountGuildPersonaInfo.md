# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildPersonaInfo"></a> Class CMsgClientToGCRequestAccountGuildPersonaInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestAccountGuildPersonaInfo : IMessage<CMsgClientToGCRequestAccountGuildPersonaInfo>, IEquatable<CMsgClientToGCRequestAccountGuildPersonaInfo>, IDeepCloneable<CMsgClientToGCRequestAccountGuildPersonaInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestAccountGuildPersonaInfo](Divine.Protobufs.Dota2.CMsgClientToGCRequestAccountGuildPersonaInfo.md)

#### Implements

IMessage<CMsgClientToGCRequestAccountGuildPersonaInfo\>, 
[IEquatable<CMsgClientToGCRequestAccountGuildPersonaInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestAccountGuildPersonaInfo\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRequestAccountGuildPersonaInfo\>\(CMsgClientToGCRequestAccountGuildPersonaInfo, params CMsgClientToGCRequestAccountGuildPersonaInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildPersonaInfo__ctor"></a> CMsgClientToGCRequestAccountGuildPersonaInfo\(\)

```csharp
public CMsgClientToGCRequestAccountGuildPersonaInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildPersonaInfo__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildPersonaInfo_"></a> CMsgClientToGCRequestAccountGuildPersonaInfo\(CMsgClientToGCRequestAccountGuildPersonaInfo\)

```csharp
public CMsgClientToGCRequestAccountGuildPersonaInfo(CMsgClientToGCRequestAccountGuildPersonaInfo other)
```

#### Parameters

`other` [CMsgClientToGCRequestAccountGuildPersonaInfo](Divine.Protobufs.Dota2.CMsgClientToGCRequestAccountGuildPersonaInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildPersonaInfo_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildPersonaInfo_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildPersonaInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildPersonaInfo_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildPersonaInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestAccountGuildPersonaInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestAccountGuildPersonaInfo](Divine.Protobufs.Dota2.CMsgClientToGCRequestAccountGuildPersonaInfo.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildPersonaInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildPersonaInfo_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildPersonaInfo_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestAccountGuildPersonaInfo Clone()
```

#### Returns

 [CMsgClientToGCRequestAccountGuildPersonaInfo](Divine.Protobufs.Dota2.CMsgClientToGCRequestAccountGuildPersonaInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildPersonaInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildPersonaInfo_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildPersonaInfo_"></a> Equals\(CMsgClientToGCRequestAccountGuildPersonaInfo\)

```csharp
public bool Equals(CMsgClientToGCRequestAccountGuildPersonaInfo other)
```

#### Parameters

`other` [CMsgClientToGCRequestAccountGuildPersonaInfo](Divine.Protobufs.Dota2.CMsgClientToGCRequestAccountGuildPersonaInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildPersonaInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildPersonaInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildPersonaInfo_"></a> MergeFrom\(CMsgClientToGCRequestAccountGuildPersonaInfo\)

```csharp
public void MergeFrom(CMsgClientToGCRequestAccountGuildPersonaInfo other)
```

#### Parameters

`other` [CMsgClientToGCRequestAccountGuildPersonaInfo](Divine.Protobufs.Dota2.CMsgClientToGCRequestAccountGuildPersonaInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildPersonaInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildPersonaInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildPersonaInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

