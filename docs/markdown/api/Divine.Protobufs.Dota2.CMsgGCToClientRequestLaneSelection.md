# <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelection"></a> Class CMsgGCToClientRequestLaneSelection

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientRequestLaneSelection : IMessage<CMsgGCToClientRequestLaneSelection>, IEquatable<CMsgGCToClientRequestLaneSelection>, IDeepCloneable<CMsgGCToClientRequestLaneSelection>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientRequestLaneSelection](Divine.Protobufs.Dota2.CMsgGCToClientRequestLaneSelection.md)

#### Implements

IMessage<CMsgGCToClientRequestLaneSelection\>, 
[IEquatable<CMsgGCToClientRequestLaneSelection\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientRequestLaneSelection\>, 
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
[EnumerableExtensions.In<CMsgGCToClientRequestLaneSelection\>\(CMsgGCToClientRequestLaneSelection, params CMsgGCToClientRequestLaneSelection\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelection__ctor"></a> CMsgGCToClientRequestLaneSelection\(\)

```csharp
public CMsgGCToClientRequestLaneSelection()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelection__ctor_Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelection_"></a> CMsgGCToClientRequestLaneSelection\(CMsgGCToClientRequestLaneSelection\)

```csharp
public CMsgGCToClientRequestLaneSelection(CMsgGCToClientRequestLaneSelection other)
```

#### Parameters

`other` [CMsgGCToClientRequestLaneSelection](Divine.Protobufs.Dota2.CMsgGCToClientRequestLaneSelection.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelection_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelection_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientRequestLaneSelection> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientRequestLaneSelection](Divine.Protobufs.Dota2.CMsgGCToClientRequestLaneSelection.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelection_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelection_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientRequestLaneSelection Clone()
```

#### Returns

 [CMsgGCToClientRequestLaneSelection](Divine.Protobufs.Dota2.CMsgGCToClientRequestLaneSelection.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelection_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelection_Equals_Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelection_"></a> Equals\(CMsgGCToClientRequestLaneSelection\)

```csharp
public bool Equals(CMsgGCToClientRequestLaneSelection other)
```

#### Parameters

`other` [CMsgGCToClientRequestLaneSelection](Divine.Protobufs.Dota2.CMsgGCToClientRequestLaneSelection.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelection_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelection_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelection_"></a> MergeFrom\(CMsgGCToClientRequestLaneSelection\)

```csharp
public void MergeFrom(CMsgGCToClientRequestLaneSelection other)
```

#### Parameters

`other` [CMsgGCToClientRequestLaneSelection](Divine.Protobufs.Dota2.CMsgGCToClientRequestLaneSelection.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelection_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelection_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelection_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

