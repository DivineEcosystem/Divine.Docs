# <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Types_PlayerCandy"></a> Class CMsgMatchDiretideCandy.Types.PlayerCandy

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgMatchDiretideCandy.Types.PlayerCandy : IMessage<CMsgMatchDiretideCandy.Types.PlayerCandy>, IEquatable<CMsgMatchDiretideCandy.Types.PlayerCandy>, IDeepCloneable<CMsgMatchDiretideCandy.Types.PlayerCandy>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgMatchDiretideCandy.Types.PlayerCandy](Divine.Protobufs.Dota2.CMsgMatchDiretideCandy.Types.PlayerCandy.md)

#### Implements

IMessage<CMsgMatchDiretideCandy.Types.PlayerCandy\>, 
[IEquatable<CMsgMatchDiretideCandy.Types.PlayerCandy\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgMatchDiretideCandy.Types.PlayerCandy\>, 
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
[EnumerableExtensions.In<CMsgMatchDiretideCandy.Types.PlayerCandy\>\(CMsgMatchDiretideCandy.Types.PlayerCandy, params CMsgMatchDiretideCandy.Types.PlayerCandy\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Types_PlayerCandy__ctor"></a> PlayerCandy\(\)

```csharp
public PlayerCandy()
```

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Types_PlayerCandy__ctor_Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Types_PlayerCandy_"></a> PlayerCandy\(PlayerCandy\)

```csharp
public PlayerCandy(CMsgMatchDiretideCandy.Types.PlayerCandy other)
```

#### Parameters

`other` [CMsgMatchDiretideCandy](Divine.Protobufs.Dota2.CMsgMatchDiretideCandy.md).[Types](Divine.Protobufs.Dota2.CMsgMatchDiretideCandy.Types.md).[PlayerCandy](Divine.Protobufs.Dota2.CMsgMatchDiretideCandy.Types.PlayerCandy.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Types_PlayerCandy_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Types_PlayerCandy_CandyAmountFieldNumber"></a> CandyAmountFieldNumber

```csharp
public const int CandyAmountFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Types_PlayerCandy_CandyBreakdownFieldNumber"></a> CandyBreakdownFieldNumber

```csharp
public const int CandyBreakdownFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Types_PlayerCandy_ConsumesPeriodicResourceFieldNumber"></a> ConsumesPeriodicResourceFieldNumber

```csharp
public const int ConsumesPeriodicResourceFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Types_PlayerCandy_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Types_PlayerCandy_CandyAmount"></a> CandyAmount

```csharp
public uint CandyAmount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Types_PlayerCandy_CandyBreakdown"></a> CandyBreakdown

```csharp
public RepeatedField<CMsgMatchDiretideCandy.Types.CandyDetails> CandyBreakdown { get; }
```

#### Property Value

 RepeatedField<[CMsgMatchDiretideCandy](Divine.Protobufs.Dota2.CMsgMatchDiretideCandy.md).[Types](Divine.Protobufs.Dota2.CMsgMatchDiretideCandy.Types.md).[CandyDetails](Divine.Protobufs.Dota2.CMsgMatchDiretideCandy.Types.CandyDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Types_PlayerCandy_ConsumesPeriodicResource"></a> ConsumesPeriodicResource

```csharp
public bool ConsumesPeriodicResource { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Types_PlayerCandy_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Types_PlayerCandy_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Types_PlayerCandy_HasCandyAmount"></a> HasCandyAmount

```csharp
public bool HasCandyAmount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Types_PlayerCandy_HasConsumesPeriodicResource"></a> HasConsumesPeriodicResource

```csharp
public bool HasConsumesPeriodicResource { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Types_PlayerCandy_Parser"></a> Parser

```csharp
public static MessageParser<CMsgMatchDiretideCandy.Types.PlayerCandy> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgMatchDiretideCandy](Divine.Protobufs.Dota2.CMsgMatchDiretideCandy.md).[Types](Divine.Protobufs.Dota2.CMsgMatchDiretideCandy.Types.md).[PlayerCandy](Divine.Protobufs.Dota2.CMsgMatchDiretideCandy.Types.PlayerCandy.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Types_PlayerCandy_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Types_PlayerCandy_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Types_PlayerCandy_ClearCandyAmount"></a> ClearCandyAmount\(\)

```csharp
public void ClearCandyAmount()
```

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Types_PlayerCandy_ClearConsumesPeriodicResource"></a> ClearConsumesPeriodicResource\(\)

```csharp
public void ClearConsumesPeriodicResource()
```

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Types_PlayerCandy_Clone"></a> Clone\(\)

```csharp
public CMsgMatchDiretideCandy.Types.PlayerCandy Clone()
```

#### Returns

 [CMsgMatchDiretideCandy](Divine.Protobufs.Dota2.CMsgMatchDiretideCandy.md).[Types](Divine.Protobufs.Dota2.CMsgMatchDiretideCandy.Types.md).[PlayerCandy](Divine.Protobufs.Dota2.CMsgMatchDiretideCandy.Types.PlayerCandy.md)

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Types_PlayerCandy_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Types_PlayerCandy_Equals_Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Types_PlayerCandy_"></a> Equals\(PlayerCandy\)

```csharp
public bool Equals(CMsgMatchDiretideCandy.Types.PlayerCandy other)
```

#### Parameters

`other` [CMsgMatchDiretideCandy](Divine.Protobufs.Dota2.CMsgMatchDiretideCandy.md).[Types](Divine.Protobufs.Dota2.CMsgMatchDiretideCandy.Types.md).[PlayerCandy](Divine.Protobufs.Dota2.CMsgMatchDiretideCandy.Types.PlayerCandy.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Types_PlayerCandy_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Types_PlayerCandy_MergeFrom_Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Types_PlayerCandy_"></a> MergeFrom\(PlayerCandy\)

```csharp
public void MergeFrom(CMsgMatchDiretideCandy.Types.PlayerCandy other)
```

#### Parameters

`other` [CMsgMatchDiretideCandy](Divine.Protobufs.Dota2.CMsgMatchDiretideCandy.md).[Types](Divine.Protobufs.Dota2.CMsgMatchDiretideCandy.Types.md).[PlayerCandy](Divine.Protobufs.Dota2.CMsgMatchDiretideCandy.Types.PlayerCandy.md)

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Types_PlayerCandy_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Types_PlayerCandy_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgMatchDiretideCandy_Types_PlayerCandy_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

