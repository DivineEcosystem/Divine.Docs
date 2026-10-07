# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResult"></a> Class CMsgClientToGCRequestPlusWeeklyChallengeResult

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestPlusWeeklyChallengeResult : IMessage<CMsgClientToGCRequestPlusWeeklyChallengeResult>, IEquatable<CMsgClientToGCRequestPlusWeeklyChallengeResult>, IDeepCloneable<CMsgClientToGCRequestPlusWeeklyChallengeResult>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestPlusWeeklyChallengeResult](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlusWeeklyChallengeResult.md)

#### Implements

IMessage<CMsgClientToGCRequestPlusWeeklyChallengeResult\>, 
[IEquatable<CMsgClientToGCRequestPlusWeeklyChallengeResult\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestPlusWeeklyChallengeResult\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRequestPlusWeeklyChallengeResult\>\(CMsgClientToGCRequestPlusWeeklyChallengeResult, params CMsgClientToGCRequestPlusWeeklyChallengeResult\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResult__ctor"></a> CMsgClientToGCRequestPlusWeeklyChallengeResult\(\)

```csharp
public CMsgClientToGCRequestPlusWeeklyChallengeResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResult__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResult_"></a> CMsgClientToGCRequestPlusWeeklyChallengeResult\(CMsgClientToGCRequestPlusWeeklyChallengeResult\)

```csharp
public CMsgClientToGCRequestPlusWeeklyChallengeResult(CMsgClientToGCRequestPlusWeeklyChallengeResult other)
```

#### Parameters

`other` [CMsgClientToGCRequestPlusWeeklyChallengeResult](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlusWeeklyChallengeResult.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResult_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResult_WeekFieldNumber"></a> WeekFieldNumber

```csharp
public const int WeekFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResult_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResult_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResult_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResult_HasWeek"></a> HasWeek

```csharp
public bool HasWeek { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResult_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestPlusWeeklyChallengeResult> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestPlusWeeklyChallengeResult](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlusWeeklyChallengeResult.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResult_Week"></a> Week

```csharp
public uint Week { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResult_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResult_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResult_ClearWeek"></a> ClearWeek\(\)

```csharp
public void ClearWeek()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResult_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestPlusWeeklyChallengeResult Clone()
```

#### Returns

 [CMsgClientToGCRequestPlusWeeklyChallengeResult](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlusWeeklyChallengeResult.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResult_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResult_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResult_"></a> Equals\(CMsgClientToGCRequestPlusWeeklyChallengeResult\)

```csharp
public bool Equals(CMsgClientToGCRequestPlusWeeklyChallengeResult other)
```

#### Parameters

`other` [CMsgClientToGCRequestPlusWeeklyChallengeResult](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlusWeeklyChallengeResult.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResult_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResult_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResult_"></a> MergeFrom\(CMsgClientToGCRequestPlusWeeklyChallengeResult\)

```csharp
public void MergeFrom(CMsgClientToGCRequestPlusWeeklyChallengeResult other)
```

#### Parameters

`other` [CMsgClientToGCRequestPlusWeeklyChallengeResult](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlusWeeklyChallengeResult.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResult_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResult_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlusWeeklyChallengeResult_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

