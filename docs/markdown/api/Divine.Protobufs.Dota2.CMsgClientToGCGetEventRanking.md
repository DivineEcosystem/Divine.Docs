# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRanking"></a> Class CMsgClientToGCGetEventRanking

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetEventRanking : IMessage<CMsgClientToGCGetEventRanking>, IEquatable<CMsgClientToGCGetEventRanking>, IDeepCloneable<CMsgClientToGCGetEventRanking>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetEventRanking](Divine.Protobufs.Dota2.CMsgClientToGCGetEventRanking.md)

#### Implements

IMessage<CMsgClientToGCGetEventRanking\>, 
[IEquatable<CMsgClientToGCGetEventRanking\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetEventRanking\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetEventRanking\>\(CMsgClientToGCGetEventRanking, params CMsgClientToGCGetEventRanking\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRanking__ctor"></a> CMsgClientToGCGetEventRanking\(\)

```csharp
public CMsgClientToGCGetEventRanking()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRanking__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetEventRanking_"></a> CMsgClientToGCGetEventRanking\(CMsgClientToGCGetEventRanking\)

```csharp
public CMsgClientToGCGetEventRanking(CMsgClientToGCGetEventRanking other)
```

#### Parameters

`other` [CMsgClientToGCGetEventRanking](Divine.Protobufs.Dota2.CMsgClientToGCGetEventRanking.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRanking_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRanking_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRanking_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRanking_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRanking_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRanking_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRanking_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRanking_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetEventRanking> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetEventRanking](Divine.Protobufs.Dota2.CMsgClientToGCGetEventRanking.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRanking_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRanking_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRanking_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRanking_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetEventRanking Clone()
```

#### Returns

 [CMsgClientToGCGetEventRanking](Divine.Protobufs.Dota2.CMsgClientToGCGetEventRanking.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRanking_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRanking_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetEventRanking_"></a> Equals\(CMsgClientToGCGetEventRanking\)

```csharp
public bool Equals(CMsgClientToGCGetEventRanking other)
```

#### Parameters

`other` [CMsgClientToGCGetEventRanking](Divine.Protobufs.Dota2.CMsgClientToGCGetEventRanking.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRanking_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRanking_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetEventRanking_"></a> MergeFrom\(CMsgClientToGCGetEventRanking\)

```csharp
public void MergeFrom(CMsgClientToGCGetEventRanking other)
```

#### Parameters

`other` [CMsgClientToGCGetEventRanking](Divine.Protobufs.Dota2.CMsgClientToGCGetEventRanking.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRanking_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRanking_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventRanking_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

