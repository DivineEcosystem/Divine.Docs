# <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTarget"></a> Class CMsgGCHAppCheersReceived.Types.CheerTarget

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCHAppCheersReceived.Types.CheerTarget : IMessage<CMsgGCHAppCheersReceived.Types.CheerTarget>, IEquatable<CMsgGCHAppCheersReceived.Types.CheerTarget>, IDeepCloneable<CMsgGCHAppCheersReceived.Types.CheerTarget>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCHAppCheersReceived.Types.CheerTarget](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.Types.CheerTarget.md)

#### Implements

IMessage<CMsgGCHAppCheersReceived.Types.CheerTarget\>, 
[IEquatable<CMsgGCHAppCheersReceived.Types.CheerTarget\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCHAppCheersReceived.Types.CheerTarget\>, 
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
[EnumerableExtensions.In<CMsgGCHAppCheersReceived.Types.CheerTarget\>\(CMsgGCHAppCheersReceived.Types.CheerTarget, params CMsgGCHAppCheersReceived.Types.CheerTarget\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTarget__ctor"></a> CheerTarget\(\)

```csharp
public CheerTarget()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTarget__ctor_Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTarget_"></a> CheerTarget\(CheerTarget\)

```csharp
public CheerTarget(CMsgGCHAppCheersReceived.Types.CheerTarget other)
```

#### Parameters

`other` [CMsgGCHAppCheersReceived](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.md).[Types](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.Types.md).[CheerTarget](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.Types.CheerTarget.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTarget_CheerTarget_FieldNumber"></a> CheerTarget\_FieldNumber

```csharp
public const int CheerTarget_FieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTarget_CheerTypesFieldNumber"></a> CheerTypesFieldNumber

```csharp
public const int CheerTypesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTarget_CheerTarget_"></a> CheerTarget\_

```csharp
public ulong CheerTarget_ { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTarget_CheerTypes"></a> CheerTypes

```csharp
public RepeatedField<CMsgGCHAppCheersReceived.Types.CheerTypeAmount> CheerTypes { get; }
```

#### Property Value

 RepeatedField<[CMsgGCHAppCheersReceived](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.md).[Types](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.Types.md).[CheerTypeAmount](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.Types.CheerTypeAmount.md)\>

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTarget_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTarget_HasCheerTarget_"></a> HasCheerTarget\_

```csharp
public bool HasCheerTarget_ { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTarget_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCHAppCheersReceived.Types.CheerTarget> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCHAppCheersReceived](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.md).[Types](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.Types.md).[CheerTarget](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.Types.CheerTarget.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTarget_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTarget_ClearCheerTarget_"></a> ClearCheerTarget\_\(\)

```csharp
public void ClearCheerTarget_()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTarget_Clone"></a> Clone\(\)

```csharp
public CMsgGCHAppCheersReceived.Types.CheerTarget Clone()
```

#### Returns

 [CMsgGCHAppCheersReceived](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.md).[Types](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.Types.md).[CheerTarget](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.Types.CheerTarget.md)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTarget_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTarget_Equals_Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTarget_"></a> Equals\(CheerTarget\)

```csharp
public bool Equals(CMsgGCHAppCheersReceived.Types.CheerTarget other)
```

#### Parameters

`other` [CMsgGCHAppCheersReceived](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.md).[Types](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.Types.md).[CheerTarget](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.Types.CheerTarget.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTarget_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTarget_MergeFrom_Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTarget_"></a> MergeFrom\(CheerTarget\)

```csharp
public void MergeFrom(CMsgGCHAppCheersReceived.Types.CheerTarget other)
```

#### Parameters

`other` [CMsgGCHAppCheersReceived](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.md).[Types](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.Types.md).[CheerTarget](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.Types.CheerTarget.md)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTarget_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTarget_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Types_CheerTarget_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

