# <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action"></a> Class CMsgGetTeamAuditInformation.Types.Action

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGetTeamAuditInformation.Types.Action : IMessage<CMsgGetTeamAuditInformation.Types.Action>, IEquatable<CMsgGetTeamAuditInformation.Types.Action>, IDeepCloneable<CMsgGetTeamAuditInformation.Types.Action>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGetTeamAuditInformation.Types.Action](Divine.Protobufs.Dota2.CMsgGetTeamAuditInformation.Types.Action.md)

#### Implements

IMessage<CMsgGetTeamAuditInformation.Types.Action\>, 
[IEquatable<CMsgGetTeamAuditInformation.Types.Action\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGetTeamAuditInformation.Types.Action\>, 
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
[EnumerableExtensions.In<CMsgGetTeamAuditInformation.Types.Action\>\(CMsgGetTeamAuditInformation.Types.Action, params CMsgGetTeamAuditInformation.Types.Action\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action__ctor"></a> Action\(\)

```csharp
public Action()
```

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action__ctor_Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_"></a> Action\(Action\)

```csharp
public Action(CMsgGetTeamAuditInformation.Types.Action other)
```

#### Parameters

`other` [CMsgGetTeamAuditInformation](Divine.Protobufs.Dota2.CMsgGetTeamAuditInformation.md).[Types](Divine.Protobufs.Dota2.CMsgGetTeamAuditInformation.Types.md).[Action](Divine.Protobufs.Dota2.CMsgGetTeamAuditInformation.Types.Action.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_Action_FieldNumber"></a> Action\_FieldNumber

```csharp
public const int Action_FieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_PlayerNameFieldNumber"></a> PlayerNameFieldNumber

```csharp
public const int PlayerNameFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_PlayerRealNameFieldNumber"></a> PlayerRealNameFieldNumber

```csharp
public const int PlayerRealNameFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_RegistrationPeriodFieldNumber"></a> RegistrationPeriodFieldNumber

```csharp
public const int RegistrationPeriodFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_Action_"></a> Action\_

```csharp
public uint Action_ { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_HasAction_"></a> HasAction\_

```csharp
public bool HasAction_ { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_HasPlayerName"></a> HasPlayerName

```csharp
public bool HasPlayerName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_HasPlayerRealName"></a> HasPlayerRealName

```csharp
public bool HasPlayerRealName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_HasRegistrationPeriod"></a> HasRegistrationPeriod

```csharp
public bool HasRegistrationPeriod { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGetTeamAuditInformation.Types.Action> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGetTeamAuditInformation](Divine.Protobufs.Dota2.CMsgGetTeamAuditInformation.md).[Types](Divine.Protobufs.Dota2.CMsgGetTeamAuditInformation.Types.md).[Action](Divine.Protobufs.Dota2.CMsgGetTeamAuditInformation.Types.Action.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_PlayerName"></a> PlayerName

```csharp
public string PlayerName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_PlayerRealName"></a> PlayerRealName

```csharp
public string PlayerRealName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_RegistrationPeriod"></a> RegistrationPeriod

```csharp
public uint RegistrationPeriod { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_ClearAction_"></a> ClearAction\_\(\)

```csharp
public void ClearAction_()
```

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_ClearPlayerName"></a> ClearPlayerName\(\)

```csharp
public void ClearPlayerName()
```

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_ClearPlayerRealName"></a> ClearPlayerRealName\(\)

```csharp
public void ClearPlayerRealName()
```

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_ClearRegistrationPeriod"></a> ClearRegistrationPeriod\(\)

```csharp
public void ClearRegistrationPeriod()
```

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_Clone"></a> Clone\(\)

```csharp
public CMsgGetTeamAuditInformation.Types.Action Clone()
```

#### Returns

 [CMsgGetTeamAuditInformation](Divine.Protobufs.Dota2.CMsgGetTeamAuditInformation.md).[Types](Divine.Protobufs.Dota2.CMsgGetTeamAuditInformation.Types.md).[Action](Divine.Protobufs.Dota2.CMsgGetTeamAuditInformation.Types.Action.md)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_Equals_Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_"></a> Equals\(Action\)

```csharp
public bool Equals(CMsgGetTeamAuditInformation.Types.Action other)
```

#### Parameters

`other` [CMsgGetTeamAuditInformation](Divine.Protobufs.Dota2.CMsgGetTeamAuditInformation.md).[Types](Divine.Protobufs.Dota2.CMsgGetTeamAuditInformation.Types.md).[Action](Divine.Protobufs.Dota2.CMsgGetTeamAuditInformation.Types.Action.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_MergeFrom_Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_"></a> MergeFrom\(Action\)

```csharp
public void MergeFrom(CMsgGetTeamAuditInformation.Types.Action other)
```

#### Parameters

`other` [CMsgGetTeamAuditInformation](Divine.Protobufs.Dota2.CMsgGetTeamAuditInformation.md).[Types](Divine.Protobufs.Dota2.CMsgGetTeamAuditInformation.Types.md).[Action](Divine.Protobufs.Dota2.CMsgGetTeamAuditInformation.Types.Action.md)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGetTeamAuditInformation_Types_Action_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

