# <a id="Divine_Protobufs_Dota2_CUserMsg_HudError"></a> Class CUserMsg\_HudError

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMsg_HudError : IMessage<CUserMsg_HudError>, IEquatable<CUserMsg_HudError>, IDeepCloneable<CUserMsg_HudError>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMsg\_HudError](Divine.Protobufs.Dota2.CUserMsg\_HudError.md)

#### Implements

IMessage<CUserMsg\_HudError\>, 
[IEquatable<CUserMsg\_HudError\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMsg\_HudError\>, 
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
[EnumerableExtensions.In<CUserMsg\_HudError\>\(CUserMsg\_HudError, params CUserMsg\_HudError\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMsg_HudError__ctor"></a> CUserMsg\_HudError\(\)

```csharp
public CUserMsg_HudError()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_HudError__ctor_Divine_Protobufs_Dota2_CUserMsg_HudError_"></a> CUserMsg\_HudError\(CUserMsg\_HudError\)

```csharp
public CUserMsg_HudError(CUserMsg_HudError other)
```

#### Parameters

`other` [CUserMsg\_HudError](Divine.Protobufs.Dota2.CUserMsg\_HudError.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMsg_HudError_OrderIdFieldNumber"></a> OrderIdFieldNumber

```csharp
public const int OrderIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMsg_HudError_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMsg_HudError_HasOrderId"></a> HasOrderId

```csharp
public bool HasOrderId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_HudError_OrderId"></a> OrderId

```csharp
public int OrderId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_HudError_Parser"></a> Parser

```csharp
public static MessageParser<CUserMsg_HudError> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMsg\_HudError](Divine.Protobufs.Dota2.CUserMsg\_HudError.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMsg_HudError_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_HudError_ClearOrderId"></a> ClearOrderId\(\)

```csharp
public void ClearOrderId()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_HudError_Clone"></a> Clone\(\)

```csharp
public CUserMsg_HudError Clone()
```

#### Returns

 [CUserMsg\_HudError](Divine.Protobufs.Dota2.CUserMsg\_HudError.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_HudError_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_HudError_Equals_Divine_Protobufs_Dota2_CUserMsg_HudError_"></a> Equals\(CUserMsg\_HudError\)

```csharp
public bool Equals(CUserMsg_HudError other)
```

#### Parameters

`other` [CUserMsg\_HudError](Divine.Protobufs.Dota2.CUserMsg\_HudError.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_HudError_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_HudError_MergeFrom_Divine_Protobufs_Dota2_CUserMsg_HudError_"></a> MergeFrom\(CUserMsg\_HudError\)

```csharp
public void MergeFrom(CUserMsg_HudError other)
```

#### Parameters

`other` [CUserMsg\_HudError](Divine.Protobufs.Dota2.CUserMsg\_HudError.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_HudError_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMsg_HudError_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_HudError_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

