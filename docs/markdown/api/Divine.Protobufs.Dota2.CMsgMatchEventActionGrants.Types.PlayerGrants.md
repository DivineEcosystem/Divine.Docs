# <a id="Divine_Protobufs_Dota2_CMsgMatchEventActionGrants_Types_PlayerGrants"></a> Class CMsgMatchEventActionGrants.Types.PlayerGrants

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgMatchEventActionGrants.Types.PlayerGrants : IMessage<CMsgMatchEventActionGrants.Types.PlayerGrants>, IEquatable<CMsgMatchEventActionGrants.Types.PlayerGrants>, IDeepCloneable<CMsgMatchEventActionGrants.Types.PlayerGrants>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgMatchEventActionGrants.Types.PlayerGrants](Divine.Protobufs.Dota2.CMsgMatchEventActionGrants.Types.PlayerGrants.md)

#### Implements

IMessage<CMsgMatchEventActionGrants.Types.PlayerGrants\>, 
[IEquatable<CMsgMatchEventActionGrants.Types.PlayerGrants\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgMatchEventActionGrants.Types.PlayerGrants\>, 
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
[EnumerableExtensions.In<CMsgMatchEventActionGrants.Types.PlayerGrants\>\(CMsgMatchEventActionGrants.Types.PlayerGrants, params CMsgMatchEventActionGrants.Types.PlayerGrants\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgMatchEventActionGrants_Types_PlayerGrants__ctor"></a> PlayerGrants\(\)

```csharp
public PlayerGrants()
```

### <a id="Divine_Protobufs_Dota2_CMsgMatchEventActionGrants_Types_PlayerGrants__ctor_Divine_Protobufs_Dota2_CMsgMatchEventActionGrants_Types_PlayerGrants_"></a> PlayerGrants\(PlayerGrants\)

```csharp
public PlayerGrants(CMsgMatchEventActionGrants.Types.PlayerGrants other)
```

#### Parameters

`other` [CMsgMatchEventActionGrants](Divine.Protobufs.Dota2.CMsgMatchEventActionGrants.md).[Types](Divine.Protobufs.Dota2.CMsgMatchEventActionGrants.Types.md).[PlayerGrants](Divine.Protobufs.Dota2.CMsgMatchEventActionGrants.Types.PlayerGrants.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgMatchEventActionGrants_Types_PlayerGrants_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchEventActionGrants_Types_PlayerGrants_ActionsGrantedFieldNumber"></a> ActionsGrantedFieldNumber

```csharp
public const int ActionsGrantedFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgMatchEventActionGrants_Types_PlayerGrants_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchEventActionGrants_Types_PlayerGrants_ActionsGranted"></a> ActionsGranted

```csharp
public RepeatedField<CMsgPendingEventAward> ActionsGranted { get; }
```

#### Property Value

 RepeatedField<[CMsgPendingEventAward](Divine.Protobufs.Dota2.CMsgPendingEventAward.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgMatchEventActionGrants_Types_PlayerGrants_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgMatchEventActionGrants_Types_PlayerGrants_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMatchEventActionGrants_Types_PlayerGrants_Parser"></a> Parser

```csharp
public static MessageParser<CMsgMatchEventActionGrants.Types.PlayerGrants> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgMatchEventActionGrants](Divine.Protobufs.Dota2.CMsgMatchEventActionGrants.md).[Types](Divine.Protobufs.Dota2.CMsgMatchEventActionGrants.Types.md).[PlayerGrants](Divine.Protobufs.Dota2.CMsgMatchEventActionGrants.Types.PlayerGrants.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgMatchEventActionGrants_Types_PlayerGrants_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchEventActionGrants_Types_PlayerGrants_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgMatchEventActionGrants_Types_PlayerGrants_Clone"></a> Clone\(\)

```csharp
public CMsgMatchEventActionGrants.Types.PlayerGrants Clone()
```

#### Returns

 [CMsgMatchEventActionGrants](Divine.Protobufs.Dota2.CMsgMatchEventActionGrants.md).[Types](Divine.Protobufs.Dota2.CMsgMatchEventActionGrants.Types.md).[PlayerGrants](Divine.Protobufs.Dota2.CMsgMatchEventActionGrants.Types.PlayerGrants.md)

### <a id="Divine_Protobufs_Dota2_CMsgMatchEventActionGrants_Types_PlayerGrants_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMatchEventActionGrants_Types_PlayerGrants_Equals_Divine_Protobufs_Dota2_CMsgMatchEventActionGrants_Types_PlayerGrants_"></a> Equals\(PlayerGrants\)

```csharp
public bool Equals(CMsgMatchEventActionGrants.Types.PlayerGrants other)
```

#### Parameters

`other` [CMsgMatchEventActionGrants](Divine.Protobufs.Dota2.CMsgMatchEventActionGrants.md).[Types](Divine.Protobufs.Dota2.CMsgMatchEventActionGrants.Types.md).[PlayerGrants](Divine.Protobufs.Dota2.CMsgMatchEventActionGrants.Types.PlayerGrants.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMatchEventActionGrants_Types_PlayerGrants_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchEventActionGrants_Types_PlayerGrants_MergeFrom_Divine_Protobufs_Dota2_CMsgMatchEventActionGrants_Types_PlayerGrants_"></a> MergeFrom\(PlayerGrants\)

```csharp
public void MergeFrom(CMsgMatchEventActionGrants.Types.PlayerGrants other)
```

#### Parameters

`other` [CMsgMatchEventActionGrants](Divine.Protobufs.Dota2.CMsgMatchEventActionGrants.md).[Types](Divine.Protobufs.Dota2.CMsgMatchEventActionGrants.Types.md).[PlayerGrants](Divine.Protobufs.Dota2.CMsgMatchEventActionGrants.Types.PlayerGrants.md)

### <a id="Divine_Protobufs_Dota2_CMsgMatchEventActionGrants_Types_PlayerGrants_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgMatchEventActionGrants_Types_PlayerGrants_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgMatchEventActionGrants_Types_PlayerGrants_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

