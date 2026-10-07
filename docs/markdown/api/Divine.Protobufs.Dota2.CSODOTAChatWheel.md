# <a id="Divine_Protobufs_Dota2_CSODOTAChatWheel"></a> Class CSODOTAChatWheel

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSODOTAChatWheel : IMessage<CSODOTAChatWheel>, IEquatable<CSODOTAChatWheel>, IDeepCloneable<CSODOTAChatWheel>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSODOTAChatWheel](Divine.Protobufs.Dota2.CSODOTAChatWheel.md)

#### Implements

IMessage<CSODOTAChatWheel\>, 
[IEquatable<CSODOTAChatWheel\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSODOTAChatWheel\>, 
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
[EnumerableExtensions.In<CSODOTAChatWheel\>\(CSODOTAChatWheel, params CSODOTAChatWheel\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSODOTAChatWheel__ctor"></a> CSODOTAChatWheel\(\)

```csharp
public CSODOTAChatWheel()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAChatWheel__ctor_Divine_Protobufs_Dota2_CSODOTAChatWheel_"></a> CSODOTAChatWheel\(CSODOTAChatWheel\)

```csharp
public CSODOTAChatWheel(CSODOTAChatWheel other)
```

#### Parameters

`other` [CSODOTAChatWheel](Divine.Protobufs.Dota2.CSODOTAChatWheel.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSODOTAChatWheel_MessageIdFieldNumber"></a> MessageIdFieldNumber

```csharp
public const int MessageIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSODOTAChatWheel_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSODOTAChatWheel_HasMessageId"></a> HasMessageId

```csharp
public bool HasMessageId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAChatWheel_MessageId"></a> MessageId

```csharp
public uint MessageId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAChatWheel_Parser"></a> Parser

```csharp
public static MessageParser<CSODOTAChatWheel> Parser { get; }
```

#### Property Value

 MessageParser<[CSODOTAChatWheel](Divine.Protobufs.Dota2.CSODOTAChatWheel.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CSODOTAChatWheel_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAChatWheel_ClearMessageId"></a> ClearMessageId\(\)

```csharp
public void ClearMessageId()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAChatWheel_Clone"></a> Clone\(\)

```csharp
public CSODOTAChatWheel Clone()
```

#### Returns

 [CSODOTAChatWheel](Divine.Protobufs.Dota2.CSODOTAChatWheel.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAChatWheel_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAChatWheel_Equals_Divine_Protobufs_Dota2_CSODOTAChatWheel_"></a> Equals\(CSODOTAChatWheel\)

```csharp
public bool Equals(CSODOTAChatWheel other)
```

#### Parameters

`other` [CSODOTAChatWheel](Divine.Protobufs.Dota2.CSODOTAChatWheel.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAChatWheel_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAChatWheel_MergeFrom_Divine_Protobufs_Dota2_CSODOTAChatWheel_"></a> MergeFrom\(CSODOTAChatWheel\)

```csharp
public void MergeFrom(CSODOTAChatWheel other)
```

#### Parameters

`other` [CSODOTAChatWheel](Divine.Protobufs.Dota2.CSODOTAChatWheel.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAChatWheel_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSODOTAChatWheel_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSODOTAChatWheel_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

