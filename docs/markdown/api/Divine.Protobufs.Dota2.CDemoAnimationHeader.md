# <a id="Divine_Protobufs_Dota2_CDemoAnimationHeader"></a> Class CDemoAnimationHeader

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDemoAnimationHeader : IMessage<CDemoAnimationHeader>, IEquatable<CDemoAnimationHeader>, IDeepCloneable<CDemoAnimationHeader>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDemoAnimationHeader](Divine.Protobufs.Dota2.CDemoAnimationHeader.md)

#### Implements

IMessage<CDemoAnimationHeader\>, 
[IEquatable<CDemoAnimationHeader\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDemoAnimationHeader\>, 
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
[EnumerableExtensions.In<CDemoAnimationHeader\>\(CDemoAnimationHeader, params CDemoAnimationHeader\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDemoAnimationHeader__ctor"></a> CDemoAnimationHeader\(\)

```csharp
public CDemoAnimationHeader()
```

### <a id="Divine_Protobufs_Dota2_CDemoAnimationHeader__ctor_Divine_Protobufs_Dota2_CDemoAnimationHeader_"></a> CDemoAnimationHeader\(CDemoAnimationHeader\)

```csharp
public CDemoAnimationHeader(CDemoAnimationHeader other)
```

#### Parameters

`other` [CDemoAnimationHeader](Divine.Protobufs.Dota2.CDemoAnimationHeader.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDemoAnimationHeader_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoAnimationHeader_EntityIdFieldNumber"></a> EntityIdFieldNumber

```csharp
public const int EntityIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoAnimationHeader_TickFieldNumber"></a> TickFieldNumber

```csharp
public const int TickFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDemoAnimationHeader_Data"></a> Data

```csharp
public ByteString Data { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CDemoAnimationHeader_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDemoAnimationHeader_EntityId"></a> EntityId

```csharp
public int EntityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoAnimationHeader_HasData"></a> HasData

```csharp
public bool HasData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoAnimationHeader_HasEntityId"></a> HasEntityId

```csharp
public bool HasEntityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoAnimationHeader_HasTick"></a> HasTick

```csharp
public bool HasTick { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoAnimationHeader_Parser"></a> Parser

```csharp
public static MessageParser<CDemoAnimationHeader> Parser { get; }
```

#### Property Value

 MessageParser<[CDemoAnimationHeader](Divine.Protobufs.Dota2.CDemoAnimationHeader.md)\>

### <a id="Divine_Protobufs_Dota2_CDemoAnimationHeader_Tick"></a> Tick

```csharp
public int Tick { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDemoAnimationHeader_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoAnimationHeader_ClearData"></a> ClearData\(\)

```csharp
public void ClearData()
```

### <a id="Divine_Protobufs_Dota2_CDemoAnimationHeader_ClearEntityId"></a> ClearEntityId\(\)

```csharp
public void ClearEntityId()
```

### <a id="Divine_Protobufs_Dota2_CDemoAnimationHeader_ClearTick"></a> ClearTick\(\)

```csharp
public void ClearTick()
```

### <a id="Divine_Protobufs_Dota2_CDemoAnimationHeader_Clone"></a> Clone\(\)

```csharp
public CDemoAnimationHeader Clone()
```

#### Returns

 [CDemoAnimationHeader](Divine.Protobufs.Dota2.CDemoAnimationHeader.md)

### <a id="Divine_Protobufs_Dota2_CDemoAnimationHeader_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoAnimationHeader_Equals_Divine_Protobufs_Dota2_CDemoAnimationHeader_"></a> Equals\(CDemoAnimationHeader\)

```csharp
public bool Equals(CDemoAnimationHeader other)
```

#### Parameters

`other` [CDemoAnimationHeader](Divine.Protobufs.Dota2.CDemoAnimationHeader.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoAnimationHeader_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoAnimationHeader_MergeFrom_Divine_Protobufs_Dota2_CDemoAnimationHeader_"></a> MergeFrom\(CDemoAnimationHeader\)

```csharp
public void MergeFrom(CDemoAnimationHeader other)
```

#### Parameters

`other` [CDemoAnimationHeader](Divine.Protobufs.Dota2.CDemoAnimationHeader.md)

### <a id="Divine_Protobufs_Dota2_CDemoAnimationHeader_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDemoAnimationHeader_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDemoAnimationHeader_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

