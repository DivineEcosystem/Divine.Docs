# <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunityGoalProgress"></a> Class CMsgSignOutCommunityGoalProgress

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSignOutCommunityGoalProgress : IMessage<CMsgSignOutCommunityGoalProgress>, IEquatable<CMsgSignOutCommunityGoalProgress>, IDeepCloneable<CMsgSignOutCommunityGoalProgress>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSignOutCommunityGoalProgress](Divine.Protobufs.Dota2.CMsgSignOutCommunityGoalProgress.md)

#### Implements

IMessage<CMsgSignOutCommunityGoalProgress\>, 
[IEquatable<CMsgSignOutCommunityGoalProgress\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSignOutCommunityGoalProgress\>, 
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
[EnumerableExtensions.In<CMsgSignOutCommunityGoalProgress\>\(CMsgSignOutCommunityGoalProgress, params CMsgSignOutCommunityGoalProgress\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunityGoalProgress__ctor"></a> CMsgSignOutCommunityGoalProgress\(\)

```csharp
public CMsgSignOutCommunityGoalProgress()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunityGoalProgress__ctor_Divine_Protobufs_Dota2_CMsgSignOutCommunityGoalProgress_"></a> CMsgSignOutCommunityGoalProgress\(CMsgSignOutCommunityGoalProgress\)

```csharp
public CMsgSignOutCommunityGoalProgress(CMsgSignOutCommunityGoalProgress other)
```

#### Parameters

`other` [CMsgSignOutCommunityGoalProgress](Divine.Protobufs.Dota2.CMsgSignOutCommunityGoalProgress.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunityGoalProgress_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunityGoalProgress_EventIncrementsFieldNumber"></a> EventIncrementsFieldNumber

```csharp
public const int EventIncrementsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunityGoalProgress_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunityGoalProgress_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunityGoalProgress_EventIncrements"></a> EventIncrements

```csharp
public RepeatedField<CMsgSignOutCommunityGoalProgress.Types.EventGoalIncrement> EventIncrements { get; }
```

#### Property Value

 RepeatedField<[CMsgSignOutCommunityGoalProgress](Divine.Protobufs.Dota2.CMsgSignOutCommunityGoalProgress.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutCommunityGoalProgress.Types.md).[EventGoalIncrement](Divine.Protobufs.Dota2.CMsgSignOutCommunityGoalProgress.Types.EventGoalIncrement.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunityGoalProgress_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunityGoalProgress_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSignOutCommunityGoalProgress> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSignOutCommunityGoalProgress](Divine.Protobufs.Dota2.CMsgSignOutCommunityGoalProgress.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunityGoalProgress_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunityGoalProgress_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunityGoalProgress_Clone"></a> Clone\(\)

```csharp
public CMsgSignOutCommunityGoalProgress Clone()
```

#### Returns

 [CMsgSignOutCommunityGoalProgress](Divine.Protobufs.Dota2.CMsgSignOutCommunityGoalProgress.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunityGoalProgress_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunityGoalProgress_Equals_Divine_Protobufs_Dota2_CMsgSignOutCommunityGoalProgress_"></a> Equals\(CMsgSignOutCommunityGoalProgress\)

```csharp
public bool Equals(CMsgSignOutCommunityGoalProgress other)
```

#### Parameters

`other` [CMsgSignOutCommunityGoalProgress](Divine.Protobufs.Dota2.CMsgSignOutCommunityGoalProgress.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunityGoalProgress_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunityGoalProgress_MergeFrom_Divine_Protobufs_Dota2_CMsgSignOutCommunityGoalProgress_"></a> MergeFrom\(CMsgSignOutCommunityGoalProgress\)

```csharp
public void MergeFrom(CMsgSignOutCommunityGoalProgress other)
```

#### Parameters

`other` [CMsgSignOutCommunityGoalProgress](Divine.Protobufs.Dota2.CMsgSignOutCommunityGoalProgress.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunityGoalProgress_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunityGoalProgress_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunityGoalProgress_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

