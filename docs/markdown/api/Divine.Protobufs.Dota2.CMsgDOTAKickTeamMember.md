# <a id="Divine_Protobufs_Dota2_CMsgDOTAKickTeamMember"></a> Class CMsgDOTAKickTeamMember

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAKickTeamMember : IMessage<CMsgDOTAKickTeamMember>, IEquatable<CMsgDOTAKickTeamMember>, IDeepCloneable<CMsgDOTAKickTeamMember>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAKickTeamMember](Divine.Protobufs.Dota2.CMsgDOTAKickTeamMember.md)

#### Implements

IMessage<CMsgDOTAKickTeamMember\>, 
[IEquatable<CMsgDOTAKickTeamMember\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAKickTeamMember\>, 
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
[EnumerableExtensions.In<CMsgDOTAKickTeamMember\>\(CMsgDOTAKickTeamMember, params CMsgDOTAKickTeamMember\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAKickTeamMember__ctor"></a> CMsgDOTAKickTeamMember\(\)

```csharp
public CMsgDOTAKickTeamMember()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAKickTeamMember__ctor_Divine_Protobufs_Dota2_CMsgDOTAKickTeamMember_"></a> CMsgDOTAKickTeamMember\(CMsgDOTAKickTeamMember\)

```csharp
public CMsgDOTAKickTeamMember(CMsgDOTAKickTeamMember other)
```

#### Parameters

`other` [CMsgDOTAKickTeamMember](Divine.Protobufs.Dota2.CMsgDOTAKickTeamMember.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAKickTeamMember_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAKickTeamMember_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAKickTeamMember_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAKickTeamMember_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAKickTeamMember_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAKickTeamMember_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAKickTeamMember_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAKickTeamMember> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAKickTeamMember](Divine.Protobufs.Dota2.CMsgDOTAKickTeamMember.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAKickTeamMember_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAKickTeamMember_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAKickTeamMember_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAKickTeamMember_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAKickTeamMember_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAKickTeamMember Clone()
```

#### Returns

 [CMsgDOTAKickTeamMember](Divine.Protobufs.Dota2.CMsgDOTAKickTeamMember.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAKickTeamMember_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAKickTeamMember_Equals_Divine_Protobufs_Dota2_CMsgDOTAKickTeamMember_"></a> Equals\(CMsgDOTAKickTeamMember\)

```csharp
public bool Equals(CMsgDOTAKickTeamMember other)
```

#### Parameters

`other` [CMsgDOTAKickTeamMember](Divine.Protobufs.Dota2.CMsgDOTAKickTeamMember.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAKickTeamMember_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAKickTeamMember_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAKickTeamMember_"></a> MergeFrom\(CMsgDOTAKickTeamMember\)

```csharp
public void MergeFrom(CMsgDOTAKickTeamMember other)
```

#### Parameters

`other` [CMsgDOTAKickTeamMember](Divine.Protobufs.Dota2.CMsgDOTAKickTeamMember.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAKickTeamMember_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAKickTeamMember_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAKickTeamMember_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

