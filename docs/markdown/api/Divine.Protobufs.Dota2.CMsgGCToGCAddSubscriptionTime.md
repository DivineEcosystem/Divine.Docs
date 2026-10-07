# <a id="Divine_Protobufs_Dota2_CMsgGCToGCAddSubscriptionTime"></a> Class CMsgGCToGCAddSubscriptionTime

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCAddSubscriptionTime : IMessage<CMsgGCToGCAddSubscriptionTime>, IEquatable<CMsgGCToGCAddSubscriptionTime>, IDeepCloneable<CMsgGCToGCAddSubscriptionTime>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCAddSubscriptionTime](Divine.Protobufs.Dota2.CMsgGCToGCAddSubscriptionTime.md)

#### Implements

IMessage<CMsgGCToGCAddSubscriptionTime\>, 
[IEquatable<CMsgGCToGCAddSubscriptionTime\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCAddSubscriptionTime\>, 
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
[EnumerableExtensions.In<CMsgGCToGCAddSubscriptionTime\>\(CMsgGCToGCAddSubscriptionTime, params CMsgGCToGCAddSubscriptionTime\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCAddSubscriptionTime__ctor"></a> CMsgGCToGCAddSubscriptionTime\(\)

```csharp
public CMsgGCToGCAddSubscriptionTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCAddSubscriptionTime__ctor_Divine_Protobufs_Dota2_CMsgGCToGCAddSubscriptionTime_"></a> CMsgGCToGCAddSubscriptionTime\(CMsgGCToGCAddSubscriptionTime\)

```csharp
public CMsgGCToGCAddSubscriptionTime(CMsgGCToGCAddSubscriptionTime other)
```

#### Parameters

`other` [CMsgGCToGCAddSubscriptionTime](Divine.Protobufs.Dota2.CMsgGCToGCAddSubscriptionTime.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCAddSubscriptionTime_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCAddSubscriptionTime_AdditionalSecondsFieldNumber"></a> AdditionalSecondsFieldNumber

```csharp
public const int AdditionalSecondsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCAddSubscriptionTime_MatchingSubscriptionDefIndexesFieldNumber"></a> MatchingSubscriptionDefIndexesFieldNumber

```csharp
public const int MatchingSubscriptionDefIndexesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCAddSubscriptionTime_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCAddSubscriptionTime_AdditionalSeconds"></a> AdditionalSeconds

```csharp
public uint AdditionalSeconds { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCAddSubscriptionTime_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCAddSubscriptionTime_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCAddSubscriptionTime_HasAdditionalSeconds"></a> HasAdditionalSeconds

```csharp
public bool HasAdditionalSeconds { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCAddSubscriptionTime_MatchingSubscriptionDefIndexes"></a> MatchingSubscriptionDefIndexes

```csharp
public RepeatedField<uint> MatchingSubscriptionDefIndexes { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCAddSubscriptionTime_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCAddSubscriptionTime> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCAddSubscriptionTime](Divine.Protobufs.Dota2.CMsgGCToGCAddSubscriptionTime.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCAddSubscriptionTime_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCAddSubscriptionTime_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCAddSubscriptionTime_ClearAdditionalSeconds"></a> ClearAdditionalSeconds\(\)

```csharp
public void ClearAdditionalSeconds()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCAddSubscriptionTime_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCAddSubscriptionTime Clone()
```

#### Returns

 [CMsgGCToGCAddSubscriptionTime](Divine.Protobufs.Dota2.CMsgGCToGCAddSubscriptionTime.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCAddSubscriptionTime_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCAddSubscriptionTime_Equals_Divine_Protobufs_Dota2_CMsgGCToGCAddSubscriptionTime_"></a> Equals\(CMsgGCToGCAddSubscriptionTime\)

```csharp
public bool Equals(CMsgGCToGCAddSubscriptionTime other)
```

#### Parameters

`other` [CMsgGCToGCAddSubscriptionTime](Divine.Protobufs.Dota2.CMsgGCToGCAddSubscriptionTime.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCAddSubscriptionTime_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCAddSubscriptionTime_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCAddSubscriptionTime_"></a> MergeFrom\(CMsgGCToGCAddSubscriptionTime\)

```csharp
public void MergeFrom(CMsgGCToGCAddSubscriptionTime other)
```

#### Parameters

`other` [CMsgGCToGCAddSubscriptionTime](Divine.Protobufs.Dota2.CMsgGCToGCAddSubscriptionTime.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCAddSubscriptionTime_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCAddSubscriptionTime_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCAddSubscriptionTime_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

