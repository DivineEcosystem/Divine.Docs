# <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestDropped"></a> Class CMsgGCToClientRequestDropped

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientRequestDropped : IMessage<CMsgGCToClientRequestDropped>, IEquatable<CMsgGCToClientRequestDropped>, IDeepCloneable<CMsgGCToClientRequestDropped>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientRequestDropped](Divine.Protobufs.Dota2.CMsgGCToClientRequestDropped.md)

#### Implements

IMessage<CMsgGCToClientRequestDropped\>, 
[IEquatable<CMsgGCToClientRequestDropped\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientRequestDropped\>, 
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
[EnumerableExtensions.In<CMsgGCToClientRequestDropped\>\(CMsgGCToClientRequestDropped, params CMsgGCToClientRequestDropped\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestDropped__ctor"></a> CMsgGCToClientRequestDropped\(\)

```csharp
public CMsgGCToClientRequestDropped()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestDropped__ctor_Divine_Protobufs_Dota2_CMsgGCToClientRequestDropped_"></a> CMsgGCToClientRequestDropped\(CMsgGCToClientRequestDropped\)

```csharp
public CMsgGCToClientRequestDropped(CMsgGCToClientRequestDropped other)
```

#### Parameters

`other` [CMsgGCToClientRequestDropped](Divine.Protobufs.Dota2.CMsgGCToClientRequestDropped.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestDropped_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestDropped_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientRequestDropped> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientRequestDropped](Divine.Protobufs.Dota2.CMsgGCToClientRequestDropped.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestDropped_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestDropped_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientRequestDropped Clone()
```

#### Returns

 [CMsgGCToClientRequestDropped](Divine.Protobufs.Dota2.CMsgGCToClientRequestDropped.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestDropped_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestDropped_Equals_Divine_Protobufs_Dota2_CMsgGCToClientRequestDropped_"></a> Equals\(CMsgGCToClientRequestDropped\)

```csharp
public bool Equals(CMsgGCToClientRequestDropped other)
```

#### Parameters

`other` [CMsgGCToClientRequestDropped](Divine.Protobufs.Dota2.CMsgGCToClientRequestDropped.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestDropped_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestDropped_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientRequestDropped_"></a> MergeFrom\(CMsgGCToClientRequestDropped\)

```csharp
public void MergeFrom(CMsgGCToClientRequestDropped other)
```

#### Parameters

`other` [CMsgGCToClientRequestDropped](Divine.Protobufs.Dota2.CMsgGCToClientRequestDropped.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestDropped_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestDropped_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestDropped_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

