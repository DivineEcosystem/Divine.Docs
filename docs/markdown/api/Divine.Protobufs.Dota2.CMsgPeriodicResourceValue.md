# <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceValue"></a> Class CMsgPeriodicResourceValue

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPeriodicResourceValue : IMessage<CMsgPeriodicResourceValue>, IEquatable<CMsgPeriodicResourceValue>, IDeepCloneable<CMsgPeriodicResourceValue>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPeriodicResourceValue](Divine.Protobufs.Dota2.CMsgPeriodicResourceValue.md)

#### Implements

IMessage<CMsgPeriodicResourceValue\>, 
[IEquatable<CMsgPeriodicResourceValue\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPeriodicResourceValue\>, 
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
[EnumerableExtensions.In<CMsgPeriodicResourceValue\>\(CMsgPeriodicResourceValue, params CMsgPeriodicResourceValue\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceValue__ctor"></a> CMsgPeriodicResourceValue\(\)

```csharp
public CMsgPeriodicResourceValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceValue__ctor_Divine_Protobufs_Dota2_CMsgPeriodicResourceValue_"></a> CMsgPeriodicResourceValue\(CMsgPeriodicResourceValue\)

```csharp
public CMsgPeriodicResourceValue(CMsgPeriodicResourceValue other)
```

#### Parameters

`other` [CMsgPeriodicResourceValue](Divine.Protobufs.Dota2.CMsgPeriodicResourceValue.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceValue_PeriodicResourceMaxFieldNumber"></a> PeriodicResourceMaxFieldNumber

```csharp
public const int PeriodicResourceMaxFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceValue_PeriodicResourceUsedFieldNumber"></a> PeriodicResourceUsedFieldNumber

```csharp
public const int PeriodicResourceUsedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceValue_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceValue_HasPeriodicResourceMax"></a> HasPeriodicResourceMax

```csharp
public bool HasPeriodicResourceMax { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceValue_HasPeriodicResourceUsed"></a> HasPeriodicResourceUsed

```csharp
public bool HasPeriodicResourceUsed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceValue_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPeriodicResourceValue> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPeriodicResourceValue](Divine.Protobufs.Dota2.CMsgPeriodicResourceValue.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceValue_PeriodicResourceMax"></a> PeriodicResourceMax

```csharp
public uint PeriodicResourceMax { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceValue_PeriodicResourceUsed"></a> PeriodicResourceUsed

```csharp
public uint PeriodicResourceUsed { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceValue_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceValue_ClearPeriodicResourceMax"></a> ClearPeriodicResourceMax\(\)

```csharp
public void ClearPeriodicResourceMax()
```

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceValue_ClearPeriodicResourceUsed"></a> ClearPeriodicResourceUsed\(\)

```csharp
public void ClearPeriodicResourceUsed()
```

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceValue_Clone"></a> Clone\(\)

```csharp
public CMsgPeriodicResourceValue Clone()
```

#### Returns

 [CMsgPeriodicResourceValue](Divine.Protobufs.Dota2.CMsgPeriodicResourceValue.md)

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceValue_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceValue_Equals_Divine_Protobufs_Dota2_CMsgPeriodicResourceValue_"></a> Equals\(CMsgPeriodicResourceValue\)

```csharp
public bool Equals(CMsgPeriodicResourceValue other)
```

#### Parameters

`other` [CMsgPeriodicResourceValue](Divine.Protobufs.Dota2.CMsgPeriodicResourceValue.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceValue_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceValue_MergeFrom_Divine_Protobufs_Dota2_CMsgPeriodicResourceValue_"></a> MergeFrom\(CMsgPeriodicResourceValue\)

```csharp
public void MergeFrom(CMsgPeriodicResourceValue other)
```

#### Parameters

`other` [CMsgPeriodicResourceValue](Divine.Protobufs.Dota2.CMsgPeriodicResourceValue.md)

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceValue_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceValue_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPeriodicResourceValue_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

