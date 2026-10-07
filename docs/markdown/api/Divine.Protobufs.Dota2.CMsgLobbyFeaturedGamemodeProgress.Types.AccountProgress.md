# <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Types_AccountProgress"></a> Class CMsgLobbyFeaturedGamemodeProgress.Types.AccountProgress

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgLobbyFeaturedGamemodeProgress.Types.AccountProgress : IMessage<CMsgLobbyFeaturedGamemodeProgress.Types.AccountProgress>, IEquatable<CMsgLobbyFeaturedGamemodeProgress.Types.AccountProgress>, IDeepCloneable<CMsgLobbyFeaturedGamemodeProgress.Types.AccountProgress>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgLobbyFeaturedGamemodeProgress.Types.AccountProgress](Divine.Protobufs.Dota2.CMsgLobbyFeaturedGamemodeProgress.Types.AccountProgress.md)

#### Implements

IMessage<CMsgLobbyFeaturedGamemodeProgress.Types.AccountProgress\>, 
[IEquatable<CMsgLobbyFeaturedGamemodeProgress.Types.AccountProgress\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgLobbyFeaturedGamemodeProgress.Types.AccountProgress\>, 
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
[EnumerableExtensions.In<CMsgLobbyFeaturedGamemodeProgress.Types.AccountProgress\>\(CMsgLobbyFeaturedGamemodeProgress.Types.AccountProgress, params CMsgLobbyFeaturedGamemodeProgress.Types.AccountProgress\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Types_AccountProgress__ctor"></a> AccountProgress\(\)

```csharp
public AccountProgress()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Types_AccountProgress__ctor_Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Types_AccountProgress_"></a> AccountProgress\(AccountProgress\)

```csharp
public AccountProgress(CMsgLobbyFeaturedGamemodeProgress.Types.AccountProgress other)
```

#### Parameters

`other` [CMsgLobbyFeaturedGamemodeProgress](Divine.Protobufs.Dota2.CMsgLobbyFeaturedGamemodeProgress.md).[Types](Divine.Protobufs.Dota2.CMsgLobbyFeaturedGamemodeProgress.Types.md).[AccountProgress](Divine.Protobufs.Dota2.CMsgLobbyFeaturedGamemodeProgress.Types.AccountProgress.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Types_AccountProgress_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Types_AccountProgress_CurrentValueFieldNumber"></a> CurrentValueFieldNumber

```csharp
public const int CurrentValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Types_AccountProgress_MaxValueFieldNumber"></a> MaxValueFieldNumber

```csharp
public const int MaxValueFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Types_AccountProgress_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Types_AccountProgress_CurrentValue"></a> CurrentValue

```csharp
public uint CurrentValue { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Types_AccountProgress_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Types_AccountProgress_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Types_AccountProgress_HasCurrentValue"></a> HasCurrentValue

```csharp
public bool HasCurrentValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Types_AccountProgress_HasMaxValue"></a> HasMaxValue

```csharp
public bool HasMaxValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Types_AccountProgress_MaxValue"></a> MaxValue

```csharp
public uint MaxValue { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Types_AccountProgress_Parser"></a> Parser

```csharp
public static MessageParser<CMsgLobbyFeaturedGamemodeProgress.Types.AccountProgress> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgLobbyFeaturedGamemodeProgress](Divine.Protobufs.Dota2.CMsgLobbyFeaturedGamemodeProgress.md).[Types](Divine.Protobufs.Dota2.CMsgLobbyFeaturedGamemodeProgress.Types.md).[AccountProgress](Divine.Protobufs.Dota2.CMsgLobbyFeaturedGamemodeProgress.Types.AccountProgress.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Types_AccountProgress_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Types_AccountProgress_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Types_AccountProgress_ClearCurrentValue"></a> ClearCurrentValue\(\)

```csharp
public void ClearCurrentValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Types_AccountProgress_ClearMaxValue"></a> ClearMaxValue\(\)

```csharp
public void ClearMaxValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Types_AccountProgress_Clone"></a> Clone\(\)

```csharp
public CMsgLobbyFeaturedGamemodeProgress.Types.AccountProgress Clone()
```

#### Returns

 [CMsgLobbyFeaturedGamemodeProgress](Divine.Protobufs.Dota2.CMsgLobbyFeaturedGamemodeProgress.md).[Types](Divine.Protobufs.Dota2.CMsgLobbyFeaturedGamemodeProgress.Types.md).[AccountProgress](Divine.Protobufs.Dota2.CMsgLobbyFeaturedGamemodeProgress.Types.AccountProgress.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Types_AccountProgress_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Types_AccountProgress_Equals_Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Types_AccountProgress_"></a> Equals\(AccountProgress\)

```csharp
public bool Equals(CMsgLobbyFeaturedGamemodeProgress.Types.AccountProgress other)
```

#### Parameters

`other` [CMsgLobbyFeaturedGamemodeProgress](Divine.Protobufs.Dota2.CMsgLobbyFeaturedGamemodeProgress.md).[Types](Divine.Protobufs.Dota2.CMsgLobbyFeaturedGamemodeProgress.Types.md).[AccountProgress](Divine.Protobufs.Dota2.CMsgLobbyFeaturedGamemodeProgress.Types.AccountProgress.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Types_AccountProgress_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Types_AccountProgress_MergeFrom_Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Types_AccountProgress_"></a> MergeFrom\(AccountProgress\)

```csharp
public void MergeFrom(CMsgLobbyFeaturedGamemodeProgress.Types.AccountProgress other)
```

#### Parameters

`other` [CMsgLobbyFeaturedGamemodeProgress](Divine.Protobufs.Dota2.CMsgLobbyFeaturedGamemodeProgress.md).[Types](Divine.Protobufs.Dota2.CMsgLobbyFeaturedGamemodeProgress.Types.md).[AccountProgress](Divine.Protobufs.Dota2.CMsgLobbyFeaturedGamemodeProgress.Types.AccountProgress.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Types_AccountProgress_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Types_AccountProgress_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyFeaturedGamemodeProgress_Types_AccountProgress_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

