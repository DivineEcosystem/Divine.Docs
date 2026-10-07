# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchange"></a> Class CMsgClientToGCCandyShopDoVariableExchange

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCandyShopDoVariableExchange : IMessage<CMsgClientToGCCandyShopDoVariableExchange>, IEquatable<CMsgClientToGCCandyShopDoVariableExchange>, IDeepCloneable<CMsgClientToGCCandyShopDoVariableExchange>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCandyShopDoVariableExchange](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDoVariableExchange.md)

#### Implements

IMessage<CMsgClientToGCCandyShopDoVariableExchange\>, 
[IEquatable<CMsgClientToGCCandyShopDoVariableExchange\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCandyShopDoVariableExchange\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCandyShopDoVariableExchange\>\(CMsgClientToGCCandyShopDoVariableExchange, params CMsgClientToGCCandyShopDoVariableExchange\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchange__ctor"></a> CMsgClientToGCCandyShopDoVariableExchange\(\)

```csharp
public CMsgClientToGCCandyShopDoVariableExchange()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchange__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchange_"></a> CMsgClientToGCCandyShopDoVariableExchange\(CMsgClientToGCCandyShopDoVariableExchange\)

```csharp
public CMsgClientToGCCandyShopDoVariableExchange(CMsgClientToGCCandyShopDoVariableExchange other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopDoVariableExchange](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDoVariableExchange.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchange_CandyShopIdFieldNumber"></a> CandyShopIdFieldNumber

```csharp
public const int CandyShopIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchange_InputFieldNumber"></a> InputFieldNumber

```csharp
public const int InputFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchange_OutputFieldNumber"></a> OutputFieldNumber

```csharp
public const int OutputFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchange_CandyShopId"></a> CandyShopId

```csharp
public uint CandyShopId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchange_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchange_HasCandyShopId"></a> HasCandyShopId

```csharp
public bool HasCandyShopId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchange_Input"></a> Input

```csharp
public CMsgCandyShopCandyQuantity Input { get; set; }
```

#### Property Value

 [CMsgCandyShopCandyQuantity](Divine.Protobufs.Dota2.CMsgCandyShopCandyQuantity.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchange_Output"></a> Output

```csharp
public CMsgCandyShopCandyQuantity Output { get; set; }
```

#### Property Value

 [CMsgCandyShopCandyQuantity](Divine.Protobufs.Dota2.CMsgCandyShopCandyQuantity.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchange_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCandyShopDoVariableExchange> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCandyShopDoVariableExchange](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDoVariableExchange.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchange_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchange_ClearCandyShopId"></a> ClearCandyShopId\(\)

```csharp
public void ClearCandyShopId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchange_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCandyShopDoVariableExchange Clone()
```

#### Returns

 [CMsgClientToGCCandyShopDoVariableExchange](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDoVariableExchange.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchange_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchange_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchange_"></a> Equals\(CMsgClientToGCCandyShopDoVariableExchange\)

```csharp
public bool Equals(CMsgClientToGCCandyShopDoVariableExchange other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopDoVariableExchange](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDoVariableExchange.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchange_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchange_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchange_"></a> MergeFrom\(CMsgClientToGCCandyShopDoVariableExchange\)

```csharp
public void MergeFrom(CMsgClientToGCCandyShopDoVariableExchange other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopDoVariableExchange](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopDoVariableExchange.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchange_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchange_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopDoVariableExchange_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

