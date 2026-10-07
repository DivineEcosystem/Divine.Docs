# <a id="Divine_Protobufs_Dota2_CCLCMsg_BaselineAck"></a> Class CCLCMsg\_BaselineAck

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CCLCMsg_BaselineAck : IMessage<CCLCMsg_BaselineAck>, IEquatable<CCLCMsg_BaselineAck>, IDeepCloneable<CCLCMsg_BaselineAck>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CCLCMsg\_BaselineAck](Divine.Protobufs.Dota2.CCLCMsg\_BaselineAck.md)

#### Implements

IMessage<CCLCMsg\_BaselineAck\>, 
[IEquatable<CCLCMsg\_BaselineAck\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CCLCMsg\_BaselineAck\>, 
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
[EnumerableExtensions.In<CCLCMsg\_BaselineAck\>\(CCLCMsg\_BaselineAck, params CCLCMsg\_BaselineAck\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CCLCMsg_BaselineAck__ctor"></a> CCLCMsg\_BaselineAck\(\)

```csharp
public CCLCMsg_BaselineAck()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_BaselineAck__ctor_Divine_Protobufs_Dota2_CCLCMsg_BaselineAck_"></a> CCLCMsg\_BaselineAck\(CCLCMsg\_BaselineAck\)

```csharp
public CCLCMsg_BaselineAck(CCLCMsg_BaselineAck other)
```

#### Parameters

`other` [CCLCMsg\_BaselineAck](Divine.Protobufs.Dota2.CCLCMsg\_BaselineAck.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CCLCMsg_BaselineAck_BaselineNrFieldNumber"></a> BaselineNrFieldNumber

```csharp
public const int BaselineNrFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_BaselineAck_BaselineTickFieldNumber"></a> BaselineTickFieldNumber

```csharp
public const int BaselineTickFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CCLCMsg_BaselineAck_BaselineNr"></a> BaselineNr

```csharp
public int BaselineNr { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_BaselineAck_BaselineTick"></a> BaselineTick

```csharp
public int BaselineTick { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_BaselineAck_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CCLCMsg_BaselineAck_HasBaselineNr"></a> HasBaselineNr

```csharp
public bool HasBaselineNr { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_BaselineAck_HasBaselineTick"></a> HasBaselineTick

```csharp
public bool HasBaselineTick { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_BaselineAck_Parser"></a> Parser

```csharp
public static MessageParser<CCLCMsg_BaselineAck> Parser { get; }
```

#### Property Value

 MessageParser<[CCLCMsg\_BaselineAck](Divine.Protobufs.Dota2.CCLCMsg\_BaselineAck.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CCLCMsg_BaselineAck_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_BaselineAck_ClearBaselineNr"></a> ClearBaselineNr\(\)

```csharp
public void ClearBaselineNr()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_BaselineAck_ClearBaselineTick"></a> ClearBaselineTick\(\)

```csharp
public void ClearBaselineTick()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_BaselineAck_Clone"></a> Clone\(\)

```csharp
public CCLCMsg_BaselineAck Clone()
```

#### Returns

 [CCLCMsg\_BaselineAck](Divine.Protobufs.Dota2.CCLCMsg\_BaselineAck.md)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_BaselineAck_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_BaselineAck_Equals_Divine_Protobufs_Dota2_CCLCMsg_BaselineAck_"></a> Equals\(CCLCMsg\_BaselineAck\)

```csharp
public bool Equals(CCLCMsg_BaselineAck other)
```

#### Parameters

`other` [CCLCMsg\_BaselineAck](Divine.Protobufs.Dota2.CCLCMsg\_BaselineAck.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_BaselineAck_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_BaselineAck_MergeFrom_Divine_Protobufs_Dota2_CCLCMsg_BaselineAck_"></a> MergeFrom\(CCLCMsg\_BaselineAck\)

```csharp
public void MergeFrom(CCLCMsg_BaselineAck other)
```

#### Parameters

`other` [CCLCMsg\_BaselineAck](Divine.Protobufs.Dota2.CCLCMsg\_BaselineAck.md)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_BaselineAck_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CCLCMsg_BaselineAck_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_BaselineAck_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

