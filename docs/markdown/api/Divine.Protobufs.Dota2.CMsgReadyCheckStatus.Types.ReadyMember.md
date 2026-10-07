# <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_Types_ReadyMember"></a> Class CMsgReadyCheckStatus.Types.ReadyMember

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgReadyCheckStatus.Types.ReadyMember : IMessage<CMsgReadyCheckStatus.Types.ReadyMember>, IEquatable<CMsgReadyCheckStatus.Types.ReadyMember>, IDeepCloneable<CMsgReadyCheckStatus.Types.ReadyMember>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgReadyCheckStatus.Types.ReadyMember](Divine.Protobufs.Dota2.CMsgReadyCheckStatus.Types.ReadyMember.md)

#### Implements

IMessage<CMsgReadyCheckStatus.Types.ReadyMember\>, 
[IEquatable<CMsgReadyCheckStatus.Types.ReadyMember\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgReadyCheckStatus.Types.ReadyMember\>, 
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
[EnumerableExtensions.In<CMsgReadyCheckStatus.Types.ReadyMember\>\(CMsgReadyCheckStatus.Types.ReadyMember, params CMsgReadyCheckStatus.Types.ReadyMember\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_Types_ReadyMember__ctor"></a> ReadyMember\(\)

```csharp
public ReadyMember()
```

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_Types_ReadyMember__ctor_Divine_Protobufs_Dota2_CMsgReadyCheckStatus_Types_ReadyMember_"></a> ReadyMember\(ReadyMember\)

```csharp
public ReadyMember(CMsgReadyCheckStatus.Types.ReadyMember other)
```

#### Parameters

`other` [CMsgReadyCheckStatus](Divine.Protobufs.Dota2.CMsgReadyCheckStatus.md).[Types](Divine.Protobufs.Dota2.CMsgReadyCheckStatus.Types.md).[ReadyMember](Divine.Protobufs.Dota2.CMsgReadyCheckStatus.Types.ReadyMember.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_Types_ReadyMember_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_Types_ReadyMember_ReadyStatusFieldNumber"></a> ReadyStatusFieldNumber

```csharp
public const int ReadyStatusFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_Types_ReadyMember_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_Types_ReadyMember_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_Types_ReadyMember_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_Types_ReadyMember_HasReadyStatus"></a> HasReadyStatus

```csharp
public bool HasReadyStatus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_Types_ReadyMember_Parser"></a> Parser

```csharp
public static MessageParser<CMsgReadyCheckStatus.Types.ReadyMember> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgReadyCheckStatus](Divine.Protobufs.Dota2.CMsgReadyCheckStatus.md).[Types](Divine.Protobufs.Dota2.CMsgReadyCheckStatus.Types.md).[ReadyMember](Divine.Protobufs.Dota2.CMsgReadyCheckStatus.Types.ReadyMember.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_Types_ReadyMember_ReadyStatus"></a> ReadyStatus

```csharp
public EReadyCheckStatus ReadyStatus { get; set; }
```

#### Property Value

 [EReadyCheckStatus](Divine.Protobufs.Dota2.EReadyCheckStatus.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_Types_ReadyMember_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_Types_ReadyMember_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_Types_ReadyMember_ClearReadyStatus"></a> ClearReadyStatus\(\)

```csharp
public void ClearReadyStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_Types_ReadyMember_Clone"></a> Clone\(\)

```csharp
public CMsgReadyCheckStatus.Types.ReadyMember Clone()
```

#### Returns

 [CMsgReadyCheckStatus](Divine.Protobufs.Dota2.CMsgReadyCheckStatus.md).[Types](Divine.Protobufs.Dota2.CMsgReadyCheckStatus.Types.md).[ReadyMember](Divine.Protobufs.Dota2.CMsgReadyCheckStatus.Types.ReadyMember.md)

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_Types_ReadyMember_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_Types_ReadyMember_Equals_Divine_Protobufs_Dota2_CMsgReadyCheckStatus_Types_ReadyMember_"></a> Equals\(ReadyMember\)

```csharp
public bool Equals(CMsgReadyCheckStatus.Types.ReadyMember other)
```

#### Parameters

`other` [CMsgReadyCheckStatus](Divine.Protobufs.Dota2.CMsgReadyCheckStatus.md).[Types](Divine.Protobufs.Dota2.CMsgReadyCheckStatus.Types.md).[ReadyMember](Divine.Protobufs.Dota2.CMsgReadyCheckStatus.Types.ReadyMember.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_Types_ReadyMember_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_Types_ReadyMember_MergeFrom_Divine_Protobufs_Dota2_CMsgReadyCheckStatus_Types_ReadyMember_"></a> MergeFrom\(ReadyMember\)

```csharp
public void MergeFrom(CMsgReadyCheckStatus.Types.ReadyMember other)
```

#### Parameters

`other` [CMsgReadyCheckStatus](Divine.Protobufs.Dota2.CMsgReadyCheckStatus.md).[Types](Divine.Protobufs.Dota2.CMsgReadyCheckStatus.Types.md).[ReadyMember](Divine.Protobufs.Dota2.CMsgReadyCheckStatus.Types.ReadyMember.md)

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_Types_ReadyMember_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_Types_ReadyMember_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgReadyCheckStatus_Types_ReadyMember_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

