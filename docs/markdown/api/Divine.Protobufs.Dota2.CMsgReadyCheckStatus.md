# <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus"></a> Class CMsgReadyCheckStatus

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgReadyCheckStatus : IMessage<CMsgReadyCheckStatus>, IEquatable<CMsgReadyCheckStatus>, IDeepCloneable<CMsgReadyCheckStatus>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgReadyCheckStatus](Divine.Protobufs.Dota2.CMsgReadyCheckStatus.md)

#### Implements

IMessage<CMsgReadyCheckStatus\>, 
[IEquatable<CMsgReadyCheckStatus\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgReadyCheckStatus\>, 
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
[EnumerableExtensions.In<CMsgReadyCheckStatus\>\(CMsgReadyCheckStatus, params CMsgReadyCheckStatus\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus__ctor"></a> CMsgReadyCheckStatus\(\)

```csharp
public CMsgReadyCheckStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus__ctor_Divine_Protobufs_Dota2_CMsgReadyCheckStatus_"></a> CMsgReadyCheckStatus\(CMsgReadyCheckStatus\)

```csharp
public CMsgReadyCheckStatus(CMsgReadyCheckStatus other)
```

#### Parameters

`other` [CMsgReadyCheckStatus](Divine.Protobufs.Dota2.CMsgReadyCheckStatus.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_FinishTimestampFieldNumber"></a> FinishTimestampFieldNumber

```csharp
public const int FinishTimestampFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_InitiatorAccountIdFieldNumber"></a> InitiatorAccountIdFieldNumber

```csharp
public const int InitiatorAccountIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_ReadyMembersFieldNumber"></a> ReadyMembersFieldNumber

```csharp
public const int ReadyMembersFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_StartTimestampFieldNumber"></a> StartTimestampFieldNumber

```csharp
public const int StartTimestampFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_FinishTimestamp"></a> FinishTimestamp

```csharp
public uint FinishTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_HasFinishTimestamp"></a> HasFinishTimestamp

```csharp
public bool HasFinishTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_HasInitiatorAccountId"></a> HasInitiatorAccountId

```csharp
public bool HasInitiatorAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_HasStartTimestamp"></a> HasStartTimestamp

```csharp
public bool HasStartTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_InitiatorAccountId"></a> InitiatorAccountId

```csharp
public uint InitiatorAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_Parser"></a> Parser

```csharp
public static MessageParser<CMsgReadyCheckStatus> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgReadyCheckStatus](Divine.Protobufs.Dota2.CMsgReadyCheckStatus.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_ReadyMembers"></a> ReadyMembers

```csharp
public RepeatedField<CMsgReadyCheckStatus.Types.ReadyMember> ReadyMembers { get; }
```

#### Property Value

 RepeatedField<[CMsgReadyCheckStatus](Divine.Protobufs.Dota2.CMsgReadyCheckStatus.md).[Types](Divine.Protobufs.Dota2.CMsgReadyCheckStatus.Types.md).[ReadyMember](Divine.Protobufs.Dota2.CMsgReadyCheckStatus.Types.ReadyMember.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_StartTimestamp"></a> StartTimestamp

```csharp
public uint StartTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_ClearFinishTimestamp"></a> ClearFinishTimestamp\(\)

```csharp
public void ClearFinishTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_ClearInitiatorAccountId"></a> ClearInitiatorAccountId\(\)

```csharp
public void ClearInitiatorAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_ClearStartTimestamp"></a> ClearStartTimestamp\(\)

```csharp
public void ClearStartTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_Clone"></a> Clone\(\)

```csharp
public CMsgReadyCheckStatus Clone()
```

#### Returns

 [CMsgReadyCheckStatus](Divine.Protobufs.Dota2.CMsgReadyCheckStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_Equals_Divine_Protobufs_Dota2_CMsgReadyCheckStatus_"></a> Equals\(CMsgReadyCheckStatus\)

```csharp
public bool Equals(CMsgReadyCheckStatus other)
```

#### Parameters

`other` [CMsgReadyCheckStatus](Divine.Protobufs.Dota2.CMsgReadyCheckStatus.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_MergeFrom_Divine_Protobufs_Dota2_CMsgReadyCheckStatus_"></a> MergeFrom\(CMsgReadyCheckStatus\)

```csharp
public void MergeFrom(CMsgReadyCheckStatus other)
```

#### Parameters

`other` [CMsgReadyCheckStatus](Divine.Protobufs.Dota2.CMsgReadyCheckStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

