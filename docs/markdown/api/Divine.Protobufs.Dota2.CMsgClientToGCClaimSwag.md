# <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimSwag"></a> Class CMsgClientToGCClaimSwag

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCClaimSwag : IMessage<CMsgClientToGCClaimSwag>, IEquatable<CMsgClientToGCClaimSwag>, IDeepCloneable<CMsgClientToGCClaimSwag>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCClaimSwag](Divine.Protobufs.Dota2.CMsgClientToGCClaimSwag.md)

#### Implements

IMessage<CMsgClientToGCClaimSwag\>, 
[IEquatable<CMsgClientToGCClaimSwag\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCClaimSwag\>, 
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
[EnumerableExtensions.In<CMsgClientToGCClaimSwag\>\(CMsgClientToGCClaimSwag, params CMsgClientToGCClaimSwag\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimSwag__ctor"></a> CMsgClientToGCClaimSwag\(\)

```csharp
public CMsgClientToGCClaimSwag()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimSwag__ctor_Divine_Protobufs_Dota2_CMsgClientToGCClaimSwag_"></a> CMsgClientToGCClaimSwag\(CMsgClientToGCClaimSwag\)

```csharp
public CMsgClientToGCClaimSwag(CMsgClientToGCClaimSwag other)
```

#### Parameters

`other` [CMsgClientToGCClaimSwag](Divine.Protobufs.Dota2.CMsgClientToGCClaimSwag.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimSwag_ActionIdFieldNumber"></a> ActionIdFieldNumber

```csharp
public const int ActionIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimSwag_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimSwag_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimSwag_ActionId"></a> ActionId

```csharp
public uint ActionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimSwag_Data"></a> Data

```csharp
public uint Data { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimSwag_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimSwag_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimSwag_HasActionId"></a> HasActionId

```csharp
public bool HasActionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimSwag_HasData"></a> HasData

```csharp
public bool HasData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimSwag_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimSwag_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCClaimSwag> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCClaimSwag](Divine.Protobufs.Dota2.CMsgClientToGCClaimSwag.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimSwag_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimSwag_ClearActionId"></a> ClearActionId\(\)

```csharp
public void ClearActionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimSwag_ClearData"></a> ClearData\(\)

```csharp
public void ClearData()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimSwag_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimSwag_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCClaimSwag Clone()
```

#### Returns

 [CMsgClientToGCClaimSwag](Divine.Protobufs.Dota2.CMsgClientToGCClaimSwag.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimSwag_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimSwag_Equals_Divine_Protobufs_Dota2_CMsgClientToGCClaimSwag_"></a> Equals\(CMsgClientToGCClaimSwag\)

```csharp
public bool Equals(CMsgClientToGCClaimSwag other)
```

#### Parameters

`other` [CMsgClientToGCClaimSwag](Divine.Protobufs.Dota2.CMsgClientToGCClaimSwag.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimSwag_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimSwag_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCClaimSwag_"></a> MergeFrom\(CMsgClientToGCClaimSwag\)

```csharp
public void MergeFrom(CMsgClientToGCClaimSwag other)
```

#### Parameters

`other` [CMsgClientToGCClaimSwag](Divine.Protobufs.Dota2.CMsgClientToGCClaimSwag.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimSwag_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimSwag_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCClaimSwag_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

