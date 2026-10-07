# <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration"></a> Class CMsgClientToGCShowcaseModerationApplyModeration

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCShowcaseModerationApplyModeration : IMessage<CMsgClientToGCShowcaseModerationApplyModeration>, IEquatable<CMsgClientToGCShowcaseModerationApplyModeration>, IDeepCloneable<CMsgClientToGCShowcaseModerationApplyModeration>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCShowcaseModerationApplyModeration](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseModerationApplyModeration.md)

#### Implements

IMessage<CMsgClientToGCShowcaseModerationApplyModeration\>, 
[IEquatable<CMsgClientToGCShowcaseModerationApplyModeration\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCShowcaseModerationApplyModeration\>, 
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
[EnumerableExtensions.In<CMsgClientToGCShowcaseModerationApplyModeration\>\(CMsgClientToGCShowcaseModerationApplyModeration, params CMsgClientToGCShowcaseModerationApplyModeration\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration__ctor"></a> CMsgClientToGCShowcaseModerationApplyModeration\(\)

```csharp
public CMsgClientToGCShowcaseModerationApplyModeration()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration__ctor_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration_"></a> CMsgClientToGCShowcaseModerationApplyModeration\(CMsgClientToGCShowcaseModerationApplyModeration\)

```csharp
public CMsgClientToGCShowcaseModerationApplyModeration(CMsgClientToGCShowcaseModerationApplyModeration other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseModerationApplyModeration](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseModerationApplyModeration.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration_ApproveFieldNumber"></a> ApproveFieldNumber

```csharp
public const int ApproveFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration_ShowcaseTimestampFieldNumber"></a> ShowcaseTimestampFieldNumber

```csharp
public const int ShowcaseTimestampFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration_ShowcaseTypeFieldNumber"></a> ShowcaseTypeFieldNumber

```csharp
public const int ShowcaseTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration_Approve"></a> Approve

```csharp
public bool Approve { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration_HasApprove"></a> HasApprove

```csharp
public bool HasApprove { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration_HasShowcaseTimestamp"></a> HasShowcaseTimestamp

```csharp
public bool HasShowcaseTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration_HasShowcaseType"></a> HasShowcaseType

```csharp
public bool HasShowcaseType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCShowcaseModerationApplyModeration> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCShowcaseModerationApplyModeration](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseModerationApplyModeration.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration_ShowcaseTimestamp"></a> ShowcaseTimestamp

```csharp
public uint ShowcaseTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration_ShowcaseType"></a> ShowcaseType

```csharp
public EShowcaseType ShowcaseType { get; set; }
```

#### Property Value

 [EShowcaseType](Divine.Protobufs.Dota2.EShowcaseType.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration_ClearApprove"></a> ClearApprove\(\)

```csharp
public void ClearApprove()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration_ClearShowcaseTimestamp"></a> ClearShowcaseTimestamp\(\)

```csharp
public void ClearShowcaseTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration_ClearShowcaseType"></a> ClearShowcaseType\(\)

```csharp
public void ClearShowcaseType()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCShowcaseModerationApplyModeration Clone()
```

#### Returns

 [CMsgClientToGCShowcaseModerationApplyModeration](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseModerationApplyModeration.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration_Equals_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration_"></a> Equals\(CMsgClientToGCShowcaseModerationApplyModeration\)

```csharp
public bool Equals(CMsgClientToGCShowcaseModerationApplyModeration other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseModerationApplyModeration](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseModerationApplyModeration.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration_"></a> MergeFrom\(CMsgClientToGCShowcaseModerationApplyModeration\)

```csharp
public void MergeFrom(CMsgClientToGCShowcaseModerationApplyModeration other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseModerationApplyModeration](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseModerationApplyModeration.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseModerationApplyModeration_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

