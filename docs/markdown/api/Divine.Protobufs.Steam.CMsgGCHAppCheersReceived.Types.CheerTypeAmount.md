# <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTypeAmount"></a> Class CMsgGCHAppCheersReceived.Types.CheerTypeAmount

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCHAppCheersReceived.Types.CheerTypeAmount : IMessage<CMsgGCHAppCheersReceived.Types.CheerTypeAmount>, IEquatable<CMsgGCHAppCheersReceived.Types.CheerTypeAmount>, IDeepCloneable<CMsgGCHAppCheersReceived.Types.CheerTypeAmount>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCHAppCheersReceived.Types.CheerTypeAmount](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.Types.CheerTypeAmount.md)

#### Implements

IMessage<CMsgGCHAppCheersReceived.Types.CheerTypeAmount\>, 
[IEquatable<CMsgGCHAppCheersReceived.Types.CheerTypeAmount\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCHAppCheersReceived.Types.CheerTypeAmount\>, 
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
[EnumerableExtensions.In<CMsgGCHAppCheersReceived.Types.CheerTypeAmount\>\(CMsgGCHAppCheersReceived.Types.CheerTypeAmount, params CMsgGCHAppCheersReceived.Types.CheerTypeAmount\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTypeAmount__ctor"></a> CheerTypeAmount\(\)

```csharp
public CheerTypeAmount()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTypeAmount__ctor_Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTypeAmount_"></a> CheerTypeAmount\(CheerTypeAmount\)

```csharp
public CheerTypeAmount(CMsgGCHAppCheersReceived.Types.CheerTypeAmount other)
```

#### Parameters

`other` [CMsgGCHAppCheersReceived](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.md).[Types](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.Types.md).[CheerTypeAmount](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.Types.CheerTypeAmount.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTypeAmount_CheerAmountFieldNumber"></a> CheerAmountFieldNumber

```csharp
public const int CheerAmountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTypeAmount_CheerTypeFieldNumber"></a> CheerTypeFieldNumber

```csharp
public const int CheerTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTypeAmount_CheerAmount"></a> CheerAmount

```csharp
public uint CheerAmount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTypeAmount_CheerType"></a> CheerType

```csharp
public uint CheerType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTypeAmount_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTypeAmount_HasCheerAmount"></a> HasCheerAmount

```csharp
public bool HasCheerAmount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTypeAmount_HasCheerType"></a> HasCheerType

```csharp
public bool HasCheerType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTypeAmount_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCHAppCheersReceived.Types.CheerTypeAmount> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCHAppCheersReceived](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.md).[Types](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.Types.md).[CheerTypeAmount](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.Types.CheerTypeAmount.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTypeAmount_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTypeAmount_ClearCheerAmount"></a> ClearCheerAmount\(\)

```csharp
public void ClearCheerAmount()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTypeAmount_ClearCheerType"></a> ClearCheerType\(\)

```csharp
public void ClearCheerType()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTypeAmount_Clone"></a> Clone\(\)

```csharp
public CMsgGCHAppCheersReceived.Types.CheerTypeAmount Clone()
```

#### Returns

 [CMsgGCHAppCheersReceived](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.md).[Types](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.Types.md).[CheerTypeAmount](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.Types.CheerTypeAmount.md)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTypeAmount_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTypeAmount_Equals_Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTypeAmount_"></a> Equals\(CheerTypeAmount\)

```csharp
public bool Equals(CMsgGCHAppCheersReceived.Types.CheerTypeAmount other)
```

#### Parameters

`other` [CMsgGCHAppCheersReceived](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.md).[Types](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.Types.md).[CheerTypeAmount](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.Types.CheerTypeAmount.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTypeAmount_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTypeAmount_MergeFrom_Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTypeAmount_"></a> MergeFrom\(CheerTypeAmount\)

```csharp
public void MergeFrom(CMsgGCHAppCheersReceived.Types.CheerTypeAmount other)
```

#### Parameters

`other` [CMsgGCHAppCheersReceived](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.md).[Types](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.Types.md).[CheerTypeAmount](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.Types.CheerTypeAmount.md)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTypeAmount_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTypeAmount_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTypeAmount_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

