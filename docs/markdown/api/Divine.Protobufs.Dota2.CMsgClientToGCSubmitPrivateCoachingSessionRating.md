# <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRating"></a> Class CMsgClientToGCSubmitPrivateCoachingSessionRating

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCSubmitPrivateCoachingSessionRating : IMessage<CMsgClientToGCSubmitPrivateCoachingSessionRating>, IEquatable<CMsgClientToGCSubmitPrivateCoachingSessionRating>, IDeepCloneable<CMsgClientToGCSubmitPrivateCoachingSessionRating>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCSubmitPrivateCoachingSessionRating](Divine.Protobufs.Dota2.CMsgClientToGCSubmitPrivateCoachingSessionRating.md)

#### Implements

IMessage<CMsgClientToGCSubmitPrivateCoachingSessionRating\>, 
[IEquatable<CMsgClientToGCSubmitPrivateCoachingSessionRating\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCSubmitPrivateCoachingSessionRating\>, 
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
[EnumerableExtensions.In<CMsgClientToGCSubmitPrivateCoachingSessionRating\>\(CMsgClientToGCSubmitPrivateCoachingSessionRating, params CMsgClientToGCSubmitPrivateCoachingSessionRating\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRating__ctor"></a> CMsgClientToGCSubmitPrivateCoachingSessionRating\(\)

```csharp
public CMsgClientToGCSubmitPrivateCoachingSessionRating()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRating__ctor_Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRating_"></a> CMsgClientToGCSubmitPrivateCoachingSessionRating\(CMsgClientToGCSubmitPrivateCoachingSessionRating\)

```csharp
public CMsgClientToGCSubmitPrivateCoachingSessionRating(CMsgClientToGCSubmitPrivateCoachingSessionRating other)
```

#### Parameters

`other` [CMsgClientToGCSubmitPrivateCoachingSessionRating](Divine.Protobufs.Dota2.CMsgClientToGCSubmitPrivateCoachingSessionRating.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRating_CoachingSessionIdFieldNumber"></a> CoachingSessionIdFieldNumber

```csharp
public const int CoachingSessionIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRating_SessionRatingFieldNumber"></a> SessionRatingFieldNumber

```csharp
public const int SessionRatingFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRating_CoachingSessionId"></a> CoachingSessionId

```csharp
public ulong CoachingSessionId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRating_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRating_HasCoachingSessionId"></a> HasCoachingSessionId

```csharp
public bool HasCoachingSessionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRating_HasSessionRating"></a> HasSessionRating

```csharp
public bool HasSessionRating { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRating_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCSubmitPrivateCoachingSessionRating> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCSubmitPrivateCoachingSessionRating](Divine.Protobufs.Dota2.CMsgClientToGCSubmitPrivateCoachingSessionRating.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRating_SessionRating"></a> SessionRating

```csharp
public ECoachTeammateRating SessionRating { get; set; }
```

#### Property Value

 [ECoachTeammateRating](Divine.Protobufs.Dota2.ECoachTeammateRating.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRating_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRating_ClearCoachingSessionId"></a> ClearCoachingSessionId\(\)

```csharp
public void ClearCoachingSessionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRating_ClearSessionRating"></a> ClearSessionRating\(\)

```csharp
public void ClearSessionRating()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRating_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCSubmitPrivateCoachingSessionRating Clone()
```

#### Returns

 [CMsgClientToGCSubmitPrivateCoachingSessionRating](Divine.Protobufs.Dota2.CMsgClientToGCSubmitPrivateCoachingSessionRating.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRating_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRating_Equals_Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRating_"></a> Equals\(CMsgClientToGCSubmitPrivateCoachingSessionRating\)

```csharp
public bool Equals(CMsgClientToGCSubmitPrivateCoachingSessionRating other)
```

#### Parameters

`other` [CMsgClientToGCSubmitPrivateCoachingSessionRating](Divine.Protobufs.Dota2.CMsgClientToGCSubmitPrivateCoachingSessionRating.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRating_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRating_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRating_"></a> MergeFrom\(CMsgClientToGCSubmitPrivateCoachingSessionRating\)

```csharp
public void MergeFrom(CMsgClientToGCSubmitPrivateCoachingSessionRating other)
```

#### Parameters

`other` [CMsgClientToGCSubmitPrivateCoachingSessionRating](Divine.Protobufs.Dota2.CMsgClientToGCSubmitPrivateCoachingSessionRating.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRating_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRating_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSubmitPrivateCoachingSessionRating_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

