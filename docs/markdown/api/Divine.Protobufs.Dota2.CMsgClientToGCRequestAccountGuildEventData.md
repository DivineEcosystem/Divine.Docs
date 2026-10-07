# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventData"></a> Class CMsgClientToGCRequestAccountGuildEventData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestAccountGuildEventData : IMessage<CMsgClientToGCRequestAccountGuildEventData>, IEquatable<CMsgClientToGCRequestAccountGuildEventData>, IDeepCloneable<CMsgClientToGCRequestAccountGuildEventData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestAccountGuildEventData](Divine.Protobufs.Dota2.CMsgClientToGCRequestAccountGuildEventData.md)

#### Implements

IMessage<CMsgClientToGCRequestAccountGuildEventData\>, 
[IEquatable<CMsgClientToGCRequestAccountGuildEventData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestAccountGuildEventData\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRequestAccountGuildEventData\>\(CMsgClientToGCRequestAccountGuildEventData, params CMsgClientToGCRequestAccountGuildEventData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventData__ctor"></a> CMsgClientToGCRequestAccountGuildEventData\(\)

```csharp
public CMsgClientToGCRequestAccountGuildEventData()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventData__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventData_"></a> CMsgClientToGCRequestAccountGuildEventData\(CMsgClientToGCRequestAccountGuildEventData\)

```csharp
public CMsgClientToGCRequestAccountGuildEventData(CMsgClientToGCRequestAccountGuildEventData other)
```

#### Parameters

`other` [CMsgClientToGCRequestAccountGuildEventData](Divine.Protobufs.Dota2.CMsgClientToGCRequestAccountGuildEventData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventData_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventData_GuildIdFieldNumber"></a> GuildIdFieldNumber

```csharp
public const int GuildIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventData_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventData_GuildId"></a> GuildId

```csharp
public uint GuildId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventData_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventData_HasGuildId"></a> HasGuildId

```csharp
public bool HasGuildId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestAccountGuildEventData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestAccountGuildEventData](Divine.Protobufs.Dota2.CMsgClientToGCRequestAccountGuildEventData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventData_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventData_ClearGuildId"></a> ClearGuildId\(\)

```csharp
public void ClearGuildId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventData_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestAccountGuildEventData Clone()
```

#### Returns

 [CMsgClientToGCRequestAccountGuildEventData](Divine.Protobufs.Dota2.CMsgClientToGCRequestAccountGuildEventData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventData_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventData_"></a> Equals\(CMsgClientToGCRequestAccountGuildEventData\)

```csharp
public bool Equals(CMsgClientToGCRequestAccountGuildEventData other)
```

#### Parameters

`other` [CMsgClientToGCRequestAccountGuildEventData](Divine.Protobufs.Dota2.CMsgClientToGCRequestAccountGuildEventData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventData_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventData_"></a> MergeFrom\(CMsgClientToGCRequestAccountGuildEventData\)

```csharp
public void MergeFrom(CMsgClientToGCRequestAccountGuildEventData other)
```

#### Parameters

`other` [CMsgClientToGCRequestAccountGuildEventData](Divine.Protobufs.Dota2.CMsgClientToGCRequestAccountGuildEventData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestAccountGuildEventData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

